using System.Windows.Forms;
using Rental_App_V1._0.Models;
using Rental_App_V1._0.ModelViews;

namespace Rental_Kiosk.Views
{
    public partial class CheckoutScreen : Form
    {
        Application_Model ApMD = new Application_Model();

        public CheckoutScreen()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            ApMD.importCart(Program.LoginStudentID);
        }

        private void ReturnToGrid(object sender, System.EventArgs e)
        {
            CartOrderSmmry.DataSource = null;
            this.Close();
            ItemRentalView itemRental = new ItemRentalView();
            itemRental.Show();
        }

        private void DeleteItem(object sender, System.EventArgs e)
        {
            int ID = int.Parse(CartOrderSmmry.CurrentRow.Cells[0].Value.ToString());
            ApMD.RemoveFromCart(ID);
            loadData();
        }
    }
}
