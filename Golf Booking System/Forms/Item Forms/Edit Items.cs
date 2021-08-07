using DatabaseTables;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DataHandling.Database;
using static Validation.SearchingSorting;


namespace Golf_Booking_System
{
    public partial class Edit_Items : Form
    {
        private static string OrgianlItemID;
        public Edit_Items()
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
            SearchForItem();
             
        }

        private void SearchForItem()
        {
            //The original item ID Will be needed if the user wants to change the name of the Item aswell.
            OrgianlItemID = txtItemName.Text;
            Item Items = Item.LoadItems();

            int intSearchValue = BinarySearch(Items.strItemID, 0, Items.strItemID.Count, OrgianlItemID);

            if (intSearchValue == -1)
            {
                MessageBox.Show("There is no such Item in the database");
            }
            else
            {

               
                ShowFoundItemControls();
                MessageBox.Show("Item Found");
                txtItemName.Text = Items.strItemID[intSearchValue];
                txtLendPrice.Text = Items.strLendCost[intSearchValue];
                txtLendQuantity.Text = Items.strLendQuantity[intSearchValue];
                txtSellPrice.Text = Items.strBuyCost[intSearchValue];
                txtSellQuantity.Text = Items.strBuyQuantity[intSearchValue];


            }

        }
        private void Edit_Click(object sender, EventArgs e)
        {
            ValidateData();
            
        }

        private void ValidateData()
        {

            string strItemName = txtItemName.Text;
            string strLendQuantity = txtLendQuantity.Text;
            string strSellQuantity = txtSellQuantity.Text;
            string strSellPrice = txtSellPrice.Text;
            string strLendPrice = txtLendPrice.Text;

            //makes sure all the data is valid before allowing the data to be changed. 
            if (Item.ValidateItem(strItemName, strSellQuantity, strLendQuantity, strSellPrice, strLendPrice))
            {
                string[] strInputValues = new string[5] { strItemName, strSellPrice, strLendPrice, strSellQuantity, strLendQuantity };

                EditDatabase("Items", Item.Fields, strInputValues, "Item_ID", OrgianlItemID);
                MessageBox.Show("Item Editted");
                HideFoundItemControls();
                LoadDataGridView();

            }
        }

        private void Edit_Items_Load(object sender, EventArgs e)
        {
            HideFoundItemControls();
            LoadDataGridView();
           
        }

        private void LoadDataGridView()
        {
            DataTable ItemData = new DataTable();
            ItemData = LoadTableIntoDataTable("Items");

            dgvItems.DataSource = ItemData;
        }

        //Shows all the text boxes that allow the user to be able to change the item details.
        private void ShowFoundItemControls()
        {

            txtLendPrice.Show();
            txtLendQuantity.Show();
            txtSellPrice.Show();
            txtSellQuantity.Show();

            lblLendPrice.Show();
            lblLendQuantity.Show();
            lblSellPrice.Show();
            lblSellQuantity.Show();

            btnEdit.Show();
            btnSearch.Location = new Point(167, 388);
        }

        //Hides all the text boxes that allow the user to able to change item details
        private void HideFoundItemControls()
        {

            txtLendPrice.Hide();
            txtLendQuantity.Hide();
            txtSellPrice.Hide();
            txtSellQuantity.Hide();

            lblLendPrice.Hide();
            lblLendQuantity.Hide();
            lblSellPrice.Hide();
            lblSellQuantity.Hide();

            btnEdit.Hide();
            btnSearch.Location = new Point(167, 170);
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

        private void Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int intSearchValue = dgvItems.CurrentCell.RowIndex;

            //If the search value is -1 then the user hasn't clicked on a cell and therefore will cause the system to crash
            if (intSearchValue != -1)
            {
                //Gets the item name from the selected cell's row, which means you don't need to click on the name directly only the row it's on.
                txtItemName.Text = dgvItems.Rows[intSearchValue].Cells[0].Value.ToString();
            }
        }
    }
}
