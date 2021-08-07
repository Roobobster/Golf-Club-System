//This imports the validation methods from the Validation code file so that they can be called .
//The "static" part makes it so that the methods can be called without having to type the class e.g the IsAlphabetic method can be writted as IsAlphabetic() instead of Validation.Validate.IsAplhabetic()
using DatabaseTables;
using System;
using System.Drawing;
using System.Windows.Forms;
using static DataHandling.Database;
using static Validation.SearchingSorting;

namespace Golf_Booking_System
{
    public partial class Add_Member : Form
    {
        public Add_Member()
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

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void AddMember()
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


            //This IsValidMember is in the Member Validation code file as the same code can be used for two seperate forms and checks whether the inputs
            //are in the correct formats and if they're not it will display the appropriate error message.
            if (Member.ValidateMember(strMembershipID, strForename, strSurname, strTelephone, strPostcode, strEmail, strDOB, strMembershipType, strTown))
            {

                //This is the last layer of the validation that checks if the member isn't already in the database.
                Member Members = Member.LoadMembers();
                if (BinarySearch(Members.strMembershipID, 0, Members.strMembershipID.Count, strMembershipID) == -1)
                {
                    //If there is no match then that would mean that person isn't a member yet and therefore will allow the change   
                    string[] strInputValues = new string[9] { strMembershipID, strForename, strSurname, strTelephone, strPostcode, strTown, strEmail, strDOB, strMembershipType };

                    AddToDatabase("Members", Member.Fields, strInputValues);

                    MessageBox.Show(strForename + " " + strSurname + " Has Been Added As A " + strMembershipType + " Member");


                }
                else
                {
                    MessageBox.Show("That Person Already Has A Membership");
                }

            }

        }


        private void AddMember_Click(object sender, EventArgs e)
        {
            AddMember();                                  
        }
                   
            
        private void Add_Member_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today;
            //This max the max age someone could be is 100, although this is most likely unlikely  it needs to cater for all ages.
            dtpDOB.MinDate = DateTime.Today.Subtract(TimeSpan.FromDays(365 * 100));
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
