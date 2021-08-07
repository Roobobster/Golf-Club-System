using System.Collections.Generic;
using static DataHandling.Database;
using System.Data.OleDb;

namespace DatabaseTables
{
    public class GolfCourseBooking
    {
        public List<string> strPurchaseID, strCourseBookingID, strHoleNumbers, strBookedDate, strBookedStartTime, strBookedEndTime;

        public static readonly string[] Fields = new string[6] { "Purchase_ID", "Course_Booking_ID", "Hole_Numbers", "Booked_Date", "Booked_Start_Time", "Booked_End_Time" };
        public GolfCourseBooking()
        {

            strPurchaseID = new List<string>();
            strCourseBookingID = new List<string>();
            strHoleNumbers = new List<string>();
            strBookedEndTime = new List<string>();
            strBookedStartTime = new List<string>();
            strBookedDate = new List<string>();

        }

        //Loads all the bookings from the driving range database into a structure that is more easy to handle
        public static GolfCourseBooking LoadBookings(string OrderBy = "Purchase_ID")
        {
            ConnectToDatabase();

            OleDbCommand AccessDatabaseCommand = new OleDbCommand("SELECT * FROM Golf_Course_Bookings ORDER BY " + OrderBy + " ASC", MyConnection);

            OleDbDataReader DatabaseReader = AccessDatabaseCommand.ExecuteReader();

            GolfCourseBooking GolfCourseBookings = new GolfCourseBooking();

            //Loops for every singe record and gest every field from the record and adds those details to the data structure.
            while (DatabaseReader.Read())
            {
                GolfCourseBookings.strPurchaseID.Add(DatabaseReader.GetValue(0).ToString());
                GolfCourseBookings.strCourseBookingID.Add(DatabaseReader.GetValue(1).ToString());
                GolfCourseBookings.strHoleNumbers.Add(DatabaseReader.GetValue(2).ToString());
                GolfCourseBookings.strBookedDate.Add(DatabaseReader.GetValue(3).ToString());
                GolfCourseBookings.strBookedStartTime.Add(DatabaseReader.GetValue(4).ToString());
                GolfCourseBookings.strBookedEndTime.Add(DatabaseReader.GetValue(5).ToString());

            }        

            MyConnection.Close();

            return GolfCourseBookings;

        }

    }
}
