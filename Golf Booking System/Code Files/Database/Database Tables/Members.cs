using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using static DataHandling.Database;
using static Validation.Validate;

namespace DatabaseTables
{
    public class Member
    {

        public static readonly string[] Fields = new string[9] { "Membership_ID", "Forename", "Surname", "Telephone", "Postcode", "Town", "Email", "DOB", "Membership_Type" };

        public List<string> strMembershipID, strForename, strSurname, strTelephone, strPostcode, strTown, strEmail, strDOB, strMembershipType;

        public Member()
        {
            strMembershipID = new List<string>();
            strForename = new List<string>();
            strSurname = new List<string>();
            strTelephone = new List<string>();
            strPostcode = new List<string>();
            strTown = new List<string>();
            strEmail = new List<string>();
            strDOB = new List<string>();
            strMembershipType = new List<string>();
        }

        //Loads all the members from the database into a structure that is more easy to handle
        public static Member LoadMembers()
        {
            ConnectToDatabase();

            OleDbCommand AccessDatabaseCommand = new OleDbCommand("SELECT * FROM Members ORDER BY Membership_ID ASC", MyConnection);
            OleDbDataReader DatabaseReader = AccessDatabaseCommand.ExecuteReader();

            Member Members = new Member();

            //Loops for every singe record and gest every field from the record and adds those details to the data structure.
            while (DatabaseReader.Read())
            {
                Members.strMembershipID.Add(DatabaseReader.GetValue(0).ToString());
                Members.strForename.Add(DatabaseReader.GetValue(1).ToString());
                Members.strSurname.Add(DatabaseReader.GetValue(2).ToString());
                Members.strTelephone.Add(DatabaseReader.GetValue(3).ToString());
                Members.strPostcode.Add(DatabaseReader.GetValue(4).ToString());
                Members.strTown.Add(DatabaseReader.GetValue(5).ToString());
                Members.strEmail.Add(DatabaseReader.GetValue(6).ToString());
                Members.strDOB.Add(DatabaseReader.GetValue(7).ToString());
                Members.strMembershipType.Add(DatabaseReader.GetValue(8).ToString());

            }

            MyConnection.Close();

            return Members;

        }

        //Does multiple checks on the different fields on the passed data to see if it is the correct format.
        public static bool ValidateMember(string strMembershipID, string strForename, string strSurname, string strTelephone, string strPostcode, string strEmail, string strDOB, string strMembershipType, string strTown)
        {
            IDictionary<string, string> ErrorDictionary = new Dictionary<string, string>();
            //This is the first layer of validation that checks if all the inputs are filled and if they aren't then there isn't any point in checking if the formats are correct
            if (IsNotNothing(strForename, ref ErrorDictionary, "Forename") & IsNotNothing(strSurname, ref ErrorDictionary, "Surname") & IsNotNothing(strTown, ref ErrorDictionary, "Town")
                & IsNotNothing(strTelephone, ref ErrorDictionary, "Telephone") & IsNotNothing(strPostcode, ref ErrorDictionary, "Postcode") & IsNotNothing(strEmail, ref ErrorDictionary, "Email")
                 & IsNotNothing(strDOB, ref ErrorDictionary, "DOB") & IsNotNothing(strMembershipType, ref ErrorDictionary, "Membership Type"))
            {
                //This is the second layer of validation that validates the formats of the individual inputs like the format of a telephone or Email.
                if (IsAlphabetic(strSurname, ref ErrorDictionary, "Surname") & IsAlphabetic(strForename, ref ErrorDictionary, "Forename") & IsAlphabetic(strTown, ref ErrorDictionary, "Town")
                    & IsValidPostcode(strPostcode, ref ErrorDictionary, "Postcode") & IsValidTelephone(strTelephone, ref ErrorDictionary, "Telephone")
                    & IsValidLength(strForename, 25, ref ErrorDictionary, "Forename") & IsValidLength(strSurname, 25, ref ErrorDictionary, "Surname")
                    & IsValidLength(strTown, 25, ref ErrorDictionary, "Town") & IsValidLength(strEmail, 50, ref ErrorDictionary, "Email") & IsValidEmail(strEmail, ref ErrorDictionary, "Email"))
                {
                    return true;

                }
                else
                {
                    MessageBox.Show(GenerateErrorMessage(ErrorDictionary));
                    return false;
                }

            }
            else
            {
                MessageBox.Show(GenerateErrorMessage(ErrorDictionary));
                return false;
            }
        }





    }
}