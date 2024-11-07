using System.Data;
using System.Windows.Forms;
using Rental_App_V1._0.ModelViews;


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
    }
}
