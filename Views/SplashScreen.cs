using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
SPLASH SCREEN DOCUMENTATION
--------------------------
METHODS/FUNCTIONS
--------------------------
SplashScreen() 
-Constructor for the SplashScreen form

LoginTransition(object sender, EventArgs e)
-Method that is called when the user clicks the screen

RegisterTransition()
-Method that closes the current form and opens the Login form
--------------------------
 
*/
namespace Rental_Kiosk.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void LendBtn_Click(object sender, EventArgs e)
        {
            LendTransition();
        }

        private void LendTransition()
        {
            this.Close();
            LendInstruction lend = new LendInstruction();
            lend.Show();
        }

        private void RentBtn_Click(object sender, EventArgs e)
        {
            RemindersTransition();
        }

        private void RemindersTransition()
        {
            this.Close();
            Reminders reminders = new Reminders();
            reminders.Show();
        }
    }
}
