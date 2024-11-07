using System.Data;
using System.Windows.Forms;
using Rental_App_V1._0.ModelViews;
using Rental_App_V1._0.Models;


namespace Rental_Kiosk.Views
{
    public partial class ItemRentalView : Form
    {
        public ItemRentalView()
        {
            InitializeComponent();
            ImportData();
        }


        private void ImportData()
        {
            Application_Model ApModel = new Application_Model();
            DataTable ItemData = ApModel.ImportData();
            ItemGridRental.DataSource = ItemData;
            //hide the last column
            ItemGridRental.Columns[ItemGridRental.Columns.Count - 1].Visible = false;

            //Set default value
            RentalDaysAmnt.Text = "1";


        }

        private void SelectItem(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ItemGridRental.Rows[e.RowIndex];

            int ItemID = int.Parse(row.Cells[0].Value.ToString());
            string ItemName = row.Cells[1].Value.ToString();
            string Category = row.Cells[2].Value.ToString();
            int RentPerDay = int.Parse(row.Cells[3].Value.ToString());
            string ImagePath = row.Cells[5].Value.ToString();
            string studentID = Program.LoginStudentID;
            int noOfDays = int.Parse(RentalDaysAmnt.Text);


            DialogResult result = MessageBox.Show("Do you want to rent " + ItemName + "?", "Rent Item", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application_Model ApModel = new Application_Model();
                Cart item = new Cart(ItemID, studentID, ItemName, Category, RentPerDay, ImagePath, noOfDays, noOfDays * RentPerDay);
                if (ApModel.AddtoCart(item) == true)
                {
                    MessageBox.Show("Item added to cart", "Transaction Successful");
                    CartTransition();
                }
                else
                {
                    MessageBox.Show("Item not added to cart", "Cancel Transaction");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Item not added to cart", "Cancel Transaction");
                return;
            }

        }

        private void CartTransition()
        {
            this.Close();
            CheckoutScreen cart = new CheckoutScreen();
            cart.Show();
        }
    }
}
