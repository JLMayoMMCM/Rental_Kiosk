using Rental_App_V1._0.Models;
using Rental_Kiosk.Views;
using System;
using System.Windows.Forms;

/*
PROGRAM DOCUMENTATION
--------------------------
METHODS/FUNCTIONS
--------------------------
Main()
- This is the main function that runs the application.
--------------------------
*/
namespace Rental_Kiosk
{

    internal static class Program
    {
        public static string LoginStudentID = "";
        public static Student CurrentStudent = new Student();

        [STAThread]
        static void Main()
        {
            Application.Run(new SplashScreen());
        }
    }
}
