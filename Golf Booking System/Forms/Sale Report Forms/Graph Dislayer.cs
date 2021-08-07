using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Golf_Booking_System
{
    public partial class Graph_Dislayer : Form
    {
        private string AnalysisType;
        private IDictionary<string, float> DataValues;
        public Graph_Dislayer(IDictionary<string, float> dataValues, string analysisType)
        {
            chrtAnalysis = new Chart();
            chrtAnalysis.Series.Add("Main");
            DataValues = dataValues;
            AnalysisType = analysisType;
           
            InitializeComponent();
        }


        private void LoadDataIntoGraph()
        {
            foreach (KeyValuePair<string,float> pair in DataValues)
            {
                chrtAnalysis.Series["Main"].Points.AddXY(pair.Key, pair.Value);
            }

        }

        private void LoadGraphType()
        {
            switch (AnalysisType)
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


        private void Graph_Dislayer_Load(object sender, EventArgs e)
        {
            LoadGraphType();
            LoadDataIntoGraph();
        }

        private void chrtAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
