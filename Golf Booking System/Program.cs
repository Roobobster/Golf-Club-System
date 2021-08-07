using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf_Booking_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //This makes it so that the renderings is done by uing the default options.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login frmLogin = new Login();
            frmLogin.Show();
            Application.Run();
        }
    }
}
