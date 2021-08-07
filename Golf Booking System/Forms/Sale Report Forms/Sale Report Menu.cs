using Microsoft.Office.Interop.Word;
using Reports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Golf_Booking_System
{
    public partial class Sale_Report_Menu : Form
    {

        private Analysis[] Analyses = null;


        public Sale_Report_Menu(List<Analysis> analysisList = null)
        {
           
            InitializeComponent();
    
            if (analysisList != null)
            {

                LoadAnalyses(analysisList);
            }
            

            
        }

        private void LoadAnalyses(List<Analysis> analysisList)
        {
            Analyses = analysisList.ToArray();

            foreach (Analysis analysis in Analyses)
            {
                foreach (SeriesChartType formatTpye in analysis.ChartTypes)
                {
                    lstAnalyses.Items.Add(analysis.Title + " - " + formatTpye.ToString());
                }

                if (analysis.IsReport)
                {
                    lstAnalyses.Items.Add(analysis.Title + " - Report");
                }
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu frmMain_Menu = new Main_Menu();
            frmMain_Menu.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Sale_Report_Menu_Load(object sender, EventArgs e)
        {
      
        }

        #region Moveable Form Code
        private bool mouseDown;
        private System.Drawing.Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new System.Drawing.Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

      



  




        

        private void btnAnalysisOptions_Click(object sender, EventArgs e)
        {
            Create_Analyses analysisOptionsForm = new Create_Analyses(Analyses);
            analysisOptionsForm.Show();
            this.Close();
        }

        private void btnViewAnalysis_Click(object sender, EventArgs e)
        {

            



            int analysisIndex = 0;
            string analysisType = "";
            if (lstAnalyses.SelectedIndex != -1)
            {
                GetAnalysisOption(ref analysisIndex, ref analysisType);
                IDictionary<string, float> dataValues = GenerateDataValues(Analyses[analysisIndex]);

                if (analysisType == "Report")
                {

                    string baseAddress = AppDomain.CurrentDomain.BaseDirectory;
                    string tempDocFileAddress = baseAddress.Replace(@"\bin\Debug", "") + "temp.docx";

                    CreateReport(dataValues, Analyses[analysisIndex], tempDocFileAddress);

        
                    Microsoft.Office.Interop.Word.Application wordApplication = new Microsoft.Office.Interop.Word.Application();
                 
                    Document document = wordApplication.Documents.Open(tempDocFileAddress);

                    wordApplication.Visible = true;



                }
                else
                {
                    

                    Graph_Dislayer graph_DislayerForm = new Graph_Dislayer(dataValues, analysisType);
                    graph_DislayerForm.Show();

                }
            }
            
        }

        private void CreateReport(IDictionary<string, float> dataValues, Analysis analysis, object fileLocation)
        {
            //CalculateAllDataValues();
            WordDocument wordDocument = new WordDocument();

            wordDocument.InitialiseDocument();

 

            string strTitle = "";
            int sectionCount = analysis.Sections.Length;
            //This creates a title based off all the different sections selected by the user before pressing generate report.
            for (int i = 0; i < sectionCount; i++)
            {
                if (i == sectionCount - 1)
                {
                    strTitle += analysis.Sections[i];
                }
                else if (i == sectionCount - 2)
                {
                    strTitle += analysis.Sections[i] + " And ";
                }
                else
                {
                    strTitle += analysis.Sections[i] + ", ";
                }
            }



            strTitle += " Sale Report";
            //Adds the title generated above to the header of a word document
            wordDocument.AddHeaderToDocument(strTitle);

            //Makes a gap in the document
            wordDocument.AddGapToDocument();

            //Adds a table with all the values from the selected sections
            wordDocument.AddTableToDocument(dataValues);


            //Adds a pre generated footer that then has the date the report was generated added to the word document
            wordDocument.AddFooterToDocument("Property of Erin's Golf Club" + Environment.NewLine + "Date Generated: " + DateTime.Now.ToString("dd/mm/yy HH:mm"));

            //This saves and closes the document.
            wordDocument.FinaliseDocument(fileLocation);
        }

        private IDictionary<string,float> GenerateDataValues(Analysis analysis)
        {
            
            DataValueGenerator dataValueGenerator = new DataValueGenerator();

            

            dataValueGenerator = LoadSections(analysis, dataValueGenerator);


            IDictionary<string, float> dataValues = dataValueGenerator.ReturnDataValues();

            return dataValues;
        }

       //Loads the different sections into the data value generator that accumulates all the different sales depending on the selected sections. 
        private DataValueGenerator LoadSections(Analysis analysis,  DataValueGenerator dataValueGenerator)
        {
            bool withDiscount = analysis.WithDiscount;
            string[] sections = analysis.Sections;
            string[] customersIncluded = analysis.Customers;
            string dateStringType = GetDateStringTpye(analysis.Interval);

            foreach (string section in sections)
            {
                switch (section)
                {
                    case "Items Sold":
                        dataValueGenerator.LoadItems("B", dateStringType, withDiscount, customersIncluded);
                        break;
                    case "Items Lent":
                        dataValueGenerator.LoadItems("L", dateStringType, withDiscount, customersIncluded);
                        break;
                    case "Tokens":
                        break;
                    case "Golf Bookings":
                        dataValueGenerator.LoadGolfBookings(dateStringType, withDiscount, customersIncluded);
                        break;
                    default:
                        MessageBox.Show("An Error Has Occurred.");
                        break;
                }
            }

            return dataValueGenerator;
        }


        //Gets the date string format for the different intervals.
        private string GetDateStringTpye(string interval)
        {
            string dateStringType = "";
            switch (interval)
            {
                case "Hours":
                    //The "H" format of a date time will get the hour of the date in a 24 hour clock format
                    dateStringType = "h tt";
                    break;
                case "Days":
                    //The "dddd" format of a date time will get the day of the week from the date
                    dateStringType = "dddd";
                    break;
                case "Months":
                    //The "MMMMM" format of a date time will get the full name of the month from the date.
                    dateStringType = "MMMMM";
                    break;
                case "Years":
                    //The "yyyy" format of a date time will get the year of the date.
                    dateStringType = "yyyy";
                    break;
            }
            return dateStringType;
        }


        private void GetAnalysisOption(ref int analysisIndex, ref string analysisType)
        {
            int selectedIndex = lstAnalyses.SelectedIndex;

            int analysisCount = Analyses.Length;
            int listIndex = 0;
            analysisIndex = 0;
            //Loops for every analysis
            foreach (Analysis analysis in Analyses)
            {
                //Loops for every different chart type for a specific analysis
                foreach (SeriesChartType chartType in analysis.ChartTypes)
                {
                    analysisType = chartType.ToString();
                    listIndex++;

                    //Exits loop if the chart selected is the selected list index.
                    if (selectedIndex == listIndex -1)
                        break;
                        

                        
                }

                //Exits loop if the index is on the correct item
                if (selectedIndex == listIndex -1)
                    break;


                if (analysis.IsReport)
                {

                    analysisType = "Report";
                    //Exits loop if the index is on the correct item
                    if (selectedIndex == listIndex)
                        break;

                    listIndex++;
                }

                    

                   

                //Keeps track of which analysis it's on
                analysisIndex++;
            }

        }
        



        private void btnSaveAnalyses_Click(object sender, EventArgs e)
        {


           
 
            
          

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            object fileLocation = saveFileDialog.FileName;


            int analysisIndex = 0;
            string analysisType = "";
            if (lstAnalyses.SelectedIndex != -1)
            {
                GetAnalysisOption(ref analysisIndex, ref analysisType);
                IDictionary<string, float> dataValues = GenerateDataValues(Analyses[analysisIndex]);



                if (analysisType == "Report")
                {
                    CreateReport(dataValues, Analyses[analysisIndex], fileLocation);
                }
                else
                {
                   
                   
                    chrtAnalysis.Size = new Size(1000, 1000);
                    if (chrtAnalysis.Series.Count == 0)
                    {
                        chrtAnalysis.Series.Add("Main");
                    }
                    
                    LoadDataIntoGraph( dataValues);
                    LoadGraphType( analysisType);

                    chrtAnalysis.SaveImage(fileLocation.ToString() + ".jpeg", ChartImageFormat.Jpeg);
                }
            }
        }


        private void LoadDataIntoGraph( IDictionary<string, float> dataValues)
        {
            foreach (KeyValuePair<string, float> pair in dataValues)
            {
                chrtAnalysis.Series["Main"].Points.AddXY(pair.Key, pair.Value);
                
            }

        }

        private void LoadGraphType( string analysisType)
        {
            switch (analysisType)
            {
                case "Bar":
                    chrtAnalysis.Series["Main"].ChartType = SeriesChartType.Bar;
                    break;
                case "Line":
                    chrtAnalysis.Series["Main"].ChartType = SeriesChartType.Line;
                    break;
                case "Pie":
                    chrtAnalysis.Series["Main"].ChartType = SeriesChartType.Pie;
                    break;
                default:
                    MessageBox.Show("There was an error loading the chart type");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAnalyses.SelectedIndex;

            if (selectedIndex != -1)
            {
                lstAnalyses.Items.RemoveAt(selectedIndex);

                
                int currentIndex = 0;


                //loops for every analysis
                foreach (Analysis analysis in Analyses)
                {
                    int chartIndex = 0;
                    //loops for every chart type that the analysis has
                    foreach (SeriesChartType chartType in analysis.ChartTypes)
                    {
                        if (selectedIndex == currentIndex)
                        {

                            List<SeriesChartType> tempList = new List<SeriesChartType>(analysis.ChartTypes);
                            tempList.RemoveAt(chartIndex);
                            analysis.ChartTypes = tempList.ToArray();
                        }
                        chartIndex++;
                        currentIndex++;

                    }
                    //checks to see if it is reportable chart.
                    if (analysis.IsReport)
                    {
                        if (selectedIndex == currentIndex)
                        {
                            analysis.IsReport = false;

                        }
                        currentIndex++;
                    }

                }
            }
        }
    }
}
