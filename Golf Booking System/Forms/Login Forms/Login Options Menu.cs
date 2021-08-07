using System;
using System.Drawing;
using System.Windows.Forms;

namespace Golf_Booking_System
{
    public partial class Login_Option_Menu : Form
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
        public Login_Option_Menu()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main_Menu frmMain_Menu = new Main_Menu();
            frmMain_Menu.Show();
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
            Add_Login frmAdd_Login = new Add_Login();
            frmAdd_Login.Show();
            this.Close();
        }

        private void ChangeLoginPassword_Click(object sender, EventArgs e)
        {
            Change_Login_Password frmChange_Password = new Change_Login_Password();
            frmChange_Password.Show();
            this.Close();

        }

        private void RemoveLogin_Click(object sender, EventArgs e)
        {
            RemoveLogin frmRemove_Login = new RemoveLogin();
            frmRemove_Login.Show();
            this.Close();
        }
    }
}
