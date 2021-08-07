using DatabaseTables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Global_Variables.Global_Variables_class;


namespace Golf_Booking_System
{
    public partial class Driving_Range_Bookings : Form
    {
        int CartChangeIndex;
        DrivingRangeBooking DrivingRangeBookings = new DrivingRangeBooking();

        Button[] CubicalLayout = new Button[36];

        
        List<string> SelectedCubicles = new List<string>();
        
        public Driving_Range_Bookings(int cartChangeIndex = -1)
        {
            InitializeComponent();

            LoadSelectedCubicals(cartChangeIndex);
        }

        private void LoadSelectedCubicals(int cartChangeIndex)
        {
            CartChangeIndex = cartChangeIndex;
            if (cartChangeIndex != -1)
            {
                string[] strCubicalNumbers = CartDrivingRangeBookings.strCubicalNumber[cartChangeIndex].Split('|');
                for (int i = 0; i < strCubicalNumbers.Length - 1; i++)
                {
                    SelectedCubicles.Add(strCubicalNumbers[i]);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Menu frmSales_Menu = new Sales_Menu();
            frmSales_Menu.Show();

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //This loops from 0 to 18 and makes buttons to simulate the mats in the driving range.
        private void Driving_Range_Bookings_Load(object sender, EventArgs e)
        {
            DrivingRangeBookings = DrivingRangeBooking.LoadBookings("Purchase_ID");

            CreateDrivingRange();

            LoadBookedCubicals();

            LoadCartBookings();

            if (CartChangeIndex != -1)
                LoadEditBookings();

            DisplayFloor(1);

        }

        private void LoadEditBookings()
        {
                DisplayBookedCubicles(CartChangeIndex, true, true);

        }

        private void LoadCartBookings()
        {
            for (int i = 0; i < CartDrivingRangeBookings.strCubicalNumber.Count; i++)
            {
                if (CartDrivingRangeBookings.strBookedDate[i] == Booking_Menu.SelectedTimeDate[0] && CartDrivingRangeBookings.strBookedStartTime[i] == Booking_Menu.SelectedTimeDate[1])
                {
    
                        DisplayBookedCubicles(i, true);

                    break;
                }
            }

           
        }

        private void CreateDrivingRange()
        {
            //This uses preset Y values as there is no simple algorithm to simulate the places where the mats are placed, therefore it's easy to just use a integer array with all the y values.
            int[] YPoints = new int[18] { 250, 225, 200, 175, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 175, 200, 225, 250 };

            //This loops 18 times for the 18 cubicals on the bottom floor
            //For each cubical a button is added to an array of buttons
            for (int Cubical = 0; Cubical < 18; Cubical++)                           
                CubicalLayout[Cubical] = CreateCublical(Cubical, YPoints[Cubical], Cubical);
            

            int intCubicalNumber;
            //This creates the top floor of cubicals by looping from 17 to 34 and creating buttons which are put into an array of buttons
            for (int Cubical = 18; Cubical < 36; Cubical++)
            {
                intCubicalNumber = Cubical;
                //As the layout requires that the 24th and 25th cubical doesn't exist, it will need to check if the cubical is not 24 or 25 before it adds it to the array.
                if (!(Cubical == 24 | Cubical == 25))
                {
                    if (Cubical > 25)
                    {
                        intCubicalNumber = Cubical - 2;
                    }
                    //The X and Y Parameters need to be -18 the cubical number a it's on floor two and needs to reset the counter
                    CubicalLayout[Cubical] = CreateCublical(Cubical - 18, YPoints[Cubical - 18], intCubicalNumber);
                }

               
            }

        }


        private void DisplayFloor(int intFloorNumber)
        {
            int intStartIndex, intEndIndex;

            //Checks what floor number the user wants to display and then changes the start and end index of the loop so that it shows the
            //correct buttons
            if (intFloorNumber == 1)
            {
                //If it's the bottom floor then the index will start from 0 and end on 17 as the end index is exclusive
                intStartIndex = 0;
                intEndIndex = 18;
                lblFloor.Text = " Floor 1";
            }
            else
            {
                //If it's the top floor then the index of the for loop will start from 17 and end on 34 as the end index is exclusive
                intStartIndex = 18;
                intEndIndex = 36;
                lblFloor.Text = " Floor 2";
            }

            //Loops through all the buttons 
            for (int Cubical = 0; Cubical < 36; Cubical++)
            {
                //First checks if the Cubical number has a value, if it doesn't then it doesn't exists and therefore will not do anything
                //and will just increment the counter and do this intil the loop has finished
                if (CubicalLayout[Cubical] != null)
                {
                    //If the the cubical index in the cubicallayout has a value then it will only display the button if it is inbetween the floor cubical numbers
                    if (Cubical >= intStartIndex & Cubical < intEndIndex)
                    {
                        //If it is between the values stated then it will mean that that cubical is on the floor and needs to be shown
                        CubicalLayout[Cubical].Show();
                    }
                    else
                    {
                        //If it ins't between the values stated then it will mean that that cubical ins't on this floor and needs to be hidden
                        //This way there won't be buttons left over from change between floors
                        CubicalLayout[Cubical].Hide();
                    }
                }
                
                
            }



        }



        //This handles the button clicking 
        private void Cubical_Click(object sender, EventArgs e)
        {
            //This simply casts the object sender into a control instead of a object that way it can be used to change the 
            //button's properties like the color and text
            Control CubicalButton = (Control)sender;
            Color ButtonColor;
            //If the colour of the button is already red then it will mean they're unselecting a cubical
            if (CubicalButton.BackColor == Color.DeepSkyBlue)
            {
                //To show they've unselected the button it will go back to it's original colour
                ButtonColor = Color.LimeGreen;
                //It will also remove the cubical number from the selectedcubicals list as it's no longer being booked
                SelectedCubicles.Remove(CubicalButton.Text);
            }
                
            else
            {
                //If the button is not red then it will be LimeGreen, meaning it's available and when they click it then it will make the 
                //backcolour red as that the user knows he's booked that cubical
                ButtonColor = Color.DeepSkyBlue;
                //It will then add the cubical number to the selected cubicals list so that all the selected cubicals are stored
                //and can be used to add to the database all at once as you are able to book multiple cubicals at once.
                SelectedCubicles.Add(CubicalButton.Text);

            }
           
            //This is what actually sets the back colour of the button by using the variable buttoncolor which as desired colour for the button.
            //Which indicates if it's being booked or is available for booking
            CubicalButton.BackColor = ButtonColor;         
        }


        //This creates the mat that can be clicked for the user to be able to book a mat(Cubical).
        //The X and Y Parameters are used to determine where the cubicals should be placed on the form 
        //the cubical number is used to lable the cubicals with the correct cubical number on it
        private Button CreateCublical(int X, int Y, int intCubicalNumber)
        {
            Button btnCubical = new Button();
            //This adds the custom made event handler for clicking the cubicals button to the button variable created above.
            btnCubical.Click += new EventHandler(Cubical_Click);
            //Sets a prefixed size value for the cubical and then makes the location based of the passed parameters.
            btnCubical.Size = new Size(53, 119);
            btnCubical.Location = new Point(60 +( 60 * X), Y);
            //Each cubical button needs it's cubical number on it so that those can be used when the user clicks on a button to store the selected cubicals
            //Also since it's passed by an integer from the for loops it will need to be converted into string format.
            string strCubicalNumber = (intCubicalNumber).ToString();
            btnCubical.Text = strCubicalNumber;
            //The first color the button will be is green as it will mean initially it's available 
            btnCubical.BackColor = Color.LimeGreen;
            btnCubical.FlatStyle = FlatStyle.Popup;
            //Once all the properties of the button are added the button is then added to the form controls
            this.Controls.Add(btnCubical);
          
            //Also returns the button variable so that it can be stored in a array of buttons, meaning that they can be editted later. 
            return btnCubical;

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

        private void LoadBookedCubicals()
        {
            string strBookedDate = Booking_Menu.SelectedTimeDate[0];

            DateTime NewStartTime = DateTime.Parse(Booking_Menu.SelectedTimeDate[1]);
            DateTime NewEndTime = DateTime.Parse(Booking_Menu.SelectedTimeDate[2]);

            //This loops through all the bookings by getting all the amount of strings are in a list.
            for (int Booking = 0; Booking < DrivingRangeBookings.strPurchaseID.Count; Booking++)
            {
                //This checks if the date strings are exactly the same, meaning that the bookings are on the same day.
                if (strBookedDate == DrivingRangeBookings.strBookedDate[Booking])
                {
                    //This gets the string values for the bookings and turns them into datetimes so that they can be used for comparing times
                    //meaning that you can see if a time is after or before another.
                    DateTime BookedStartTime = DateTime.Parse(DrivingRangeBookings.strBookedStartTime[Booking]);
                    DateTime BookedEndTime = DateTime.Parse(DrivingRangeBookings.strBookedEndTime[Booking]);


                    //This checks if the end time for the booking the user wants is after the start time of the current bookings
                    //Then it checks if the start time of the booking the user wants is before the end time of the current bookings
                    //So overall this acts as a way of checking if two periods overlap and if they do then it will mean that that cubical will be occupied at the time
                    if ((NewEndTime > BookedStartTime ) && (NewStartTime < BookedEndTime))
                    {
                        //If the there isn't no overlapping then it will mean that the booking will overlap with another.
                        DisplayBookedCubicles(Booking);
                    }                 
                }
            }         
            
        }


       

        private void ChangeFloor_Click(object sender, EventArgs e)
        {
            //If the text of the button that changes the floor says to go to floor 2 then it will display floor two when it's clicked. 
            if (btnChangeFloor.Text == "Go To Floor 2")
            {
                DisplayFloor(2);
                //It will then change the text of the button to say go to floor 1 as then you can go between the two floors infinitely 
                btnChangeFloor.Text = "Go To Floor 1";

            }
            else
            {
                DisplayFloor(1);
                //Of the button text doens't say go to floor 2 then it must say go to floor 1. So when the button is clicked it will show floor 1
                //Then it will change the text to say go to floor 2 instead.
                btnChangeFloor.Text = "Go To Floor 2";
            }
                                
        }

        //Change this so that it doens't allow to book something that already is in the cart.
        private void Book_Click(object sender, EventArgs e)
        {
            string strCubicalNumbers = "";
            if (SelectedCubicles.Count != 0)
            {
                //Loops for all the selected cubical values by getting the size of the selectedcubicals list
                for (int Cubical = 0; Cubical < SelectedCubicles.Count; Cubical++)
                {
                    //A divider is used to split the cubical numbers so when the program is looking at the selected cubical values it can determine if 
                    //a number like 17 is 17 or 1 and 7 as it would be dispalyed 17| if it was 17 or 1|7| if it was 1 and 7
                    strCubicalNumbers += SelectedCubicles[Cubical] + "|";
                }



                if (CartChangeIndex != -1)
                {
                    CartDrivingRangeBookings.strCubicalNumber[CartChangeIndex] = strCubicalNumbers;
                    MessageBox.Show("Bookings Changed");
                }
                else
                {
                    AddBookingsToCart(strCubicalNumbers);
                    CartChangeIndex = CartDrivingRangeBookings.strPurchaseID.Count() - 1;
                    MessageBox.Show("Bookings Added To Purchase Cart");
                }

            }
            else
            {
                MessageBox.Show("Select A Cubical Before Booking");
            }
            
           
                     
        }

        //This Adds all the selected cubicals and details associated with that booking to the cart 
        private void AddBookingsToCart(string CubicalNumbers)
        {
            CartDrivingRangeBookings.strPurchaseID.Add("Purchase ID");
            CartDrivingRangeBookings.strRangeBookingID.Add("Range Booking ID");
            CartDrivingRangeBookings.strCubicalNumber.Add(CubicalNumbers);
            CartDrivingRangeBookings.strBookedDate.Add(Booking_Menu.SelectedTimeDate[0]);
            CartDrivingRangeBookings.strBookedStartTime.Add(Booking_Menu.SelectedTimeDate[1]);
            CartDrivingRangeBookings.strBookedEndTime.Add(Booking_Menu.SelectedTimeDate[2]);
        }


        //This procedure gets a booking index and checks what cubicals the booking has booked
        private void DisplayBookedCubicles(int Booking, bool inCart = false, bool changeable = false)
        {
            //Gets the whole selected cubicals string from DrivingRangeBookings Object that acts as the database.
            string CombinedCubicalNumbers;

            if (inCart)           
                 CombinedCubicalNumbers = CartDrivingRangeBookings.strCubicalNumber[Booking];
            else
                 CombinedCubicalNumbers = DrivingRangeBookings.strCubicalNumber[Booking];
            
            

            //This splits the string in to an array of string of which contains the booked cubical numbers in each index but it also removes the "|"
            //E.g 12|2|3| will split into an array with 12,2 and 3 at indexes 0,1,2 respectively.
            
            string[] strCubicalNumbers = CombinedCubicalNumbers.Split('|');
            //Then it gets the length of this array, which will tell you how many bookings there are +1 as it also makes the null value after the |
            //part of the array, therefore it will always be 1 more value in the array than there is values.
            int AmountOfBookings = strCubicalNumbers.Length -1;
            
            int intCubicalNumbers;
            //Loops for the amount of bookings
            for (int Cubical = 0; Cubical < AmountOfBookings; Cubical++)
            {
                //This gets the first index of the array and turns the string values into integers so that they can be used for the indexes
                intCubicalNumbers = int.Parse(strCubicalNumbers[Cubical]);

                if (changeable)
                {
                    //if it's found in the cart then changeable will be set to true and therefore shouldn't be disabled and should be highlighted blue
                    //which indicates that the user has selected that cubical and can deselect it.
                    if (CubicalLayout[intCubicalNumbers] != null)
                    {
                        CubicalLayout[intCubicalNumbers].BackColor = Color.DeepSkyBlue;
                        CubicalLayout[intCubicalNumbers].Enabled = true;
                    }                 
                }
                else
                {
                    //Changes booked cubicals with the index of the cubical numbers (Which is equal to the index as well) so that they are red and disabled
                    //Meaning that they can't be clicked or interactive with. 
                    CubicalLayout[intCubicalNumbers].BackColor = Color.Red;
                    CubicalLayout[intCubicalNumbers].Enabled = false;
                }
                
            }
        }   
       
    }
}
