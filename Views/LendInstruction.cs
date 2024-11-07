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
    public partial class LendInstruction : Form
    {
        public LendInstruction()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            SplashTransition();
        }


        private void SplashTransition()
        {
            this.Close();
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
        }
    }
}
