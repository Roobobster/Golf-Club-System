using DatabaseTables;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DataHandling.Database;
using static Validation.SearchingSorting;

namespace Golf_Booking_System
{
    public partial class Remove_Member : Form
    {
        public int intSearchValue;
        public Remove_Member()
        {
            InitializeComponent();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Menu frmMembership_Menu = new Member_Menu();
            frmMembership_Menu.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Remove_Member_Load(object sender, EventArgs e)
        {

            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable MemberData = new DataTable();
            MemberData = LoadTableIntoDataTable("Members");

            dgvMembers.DataSource = MemberData;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteMember();
        }


        private void DeleteMember()
        {


            string strMembershipID = txtSurname.Text + txtForename.Text;

            if (strMembershipID == "MEMBERVISITOR")
            {
                MessageBox.Show("You can not delete the visitor member");
            }
            else
            {
                Member Members = Member.LoadMembers();
                //Does binary search for a certain MembershipID in the database. 
                intSearchValue = BinarySearch(Members.strMembershipID, 0, Members.strMembershipID.Count, strMembershipID);

                //If it returns -1 then the member must not exist.
                if (intSearchValue == -1)
                {
                    MessageBox.Show("There is no such Member in the database");
                }
                else
                {
                    RemoveFromDatabase("Members", "Membership_ID", Members.strMembershipID[intSearchValue]);
                    MessageBox.Show("Member Deleted");
                    LoadDataGridView();

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

        private void Members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int intSearchValue = dgvMembers.CurrentCell.RowIndex;

            if (intSearchValue != -1)
            {
                txtForename.Text = dgvMembers.Rows[intSearchValue].Cells[1].Value.ToString();
                txtSurname.Text = dgvMembers.Rows[intSearchValue].Cells[2].Value.ToString();
            }
        }
    }
}
