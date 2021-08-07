using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Golf_Booking_System
{
    public class Analysis
    {
        //These are some variables that are just a lot easier if they are global variables that can be used between the different forms easily.
        public string Title { get; set; }
        public bool WithDiscount { get; set; }
        public bool IsReport { get; set; }
        public SeriesChartType[] ChartTypes { get; set; }
        public string[] Sections { get; set; }
        public IDictionary<string, float> DataValues { get; set; }
        public string Interval { get; set; }
        public string[] Customers { get; set; }

        
    }
}
