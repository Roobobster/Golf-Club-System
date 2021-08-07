using DatabaseTables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static DataHandling.Database;
using static InputForms.InputBox;
using static Validation.SearchingSorting;

namespace Golf_Booking_System
{


    public partial class Remove_Member_Bookings : Form
    {
        private string strMembershipID;

        public Remove_Member_Bookings()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Member_Menu frmMemberMenu = new Member_Menu();
            frmMemberMenu.Show();
            this.Close();
        }


        private void Remove_Member_Bookings_Load(object sender, EventArgs e)
        {

            LoadMemberBookings();

        }


        private void LoadMemberBookings()
        {
            Member Members = Member.LoadMembers();
            int intMemberIndex;
            DialogResult surnameInputResult;
            DialogResult forenameInputResult;
            do
            {
                string strForename = "";
                string strSurname = "";
                //Allows the user to input the name of the member
                surnameInputResult = CreateInputBox("Member Details", "Enter surname Name Of Member", ref strSurname);
                //Checks if the user has pressed cancel or has aborted any of the dialog boxes. And if they have then it will go back to the member menu.

                if (surnameInputResult == DialogResult.Cancel || surnameInputResult == DialogResult.Abort)
                {
                    GoBackToMemberMenu();
                    break;
                }
                forenameInputResult = CreateInputBox("Member Details", "Enter forename Name Of Member", ref strForename);
                //Checks if the user has pressed cancel or has aborted any of the dialog boxes. And if they have then it will go back to the member menu.

                if (forenameInputResult == DialogResult.Cancel || forenameInputResult == DialogResult.Abort)
                {
                    GoBackToMemberMenu();
                    break;
                }

                //The names are used to create the membershipID
                strMembershipID = strSurname + strForename;
                //The index of this member is then found
                intMemberIndex = BinarySearch(Members.strMembershipID, 0, Members.strMembershipID.Count, strMembershipID);

                if (intMemberIndex != -1)
                    LoadBookingsIntoListBoxes();
                else
                    MessageBox.Show("Member Not Found");

                //Loops until the user puts a user that in the database or cancels on of the input boxes.
            } while (intMemberIndex == -1 );
        }

        private void GoBackToMemberMenu()
        {
            Member_Menu frmMemberMenu = new Member_Menu();
            frmMemberMenu.Show();
            this.Close();
        }


        private void LoadBookingsIntoListBoxes()
        {
            //Clears the current list boxes
            lstDrivingRangeBookings.Items.Clear();
            lstGolfCourseBookings.Items.Clear();
            //Gets all the purchases the member has made
            List<string> strMembersPurchases = GetMembersPurchases(strMembershipID);
            //Gets all the bookings that haven't already passed. 
            DrivingRangeBooking MemberRangeBookings = GetValidRangeBookings();
            GolfCourseBooking MemberCourseBookings = GetValidCourseBoookings();

            //Loops for every purchase the member has made 
            for (int PurchaseIndex = 0; PurchaseIndex < strMembersPurchases.Count; PurchaseIndex++)
            {
                //Loops for every booking on the golf course that haven't already passed
                for (int BookingIndex = 0; BookingIndex < MemberCourseBookings.strPurchaseID.Count; BookingIndex++)
                {
                    //Addds the booking to the golf course list box if the golf course booking Id is the same as the purchase ID that is currently being looped through.
                    if (MemberCourseBookings.strPurchaseID[BookingIndex] == strMembersPurchases[PurchaseIndex])
                        lstGolfCourseBookings.Items.Add(MemberCourseBookings.strBookedDate[BookingIndex] + "    " + MemberCourseBookings.strBookedStartTime[BookingIndex] + " - " + MemberCourseBookings.strBookedEndTime[BookingIndex]);
                    
                }

                //loops for every booking on the driving range that haven't already passed
                for (int BookingIndex = 0; BookingIndex < MemberRangeBookings.strPurchaseID.Count; BookingIndex++)
                {
                    //Adds the booking to the driving range list box if the driving range booking ID is the same as the purchase ID that is currently being looped through.
                    if (MemberRangeBookings.strPurchaseID[BookingIndex] == strMembersPurchases[PurchaseIndex])                  
                        lstDrivingRangeBookings.Items.Add(MemberRangeBookings.strBookedDate[BookingIndex] + "    " + MemberRangeBookings.strBookedStartTime[BookingIndex] + " - " + MemberRangeBookings.strBookedEndTime[BookingIndex]);
                    
                }

            }
        }


        private List<string> GetMembersPurchases(string MembershipID)
        {
            //This will hold all the member's purchase ID's 
            List<string> strMembersPurchases = new List<string>();
            //Loads all the purchases in the database. 
            Purchase Purchases = Purchase.LoadPurchases();

            //Loops for every purchase in the database
            for (int purchase = 0; purchase < Purchases.strMembershipID.Count; purchase++)
            {
                //Checks to see if the purchase's MembershipID is equal to the member's Membership ID
                //If it is then it will add the purchase ID for that purchase into the member's list of PurchaseIDs
                if (Purchases.strMembershipID[purchase] == MembershipID)               
                    strMembersPurchases.Add(Purchases.strPurchaseID[purchase]);
            
                
            }

            //Returns the list of purchase IDs that the member is connected to.
            return strMembersPurchases;
            

        }

        private DrivingRangeBooking GetValidRangeBookings()
        {
            //Loads all the range booking details from the database
            DrivingRangeBooking RangeBookings = DrivingRangeBooking.LoadBookings();
            //Creates a template of the database to be able to add all the driving range booking details that the member is connected
            DrivingRangeBooking ValidRangeBookings = new DrivingRangeBooking();

            //Loops for every range booking in the database. 
            for (int i = 0; i < RangeBookings.strPurchaseID.Count; i++)
            {
                //Checks to see if the date the booking is made for is after the current date
                if (DateTime.Parse(RangeBookings.strBookedDate[i]) >= DateTime.Today)
                {
                    //It then does the same as the above but instead it is done for time and it allows the user to cancel bookings if they
                    //are in progress as long as the end time isn't before the current time. This way if someone wants to finish early
                    //then they can free up a space and allow other people to be able to book
                    if (DateTime.Parse(RangeBookings.strBookedEndTime[i]) > DateTime.Parse(DateTime.Now.ToString("h: mm")))
                    {
                        //Adds all the details for that booking into the lists in MemberRangeBookings that simulates a database.
                        //But only if the datetime for the end of the booking if after the current time
                        ValidRangeBookings.strPurchaseID.Add(RangeBookings.strPurchaseID[i]);
                        ValidRangeBookings.strRangeBookingID.Add(RangeBookings.strRangeBookingID[i]);
                        ValidRangeBookings.strBookedDate.Add(RangeBookings.strBookedDate[i]);
                        ValidRangeBookings.strBookedEndTime.Add(RangeBookings.strBookedEndTime[i]);
                        ValidRangeBookings.strBookedStartTime.Add(RangeBookings.strBookedStartTime[i]);                      
                    }

                }
            }

            //Returns all the bookings that are after the current datetime
            return ValidRangeBookings;

        }

        private GolfCourseBooking GetValidCourseBoookings()
        {
            //Loads all the golf course booking details from the database
            GolfCourseBooking ValidCourseBookings = new GolfCourseBooking();
            //Creates a template of the database to be able to add all the golf course booking details that the member is connected
            GolfCourseBooking CourseBookings = GolfCourseBooking.LoadBookings();

            //Loops for every golf course booking in the database. 
            for (int i = 0; i < CourseBookings.strPurchaseID.Count; i++)
            {
                //Checks to see if the date the booking is made for is after the current date
                if (DateTime.Parse(CourseBookings.strBookedDate[i]) >= DateTime.Today)
                {
                    //It then does the same as the above but instead it is done for time and it allows the user to cancel bookings if they
                    //are in progress as long as the end time isn't before the current time. This way if someone wants to finish early
                    //then they can free up a space and allow other people to be able to book
                    if (DateTime.Parse(CourseBookings.strBookedEndTime[i]) > DateTime.Parse(DateTime.Now.ToString("h: mm")))
                    {
                        ValidCourseBookings.strPurchaseID.Add(CourseBookings.strPurchaseID[i]);
                        ValidCourseBookings.strCourseBookingID.Add(CourseBookings.strCourseBookingID[i]);
                        ValidCourseBookings.strBookedDate.Add(CourseBookings.strBookedDate[i]);
                        ValidCourseBookings.strBookedEndTime.Add(CourseBookings.strBookedEndTime[i]);
                        ValidCourseBookings.strBookedStartTime.Add(CourseBookings.strBookedStartTime[i]);                      
                    }

                }
            }

            return ValidCourseBookings;
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


        private void RemoveCourseBooking()
        {
            //Removes a golf booking depending on the booking ID which is determined by the  selected index of the golf course list box.
            GolfCourseBooking MemberBookings = GetValidCourseBoookings();
            string strCourseBookingID = MemberBookings.strCourseBookingID[lstGolfCourseBookings.SelectedIndex];
            RemoveFromDatabase("Golf_Course_Bookings", "Course_Booking_ID", strCourseBookingID);
            MessageBox.Show("Booking Has Been Deleted");
            
        }

        private void RemoveRangeBooking()
        {
            //Removes a range booking depending on the booking ID which is determined by the  selected index of the driving range list box.
            DrivingRangeBooking MemberBookings = GetValidRangeBookings();
            string strRangeBookingID = MemberBookings.strRangeBookingID[lstDrivingRangeBookings.SelectedIndex];
            RemoveFromDatabase("Driving_Range_Bookings", "Range_Booking_ID", strRangeBookingID);
            MessageBox.Show("Booking Has Been Deleted");
            
        }

        private void RemoveGolfBooking_Click(object sender, EventArgs e)
        {
            RemoveCourseBooking();
            LoadBookingsIntoListBoxes();
        }



        private void RemoveDrivingBooking_Click(object sender, EventArgs e)
        {

            RemoveRangeBooking();
            LoadBookingsIntoListBoxes();
        }
    }
}
