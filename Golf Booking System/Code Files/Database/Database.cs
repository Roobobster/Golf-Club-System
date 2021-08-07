
//This Module will hold all the code to deal with the database 
using System;
using System.Data;
using System.Data.OleDb;
namespace DataHandling
{
    public class Database
    {


        public static OleDbConnection MyConnection;

        public static void ConnectToDatabase()
        {
            //This determines no matter where the database is, as long as it's in the the program folder.
            string baseAddress = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\", "/");
            string databaseAddress = baseAddress.Replace("/bin/Debug", "");

            MyConnection = new OleDbConnection()
            {ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + databaseAddress + "/Golf Booking System Database.accdb;Jet OLEDB:Database Password=password;"};

            MyConnection.Open();

            //MyConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:/Users/Robert/OneDrive - Cardinal Newman College/Computer Science Project/Golf Booking System/Golf Booking System/Golf Booking System Database.accdb;Jet OLEDB:Database Password=password;";
            
            

        }

        
        //This inserts a whole row of data into the database.
        //This procedure however does require the table fields and values to be in sync with each other meaning that they should be in the same order
        //Otherwise the wrong values will be put in the wrong field values.
        public static void AddToDatabase(string TableName, string[] TableFields, string[] Values)
        {
            //Opens a connection to the database
            ConnectToDatabase();
            //These next few lines of code generate the command string depending on the table fields provided, the table name and the values that are supposed to be changed for.
            string Command = "INSERT INTO " + TableName + "(";


            for (int intFieldIndex = 0; intFieldIndex < TableFields.Length; intFieldIndex++)
            {
                Command += TableFields[intFieldIndex];
                if ((intFieldIndex < TableFields.Length - 1))
                {
                    Command += ", ";
                }
            }

            Command += ")Values(";

            int intCounter = 0;
            foreach (string Field in Values)
            {

                intCounter += 1;
                Command += "'" + Field + "'";
                if ((intCounter < Values.Length))
                {
                    Command += ", ";
                }
            }
            Command += ")";

            OleDbCommand AccessDatabaseCommand = new OleDbCommand(Command, MyConnection);

            //This is what the command string will roughly look like but with different values and fields depending on the senario it is used for
            //"INSERT INTO Item_Sales(Purchase_ID, Lend/Buy, Item_ID, Quantity)Values('Purchase ID', 'B', 'Golf Balls x10', '3')"
            //This then exucutes that command generated above.
            AccessDatabaseCommand.ExecuteNonQuery();
            //Closes the connection as all nessecary changes are done. 
            MyConnection.Close();
        }


        //This updates a row of data in the database even if they're the same.
        //Although this procedure relies on the inputted table fields and change values are in the same order as each other and the database.
        //Otherwise the wrong values will be assigned to the field values.
        public static void EditDatabase(string TableName, string[] TableFields, string[] ChangeValues, string ParameterKey, string ParameterKeyValue)
        {
            ConnectToDatabase();
            
            //The command string is constructed based off the inputs the called procedure.
            string Command = "UPDATE " + TableName + " set ";

     
            int intAmountOfFields = (TableFields.Length - 1);

            for (int FieldIndex = 0; FieldIndex <= intAmountOfFields; FieldIndex++)
            {
                Command += TableFields[FieldIndex] + "= ?";
                if (FieldIndex < intAmountOfFields)
                {
                    Command += ", ";
                }
            }

            Command += " where " + ParameterKey + "= '" + ParameterKeyValue + "'";
            OleDbCommand AccessDatabaseCommand = new OleDbCommand(Command, MyConnection);

            for (int i = 0; i <= intAmountOfFields; i++)
            {
                AccessDatabaseCommand.Parameters.AddWithValue(TableFields[i], ChangeValues[i]);
            }
          
            //This then executes the generated command string above to change the fields with the provided values.
            AccessDatabaseCommand.ExecuteNonQuery();

            //This then closes the connection as all nesseccary changes have been made.
            MyConnection.Close();
        }

        //This simply gets a table name ,a field from that table and a value to look for in that field and if any match the items in the database
        //then it will delete the whole row for that field value (deletes a record of data).
        public static void RemoveFromDatabase(string TableName, string ParameterKey, string ParameterKeyValue)
        {
            //Opens a connection to the database
            ConnectToDatabase();
            //A command string is generated using the table name, parameter key and the parameter key value.
            OleDbCommand AccessDatabaseCommand = new OleDbCommand("DELETE FROM " + TableName + " WHERE " + ParameterKey + " = '" + ParameterKeyValue + "'", MyConnection);
            //The generated command string is then executed.
            AccessDatabaseCommand.ExecuteNonQuery();
            //The connection is then closed as the record has been deleted and the connection is no longer required.
            MyConnection.Close();
        }

        //This function accepts a table name and then loads all the data from that table.
        public static DataTable LoadTableIntoDataTable(string TableName )
        {
            //Opens a connection to the database
            ConnectToDatabase();
            //A connection string is generated using the table name
            string CommandString = "Select * from " + TableName;

            //The command is generated using the connection and the command string generated above
            OleDbCommand Command = new OleDbCommand(CommandString, MyConnection);

            //A atapter is then used with the command so that the adapter can be used to fill a datatable.
            OleDbDataAdapter Adapter = new OleDbDataAdapter(Command);
            //A database is intialised so that it can be filled.
            DataTable dtOutputData = new DataTable();

            //The adapter then fills the datatable with all the values from the database table.
            Adapter.Fill(dtOutputData);
            //The datatable now has all the needed data therefore the connection is no longer needed and therefore is closed.
            MyConnection.Close();


            //This then returns the datatable which contains all the data from the database table.
            return dtOutputData;
            

        }

    }
}