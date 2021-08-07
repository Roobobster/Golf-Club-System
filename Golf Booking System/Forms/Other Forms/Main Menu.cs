using System;
using System.Drawing;
using System.Windows.Forms;



namespace Golf_Booking_System
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        //This gets the file the program is running from but then changes to backslashes to forward slashes so that they're easier to handle.
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //Turns the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //Sets the rotation point to the center of the image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //Rotates image
            //It's +45 the angle as the images is around 45 degrees to the left initial therefore it needs to turn it 45 degrees to the rigght
            gfx.RotateTransform(rotationAngle + 45f);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);


            //draws new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //disposes the Graphics object
            gfx.Dispose();

            //return the  rotated image
            return bmp;
        }

        private string visualsFileAddress = WeatherAPI.WeatherAPI.baseAddress.Replace("/Golf Booking System/bin/Debug", "") + "Form Visuals/";

        private void DisplayWeatherData()
        {
            string[] strCurrentWeatherInfo = WeatherAPI.WeatherAPI.GrabWeatherAPI();
            string[] WindSpeedData = strCurrentWeatherInfo[2].Split(' ');

            string strWindDescription = "";
            //This for loop loops for each word after the first and that will be the description for example "12.7 strong gust" will loop twice. 
            for (int i = 1; i < WindSpeedData.Length; i++)           
                strWindDescription += WindSpeedData[i] + " ";
            


            //The first index is the actual wind speed number
            lblWindSpeed.Text = WindSpeedData[0];

            lblWindDescription.Text = strWindDescription;

            string strWindBearing = strCurrentWeatherInfo[3];
            lblWindDirection.Text = strWindBearing;
            pnlWindDirection.BackgroundImage = RotateImage(pnlWindDirection.BackgroundImage, float.Parse(strWindBearing));

            lblTemperature.Text = Math.Round(float.Parse(strCurrentWeatherInfo[1])).ToString();
            try
            {
                pnlWeather.BackgroundImage = Image.FromFile(visualsFileAddress + strCurrentWeatherInfo[4] + ".png");
            }
            catch (Exception)
            {

                pnlWeather.BackColor = Color.Black;
            }
           
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            DisplayWeatherData();

            
                     
        }


        
        

        //Run when the membership menu is clicked it then opens the membership menu form, then closes this form
        private void MembershipMenu_Click(object sender, EventArgs e)
        {
           
            Member_Menu frmMembership_Menu = new Member_Menu();
            frmMembership_Menu.Show();
            this.Close();

        }

        //Runs when the exit button is clicked, it then closes the whole application
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Runs when the sales report menu button is clicked, it thwn opens the sales report menu form, then it closes this form. 
        private void SaleReportMenu_Click(object sender, EventArgs e)
        {
            
            Sale_Report_Menu frmSale_Report_Menu = new Sale_Report_Menu();
            frmSale_Report_Menu.Show();
            this.Close();
        }

        //Runs when the manage items buttons is clicked, it then opens the item menu form, then it closes this form.
        private void ItemsMenu_Click(object sender, EventArgs e)
        {
           
            Item_Menu frmItem_Menu = new Item_Menu();
            frmItem_Menu.Show();
            this.Close();
        }

        //Runs when the sales menu button is clicked, it then opens the sales menu form, it then closes this form
        private void SaleMenu_Click(object sender, EventArgs e)
        {
            
            Sales_Menu frmSales_Menu = new Sales_Menu();
            frmSales_Menu.Show();
            this.Close();
        }

        //Runs when the minimize button is clicked, it then minimizes the form.
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        private void Mailing_Click(object sender, EventArgs e)
        {
            
            Mailing frmMailing = new Mailing();
            frmMailing.Show();
            this.Close();
        }

        private void WindSpeed_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoginOptions_Click(object sender, EventArgs e)
        {
            Login_Option_Menu frmLoginMenu = new Login_Option_Menu();
            frmLoginMenu.Show();
            this.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }
    }
}
