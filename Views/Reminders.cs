using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Kiosk.Views
{
    public partial class Reminders : Form
    {
        public Reminders()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            LoginTransition();
        }

        private void LoginTransition()
        {
            this.Close();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }
    }
}
