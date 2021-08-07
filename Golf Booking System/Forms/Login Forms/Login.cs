using System;
using System.Windows.Forms;
using static FileHandling.Compression;
using static Security.Login;

namespace Golf_Booking_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Remove this later
            DeleteFilesInDirectory(ZipDirectoryPath, true);

        }

        #region Moveable Form Code

        //This region of code is responsible for the movement of the form as it doesn't have a border style which means it doesn't have the inbuild movement features        
        private bool mouseDown;
        private System.Drawing.Point lastLocation;

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
                this.Location = new System.Drawing.Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

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

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        private void Login_Click(object sender, EventArgs e)
        {
            string strUsername = txtUsername.Text;
            string strPassword = txtPassword.Text;

            //Checks to see if the account is one of the existing accounts and if it is then the rest of the program will open. 
            if ((strUsername == "Admin" && strPassword == "Password") || IsValidLogin (strUsername, ref strPassword) )
                GrantAccess();
            else
                MessageBox.Show("The Entered Details Are Incorrect");
                

            
        }
        private void GrantAccess()
        {
            MessageBox.Show("Login Successful");
            Main_Menu frmMain_Menu = new Main_Menu();
            frmMain_Menu.Show();
            this.Close();
        }



        
    }
}
