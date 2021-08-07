using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Golf_Booking_System
{
    public partial class Create_Analyses : Form
    {
        //By having a dictionary for the points it means that i can just add the point for every graph type to this and then 
        //just use that, allowing me to use one single method for generating the graphs.
        private IDictionary<string, float> DataValues;
        private string Interval;
        private List<string> Sections = new List<string>();
        //Since the user can pick from a different amount of cahrt types, it will mean that i will need a list to allow for the different number of
        //graph tpyes. Moreover, it holds the SeriesChartType data tpye which is can be used to set the chart type of a chart.
        private List<SeriesChartType> ChartTypes = new List<SeriesChartType>();
        private bool WithDiscount;
        private bool IsReport;
        private List<string> Customers = new List<string>();

        private List<Analysis> Analyses = new List<Analysis>();

        Panel[] panels = new Panel[7];



        public Create_Analyses(Analysis[] analyses)
        {
            if (analyses != null)
            {
                Analyses.AddRange(analyses);
            }

            InitializeComponent();

            //Initialises all the variables and lists needed for the form
            Interval = null;
            IsReport = false;
            WithDiscount = true;
            Sections = new List<string>();
            ChartTypes = new List<SeriesChartType>();

            panels[0] = pnlIntervals;
            panels[1] = pnlFormats;
            panels[2] = pnlSection;
            panels[3] = pnlCustomers;
            panels[4] = pnlAdditional;
            panels[5] = pnlSummary;
            panels[6] = pnlCurrentAnalyses;

            Customers.Add("Visitor");
            Customers.Add("Premium");
            Customers.Add("Common");
            Customers.Add("Supreme");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIntervals_Click(object sender, EventArgs e)
        {
            ResetColoursAndPanels();
            pnlIntervals.Show();
            btnIntervals.ForeColor = Color.RoyalBlue;
        }

        private void ResetColoursAndPanels()
        {
            int panelCount = panels.Length;
            for (int i = 0; i < panelCount; i++)
            {
                panels[i].Hide();
            }
            ResetAllColours();
        }

        private void btnGraphTypes_Click(object sender, EventArgs e)
        {
            ResetColoursAndPanels();
            pnlFormats.Show();
            btnAnalysisFormat.ForeColor = Color.RoyalBlue;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ResetColoursAndPanels();
            pnlCustomers.Show();
            btnCustomer.ForeColor = Color.RoyalBlue;

        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            ResetColoursAndPanels();
            pnlSection.Show();
            btnSections.ForeColor = Color.RoyalBlue;
        }





        private void btnAdditional_Click(object sender, EventArgs e)
        {
            ResetColoursAndPanels();
            pnlAdditional.Show();
            btnAdditional.ForeColor = Color.RoyalBlue;
        }

      

        #region CheckBox Selections





   


        #endregion

        private string[] GetGraphPaths()
        {
            int amountOfAddedGraphs = 0/*lstAddedGraphs.Items.Count*/;
            string[] graphPaths = new string[amountOfAddedGraphs];

            for (int i = 0; i < amountOfAddedGraphs; i++)
            {
                graphPaths[i] = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "") + @"\ChartImages\" /*+ lstAddedGraphs.Items[i].ToString()*/;
            }

            return graphPaths;

        }

       



        private void Analysis_Options_Load(object sender, EventArgs e)
        {
            ResetColoursAndPanels();
            
            pnlIntervals.Show();
            btnIntervals.ForeColor = Color.RoyalBlue;
        }

        private void ResetAllColours()
        {

            btnIntervals.ForeColor = Color.LightYellow;
            btnAnalysisFormat.ForeColor = Color.LightYellow;
            btnSections.ForeColor = Color.LightYellow;
            btnAdditional.ForeColor = Color.LightYellow;
            btnCustomer.ForeColor = Color.LightYellow;
            btnSummary.ForeColor = Color.LightYellow;
            btnAnalyses.ForeColor = Color.LightYellow;
        }

        private void lblReportTypes_Click(object sender, EventArgs e)
        {

        }


        #region Moveable Form Code
        private bool mouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void btnSummary_Click(object sender, EventArgs e)
        {
            ResetColoursAndPanels();
            pnlSummary.Show();
            btnSummary.ForeColor = Color.RoyalBlue;
            DisplaySummary();
        }
        private void DisplaySummary()
        {
            //Adds the charts included
            lblSummary.Text = "CHART TYPES: ";         
            foreach (SeriesChartType chart in ChartTypes)
            {
                lblSummary.Text += Environment.NewLine;
                lblSummary.Text += "    - " + chart.ToString();
            }
            if (IsReport)
            {
                lblSummary.Text += Environment.NewLine;
                lblSummary.Text += "    - Report";
            }


            lblSummary.Text += Environment.NewLine;
            lblSummary.Text += Environment.NewLine;


            //Adds the customers included
            lblSummary.Text += "CUSTOMERS: ";
            foreach (string customer in Customers)
            {
                lblSummary.Text += Environment.NewLine;
                lblSummary.Text += "    - "+ customer ;
            }


            lblSummary.Text += Environment.NewLine;
            lblSummary.Text += Environment.NewLine;

            //adds the sections included
            lblSummary.Text += "SECTIONS: ";
            foreach (string section in Sections)
            {
                lblSummary.Text += Environment.NewLine;
                lblSummary.Text += "    - " + section;
            }
            lblSummary.Text += Environment.NewLine;
            lblSummary.Text += Environment.NewLine;




            lblSummary.Text += "INCLUDE DISCOUNT: " + WithDiscount.ToString();

            lblSummary.Text += Environment.NewLine;
            lblSummary.Text += Environment.NewLine;

            lblSummary.Text += "INTERVAL:  " + Interval;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string analysisName = "";
            InputForms.InputBox.CreateInputBox("Analysis Name", "Enter A Title For Analysis", ref analysisName);
            if (analysisName != "")
            {
                Analysis analysis = CreateAnalysis(analysisName);
                Analyses.Add(analysis);
            }
            
        }

        private Analysis CreateAnalysis(string title)
        {
            Analysis analysis = new Analysis
            {

                //Fills a data structure with all the data for this particular analysis.
                Title = title,
                ChartTypes = ChartTypes.ToArray(),
                Customers = Customers.ToArray(),
                Sections = Sections.ToArray(),
                IsReport = IsReport,
                WithDiscount = WithDiscount,
                DataValues = DataValues,
                Interval = Interval
            };

            return analysis;
        }

        private void ckbVisitors_CheckedChanged(object sender, EventArgs e)
        {
           
            if (ckbVisitors.Checked)
                Customers.Add("Visitor");
            else
                Customers.Remove("Visitor");
        }

        private void ckbSupreme_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSupreme.Checked)
                Customers.Add("Supreme");
            else
                Customers.Remove("Supreme");
        }

        private void ckbPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPremium.Checked)
                Customers.Add("Premium");
            else
                Customers.Remove("Premium");
        }

       

        private void ckbCommon_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCommon.Checked)
                Customers.Add("Common");
            else
                Customers.Remove("Common");
        }

        private void pnlCustomers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbHours_CheckedChanged(object sender, EventArgs e)
        {
            Interval = "Hours";
        }

        private void rdbDays_CheckedChanged(object sender, EventArgs e)
        {
            Interval = "Days";
        }

        private void rdbMonths_CheckedChanged(object sender, EventArgs e)
        {
            Interval = "Months";
        }

        private void rdbYears_CheckedChanged(object sender, EventArgs e)
        {
            Interval = "Years";
        }

        private void ckbItemsSold_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbItemsSold.Checked)
            {
                Sections.Add("Items Sold");
            }
            else
                Sections.Remove("Items Sold");
        }

        private void ckbItemsLent_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbItemsLent.Checked)
            {
                Sections.Add("Items Lent");
            }
            else
                Sections.Remove("Items Lent");
        }

        private void ckbTokens_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTokens.Checked)
            {
                Sections.Add("Tokens");
            }
            else
                Sections.Remove("Tokens");
        }

        private void ckbGolfBookings_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGolfBookings.Checked)
            {
                Sections.Add("Golf Bookings");
            }
            else
                Sections.Remove("Golf Bookings");
        }

        private void ckbBarChart_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBarChart.Checked)
                ChartTypes.Add(SeriesChartType.Bar);
            else
                ChartTypes.Remove(SeriesChartType.Bar);
        }

        private void ckbLineChart_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLineChart.Checked)
                ChartTypes.Add(SeriesChartType.Line);
            else
                ChartTypes.Remove(SeriesChartType.Line);
        }

        private void ckbPieChart_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPieChart.Checked)
                ChartTypes.Add(SeriesChartType.Pie);
            else
                ChartTypes.Remove(SeriesChartType.Pie);
        }

        private void ckbReport_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbReport.Checked)
                IsReport = true;
            else
                IsReport = false;
        }

        private void ckbWithMembership_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbWithMembership.Checked)
                WithDiscount = true;
            else
                WithDiscount = false;
        }

        private void btnCurrentAnalyses_Click(object sender, EventArgs e)
        {
            ResetColoursAndPanels();
            pnlCurrentAnalyses.Show();
            btnAnalyses.ForeColor = Color.RoyalBlue;
            LoadCurrentAnalyses();
        }

        private void LoadCurrentAnalyses()
        {
            lstAnalyses.Items.Clear();
            foreach (Analysis analysis in Analyses)
            {
                lstAnalyses.Items.Add(analysis.Title);
            }

        }
        private void btnRemoveAnalysis_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAnalyses.SelectedIndex;
            if (selectedIndex != -1)
            {
              
                Analyses.RemoveAt(selectedIndex);
                lstAnalyses.Items.RemoveAt(selectedIndex);
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Sale_Report_Menu reportMenuForm = new Sale_Report_Menu(Analyses);
            reportMenuForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }





}
