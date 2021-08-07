using DatabaseTables;
using Emailing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static DataHandling.Database;
using static Global_Variables.Global_Variables_class;
using static InputForms.InputBox;
using static Validation.SearchingSorting;
namespace Golf_Booking_System
{
    public partial class Sales_Menu : Form
    {
        private float fltTokenPrice = 3.99f;

        public Sales_Menu()
        {
            InitializeComponent();
        }

        private void DrivingRangeBookings_Click(object sender, EventArgs e)
        {
            this.Close();
            BookingType = "Driving Range";
            Booking_Menu frmBookingMenu = new Booking_Menu();
            
            frmBookingMenu.Show();
        }

        private void GolfCourseBookings_Click(object sender, EventArgs e)
        {
            this.Close();
            Booking_Menu frmBookingMenu = new Booking_Menu();
            BookingType = "Golf Course";
            frmBookingMenu.Show();
        }

        private void ItemSales_Click(object sender, EventArgs e)
        {
            this.Close();
            Item_Sales frmItem_Sales = new Item_Sales();
            frmItem_Sales.Show();
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



         //Custom Mesausre Item event handler to allow for items in the listbox like the golf range bookings to make it easier to read by spanning it across multiple lines       
        private void Purchases_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            //Adds an extra line for every new line in the string
            int numExtraLines = lstPurchases.Items[e.Index].ToString().Length - lstPurchases.Items[e.Index].ToString().Replace(Environment.NewLine, string.Empty).Length;
            //the height is the (initial height) + (a sutiable constant to increase the height times by the amount of new lines in the item).
            e.ItemHeight = 24 + 12 * numExtraLines;
            Console.WriteLine("measure item");
        }

        //DrawItem event handler for listbox
        private void lstPurchases_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.DrawBackground();
                e.Graphics.DrawString(lstPurchases.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                Console.WriteLine("Draw item");
            }
            

        }


        private void Sales_Menu_Load(object sender, EventArgs e)
        {
            cmbTokens.SelectedIndex = 0;
            lstPurchases.Items.Clear();

            LoadAllPurchases();
        }

        private void LoadAllPurchases()
        {

            //Loops for every item in the cart
            //Adds the item purchase to the purchase list box.
            for (int intItem = 0; intItem < CartItemSales.strItemID.Count; intItem++)
                lstPurchases.Items.Add(CartItemSales.strItemID[intItem] + " - Quantity: " + CartItemSales.strQuantity[intItem] + "  (" + CartItemSales.strLendOrBuy[intItem] + ")" + " - £" + Math.Round(Cart_Item_Prices[intItem], 2).ToString());


            //Loops for every golf course booking in the cart
            //Adds the golf course booking to the purchase list box
            for (int intBooking = 0; intBooking < CartGolfCourseBookings.strPurchaseID.Count; intBooking++)
                lstPurchases.Items.Add("Golf Course Booking" + " - £" + Math.Round(CartBooking_Prices[intBooking], 2).ToString() + Environment.NewLine + "          -Holes: -" + CartGolfCourseBookings.strHoleNumbers[intBooking] + Environment.NewLine + "          -Date: " + CartGolfCourseBookings.strBookedDate[intBooking] + Environment.NewLine + "          -Time: " + CartGolfCourseBookings.strBookedStartTime[intBooking] + " - " + CartGolfCourseBookings.strBookedEndTime[intBooking]);

            for (int i = 0; i < CartDrivingRangeBookings.strRangeBookingID.Count; i++)        
                lstPurchases.Items.Add("Driving Range Booking - Free" + Environment.NewLine + "          -Cubicles: |" + CartDrivingRangeBookings.strCubicalNumber[i] + Environment.NewLine + "          -Date: " + CartDrivingRangeBookings.strBookedDate[i] + Environment.NewLine + "          -Time: " + CartDrivingRangeBookings.strBookedStartTime[i] + " - " + CartDrivingRangeBookings.strBookedEndTime[i]);
            


            lblTotal.Text = "Total: £" + Math.Round(CartTotal, 2);
            //This just makes it so that if the cart is empty it will show £0.00 instead of £0
            if (CartTotal == 0)
                lblTotal.Text = "Total: £0.00";
            

            if (Cart_Tokens != 0)
                lstPurchases.Items.Add("Tokens - £" + Math.Round((Cart_Tokens * fltTokenPrice), 2).ToString() + "| Quantity - " + Cart_Tokens + " |");
            

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

   



        private void Purchase_Click(object sender, EventArgs e)
        {
            AddCartToDatabase();
                
        }

        //This generates a random UUID (Universally unique identifier) which is used for the unique IDs
        //Although this theoretically can produce collisions it so low chance that it's neligible 
        private string GenerateUniqueID()
        { return Guid.NewGuid().ToString(); }


        private void AddCartToDatabase()
        {
            //Checks if the purchase list box empty
            if (lstPurchases.Items.Count == 0)
            {
                MessageBox.Show("No items are in the Cart");
            }
            else
            {
                bool isVisitor = ckbIsVisitor.Checked;

                string strFirstName = "";
               

                if (isVisitor)
                    strFirstName = "VISITOR";
                else
                    CreateInputBox("Membership Details", "Enter Member's First Name", ref strFirstName);




                //Checks if the box was filled out.
                if (strFirstName == "")
                {
                    MessageBox.Show("Please Enter Member's First name");
                }
                else
                {
                    string strSecondName = "";

                    

                    //If the box was filled with a name then it will prompt another input box so that they can input the surname of the user
                   


                    if (isVisitor)
                        strSecondName = "MEMBER";
                    else
                        CreateInputBox("Membership Details", "Enter Member's Second Name", ref strSecondName);

                    if (strSecondName == "")
                    {
                        MessageBox.Show("Please Enter Member's second name");
                    }
                    else
                    {

                        //If everything is filled it then checks if the person exists in the database 
                        Member Members = new Member();
                        //Loads all the member data from the database into multiple string lists
                        Members = Member.LoadMembers();
                        //Does a binary search through all the surenames and sees if there's a match
                        int intMemberIndex = BinarySearch(Members.strSurname, 0, Members.strSurname.Count, strSecondName);

                        if (intMemberIndex != -1)
                        {
                            string strMembershipID = Members.strMembershipID[intMemberIndex];
                            float discount = 0;
                            if (Members.strMembershipType[intMemberIndex] == "Premium")
                            {
                                discount = 0.1f;
                            }
                            else if ( Members.strMembershipType[intMemberIndex] == "Supreme")
                            {
                                discount = 0.15f;
                            }
                            string PurchaseID = GenerateUniqueID();

                            AddPurchase(strMembershipID, PurchaseID, discount);
                            //Adds the driving range bookings to the database
                            AddDrivingRangeBookings(PurchaseID);
                            //Adds the golf course bookings to the database
                            AddGolfCourseBookings(PurchaseID);
                            //Adds the purchased items to the database
                            AddPurchasedItems(PurchaseID);
                            //Changes the stock level of the items depending on what is sold. 
                            ChangeItemStockLevel();

                            //Adds the token purchases to the database if there are any 
                            foreach (string purchase in lstPurchases.Items)
                            {
                                if (purchase.Contains("Tokens"))
                                {
                                    AddTokensPurchase(PurchaseID);
                                }
                            }


                            if (Members.strMembershipType[intMemberIndex] != "Visitor")
                            {
                                string emailBody = "";
                                emailBody += " Your Purchase on the " + DateTime.Now.ToString(); ;
                                emailBody +=  Environment.NewLine;
                                emailBody += "________________________________________________________________________________________________";
                                emailBody += Environment.NewLine;

                                foreach (string item in lstPurchases.Items)
                                {
                                    emailBody += item;
                                    emailBody += Environment.NewLine;
                                }
                                


                                emailBody += "________________________________________________________________________________________________";
                                emailBody +=  Environment.NewLine;
                                float totalPrice = CartTotal - (CartTotal * discount);
                                totalPrice = (float)Math.Round(totalPrice, 2);
                                emailBody += "Total : £" + totalPrice;
                                emailBody +=  Environment.NewLine;
                                emailBody += "________________________________________________________________________________________________";


                                string emailSubject = "Erin's Golf Club Purchase Invoice";

                                string memberEmail = Members.strEmail[intMemberIndex];
                                List<string> emailList = new List<string>
                                { memberEmail};

                                List<string> emailAttachements = new List<string>();


                                SMPT.SendEmail(emailList, "robhealless@gmail.com", "warvin123321", emailSubject, emailBody, emailAttachements);



                            }

                            MessageBox.Show("Purchase Has Been Made");
                            //Clears all the data to do with this just made purchase from the program.
                            ClearAllPurchases();

                        }
                        else
                        {
                            MessageBox.Show("There Is No Such Member With That Name");
                        }
                    }
                    
                        
                }                    
            }
        }

        private void AddTokensPurchase(string PurchaseID)
        {
            
            string[] strInput = new string[2] { PurchaseID, Cart_Tokens.ToString() };
            AddToDatabase("Tokens", Token.Fields, strInput);
            Cart_Tokens = 0;
        }
        private void AddPurchase(string MemberID, string PurchaseID, float discount)
        {
            float totalPrice = CartTotal - (CartTotal * discount);
            totalPrice = (float) Math.Round(totalPrice, 2);
            if (discount != 0)
            {
                MessageBox.Show("Total Price With Discount: £" + totalPrice);
            }
            
            string[] strInput = new string[4] { PurchaseID, totalPrice.ToString(), MemberID, DateTime.Now.ToString("dd/MM/yyyy hh:mm") };
            AddToDatabase("Purchases", Purchase.Fields, strInput);
        }


        private void ClearAllPurchases()
        {
            //Clears all the items in the list box
            lstPurchases.Items.Clear();


            //Clears all the driving range booking data from the cart
            CartDrivingRangeBookings.strBookedDate.Clear();
            CartDrivingRangeBookings.strBookedEndTime.Clear();
            CartDrivingRangeBookings.strBookedStartTime.Clear();
            CartDrivingRangeBookings.strCubicalNumber.Clear();
            CartDrivingRangeBookings.strPurchaseID.Clear();
            CartDrivingRangeBookings.strRangeBookingID.Clear();

            //Clears all the golf course booking data from the cart
            CartGolfCourseBookings.strPurchaseID.Clear();
            CartGolfCourseBookings.strHoleNumbers.Clear();
            CartGolfCourseBookings.strCourseBookingID.Clear();
            CartGolfCourseBookings.strBookedStartTime.Clear();
            CartGolfCourseBookings.strBookedEndTime.Clear();
            CartGolfCourseBookings.strBookedDate.Clear();


            //Clears all the item sales details from the cart. 
            CartItemSales.strItemID.Clear();
            CartItemSales.strLendOrBuy.Clear();
            CartItemSales.strPurchaseID.Clear();
            CartItemSales.strQuantity.Clear();

            //Clears all the prices for the items in the cart
            CartBooking_Prices.Clear();
            Cart_Item_Prices.Clear();

            //Resets the Cart_Total
            CartTotal = 0;

            //Once all the items are gone they should add up to zero currency.
            lblTotal.Text = "Total: £0.00";

        }

        private void AddDrivingRangeBookings(string PurchaseID)
        {
            //Loops for the amount of bookings made 
            for (int Booking = 0; Booking < CartDrivingRangeBookings.strPurchaseID.Count; Booking++)
            {
                string strDrivingRangeID = GenerateUniqueID();
                //Adds all the data from the cart_DrivingRangeBookings which holds all the information needed for the made bookings, into the database.
                
                string[] strInput = new string[6] { PurchaseID, strDrivingRangeID, CartDrivingRangeBookings.strCubicalNumber[Booking],
                 CartDrivingRangeBookings.strBookedDate[Booking], CartDrivingRangeBookings.strBookedStartTime[Booking],
                 CartDrivingRangeBookings.strBookedEndTime[Booking]};

                //Uses the list of string which is all the data to do with that booking in the same order as the fields to add to the database.
                AddToDatabase("Driving_Range_Bookings", DrivingRangeBooking.Fields ,strInput);
            }
            
        }

        private void AddGolfCourseBookings(string PurchaseID)
        {
            //Loops for every golf course booking in the cart
            for (int Booking = 0; Booking < CartGolfCourseBookings.strPurchaseID.Count; Booking++)
            {
                string strGolfCourseID = GenerateUniqueID();
                //Needs to add all fields into a single string array so that it can be used to add to the database. 
                string[] strInput = new string[6] { PurchaseID, strGolfCourseID, CartGolfCourseBookings.strHoleNumbers[Booking],
                 CartGolfCourseBookings.strBookedDate[Booking], CartGolfCourseBookings.strBookedStartTime[Booking],
                 CartGolfCourseBookings.strBookedEndTime[Booking]};

                //Adds the golf course bookings to the database.
                AddToDatabase("Golf_Course_Bookings", GolfCourseBooking.Fields, strInput);
            }
        }

        private void AddPurchasedItems(string PurchaseID)
        {
            //Loops for every item in the cart
            for (int item = 0; item < CartItemSales.strLendOrBuy.Count; item++)
            {
                //Puts all the item details into string array so it can be used to add to the database. 
                string[] strInput = new string[4] { PurchaseID, CartItemSales.strLendOrBuy[item], CartItemSales.strItemID[item], CartItemSales.strQuantity[item] };

                //Adds the item sale to the database. 
                AddToDatabase("Item_Sales", ItemSale.Fields, strInput);
            }
        }

        //Changes the item stock level to what is should be based of what is in the cart 
        private void ChangeItemStockLevel()
        {
            ///Loads all the item details from the database. 
            Item DatabaseItems = Item.LoadItems();

            //Loops for every item in the database
            for (int ItemIndex = 0; ItemIndex < DatabaseItems.strItemID.Count; ItemIndex++)
            {
                //Loops for every item in teh cart
                for (int CartIndex = 0; CartIndex < CartItemSales.strItemID.Count; CartIndex++)
                {
                    //Checks to see if the database item and the item in the cart are the same
                    if (DatabaseItems.strItemID[ItemIndex] == CartItemSales.strItemID[CartIndex])
                    {
                        string[] strChangeValues = new string[5];
                        //It then determines what sale type it is (Bought or Lent)
                        if (CartItemSales.strLendOrBuy[CartIndex] == "B")
                        {
                            //Calculates the new quantity for the item based on the amount being sold in the cart.
                            int intQuantity = int.Parse(DatabaseItems.strBuyQuantity[ItemIndex]) - int.Parse(CartItemSales.strQuantity[CartIndex]);
                            DatabaseItems.strBuyQuantity[ItemIndex] = (intQuantity).ToString();
                                                     
                        }
                        else
                        {
                            //Calculates the new quantity for the item based on the amount being lent in the cart.
                            int intQuantity = int.Parse(DatabaseItems.strLendQuantity[ItemIndex]) - int.Parse(CartItemSales.strQuantity[CartIndex]);
                            DatabaseItems.strLendQuantity[ItemIndex] = (intQuantity).ToString();
                        }

                        //Puts all the change values in the database
                        strChangeValues[0] = DatabaseItems.strItemID[ItemIndex];
                        strChangeValues[1] = DatabaseItems.strBuyCost[ItemIndex];
                        strChangeValues[2] = DatabaseItems.strLendCost[ItemIndex];
                        strChangeValues[3] = DatabaseItems.strBuyQuantity[ItemIndex];
                        strChangeValues[4] = DatabaseItems.strLendQuantity[ItemIndex];

                        //Edits the database with the new values for the quanties due to the purchase. 
                        EditDatabase("Items", Item.Fields,  strChangeValues, "Item_ID", DatabaseItems.strItemID[ItemIndex]);
                    }
                }
            }

            
        }


        private void AddTokens()
        {
            int intPreviouseCartTokens = Cart_Tokens;
            Cart_Tokens += int.Parse(cmbTokens.Text);
            float intTokenPrice = Cart_Tokens * fltTokenPrice;

            //Checks to see if the listbox is empty and if it is then it will add the token purchase straight away. 
            if (lstPurchases.Items.Count == 0)
            {
                lstPurchases.Items.Add("Tokens - £" + (intTokenPrice).ToString() + "| Quantity - " + Cart_Tokens + " |");
            }
            else
            {
                //Loops for every item in the list box so that it can see if any tokens have been bought before. 
                for (int i = 0; i < lstPurchases.Items.Count; i++)
                {
                    string item = lstPurchases.Items[i].ToString();

                    if (item.Remove(6, item.Length - 6) == "Tokens")
                    {

                        //Removes the item from the listbox so it can be added again but with the new correct values. 
                        lstPurchases.Items.Remove(item);
                        lstPurchases.Items.Add("Tokens - £" + intTokenPrice.ToString() + "| Quantity - " + Cart_Tokens + " |");
                        CartTotal -= intPreviouseCartTokens * fltTokenPrice;
                        //Ends Loop to stop unnessary code being run
                        break;
                    }
                    //If there are items in the list box but none of them are token purchases then it will add it to the listbox.
                    else if (i == lstPurchases.Items.Count - 1)
                    {
                        lstPurchases.Items.Add("Tokens - £" + (intTokenPrice).ToString() + "| Quantity - " + Cart_Tokens + " |");
                    }

                }


            }
            CartTotal += Cart_Tokens * fltTokenPrice; 

            lblTotal.Text = "Total: £" + Math.Round(CartTotal, 2);
        }

        private void BtnAddTokens_Click(object sender, EventArgs e)
        {
            AddTokens();         
        }

        //This removes the selected purchase from the list box and the cart itself
        private void RemovePurchase(int index)
        {

           

            //Makes sure that an item is selected before actually trying to remove a item from the purchase.
            if (index != -1)
            {
                //Removes the item from the listbox ( visually for the user to indicate that the item is now gone)
                lstPurchases.Items.RemoveAt(index);

                //Need to work out the indexes at which the different purchases types end ( as they are added to the list box in a certain order)
                //Items are added first, then the golf course bookings, then the range bookings and finally the tokens are added at the end of the purchase
                int lastItemIndex = CartItemSales.strItemID.Count - 1;
                int lastGolfBookingIndex = CartGolfCourseBookings.strCourseBookingID.Count - 1;
                int lastRangeBookingIndex = CartDrivingRangeBookings.strPurchaseID.Count - 1;

                //Checks to see if it's not an item
                if (index > lastItemIndex)
                {

                    index -= lastItemIndex + 1;
                    //Checks to see if it's not a golf course booking
                    if (index > lastGolfBookingIndex)
                    {
                        index -= lastGolfBookingIndex + 1;
                        //Checks to see if it's not a driving range booking
                        if (index > lastRangeBookingIndex)
                        {
                            CartTotal -= Cart_Tokens * fltTokenPrice;
                            Cart_Tokens = 0;

                        }
                        else
                            RemoveDrivingRangeBooking(index);
                    }
                    else
                        RemoveGolfCourseBooking(index);
                }
                else
                    RemoveItem(index);


                //Re displays the cart total with the new cart total after removing the item from the cart.
                lblTotal.Text = "Total: £" + Math.Round(CartTotal, 2);



            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int removeIndex = lstPurchases.SelectedIndex;
            RemovePurchase(removeIndex);
        }



        //This edits a purchase by looping through all the current items and determining which purchase type it is and then the index in that specific cart it is. 
        private void EditPurchase()
        {
            int selectedIndex = lstPurchases.SelectedIndex;

            //Ensures that the user first selects a item in the list box
            if (selectedIndex != -1)
            {

                int lastItemIndex = CartItemSales.strItemID.Count - 1;
                int lastGolfBookingIndex = CartGolfCourseBookings.strCourseBookingID.Count - 1;
                int lastRangeBookingIndex = CartDrivingRangeBookings.strPurchaseID.Count - 1;

                //Checks to see if it's not a item
                if (selectedIndex > lastItemIndex)
                {

                    selectedIndex -= lastItemIndex + 1;

                    //Checks to see if it's not a golf course booking
                    if (selectedIndex > lastGolfBookingIndex)
                    {
                        selectedIndex -= lastGolfBookingIndex + 1;

                        //Checks to see if it's not a driving range booking
                        if (selectedIndex > lastRangeBookingIndex)
                        {
                            MessageBox.Show("To Edit Tokens Remove The Current Tokens Then Add The New Amount");
                        }
                        else
                            EditDrivingRangeBooking(selectedIndex);
                    }
                    else
                        EditGolfCourseBooking(selectedIndex);
                }
                else
                    MessageBox.Show("Items Can't Be Edited, Only Removed");


            }
        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            EditPurchase();
        }

        

        private void EditGolfCourseBooking(int index)
        {
            GolfCourseBookings golfRangeForm = new GolfCourseBookings(index);

            golfRangeForm.Show();
            this.Close();
        }

        private void EditDrivingRangeBooking(int index)
        {          

            Driving_Range_Bookings rangeForm = new Driving_Range_Bookings(index);

            rangeForm.Show();
            this.Close();

        }


        //Removes an item from the cart at a specific index
        private void RemoveItem(int Index)
        {
            CartItemSales.strItemID.RemoveAt(Index);
            CartItemSales.strLendOrBuy.RemoveAt(Index);
            CartItemSales.strQuantity.RemoveAt(Index);
            float price = Cart_Item_Prices[Index];
            Cart_Item_Prices.RemoveAt(Index);
            CartTotal -= price;
        }

        //Removes a golf course booking at the specific index
        private void RemoveGolfCourseBooking(int Index)
        {
            CartGolfCourseBookings.strBookedDate.RemoveAt(Index);
            CartGolfCourseBookings.strBookedEndTime.RemoveAt(Index);
            CartGolfCourseBookings.strBookedStartTime.RemoveAt(Index);
            CartGolfCourseBookings.strCourseBookingID.RemoveAt(Index);
            CartGolfCourseBookings.strHoleNumbers.RemoveAt(Index);
            CartGolfCourseBookings.strPurchaseID.RemoveAt(Index);

            float price = CartBooking_Prices[Index];
            CartBooking_Prices.RemoveAt(Index);
            CartTotal -= price;
        }


        //Removes a driving range booking at the specific index
        private void RemoveDrivingRangeBooking(int Index)
        {

            CartDrivingRangeBookings.strBookedDate.RemoveAt(Index);
            CartDrivingRangeBookings.strBookedEndTime.RemoveAt(Index);
            CartDrivingRangeBookings.strBookedStartTime.RemoveAt(Index);
            CartDrivingRangeBookings.strRangeBookingID.RemoveAt(Index);
            CartDrivingRangeBookings.strCubicalNumber.RemoveAt(Index);
            CartDrivingRangeBookings.strPurchaseID.RemoveAt(Index);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int itemCount = lstPurchases.Items.Count;
            //Loops for every item and removes the first item, which means the next index will shift down to index 0 again.
            for (int i = 0; i < itemCount; i++)
            {
                RemovePurchase(0);
            }
        }
    }
}
