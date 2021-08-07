//This is for all the global variables that need to be used between forms.
using DatabaseTables;
using System.Collections.Generic;
namespace Global_Variables
{
    public static class Global_Variables_class
    {
        //I could change where these are placed , for some.
        //By using a global variable for the cart total it will mean that i won't need to rework out all the totals
        //instead i could just add the total price for a section of the form to the total of the cart when they add to it.
        public static float CartTotal = 0;

        //Theses are needed so that the items and their details can be added to a cart in the main sales menu screen
        //Also it allows me to add the items to the database after the user has actually finished buying everything
        //as they may change their mind after they see the total and want to change a few bookings before they finialise
        //their purchase, meaning there will be less people asking for refund
        public static ItemSale CartItemSales = new ItemSale();       
        public static DrivingRangeBooking CartDrivingRangeBookings = new DrivingRangeBooking();
        public static GolfCourseBooking CartGolfCourseBookings = new GolfCourseBooking();
        public static List<float> Cart_Item_Prices = new List<float>();
        public static List<float> CartBooking_Prices = new List<float>();

        public static int Cart_Tokens = 0;

        //This is needed so that one of the forms can be resused but with some minor changes to some part of it
        //like the min values and what form it goes to after you press the proceed button.
        public static string BookingType = "";

        

        public static string EmailBody = "";
        public static string EmailSubject = "";

        public static List<string> AttachedFilePaths = new List<string>();
        public static List<string> AttachedFileNames = new List<string>();

        public static List<string> AttachedDirectoryPaths = new List<string>();
        public static List<string> AttachedDirectoryNames = new List<string>();


    }
}