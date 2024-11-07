using System;
using System.Windows.Forms;
using Rental_App_V1._0.Models;
using Rental_App_V1._0.ModelViews;

/*
LOGIN SCREEN DOCUMENTATION
--------------------------
METHODS/FUNCTIONS
--------------------------
LoginScreen()
- This is the constructor for the LoginScreen class. It initializes the LoginScreen form.

LoginIDBtn_Click(object sender, EventArgs e)
- This function is called when the user clicks the login button. It checks if the user input 
is empty and if filled, checks the database for the user.

CheckTransition()
- This function closes the current form and opens the CheckStudent form.
--------------------------
*/

namespace Rental_Kiosk.Views
{

    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginIDBtn_Click(object sender, EventArgs e)
        {
            //checks if the user input is empty and if filled, checks databse for user

            //CHECK IF ID IS EMPTY OR NULL
            if (LoginIDInput.Text == "" || LoginIDInput.Text == null)
            {
                MessageBox.Show("Please enter your ID");
                return;
            }

            //CHECK IF ID IS A NUMBER
            else if (System.Text.RegularExpressions.Regex.IsMatch(LoginIDInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                return;
            }

            //CHECK IF ID IS IN 10 DIGITS
            else if (LoginIDInput.Text.Length != 10)
            {
                MessageBox.Show("Please enter a 10 digit ID");
                return;
            }
            else
            {
                Application_Model application_Model = new Application_Model();
                Student student = application_Model.CheckIfExist(LoginIDInput.Text);
                if (student == null)
                {
                    MessageBox.Show("Student does not exist");
                    return;
                }
                else
                {   
                    Program.LoginStudentID = student.StudentID;
                    CheckTransition();
                }
            }
        }
        private void CheckTransition()
        {
            this.Close();
            CheckStudent checkStudent = new CheckStudent();
            checkStudent.Show();
        }
    }
}
