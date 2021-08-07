using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static InputForms.InputBox;
using static Security.Login;

namespace Golf_Booking_System
{
    public partial class RemoveLogin : Form
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
        public RemoveLogin()
        {
            InitializeComponent();
        }

        private void RemoveLogin_Load(object sender, EventArgs e)
        {
            AddAllLogins();
        }

        private void AddAllLogins()
        {

            lstLogins.Items.Clear();
            GetCurrentLogins(ref strUsernames, ref strPasswords);

            lstLogins.Items.AddRange(strUsernames);
        }



        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lstLogins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLogins.SelectedIndex != -1)
            {
                txtUsername.Text = lstLogins.SelectedItem.ToString();
            }
            
        }

        private void btnChangeLogin_Click(object sender, EventArgs e)
        {

            AdminConfirmation();
           
           
        }


        private void AdminConfirmation()
        {
            string strAdminPassword = "";
            CreateInputBox("Administrator Confirmation", "Enter Administrator Password", ref strAdminPassword);

            if (strAdminPassword == "tempPassword")
            {
                string strUsername = txtUsername.Text;
                DeleteLogin(strUsername);
                AddAllLogins();
                txtUsername.Text = "";
            }
            else
            {
                MessageBox.Show("Administrator Password Incorrect");
            }
        }
        private void DeleteLogin(string Username)
        {
            if (lstLogins.Items.Contains(Username))
            {
                int loginIndex = GetLoginIndex();
                //Gets the length of the passwords and usernames combined without 1 username and password ( the ones that will be deleted)
                int intLoginDetailsLength = (strUsernames.Length * 2) - 2;

                string[] strLoginDetails = new string[intLoginDetailsLength];
                int intAccountIndex = 0;

                for (int i = 0; i < intLoginDetailsLength; i++)
                {
                    if (Username == strUsernames[intAccountIndex])
                    {
                        intAccountIndex++;
                        i--;
                        continue;
                    }

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
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("That login doesn't exist");
            }
            

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login_Option_Menu frmOption_Menu = new Login_Option_Menu();
            frmOption_Menu.Show();
            this.Close();
        } 
        
        
        //This gets the login index of a an account if there is one, else it will return -1, meaning it doesn't exist. 
        private int GetLoginIndex()
        {
            //Loops for every username aka every login.
            for (int i = 0; i < strUsernames.Length; i++)
            {
                //Checks too see ifthe username in the login file is the same as the inputted username.
                if (strUsernames[i] == txtUsername.Text)
                {
                        //returns the index of the login account.
                        return i;

                }
            }

            //It will return an idex of -1 meaning an the login hasn't been found or the password is incorrect.
            return -1;
        }
    }
}
