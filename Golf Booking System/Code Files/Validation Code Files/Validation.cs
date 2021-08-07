//This modules is for all the validation for the insertion into the database and so on.
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Validation
{
    public static class Validate
    {

        //This Method checks whether a string is fully alphabetic or not and returns a true or false repectfully.
        public static bool IsAlphabetic(string strData, ref IDictionary<string,string> ErrorDictionary, string strDataName)
        {

            int intDataLength = strData.Length;

            //This loops for the amount of characters in the string, so that it can look at every character in the string.
            for (int intCharacterIndex = 0; intCharacterIndex < intDataLength; intCharacterIndex++)
            {
                //This casts the current character which is being looked at into a integer, also know as it's ACSII value.
                int intCharacterASCIIValue = (int)strData[intCharacterIndex];

                //It then checks if that character ASCII value is not inbetween the alphabetic ASCII Values.
                if (!((intCharacterASCIIValue <= 122 & intCharacterASCIIValue >= 92) | (intCharacterASCIIValue <= 90 & intCharacterASCIIValue >= 65)))
                {
                    if (ErrorDictionary.ContainsKey(strDataName))
                        ErrorDictionary[strDataName] += ", Not Alphabetic ";
                    else
                        ErrorDictionary.Add(strDataName, " Not Alphabetic, ");
                    //If the character isn't a letter then it will return the value false to where ever it was called and terminate the method.
                    return false;
                }

            }
            //If it gets to this point then the string must be only alphabetic or else the method would have already terminated due to line 20.
            return true;
        }

        //This Method checks whether the inputted string is in the format of a telephone number and if it isn't it will add it to the error dictionary and retun false
        public static bool IsValidTelephone(string strData, ref IDictionary<string, string> ErrorDictionary, string strDataName)
        {

            //This is the telephone regex that is used to match to the inputted string to see if it's in the correct format.
            Regex TelephoneRegex = new Regex("^[0-9]{12}$");
            Match TelephoneMatch = TelephoneRegex.Match(strData);
            
            //If the match is successful then it will return true else it will add it to the error dictionary and return flase
            if (TelephoneMatch.Success)
                return true;
            else
            {
                if (ErrorDictionary.ContainsKey(strDataName))
                    ErrorDictionary[strDataName] += ", Not Valid Telephone";
                else
                    ErrorDictionary.Add(strDataName, " Not Valid Telephone ");
                
                return false;
            }
            
        }

        public static bool IsValidPostcode(string strData, ref IDictionary<string, string> ErrorDictionary, string strDataName)
        {
            //This postcode regex works by allowing 3--4 letters or number followed by a space and then 3 more letters, although this can allow some fake postcodes like 0000 000
            //But it doesn't allow for anything like '2gofk3f439fj43f3' which would be completly wrong

            Regex PostcodeRegex = new Regex("^([a-zA-Z0-9]){3,4} ([a-zA-Z0-9]){3}$");
            Match PostcodeMatch = PostcodeRegex.Match(strData);

            //Checks if postcode pattern is matched to the inputted value
            if (PostcodeMatch.Success)
                return true;
            else
            {
                //If the key already has a value it will add it to the value
                if (ErrorDictionary.ContainsKey(strDataName))
                    ErrorDictionary[strDataName] += ", Not Valid Postcode";
                //Else it will make a new key pair with the error.
                else
                    //The error messages are also slightly different as one has a comma, as it will be after another error, this way it splits the errors up.
                    ErrorDictionary.Add(strDataName, " Not Valid Postcode");

                return false;
            }
        }

        

        //Checks if a string is a nothing or doesn't contain anything
        public static bool IsNotNothing(string strData, ref IDictionary<string, string> ErrorDictionary, string strDataName)
        {
            // if the string is empty it will add a error to the error dictionary with it's pair.
            if (string.IsNullOrEmpty(strData))
            {
                ErrorDictionary.Add(strDataName, " Enter Value ");
                return false;
            }

            //This will only run if the string isn't empty as it will escape the procedure if it is due to the if return statement above.
            return true;
            
            
        }

        //This procedure checks if the string is under the max length given (inclusive)
        public static bool IsValidLength(string strData, int intMaxLength, ref IDictionary<string, string> ErrorDictionary, string strDataName)
        {
            if (strData.Length >= intMaxLength)
            {
                if (ErrorDictionary.ContainsKey(strDataName))
                    ErrorDictionary[strDataName] += ", Needs to be under " + intMaxLength + " Character ";
                else
                    ErrorDictionary.Add(strDataName, " Needs to be under " + intMaxLength + " Character ");

                return false;
            }

            return true;
        }

        public static bool IsValidEmail(string strData, ref IDictionary<string, string> ErrorDictionary, string strDataName)
        {
            //This is the Email regex pattern that allows any amount of numbers and letters followed with a @ symbol then 1 or more letters and numbers followed with a dot
            //Then 2-4 letters
            Regex EmailRegex = new Regex("^([a-zA-Z0-9_]+)@([a-zA-Z0-9]+)(.([a-zA-Z]{2,4})){1,2}$");
            Match EmailMatch = EmailRegex.Match(strData);


            if (EmailMatch.Success)
                return true;
            

            if (ErrorDictionary.ContainsKey(strDataName))
                ErrorDictionary[strDataName] += ", Not Valid Email";
            else
                ErrorDictionary.Add(strDataName, " Not Valid Email");

            return false;



        }

        public static bool IsNumeric(string strData, ref IDictionary<string, string> ErrorDictionary, string strDataName)
        {
            
            if (int.TryParse(strData, out int Number) & Number>= 0) 
                return true;

            

            //This won't cause any errors as this will only run if the return above isn't called meaning there is an error so it will only run if it is actually needs to be run.
            if (ErrorDictionary.ContainsKey(strDataName))
            {
                ErrorDictionary[strDataName] += ", Needs To Be Numeric And Positive";
            }
            else
            {
                ErrorDictionary.Add(strDataName, " Needs To Be Numeric And Postive");
            }

            return false;
        }


        //This will except the format of 0.00, 0.0 and 0 as the are all valid currency valids just some are shorter versions.
        public static bool IsCurrencyFormat(string strData, ref IDictionary<string, string> ErrorDictionary, string strDataName)
        {
            Regex CurrencyRegex = new Regex("^[0-9]{1,}([.][0-9]{0,2}){0,1}$");
            Match CurrencyMatch = CurrencyRegex.Match(strData);

            if (CurrencyMatch.Success)
                return true;

            if (ErrorDictionary.ContainsKey(strDataName))
            {
                ErrorDictionary[strDataName] += ", Must be in the format 0.00";
            }
            else
            {
                ErrorDictionary.Add(strDataName, " Must be in the format 0.00");
            }

            return false;
        }

        //Generatesa an error message based off the error dictionary valuse and keys
        public static string GenerateErrorMessage(IDictionary<string, string> ErrorDictionary)
        {
            string strErrorMessage = "";
            //Loops for each key value pair in the error dictionary.
            foreach (KeyValuePair<string, string> Error in ErrorDictionary)
            {
                //Generates a message by using the key and the value associated with that key.
                strErrorMessage += Error.Key + ": " + Error.Value + Environment.NewLine;
            }
            //The string which now has the error message is then return to where it was called.
            return strErrorMessage;
        }

        //Returns true/false depending if the value is in the range specificed by the inputted parameters. 
        public static bool IsSuitableInteger(int intNumber, int MaxInteger, int LowestInteger,ref IDictionary<string,string> ErrorDictionary, string strDataName)
        {
            //It first checks to see if the inputted number is greater than the max integer
             // 0 < n < 2

            //If the number is bigger than the max number then it will add a error message to the error dictionary for that value.
            if (intNumber > MaxInteger)
            {
                if (ErrorDictionary.ContainsKey(strDataName))
                {
                    ErrorDictionary[strDataName] += ", Must be Lower Than Or Equal to " + MaxInteger ;
                }
                else
                {
                    ErrorDictionary.Add(strDataName, " Must be Lower Than Or Equal to " + MaxInteger);
                }
                return false;
            }
            //If the number was bigger then this will never run as it's impossible for a number to be bigger than a max number and a number to be smaller than the max number
            //As long as the max integer is greater than the lowest integer.
            else if(intNumber < LowestInteger)
            {
                if (ErrorDictionary.ContainsKey(strDataName))
                {
                    ErrorDictionary[strDataName] += ", Must be Higher Than Or Equal to " + LowestInteger;
                }
                else
                {
                    ErrorDictionary.Add(strDataName, " Must be Higher Than Or Equal to " + LowestInteger);
                }
                return false;

            }

            return true;

        }
    }
}



