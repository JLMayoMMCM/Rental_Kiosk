using System.Data;
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
            loadData();
        }

        private void loadData()
        {
            DataTable dt = ApMD.importCart(Program.LoginStudentID);
            CartOrderSmmry.DataSource = dt;
            //Change the value of the total cost
            TotalCostDsply.Text = ApMD.CalculateTotal(dt).ToString();

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

        private void EndTransition()
        {
            this.Close();
            EndScreen endScreen = new EndScreen();
            endScreen.Show();
        }

        private void PrintRental()
        {
            this.Close();
        }

        private void Confirm_Order(object sender, System.EventArgs e)
        {
            int TotalCost = int.Parse(TotalCostDsply.Text);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to complete this order?", "Complete Order", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Do you want to print a receipt?", "Receipt Printing", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    string receipt = ApMD.printReceipt(TotalCost);
                    MessageBox.Show(receipt);
                    EndTransition();
                }
                else if (dialogResult2 == DialogResult.No)
                {
                    MessageBox.Show("Order completed");
                    EndTransition();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Order cancelled");
                return;
            }
        }

        private void CheckoutScreen_Load(object sender, System.EventArgs e)
        {




        }
    }
}
