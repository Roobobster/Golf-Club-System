using System;
using System.Drawing;
using System.Windows.Forms;

namespace Golf_Booking_System
{
    public partial class Item_Menu : Form
    {
        public Item_Menu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Item frmAdd_Item = new Add_Item();
            frmAdd_Item.Show();
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Remove_Item frmRemove_Item = new Remove_Item();
            frmRemove_Item.Show();
        }

        private void EditItemDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_Items frmEdit_Items = new Edit_Items();
            frmEdit_Items.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu frmMain_Menu = new Main_Menu();
            frmMain_Menu.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Item_Menu_Load(object sender, EventArgs e)
        {

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
    }
}
