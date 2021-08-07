using DatabaseTables;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DataHandling.Database;
using static Validation.SearchingSorting;


namespace Golf_Booking_System
{
    public partial class Edit_Member : Form       
    {
        public static string Orignal;
        public Edit_Member()
        {
            InitializeComponent();
        }


       
        private void Edit_Member_Load(object sender, EventArgs e)
        {
            HideMembercontrols();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable MemberData = new DataTable();
            MemberData = LoadTableIntoDataTable("Members");

            dgvMembers.DataSource = MemberData;
        }

        //Shows all The controls to allow the user to edit a member
        private void ShowMemberControls()
        {
            lblDOB.Show();
            lblEmail.Show();
            lblMembershipType.Show();
            lblPostcode.Show();
            lblTelephone.Show();
            lblTown.Show();

            txtEmail.Show();
            txtPostcode.Show();
            txtTelephone.Show();
            txtTown.Show();
            cmbMembershipType.Show();
            dtpDOB.Show();
            btnSearch.Location = new Point(223, 530);

        }

        //Hides all the controls meaning the user can not edit a member
        private void HideMembercontrols()
        {
            lblDOB.Hide();
            lblEmail.Hide();
            lblMembershipType.Hide();
            lblPostcode.Hide();
            lblTelephone.Hide();
            lblTown.Hide();

            txtEmail.Hide();
            txtPostcode.Hide();
            txtTelephone.Hide();
            txtTown.Hide();
            cmbMembershipType.Hide();
            dtpDOB.Hide();

            btnEdit.Hide();
            btnSearch.Location = new Point(223, 240);

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

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchForMember();
           
        }

        private void SearchForMember()
        {
            string strMembershipID = txtSurname.Text + txtForename.Text;
            if (strMembershipID == "MEMBERVISITOR")
            {
                MessageBox.Show("You can not change the visitor member");
            }
            else
            {
                Member Members = Member.LoadMembers();

                //Does a binary search to see if that member exists or not.
                int intSearchValue = BinarySearch(Members.strMembershipID,  0, Members.strMembershipID.Count, strMembershipID);

                //If the binary search returned -1 then it means that there is not member with that membership ID.
                if (intSearchValue == -1)
                {
                    MessageBox.Show("There is no such Member in the database");
                }
                else
                {
                    //Need to know the initial membership ID just in case the member needs to change the name of a member, which will
                    //change the membership ID of the member as well. 
                    Orignal = txtSurname.Text + txtForename.Text;

                    btnEdit.Show();
                    ShowMemberControls();

                    MessageBox.Show("Member Found");

                    //Fills all the text boxes with the information of the user from the database. 
                    txtForename.Text = Members.strForename[intSearchValue];
                    txtSurname.Text = Members.strSurname[intSearchValue];
                    txtTelephone.Text = Members.strTelephone[intSearchValue];
                    txtPostcode.Text = Members.strPostcode[intSearchValue];
                    txtEmail.Text = Members.strEmail[intSearchValue];
                    txtTown.Text = Members.strTown[intSearchValue];
                    dtpDOB.Value = Convert.ToDateTime(Members.strDOB[intSearchValue]);
                    cmbMembershipType.Text = Members.strMembershipType[intSearchValue];


                }
            }
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditMember();
        }

        private void EditMember()
        {
            
            string strForename = txtForename.Text;
            string strSurname = txtSurname.Text;
            string strMembershipID = strSurname + strForename;
            string strTelephone = txtTelephone.Text;
            string strPostcode = txtPostcode.Text;
            string strEmail = txtEmail.Text;
            string strTown = txtTown.Text;
            //This get the date from the datetime picker and turns it into a string in the format of just the date without the time.
            string strDOB = (dtpDOB.Value).ToString("d");
            string strMembershipType = cmbMembershipType.Text;

            //This checks to see if the inputted fields are valid using a method in the Member class.
            if (Member.ValidateMember(strMembershipID, strForename, strSurname, strTelephone, strPostcode, strEmail, strDOB, strMembershipType, strTown))
            {

           
                string[] strInputValues = new string[9] { strMembershipID, strForename, strSurname, strTelephone, strPostcode, strTown, strEmail, strDOB, strMembershipType };
                EditDatabase("Members", Member.Fields, strInputValues, "Membership_ID", Orignal );
                MessageBox.Show("Member Edited");
                HideMembercontrols();
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

        private void Members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int intSearchValue = dgvMembers.CurrentCell.RowIndex;

            //it will only run if an actual cell is clicked and returns a index that is -1 which means it's not a cell.
            if (intSearchValue != -1)
            {
                //Automatically puts the surname and forename in the textboxs when they are clicked in the data grid view.
                txtForename.Text = dgvMembers.Rows[intSearchValue].Cells[1].Value.ToString();
                txtSurname.Text = dgvMembers.Rows[intSearchValue].Cells[2].Value.ToString();
            }
        }
    }
}
