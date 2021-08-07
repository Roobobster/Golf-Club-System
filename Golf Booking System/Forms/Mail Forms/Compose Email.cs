using System;
using System.Drawing;
using System.Windows.Forms;
using static Global_Variables.Global_Variables_class;

namespace Golf_Booking_System
{
    public partial class Compose_Email : Form
    {
        public Compose_Email()
        {
            InitializeComponent();
        }

        private void Compose_Email_Load(object sender, EventArgs e)
        {
            txtSubject.Text = EmailSubject;
            txtBody.Text = EmailBody;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Mailing frmMailing = new Mailing();
            frmMailing.Show();
            this.Close();


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ComposeEmail_Click(object sender, EventArgs e)
        {
            EmailBody = txtBody.Text;
            EmailSubject = txtSubject.Text;
            MessageBox.Show("Email has been added");
        }

        private void Subject_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void txtBody_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
