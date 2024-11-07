using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Rental_Kiosk.Models;

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

            if (LoginIDInput.Text == "")
            {
                MessageBox.Show("Please enter your ID");
                return;
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(LoginIDInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                return;
            }
            else if (LoginIDInput.Text.Length != 10)
            {
                MessageBox.Show("Please enter a 10 digit ID");
                return;  
            }
            else
            {
                string ID = LoginIDInput.Text;
                string query = "SELECT * FROM Student WHERE StudentID = " + ID;

                //checks if the user is in the database
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                Student student = new Student(reader["StudentID"].ToString(), reader["Name"].ToString(), Convert.ToInt32(reader["Age"]), reader["Program"].ToString());
                                this.Hide();
                                MainMenu mainMenu = new MainMenu(student);
                                mainMenu.Show();
                            }
                            else
                            {
                                MessageBox.Show("User not found");
                            }
                        }
                    }
                }
            }
        }
}
