using DatabaseTables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Global_Variables.Global_Variables_class;

namespace Golf_Booking_System
{
    public partial class GolfCourseBookings : Form
    {
        int CartChangeIndex;

        private Button[] Holes = new Button[19];

        private List<int> SelectedHoles = new List<int>();

        float fltTotalCost = 0;


        public GolfCourseBookings(int cartChangeIndex = -1)
        {
            InitializeComponent();

            CartChangeIndex = cartChangeIndex;
            if (cartChangeIndex != -1)
            {
                string[] strHoleNumbers = CartGolfCourseBookings.strHoleNumbers[cartChangeIndex].Split('-');
                for (int i = 0; i < strHoleNumbers.Length - 1; i++)
                {
                    SelectedHoles.Add(int.Parse(strHoleNumbers[i]));
                    fltTotalCost += 4.90f;
                }
            }
        }


        GolfCourseBooking Bookings = new GolfCourseBooking();

         //This simple insertion sort is used to sort the selected hole numbers in order so that the user can see easily which holes
         //They have missed, for example the user may wany to book the first 6 holes and they could tell if they have if it
         //starts from 1 and goes all the way to 6 incrementing 1 each time. Although this isn't neccessary it makes the 
         //inteface better.
        public List<int> InsertionSort(List<int> intList)
        {

            int intCurrentValue, intPointer;
            //This for loops for the 1 to the size of the list -1 
            for (int CurrentPointer = 1; CurrentPointer < intList.Count ; CurrentPointer++)
            {
                //This sets the current value to the value at the current pointer
                intCurrentValue = intList[CurrentPointer];
                //the pointer is the pointer before the current pointer
                intPointer = CurrentPointer - 1;

                //While the pointer
                while (intPointer >= 0 && intList[intPointer] > intCurrentValue)
                {
                    intList[intPointer + 1] = intList[intPointer];
                    intPointer--;

                }

                intList[intPointer + 1] = intCurrentValue;

            }
            return intList;
        }

        

        private void Golf_Course_Bookings_Load(object sender, EventArgs e)
        {
                        
            //Since the buttons need to be in very specific locations it's alot simpler to just add the already created buttons to
            //an array of buttons which indexes are equal to the hole number.
            Holes[1] = btnHole1;
            Holes[2] = btnHole2;
            Holes[3] = btnHole3;
            Holes[4] = btnHole4;
            Holes[5] = btnHole5;
            Holes[6] = btnHole6;
            Holes[7] = btnHole7;
            Holes[8] = btnHole8;
            Holes[9] = btnHole9;
            Holes[10] = btnHole10;
            Holes[11] = btnHole11;
            Holes[12] = btnHole12;
            Holes[13] = btnHole13;
            Holes[14] = btnHole14;
            Holes[15] = btnHole15;
            Holes[16] = btnHole16;
            Holes[17] = btnHole17;
            Holes[18] = btnHole18;

            Bookings = GolfCourseBooking.LoadBookings();
            LoadBookedHoles();
            if (CartChangeIndex != -1)
            {
                LoadEditBookings();
            }
        }

        private void LoadEditBookings()
        {
            DisplayBookedHoles(CartChangeIndex, true, true);

        }


        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Booking_Menu frmBookingMenu = new Booking_Menu();
            frmBookingMenu.Show();
        }
      
        private void LoadBookedHoles()
        {
            string strBookedDate = Booking_Menu.SelectedTimeDate[0];
            string strBookedStartTime = Booking_Menu.SelectedTimeDate[1];
            string strBookedEndTime = Booking_Menu.SelectedTimeDate[2];

            DateTime NewStartTime = DateTime.Parse(strBookedStartTime);
            DateTime NewEndTime = DateTime.Parse(strBookedEndTime);

            //This loops through all the bookings by getting all the amount of strings are in a list.
            for (int Booking = 0; Booking < Bookings.strPurchaseID.Count; Booking++)
            {
                //This checks if the date strings are exactly the same, meaning that the bookings are on the same day.
                if (strBookedDate == Bookings.strBookedDate[Booking])
                {
                    //This gets the string values for the bookings and turns them into datetimes so that they can be used for comparing times
                    //meaning that you can see if a time is after or before another.

                    
                    DateTime BookedStartTime = DateTime.Parse(Bookings.strBookedStartTime[Booking]);
                    DateTime BookedEndTime = DateTime.Parse(Bookings.strBookedEndTime[Booking]);


                   /*This checks if the end time for the booking the user wants is after the start time of the current bookings
                   Then it checks if the start time of the booking the user wants is before the end time of the current bookings
                   So overall this acts as a way of checking if two periods overlap and if they do then it will mean that that hole will be occupied at the time */
                    if ((NewEndTime > BookedStartTime) & (NewStartTime < BookedEndTime))
                    {
                        //If the there isn't no overlapping then it will mean that the booking will overlap with another.
                        DisplayBookedHoles(Booking);
                    }

                  

                }
            }

            //Loops for each golf course booking.
            for (int Booking = 0; Booking < CartGolfCourseBookings.strPurchaseID.Count; Booking++)
            {
                //Checks to see if the booking date is the same as the booking date in the database, does this for all the bookings in the database.
                if (strBookedDate == CartGolfCourseBookings.strBookedDate[Booking])
                {
                    DateTime BookedStartTime = DateTime.Parse(CartGolfCourseBookings.strBookedStartTime[Booking]);
                    DateTime BookedEndTime = DateTime.Parse(CartGolfCourseBookings.strBookedEndTime[Booking]);

                    //Checks to see if there will be any overlapping times. 
                    if ((NewEndTime > BookedStartTime) & (NewStartTime < BookedEndTime))
                    {
                        DisplayBookedHoles(Booking, true);

                    }

                }
            }
        }


        //This procedure gets a booking index and checks what Holes the booking has booked
        private void DisplayBookedHoles(int Booking, bool inCart = false, bool changeable = false)
        {
            string CombinedHoleNumbers;
            //Gets the whole selected Holes string from DrivingRangeBookings Object that acts as the database.


            if (inCart)
                CombinedHoleNumbers = CartGolfCourseBookings.strHoleNumbers[Booking];
            else
                CombinedHoleNumbers = Bookings.strHoleNumbers[Booking];            
            
            //This splits the string in to an array of string of which contains the booked Hole numbers in each index but it also removes the "|"
            //E.g 12|2|3| will split into an array with 12,2 and 3 at indexes 0,1,2 respectively.

            string[] strHoleNumbers = CombinedHoleNumbers.Split('-');
            //Then it gets the length of this array, which will tell you how many bookings there are +1 as it also makes the null value after the |
            //part of the array, therefore it will always be 1 more value in the array than there is values.
            int AmountOfBookings = strHoleNumbers.Length - 1;

            int intHoleNumber;

            //Loops for the amount of bookings
            for (int Hole = 0; Hole < AmountOfBookings; Hole++)
            {
                //This gets the first index of the array and turns the string values into integers so that they can be used for the indexes
                intHoleNumber = int.Parse(strHoleNumbers[Hole]);
                if (changeable)
                {
                    Holes[intHoleNumber].BackgroundImage = Properties.Resources.Selected_Hole;
                    Holes[intHoleNumber].Enabled = true;
                }
                else
                {
                    
                    //Changes booked holes with the index of the hole numbers (Which is equal to the index as well) so that they are red and disabled
                    //Meaning that they can't be clicked or interactive with. 
                    Holes[intHoleNumber].BackgroundImage = Properties.Resources.Booked_Hole;
                    Holes[intHoleNumber].Enabled = false;
                }
                

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

        
        private void Hole_Click(object sender, EventArgs e)
        {
            Control btnHole = (Control)sender;

            string HoleNumber = btnHole.Tag.ToString();

            //if the hole doesn't have a background image then it means it's not been selected yet
            if (btnHole.BackgroundImage == null)
            {
                btnHole.BackgroundImage = Properties.Resources.Selected_Hole;        
                //adds the selected hole to the selected hole array which is used to hold all the hole numbers the member wants. 
                SelectedHoles.Add(int.Parse(HoleNumber));
                //Adds the price for each hole to the total
                fltTotalCost += 4.90f;
            }
            else
            {
                //if the hole does have a background image then it must be the selected one as otherwise you wouldn't be able to select 
                //that hole as it would be disabled due to it being the already booked hole. 
                SelectedHoles.Remove(int.Parse(HoleNumber));
                btnHole.BackgroundImage = null;
                //Removes the price for the hole from the total as it's being deselected. 
                fltTotalCost -= 4.90f;
            }

            //The order that the holes are booked need to be in acending order as the path starts from hole 1 and flows all the way to hole 18
            //Also this way it's easier to see what holes have been booked as you can see any holes that aren't in the list without having to look through the whole list.
            SelectedHoles = InsertionSort(SelectedHoles);
            lblSelectedHoles.Text = "";
            for (int Hole = 0; Hole < SelectedHoles.Count; Hole++)
            {
                lblSelectedHoles.Text += SelectedHoles[Hole] + "-";
            }
           
        }

        private void Book_Click(object sender, EventArgs e)
        {
            //If the label doesn't have any text the it would mean there isn't any holes selected. 
            if (lblSelectedHoles.Text == "")
            {
                MessageBox.Show("Please Select Holes To Book First");
            }
            else
            {
                if (CartChangeIndex != -1)
                {
                    CartGolfCourseBookings.strHoleNumbers[CartChangeIndex] = lblSelectedHoles.Text;
                    //Takes old price and adds new price
                    CartTotal -= CartBooking_Prices[CartChangeIndex];
                    CartBooking_Prices[CartChangeIndex] = fltTotalCost;
                    CartTotal += CartBooking_Prices[CartChangeIndex];
                    MessageBox.Show("Bookings Changed");

                }
                else
                {

                    
                    //Adds the booking to the running data fields so that when the form is clicked off you can still see the holes you selected.
                    //even if you haven't booked anything.
                    CartGolfCourseBookings.strPurchaseID.Add("Purchase ID");
                    CartGolfCourseBookings.strCourseBookingID.Add("Golf Range Booking ID");
                    CartGolfCourseBookings.strHoleNumbers.Add(lblSelectedHoles.Text);
                    CartGolfCourseBookings.strBookedDate.Add(Booking_Menu.SelectedTimeDate[0]);
                    CartGolfCourseBookings.strBookedStartTime.Add(Booking_Menu.SelectedTimeDate[1]);
                    CartGolfCourseBookings.strBookedEndTime.Add(Booking_Menu.SelectedTimeDate[2]);
                    CartChangeIndex = CartGolfCourseBookings.strPurchaseID.Count() - 1;
                    CartBooking_Prices.Add(fltTotalCost);
                    CartTotal += fltTotalCost;
                    MessageBox.Show("Bookings Added To Purchase Cart");
                    

                }




            }




         
 
               
        

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
      
            SelectedHoles.Clear();
            lblSelectedHoles.Text = "";
            bool holesBooked = false;

            //Holes can only be booked if there are no currently booked holes on the golf course.
            for (int hole = 1; hole < 19; hole++)
            {
                
                if (Holes[hole].Enabled == false)
                {
                    holesBooked = true;
                   
                }
            }


            if (!holesBooked)
            {
                for (int hole = 1; hole < 19; hole++)
                {
                    SelectedHoles.Add(hole);
                    fltTotalCost += 4.90f;
                    Holes[hole].BackgroundImage = Properties.Resources.Selected_Hole;
                }

                for (int Hole = 0; Hole < SelectedHoles.Count; Hole++)
                {
                    lblSelectedHoles.Text += SelectedHoles[Hole] + "-";
                }

            }
            

            
           

            
            
            


           
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
 }

