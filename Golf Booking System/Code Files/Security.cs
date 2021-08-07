using System;
using System.IO;
using System.Text;

namespace Security
{
    public class Login
    {

        public static void GetCurrentLogins( ref string[] Usernames , ref string[] Passwords)
        {
            //These are used to locate the file based on where the program is. 
            string baseAddress = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\", "/");
            string accountsFileAddress = baseAddress.Replace("/bin/Debug", "") + "Logins.txt";

            //Fills an array with all the passwords and usernames alternating between username and password in that order. 
            string[] strAccounts = File.ReadAllLines(accountsFileAddress, Encoding.UTF7);

            int intAccountsLength = strAccounts.Length;

            //Sets the array size of the passwords and usernames which is half all the account details. 
            Usernames = new string[intAccountsLength / 2];
            Passwords = new string[intAccountsLength / 2];

            //This counter is used to keep reference of what account number it's on. 
            int intAccountIndex = 0;
            for (int line = 0; line < intAccountsLength; line++)
            {

                //It adds the account info if it's odd meaning it's in the password section, also since it starts at index of 0 the password will be on the odd lines
                if (line % 2 != 0)
                {
                    //Once it adds the password it will then go onto the next account as in the text file it is written in the order
                    //Username
                    //Password
                    Passwords[intAccountIndex] = strAccounts[line];
                    intAccountIndex++;
                }
                else // This will run if it's on a even line where the usernames are.
                {
                    Usernames[intAccountIndex] = strAccounts[line];
                }
            }
        }


        public static bool IsValidLogin(string Username, ref string Password)
        {
            string[] strUsernames = null, strPasswords = null;
            GetCurrentLogins(ref strUsernames, ref strPasswords);


            Password = EncryptPassword(Password);
            //Loops for all the accounts that exists
            for (int AccountIndex = 0; AccountIndex < strUsernames.Length; AccountIndex++)
            {
                //Checks to see if the inputted details are equal to any account in the database. 
                if (strUsernames[AccountIndex] == Username && strPasswords[AccountIndex] == Password)
                {
                    return true;
                }
            }

            //It will only get to this point if it's not returned true meaning that the inputted values are not equal to any account in the text file. 
            return false;

        }



        public static string EncryptPassword(string strInputtedPassword)
        {
            const int Key = 206;
            string strEncryptedPassword = "";
            //Loops for each character in the inputted password.
            foreach (char character in strInputtedPassword)
            {
                //For each character a Xor encryption is applied and then added to a string. 
                strEncryptedPassword += Convert.ToChar((Convert.ToInt32(character) ^ Key));
            }

            return strEncryptedPassword;
        }
    }
}