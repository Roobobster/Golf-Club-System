using System.Collections.Generic;
using System.Data.OleDb;
using static DataHandling.Database;
namespace DatabaseTables
{
    public class ItemSale
    {
        public List<string> strPurchaseID, strLendOrBuy, strItemID, strQuantity;
        public static readonly string[] Fields = new string[4] { "Purchase_ID", "Lend_Buy", "Item_ID", "Quantity" };

        public ItemSale()
        {
            strPurchaseID = new List<string>();
            strLendOrBuy = new List<string>();
            strItemID = new List<string>();
            strQuantity = new List<string>();
        }

        //Loads all the item sales from the database into a structure that is more easy to handle
        public static ItemSale LoadItemSales()
        {
            ConnectToDatabase();



            OleDbCommand AccessDatabaseCommand = new OleDbCommand("SELECT * FROM Item_Sales ORDER BY Purchase_ID ASC", MyConnection);

            OleDbDataReader DatabaseReader = AccessDatabaseCommand.ExecuteReader();

            ItemSale ItemSales = new ItemSale();

            //Loops for every singe record and gest every field from the record and adds those details to the data structure.
            while (DatabaseReader.Read())
            {
                ItemSales.strPurchaseID.Add(DatabaseReader.GetValue(0).ToString());
                ItemSales.strLendOrBuy.Add(DatabaseReader.GetValue(1).ToString());
                ItemSales.strItemID.Add(DatabaseReader.GetValue(2).ToString());
                ItemSales.strQuantity.Add(DatabaseReader.GetValue(3).ToString());
            }


            MyConnection.Close();
            return ItemSales;

        }
    }
}
