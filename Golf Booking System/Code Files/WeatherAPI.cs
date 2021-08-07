using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace WeatherAPI
{

    public class WeatherAPI
    {

        public static string baseAddress = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\", "/");

        private static string weatherFileAddress = baseAddress.Replace("/bin/Debug", "") + "Weather.txt";

       

        #region Weather

       


        // Return the XML result of the URL.
        private static string GetDataInXmlFormat(string url)
        {
            // Create a web client.
            using (WebClient client = new WebClient())
            {
                string xml = null;
                try
                {
                     xml = client.DownloadString(url);
                }
                catch (Exception)
                {
                    MessageBox.Show("Weather API Could not be reached; Ports may be blocked. Weather data will be outdated.");

                }
               

                return xml;
            }
        }

        private const string API_KEY = "09353b1b64f6b476c19dedc3a5b1929e";

        // Query URLs
        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" + "q=Preston&mode=xml&units=imperial&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" + "q=Preston&mode=xml&units=imperial&APPID=" + API_KEY;

        #endregion


        private static string GetTemperature(string APIOutput)
        {

            Regex tempRegex = new Regex("temperature value=([0-9])+.([0-9])+");
            Match match = tempRegex.Match(APIOutput);

            string Output = match.Value;

            //Removes the first part of the string
            Output = Output.Replace("temperature value=", "");

            

            return Output;
        }


        private static string GetWindSpeed(string APIOutput)
        {
            //Gets bothe the description of the wind speed and the actual value for the wind speed 
            Regex windSpeedRegex = new Regex("speed value=[0-9]+.[0-9]+ name=[a-zA-Z ,-]*");
            Match match = windSpeedRegex.Match(APIOutput);

            string Output = match.Value;

            //Removes the parts of the string that aren't needed for the final output
            Output = Output.Replace("speed value=", "");
            Output = Output.Replace("name=", "");
            return Output;
        }

        private static string GetWindDirection(string APIOutput)
        {
            Regex directionRegex = new Regex("direction value=[0-9]+");
            Match match = directionRegex.Match(APIOutput);

            string Output = match.Value;

            //Removes the parts of the string that aren't needed for the final output
            Output = Output.Replace("direction value=", "");
            return Output;
        }

        private static string GetWeather(string APIOutput)
        {
            //The weather id can be 10n although this is night time and the weather won't be needed at that time
            Regex weatherRegex = new Regex("icon=[0-9]+d");
            Match match = weatherRegex.Match(APIOutput);

            string Output = match.Value;

            //Removes the parts of the string that aren't needed for the final output
            Output = Output.Replace("icon=", "");

            return Output;

        }

        public static string[] GrabWeatherAPI()
        {
            string[] strCurrentWeatherInfo = File.ReadAllLines(weatherFileAddress);

            //The API only allows you to collect data from them every 15 minutes therefore it won't grab the information if it's not been 15 mins from the last query.
            if (DateTime.Parse(strCurrentWeatherInfo[0]).AddMinutes(15) < DateTime.Now)
            {
                string strWeatherData = GetDataInXmlFormat(CurrentUrl);
             
                //This removes the quotes from the response.
                strWeatherData = strWeatherData.Replace("\"", "");
   

                strCurrentWeatherInfo[0] = DateTime.Now.ToString();
                strCurrentWeatherInfo[1] = GetTemperature(strWeatherData);
                strCurrentWeatherInfo[2] = GetWindSpeed(strWeatherData);
                strCurrentWeatherInfo[3] = GetWindDirection(strWeatherData);
                strCurrentWeatherInfo[4] = GetWeather(strWeatherData);

                //Writes each index of the array on a seperate line of the text file.
             

                File.WriteAllLines(weatherFileAddress, strCurrentWeatherInfo);
            }

            return strCurrentWeatherInfo;


        }

    }

}