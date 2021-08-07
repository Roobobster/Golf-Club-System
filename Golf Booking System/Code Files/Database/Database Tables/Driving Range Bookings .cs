using System.Collections.Generic;
using System.Data.OleDb;
using static DataHandling.Database;
namespace DatabaseTables
{
    public class DrivingRangeBooking
    {
        //This array of fields is used to iterate through for the adding to the database.
        public static readonly string[] Fields = new string[6] { "Purchase_ID", "Range_Booking_ID", "Cubical_Number", "Booked_Date", "Booked_Start_Time",  "Booked_End_Time"};

        public List<string> strPurchaseID, strRangeBookingID, strCubicalNumber, strBookedDate, strBookedStartTime,strBookedEndTime;

        public DrivingRangeBooking()
        {
            //Initialises all the Lists when an instance of this class is generated. 
            strPurchaseID = new List<string>();
            strRangeBookingID = new List<string>();
            strCubicalNumber = new List<string>();
            strBookedStartTime = new List<string>();
            strBookedEndTime = new List<string>();
            strBookedDate = new List<string>();

        }
     
        
        //Loads all the bookings from the driving range database into a structure that is more easy to handle
        public static DrivingRangeBooking LoadBookings(string OrderBy = "Purchase_ID")
        {
            ConnectToDatabase();

            OleDbCommand AccessDatabaseCommand = new OleDbCommand("SELECT * FROM Driving_Range_Bookings ORDER BY " + OrderBy + " ASC", MyConnection);

            OleDbDataReader DatabaseReader = AccessDatabaseCommand.ExecuteReader();

            DrivingRangeBooking DrivingRangeBookings =  new DrivingRangeBooking();

            //Loops for every singe record and gest every field from the record and adds those details to the data structure.
            while (DatabaseReader.Read())
            {
                DrivingRangeBookings.strPurchaseID.Add(DatabaseReader.GetValue(0).ToString());
                DrivingRangeBookings.strRangeBookingID.Add(DatabaseReader.GetValue(1).ToString());
                DrivingRangeBookings.strCubicalNumber.Add(DatabaseReader.GetValue(2).ToString());
                DrivingRangeBookings.strBookedDate.Add(DatabaseReader.GetValue(3).ToString());
                DrivingRangeBookings.strBookedStartTime.Add(DatabaseReader.GetValue(4).ToString());
                DrivingRangeBookings.strBookedEndTime.Add(DatabaseReader.GetValue(5).ToString());              

            }

            MyConnection.Close();
            return DrivingRangeBookings;

        }


    }

}