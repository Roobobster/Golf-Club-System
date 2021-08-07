using DatabaseTables;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DataHandling.Database;
using static Validation.SearchingSorting;
namespace Golf_Booking_System
{
    public partial class Remove_Item : Form
    {
        public Remove_Item()
        {
            InitializeComponent();
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

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string strItemName = txtItemName.Text;

        }

        private void Remove_Item_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            
            DataTable ItemData = new DataTable();
            //Loads all the items in the databae into a datatable
            ItemData = LoadTableIntoDataTable("Items");

            //The datasourse for the data grid view is then the datatable filled with all the item details.
            dgvItems.DataSource = ItemData;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void DeleteItem()
        {
            string strItemID = txtItemName.Text;

            //Loads all the items from the database into series of string lists within the Items Object.
            Item Items = Item.LoadItems();

            //Does a binary search to find the item in the database. 
            int intSearchValue = BinarySearch(Items.strItemID, 0, Items.strItemID.Count , strItemID);

            //If -1 is returned then the item doesn't exists in the database.
            if (intSearchValue == -1)
            {
                MessageBox.Show("There is no such Member in the database");
            }
            else
            {
                RemoveFromDatabase("Items", "Item_ID", Items.strItemID[intSearchValue]);
                MessageBox.Show("Item Removed");
                LoadDataGridView();

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

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gets the selected cell then gets it's row index for that cell
            int intSearchValue = dgvItems.CurrentCell.RowIndex;

            //if it returns 0 then the user didn't click on a cell.
            if (intSearchValue != -1)
            {
                //Gets the item name the user click on from the row index of the selected cell. 
                txtItemName.Text = dgvItems.Rows[intSearchValue].Cells[0].Value.ToString();
            }
        }
    }
}
