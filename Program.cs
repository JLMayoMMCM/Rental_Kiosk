using Rental_Kiosk.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Kiosk
{

    internal static class Program
    {
        public static string connectionString = "Data Source=localhost\\VPDBOOP;Initial Catalog=VPDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
