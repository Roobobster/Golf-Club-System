using System;
using System.Drawing;
using System.Windows.Forms;

namespace Golf_Booking_System
{
    public partial class Member_Menu : Form
    {
        public Member_Menu()
        {
            InitializeComponent();
        }

        private void Membeship_Menu_Load(object sender, EventArgs e)
        {

        }

        private void EditMember_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_Member frmEdit_Member = new Edit_Member();
            frmEdit_Member.Show();
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Member frmAdd_Member = new Add_Member();
            frmAdd_Member.Show();
        }

        private void RemoveMember_Click(object sender, EventArgs e)
        {
            this.Close();
            Remove_Member frmRemove_Member = new Remove_Member();
            frmRemove_Member.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu frmMain_Menu = new Main_Menu();
            frmMain_Menu.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #region Moveable Form Code
        private bool mouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void RemoveMemberBookings_Click(object sender, EventArgs e)
        {
            Remove_Member_Bookings frmRemoveMemberBookings = new Remove_Member_Bookings();
            frmRemoveMemberBookings.Show();
            this.Close();
        }
    }
}
