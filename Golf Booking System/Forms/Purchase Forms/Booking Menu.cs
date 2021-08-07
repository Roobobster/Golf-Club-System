using System;
using System.Drawing;
using System.Windows.Forms;
using static Global_Variables.Global_Variables_class;

namespace Golf_Booking_System
{
    public partial class Booking_Menu : Form
    {
        //This is used to allow the passing of the date and time the user wants to book on to the cubical booking form
        public static string[] SelectedTimeDate = new string[3];

        //This is just to set the initial max values for the date time pickers so that users can't book times that shouldn't be allowed and changes the format of the date time pickers.
        private void SetMaxDTP()
        {
            string intMaxStartTime;
            if (BookingType == "Driving Range")
            {
                intMaxStartTime = "17:50";
            }
            else
            {
                intMaxStartTime = "17:30";
            }

            //The Latest time you can book is 10 minutes before the close time of the club as the shortest booking you can make is 10 minutes, therefore it won't be possible to book after that.
            dtpBookingStartTime.MaxDate = DateTime.Parse(intMaxStartTime);
            //The Latest time you can finish a booking will be the closing time of the golf club.
            dtpBookingEndTime.MaxDate = DateTime.Parse("18:00");

        }

        private void SetDTPFormats()
        {
            //This changes the format of the date time pickers so that they allow the user to only see the time and change the time by hours or minutes.
            dtpBookingStartTime.CustomFormat = "HH:mm";
            dtpBookingEndTime.CustomFormat = "HH:mm";
        }

        public Booking_Menu()
        {
            InitializeComponent();
            SetDTPFormats();

            
        }

      

        private void ViewAvailable_Click(object sender, EventArgs e)
        {

            ViewAvailiableBookings();
        }

        private void ViewAvailiableBookings()
        {
            SelectedTimeDate[0] = dtpBookingDate.Value.ToString("d");
            SelectedTimeDate[1] = dtpBookingStartTime.Value.ToString("HH:mm");
            SelectedTimeDate[2] = dtpBookingEndTime.Value.ToString("HH:mm");

        
           
            if (BookingType == "Driving Range")
            {
                Driving_Range_Bookings frmDrivingRangeBookings = new Driving_Range_Bookings();
                frmDrivingRangeBookings.Show();
            }
            else
            {
                GolfCourseBookings frmGolfCourseBookings = new GolfCourseBookings();
                frmGolfCourseBookings.Show();
            }

            this.Close();
           

        }

        //This procedure changes the minimum values that the user can pick within the start and end date time pickers so that it doesn't allow booking of times that shouldn't be avaliable.
        private void SetMinDTP()
        {

            int intMinDuration;
            string intMaxStartTime;
            if (BookingType == "Driving Range")
            {
                intMinDuration = 10;
                intMaxStartTime = "17:50";
            }
            else
            {
                intMinDuration = 30;
                intMaxStartTime = "17:30";
            }

             
            //Checks if the current date is the same as the date that is trying to be booked
            //It converts the datetime value in the date time picker to a string with only the date values (without time, e.g 07/02/2018) as it only needs to check the date not time.
            if (dtpBookingDate.Value.ToString("d") == DateTime.Now.ToString("d"))
            {
                        

                //It then makes the minimum time the user can book the current time as you wouldn't be able to book the driving range for a time that has already passed.
                if (DateTime.Now > DateTime.Parse(intMaxStartTime)) 
                {
                  
                    dtpBookingStartTime.MinDate = DateTime.Parse(intMaxStartTime);
                    btnViewAvailable.ForeColor = Color.OrangeRed;
                }
                else
                {
                    dtpBookingStartTime.MinDate = DateTime.Now;
                    btnViewAvailable.ForeColor = Color.LightYellow;
                }
            }
            else
            {
                //If the date isn't the current date then it will set the minimum date time picker for the start time value the same as the start time of the golf club.
                dtpBookingStartTime.MinDate = DateTime.Parse("9:00");
                btnViewAvailable.ForeColor = Color.LightYellow;
            }

            
                
            //Since the shortest time you can book is 10 minutes then the end time's minimum time you can book will always be 10 minutes after the booking start time
            dtpBookingEndTime.MinDate = dtpBookingStartTime.Value.AddMinutes(intMinDuration);

            //Makes it so that the minimum date is the current date, as you can't make a booking for a day that has already passed.
            dtpBookingDate.MinDate = DateTime.Now.Date;

        }



        private void BookingDate_ValueChanged(object sender, EventArgs e)
        {
            SetMinDTP();
        }

        private void Driving_Range_Booking_Menu_Load(object sender, EventArgs e)
        {
            SetMinDTP();
            SetMaxDTP();

            if (DateTime.Now > DateTime.Parse("17:50"))
            {
                MessageBox.Show("The Max Time for booking has passed");
               
            }
        }
        private void BookingStartTime_ValueChanged(object sender, EventArgs e)
        {
            SetMinDTP();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
  
                this.WindowState = FormWindowState.Minimized;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Sales_Menu frmSalesMenu = new Sales_Menu();
            frmSalesMenu.Show();
            this.Close();
        }
    }
}
