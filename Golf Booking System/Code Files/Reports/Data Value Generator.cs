using DatabaseTables;
using System;
using System.Collections.Generic;
using static Validation.SearchingSorting;

namespace Reports
{

    public class DataValueGenerator
    {
        private IDictionary<string, float> DataValues;

        
        public DataValueGenerator()
        {
            DataValues =  new Dictionary<string, float>();
        }

        public IDictionary<string, float> ReturnDataValues()
        {return DataValues;}

        public void LoadItems(string buyOrLend, string dateStringType, bool withDiscount, string[] includedCustomers)
        {
            //Loads all the item sales, item details and purchases them self, this allows me to calculate the item prices
            //from the amount of items bought in the item sales and the the price from the item details and finially the date it
            //was bought on from the purchase data table.
            ItemSale item_Sales = new ItemSale();
            item_Sales = ItemSale.LoadItemSales();

            Purchase purchases = new Purchase();
            purchases = Purchase.LoadPurchases();

            Member members = new Member();
            members = Member.LoadMembers();

            Item items = new Item();
            items = Item.LoadItems();


            for (int Sale = 0; Sale < item_Sales.strItemID.Count; Sale++)
            {

                if (item_Sales.strLendOrBuy[Sale] == buyOrLend)
                {
                    //This does a searches the purchase ID of a sale in the purchase database and returns the index of the ID Within the database
                    int purchaseIndex = BinarySearch(purchases.strPurchaseID, 0, purchases.strPurchaseID.Count, item_Sales.strPurchaseID[Sale]);
                    if (purchaseIndex != -1)
                    {
                        string X = purchases.strPurchaseDate[purchaseIndex];

                        int itemIndex = BinarySearch(items.strItemID, 0, items.strItemID.Count, item_Sales.strItemID[Sale]);
                        if (itemIndex != -1)
                        {
                            float price;
                            float discount = 0;
                            int memberIndex = BinarySearch(members.strMembershipID, 0, members.strMembershipID.Count, purchases.strMembershipID[purchaseIndex]);
                            if (memberIndex != -1)
                            {
                                if (withDiscount)
                                {

                                    if (members.strMembershipType[memberIndex] == "Premium")
                                    {
                                        discount = 0.1f;
                                    }
                                    else if (members.strMembershipType[memberIndex] == "Supreme")
                                    {
                                        discount = 0.15f;
                                    }
                                }
                                if (buyOrLend == "B")
                                {
                                    price = float.Parse(items.strBuyCost[itemIndex]) * float.Parse(item_Sales.strQuantity[Sale]);

                                }
                                else
                                {
                                    price = float.Parse(items.strLendCost[itemIndex]) * float.Parse(item_Sales.strQuantity[Sale]);
                                }

                                bool customerIncluded = false;
                                //Loops through the customer to include to determine if this purchase should be included into the analysis.
                                for (int customerIndex = 0; customerIndex < includedCustomers.Length; customerIndex++)
                                {
                                    if (includedCustomers[customerIndex] == members.strMembershipType[memberIndex])
                                    {
                                        customerIncluded = true;
                                    }
                                }

                                if (customerIncluded)
                                {
                                    price -= price * discount;

                                    //This turns the string X which is the string version of a the date the purchase was made into a datetime variable.
                                    DateTime dtX = DateTime.Parse(X);
                                    //It then allows the use of the ToString() method that allows me to pass a format that makes it so that it gets the correct format of the
                                    //date, forexample if i wanted only the hour of the date i could pass a certain string that makes it return only the hours as a string.
                                    string strX = dtX.ToString(dateStringType);


                                    if (DataValues.ContainsKey(strX))
                                        DataValues[strX] += price;
                                    else
                                        DataValues.Add(strX, price);
                                }
                            }
                            
                            
                        }
                       
                    }
                    
                }
            }

        }

        public void LoadGolfBookings(string DateStringType, bool withDiscount, string[] includedCustomers)
        {

            GolfCourseBooking golfCourseBookings = new GolfCourseBooking();
            //Loads all the golf course bookings from the database.
            golfCourseBookings = GolfCourseBooking.LoadBookings();

            Purchase purchases = new Purchase();
            purchases = Purchase.LoadPurchases();

            Member members = new Member();
            members = Member.LoadMembers();


            //Loops for each booking in the database. 
            for (int bookingIndex = 0; bookingIndex < golfCourseBookings.strPurchaseID.Count; bookingIndex++)
            {
                //X is the time intervals for the graph like monday, tuesday. But first of all it needs to full date so 
                //that it can look at it and trim the parts of the interval the user didn't want to look at
                //for example if the user wanted a graph for days then it would exlude year,month and ect.
                string X = golfCourseBookings.strBookedDate[bookingIndex] + " " + golfCourseBookings.strBookedStartTime[bookingIndex] + ":00";

                string[] strCubicalNumbers = golfCourseBookings.strHoleNumbers[bookingIndex].Split('-');
                //Gets the amount of holes where booked for that booking alone
                int intAmountOfHoles = strCubicalNumbers.Length - 1;
                //Gets the total amount of money for that booking. 
               
                float discount = 0;
                int purchaseIndex = BinarySearch(purchases.strPurchaseID, 0, purchases.strPurchaseID.Count, golfCourseBookings.strPurchaseID[bookingIndex]);
               
                int memberIndex = BinarySearch(members.strMembershipID, 0, members.strMembershipID.Count, purchases.strMembershipID[purchaseIndex]);
                if (memberIndex != -1)
                {
                    bool customerIncluded = false;
                    //Loops through the customer to include to determine if this purchase should be included into the analysis.
                    for (int customerIndex = 0; customerIndex < includedCustomers.Length; customerIndex++)
                    {
                        if (includedCustomers[customerIndex] == members.strMembershipType[memberIndex])
                        {
                            customerIncluded = true;
                        }
                    }
                    if (withDiscount)
                    {

                        if (members.strMembershipType[memberIndex] == "Premium")
                        {
                            discount = 0.1f;
                        }
                        else if (members.strMembershipType[memberIndex] == "Supreme")
                        {
                            discount = 0.15f;
                        }
                    }

                    if (customerIncluded)
                    {
                        float price = intAmountOfHoles * 4.90f;
                        price -= price * discount;
                        //Trims part of the date that aren't needed so that it catagorises the dates how the user wants it.
                        DateTime dtX = DateTime.Parse(X);

                        string strX = dtX.ToString(DateStringType);

                        //Checks to see if that time interval is already there
                        if (DataValues.ContainsKey(strX))
                            //if it is then it will simple add the price to the current price for that time interval
                            DataValues[strX] += price;
                        else
                            //if it isn't then it will add that time interval to the points and add the price for that booking as well for the y axis.
                            DataValues.Add(strX, price);
                    }
                }
               
                
            }

        }

    }
}