using Rental_App_V1._0.Models;
using Rental_App_V1._0.ModelViews;
using System.Windows.Forms;

/*
CHECK STUDENT DOCUMENTATION
--------------------------
METHODS/FUNCTIONS
--------------------------
CheckStudent()
- This is the constructor for the CheckStudent class. It initializes the CheckStudent form.

DeselectAll()
- This function clears the textboxes.

ImportData()
- This function imports the data from the database.

GridTransition()
- This function closes the current form and opens the CheckStudent form.

LoginTransition()
- This function closes the current form and opens the LoginScreen form.
--------------------------
*/


namespace Rental_Kiosk.Views
{
    public partial class CheckStudent : Form
    {
        public CheckStudent()
        {
            InitializeComponent();
            ImportData();
        }

        private void ImportData()
        {
            string id = Program.LoginStudentID;
            Application_Model application_Model = new Application_Model();

            Student student = application_Model.CheckIfExist(id);

            StudentNameDsply.Text = student.StudentName;
            StudentIDDsply.Text = student.StudentID;
            StudentNumDsply.Text = student.number;
            StudentProgramDsply.Text = student.StudentProgram;
            IsEnrolledDsply.Text = student.IsEnroled ? "Yes" : "No";

        }
        private void GridTransition()
        {
            this.Close();
            ItemRentalView itemRental = new ItemRentalView();
            itemRental.Show();
        }

        private void LoginTransition()
        {
            this.Close(); 
            LoginScreen login = new LoginScreen();
            login.Show();
        }

        private void CheckYesBtn_Click(object sender, System.EventArgs e)
        {
            GridTransition();
        }
        private void CheckNoBtn_Click(object sender, System.EventArgs e)
        {
            LoginTransition();
        }
    }
}
