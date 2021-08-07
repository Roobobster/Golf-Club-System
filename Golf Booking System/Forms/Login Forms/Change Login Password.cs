using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static Security.Login;

namespace Golf_Booking_System
{
    public partial class Change_Login_Password : Form
    {
        #region Moveable Form Code

        //This region of code is responsible for the movement of the form as it doesn't have a border style which means it doesn't have the inbuild movement features        
        private bool mouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            //Gets the location of the mouse when mouse button 1 is clicked
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            //Will only run if the mouse has been pressed down and is still being pressed down.
            if (mouseDown)
            {
                //Moves the form by betting the location of the mouse when it was clicked and taking that away from the location of the form to get the offset
                //Then it gets the position of the mouse and adds that to the offset to get the new postion for the form
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                //This is needed to prevent the flickering of the form.
                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {

            //This is just makes it so that when the user isn't clicking the form it doesn't move the form.
            mouseDown = false;
        }


        #endregion
        private string[] strUsernames = null, strPasswords = null;
        public Change_Login_Password()
        {
            InitializeComponent();
        }

        private void Change_Login_Password_Load(object sender, EventArgs e)
        {
            AddAllLogins();
        }
        //Adds all the current login usernames to a listbox to allow the user to see what logins exists.
        private void AddAllLogins()
        {
            

            GetCurrentLogins(ref strUsernames, ref strPasswords);

            lstLogins.Items.AddRange(strUsernames);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login_Option_Menu frmOption_Menu = new Login_Option_Menu();
            frmOption_Menu.Show();
            this.Close();
        }

        private void lstLogins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLogins.SelectedIndex != -1)
            {
                txtUsername.Text = lstLogins.SelectedItem.ToString();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Enables/Disables the password characters every time the checkbox is changed. 
            txtCurrentPassword.UseSystemPasswordChar = !txtCurrentPassword.UseSystemPasswordChar;
            txtNewPassword.UseSystemPasswordChar = !txtNewPassword.UseSystemPasswordChar;
            txtVerifyPassword.UseSystemPasswordChar = !txtVerifyPassword.UseSystemPasswordChar;
        }

        private void ChangeLogin_Click(object sender, EventArgs e)
        {
            ValidateLogin();
          
        }

        private void ValidateLogin()
        {
            int loginIndex = GetLoginIndex();

            if (loginIndex == -1)
            {
                MessageBox.Show("Login Details Are Incorrect");
            }
            else
            {
                if (txtNewPassword.Text == txtVerifyPassword.Text)
                {
                    ChangePassword(loginIndex);
                    MessageBox.Show("The Password For The User '" + strUsernames[loginIndex] + "' Has Been Changed.");
                    txtCurrentPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtUsername.Text = "";
                    txtVerifyPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("The New Passwords Are Not The Same.");
                }
            }
        }

        private void ChangePassword(int loginIndex)
        {
            //Gets the length of the passwords and usernames combined
            int intLoginDetailsLength = strUsernames.Length * 2;

            string[] strLoginDetails = new string[intLoginDetailsLength];
            int intAccountIndex = 0;
            strPasswords[loginIndex] = EncryptPassword(txtNewPassword.Text);
            for (int i = 0; i < intLoginDetailsLength; i++)
            {
                //It adds the account info if it's odd meaning it's in the password section, also since it starts at index of 0 the password will be on the odd lines
                if (i % 2 != 0)
                {
                    //Once it adds the password it will then go onto the next account as in the text file it is written in the order
                    //Username
                    //Password
                    strLoginDetails[i] = strPasswords[intAccountIndex];
                    intAccountIndex++;
                }
                else // This will run if it's on a even line where the usernames are.
                {
                    strLoginDetails[i] = strUsernames[intAccountIndex];
                }
            }
            //The location of the file that holds all the login details. 
            string baseAddress = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\", "/");
            string loginsFileAddress = baseAddress.Replace("/bin/Debug", "") + "Logins.txt";
            //Writes all the details again to be able to change the password easily and since there is only a few logins it won't affect profrormance that much.
            File.WriteAllLines(loginsFileAddress, strLoginDetails, Encoding.UTF7);
            
            
        }

        //This gets the login index of a an account if there is one, else it will return -1, meaning it doesn't exist. 
        private int GetLoginIndex()
        {
            //Encrypts the password so it can be compared to the other passwords without having the decrypt all the other passwords
            string strEncryptedPassword = EncryptPassword(txtCurrentPassword.Text);
            //Loops for every username aka every login.
            for (int i = 0; i < strUsernames.Length; i++)
            {
                //Checks too see ifthe username in the login file is the same as the inputted username.
                if (strUsernames[i] == txtUsername.Text)
                {
                    //Checks to see if the encrypted password is the password corresponding to that username.
                    if (strPasswords[i] == strEncryptedPassword)
                    {
                        //returns the index of the login account.
                        return i;
                    }

                }
            }

            //It will return an idex of -1 meaning an the login hasn't been found or the password is incorrect.
            return -1;
        }
    }
}
