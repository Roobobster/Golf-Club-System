using System.Collections.Generic;
using System.Data.OleDb;
using static DataHandling.Database;

namespace DatabaseTables
{
    public class Token
    {
        public static readonly string[] Fields = new string[2] { "Purchase_ID", "Amount_Of_Tokens" };
        public List<string> strPurchaseID, strAmountOfTokens;

        public Token()
        {
            strPurchaseID = new List<string>();
            strAmountOfTokens = new List<string>();
        }


        //Loads all the token purchases from the database into a structure that is more easy to handle
        public static Token LoadTokens()
        {
            ConnectToDatabase();



            OleDbCommand AccessDatabaseCommand = new OleDbCommand("SELECT * FROM Tokens", MyConnection);

            OleDbDataReader DatabaseReader = AccessDatabaseCommand.ExecuteReader();

            Token Tokens = new Token();

            //Loops for every singe record and gest every field from the record and adds those details to the data structure.
            while (DatabaseReader.Read())
            {
                Tokens.strPurchaseID.Add(DatabaseReader.GetValue(0).ToString());
                Tokens.strAmountOfTokens.Add(DatabaseReader.GetValue(1).ToString());
            }


            MyConnection.Close();
            return Tokens;

        }
    }
}