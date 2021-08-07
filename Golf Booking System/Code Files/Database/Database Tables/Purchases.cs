using System.Collections.Generic;
using System.Data.OleDb;
using static DataHandling.Database;


namespace DatabaseTables
{
    public class Purchase
    {

        public static readonly string[] Fields = new string[4] { "Purchase_ID", "Cost", "Member_ID", "Purchase_Date" };
        public List<string> strPurchaseID, strCost, strMembershipID, strPurchaseDate;

        public Purchase()
        {
            strPurchaseID = new List<string>();
            strCost = new List<string>();
            strMembershipID = new List<string>();
            strPurchaseDate = new List<string>();
        }

        //Loads all the purchases from the database into a structure that is more easy to handle
        public static Purchase LoadPurchases()
        {
            ConnectToDatabase();



            OleDbCommand AccessDatabaseCommand = new OleDbCommand("SELECT * FROM Purchases ORDER BY Purchase_ID ASC", MyConnection);

            OleDbDataReader DatabaseReader = AccessDatabaseCommand.ExecuteReader();

            Purchase Purchases = new Purchase();

            //Loops for every singe record and gest every field from the record and adds those details to the data structure.
            while (DatabaseReader.Read())
            {
                Purchases.strPurchaseID.Add(DatabaseReader.GetValue(0).ToString());
                Purchases.strCost.Add(DatabaseReader.GetValue(1).ToString());
                Purchases.strMembershipID.Add(DatabaseReader.GetValue(2).ToString());
                Purchases.strPurchaseDate.Add(DatabaseReader.GetValue(3).ToString());
            }


            MyConnection.Close();
            return Purchases;

        }
    }
}
    
