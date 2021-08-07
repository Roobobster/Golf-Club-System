using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static Security.Login;
using static Validation.Validate;

namespace Golf_Booking_System
{
    public partial class Add_Login : Form
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
        public Add_Login()
        {
            InitializeComponent();
        }

        private void Add_Logincs_Load(object sender, EventArgs e)
        {

        }

        private void Back_click(object sender, EventArgs e)
        {
            Login_Option_Menu frmLogin_Menu = new Login_Option_Menu();
            frmLogin_Menu.Show();
            this.Close(); 
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddLogin_Click(object sender, EventArgs e)
        {
            CreateLogin();
        }


        private void CreateLogin()
        {

            string strUsername = txtUsername.Text;
            //There are two passwords to be able to verify the passwords are the same so that they person making the password is less likely to make a mistake.
            string strPassword1 = txtPassword.Text;
            string strPassword2 = txtVerifyPassword.Text;
            if (strPassword1 == strPassword2)
            {
                if (IsValidLoginFormat(strUsername, strPassword1))
                {
                    //Gets the location of the logins details. 
                    string baseAddress = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\", "/");
                    string loginsFileAddress = baseAddress.Replace("/bin/Debug", "") + "Logins.txt";
                  
                    //Reads all the login details from the file. 
                    string[] strExistingLogins = File.ReadAllLines(loginsFileAddress);

                    for (int i = 0; i < strExistingLogins.Length; i++)
                    {
                        //It will run if it's on a even line 
                        if (i % 2 == 0)
                        {
                            MessageBox.Show(strExistingLogins[i]);
                            //Checks to see if the the details are the same as an existing one. 
                            if (strExistingLogins[i] == strUsername)
                            {
                                MessageBox.Show("That Login Already Exists.");
                                //It will not do anything if the username is already taken.
                                return;
                            }
                        }
                    }
                    //Puts the new login details into a string so that it can be appended into the file using the AppendAllLines
                    string[] strnewLogin = new string[2] { strUsername, EncryptPassword(strPassword1) };


                    //It will only get to this point of adding the details if the username isn't equal to the ones in the text file.
                    File.AppendAllLines(loginsFileAddress, strnewLogin, Encoding.UTF7);

                    MessageBox.Show("Login Created");

                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    txtVerifyPassword.Text = "";

                }

            }
            else
            {
                MessageBox.Show("The Passwords Don't Match");
                //If someone doesn't match each password then they probably won't know where they went wrong therefore they'll probably start again
                //So to make it more convienant for the user, it now clears automatically on fail.
                txtPassword.Clear();
                txtVerifyPassword.Clear();
            }

        }





        private bool IsValidLoginFormat(string Username, string Password)
        {
            //Checks to see that the username and the password are not too long and that they have actual values. 
            IDictionary<string, string> ErrorDictionary = new Dictionary<string, string>();
            if (IsValidLength(Username, 20, ref ErrorDictionary, "Username") & IsNotNothing(Username, ref ErrorDictionary, "Username")
                & IsValidLength(Password, 30, ref ErrorDictionary, "Password") & IsNotNothing(Password, ref ErrorDictionary, "Password"))
            {
                return true;
            }
       
            MessageBox.Show(GenerateErrorMessage(ErrorDictionary));
            return false;
            
        }

        //If the password Characters are on then it will turn them off and vice versa when the checkbox is changed. 
        private void ShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            txtVerifyPassword.UseSystemPasswordChar = !txtVerifyPassword.UseSystemPasswordChar;
        }

    }
}
