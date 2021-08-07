using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using static DataHandling.Database;
using static Validation.Validate;


namespace DatabaseTables
{

    public class Item
    {
            
            public static readonly string[] Fields = new string[5] { "Item_ID", "Buy_Cost", "Lend_Cost", "Buy_Quantity", "Lend_Quantity" };

            public List<string> strItemID, strBuyCost, strLendCost, strBuyQuantity, strLendQuantity;

            public Item()
            {
                strItemID = new List<string>();
                strBuyCost = new List<string>();
                strLendCost = new List<string>();
                strBuyQuantity = new List<string>();
                strLendQuantity = new List<string>();
            }


        //Does multiple checks on the different fields on the passed data to see if it is the correct format.
        public static bool ValidateItem(string strItemName, string strSellQuantity, string strLendQuantity, string strSellPrice, string strLendPrice)
        {

            IDictionary<string, string> ErrorDictionary = new Dictionary<string, string>();

            //First checks to see if any of the fields are empty.
            if (IsNotNothing(strItemName, ref ErrorDictionary, "Item Name") & IsNotNothing(strSellQuantity, ref ErrorDictionary, "Sell Quantity") & IsNotNothing(strLendQuantity, ref ErrorDictionary, "Lend Quantity")
                & IsNotNothing(strSellPrice, ref ErrorDictionary, "Sell Price") & IsNotNothing(strLendPrice, ref ErrorDictionary, "Lend Price"))
            {
                //Then checks to see if the actual format of the data is correct.
                if (IsValidLength(strItemName, 25, ref ErrorDictionary, "Item Name") & IsNumeric(strSellQuantity, ref ErrorDictionary, "Sell Quantity") & IsNumeric(strLendQuantity, ref ErrorDictionary, "Lend Quantity")
                    & IsCurrencyFormat(strLendPrice, ref ErrorDictionary, "Lend Price") & IsCurrencyFormat(strSellPrice, ref ErrorDictionary, "Sell Price") && IsSuitableInteger(int.Parse(strSellQuantity), 1000, 0, ref ErrorDictionary, "Sell Quantity")
                    && IsSuitableInteger(int.Parse(strSellQuantity), 1000, 0, ref ErrorDictionary, "Sell Quantity"))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(GenerateErrorMessage(ErrorDictionary));
                }

            }
            else
            {
                MessageBox.Show(GenerateErrorMessage(ErrorDictionary));
            }

            return false;
        }


        //Loads all the item from the database into a structure that is more easy to handle
        public static Item LoadItems()
        {
            ConnectToDatabase();



            OleDbCommand AccessDatabaseCommand = new OleDbCommand("SELECT * FROM Items ORDER BY Item_ID ASC", MyConnection);

            OleDbDataReader DatabaseReader = AccessDatabaseCommand.ExecuteReader();

            Item Items = new Item();

            //Loops for every singe record and gest every field from the record and adds those details to the data structure.
            while (DatabaseReader.Read())
            {
                Items.strItemID.Add(DatabaseReader.GetValue(0).ToString());
                Items.strBuyCost.Add(DatabaseReader.GetValue(1).ToString());
                Items.strLendCost.Add(DatabaseReader.GetValue(2).ToString());
                Items.strBuyQuantity.Add(DatabaseReader.GetValue(3).ToString());
                Items.strLendQuantity.Add(DatabaseReader.GetValue(4).ToString());
            }


            MyConnection.Close();
            return Items;

        }


    }

}