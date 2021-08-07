using DatabaseTables;
using System;
using System.Drawing;
using System.Windows.Forms;
using static DataHandling.Database;

namespace Golf_Booking_System
{
    public partial class Add_Item : Form
    {
        public Add_Item()
        {
            InitializeComponent();
        }
     

        private void Add_Item_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Item_Menu frmItem_Menu = new Item_Menu();
            frmItem_Menu.Show();
        }

        private void Minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {

            AddItem();
        }

        private void AddItem()
        {
            string strItemName = txtItemName.Text;
            string strSellQuantity = txtSellQuantity.Text;
            string strLendQuantity = txtLendQuantity.Text;
            string strSellPrice = txtSellPrice.Text;
            string strLendPrice = txtLendPrice.Text;

            //Checks if the inputted fields for an item is valid by using a validation method in the class Item
            if (Item.ValidateItem(strItemName, strSellQuantity, strLendQuantity, strSellPrice, strLendPrice))
            {
                //Loads all the items from the database into lots of string lists.
                Item Items = Item.LoadItems();
                //Does a binary search to see if the item already exists or not.
                if (Validation.SearchingSorting.BinarySearch(Items.strItemID, 0, Items.strItemID.Count, strItemName) == -1)
                {
                    
                    string[] strInputValues = new string[5] { strItemName, strSellPrice, strLendPrice, strSellQuantity, strLendQuantity };
                    //If the item doesn't exists then it will add the item to the database. 
                    AddToDatabase("Items", Item.Fields, strInputValues);

                    MessageBox.Show(strItemName + " Has Been Added As A New Item");


                }
                else
                {
                    MessageBox.Show("That Item Is Already In The Database");
                }

            }

            
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
