using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Rental_App_V1._0.Models;
using Image = System.Drawing.Image;

namespace Rental_App_V1._0.ModelViews
{
    internal class Application_Model
    {
        internal string connectionString = "Data Source=localhost\\VPDBOOP;Initial Catalog=VPDB;integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Student CheckIfExist(String id)
        {
            string query = $"SELECT * FROM studentData WHERE StudentID = '{id}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Student student = new Student(reader.GetInt32(reader.GetOrdinal("PrimaryKey")), reader.GetString(reader.GetOrdinal("StudentID")),reader.GetString(reader.GetOrdinal("Name")), reader.GetString(reader.GetOrdinal("ContactNo")), reader.GetString(reader.GetOrdinal("Program")), reader.GetBoolean(reader.GetOrdinal("IsEnrolled")));
                            connection.Close();
                            return student;
                        }
                        else
                        {
                            connection.Close();
                            return null;
                        }
                    }
                }
            }
        }
        public DataTable ImportData()
        {
            string query = "SELECT ItemID, Name, Category, RentPerDay, ItemImage FROM itemList";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();

                        dt.Columns.Add("ItemID", typeof(int));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("Category", typeof(string));
                        dt.Columns.Add("RentPerDay", typeof(int));
                        dt.Columns.Add("ItemImage", typeof(Image));
                        dt.Columns.Add("ItemPath", typeof(string));


                        while (reader.Read())
                        {

                            int itemId = reader.GetInt32(reader.GetOrdinal("ItemID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string category = reader.GetString(reader.GetOrdinal("Category"));
                            int price = reader.GetInt32(reader.GetOrdinal("RentPerDay"));
                            string imagePath = reader.GetString(reader.GetOrdinal("ItemImage"));
                            string imageAddress = reader.GetString(reader.GetOrdinal("ItemImage"));

                            Image itemImage = null;
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                try
                                {
                                    itemImage = Image.FromFile(imagePath);
                                    itemImage = ResizeImage(itemImage, 200, 200);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error loading image: " + ex.Message);

                                }
                            }

                            dt.Rows.Add(itemId, name, category, price, itemImage, imageAddress);

                        }
                        connection.Close();
                        return dt;
                    }
                }
            }
        }
        public DataTable importCart(string id)
        {
            string query = $"SELECT ItemID, StudentID, Name, Category, RentPerDay, ItemImage, TotalPrice FROM Cart WHERE StudentID = '{id}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();

                        dt.Columns.Add("ItemID", typeof(int));
                        dt.Columns.Add("StudentID", typeof(string));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("Category", typeof(string));
                        dt.Columns.Add("RentPerDay", typeof(int));
                        dt.Columns.Add("ItemImage", typeof(Image));
                        dt.Columns.Add("TotalPrice", typeof(int));

                        while (reader.Read())
                        {
                            int itemId = reader.GetInt32(reader.GetOrdinal("ItemID"));
                            string studentid = reader.GetString(reader.GetOrdinal("StudentID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string category = reader.GetString(reader.GetOrdinal("Category"));
                            int rentPerDay = reader.GetInt32(reader.GetOrdinal("RentPerDay"));
                            string ImageItem = reader.GetString(reader.GetOrdinal("ItemImage"));
                            int totalPrice = reader.GetInt32(reader.GetOrdinal("TotalPrice"));

                            Image itemImage = null;
                            if (!string.IsNullOrEmpty(ImageItem) && File.Exists(ImageItem))
                            {
                                try
                                {
                                    itemImage = Image.FromFile(ImageItem);
                                    itemImage = ResizeImage(itemImage, 200, 200);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error loading image: " + ex.Message);

                                }
                            }
                            dt.Rows.Add(itemId, studentid, name, category, rentPerDay, itemImage, totalPrice);
                        }

                        connection.Close();
                        return dt;
                    }
                }
            }
        }

        public DataTable SearchFilter(string word, string cat)
        {
            string query = $"SELECT ItemID, Name, Category, RentPerDay, ItemImage FROM itemList WHERE Name LIKE '%{word}%' AND Category = '{cat}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable dt = new DataTable();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {


                        dt.Columns.Add("ItemID", typeof(int));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("Category", typeof(string));
                        dt.Columns.Add("RentPerDay", typeof(int));
                        dt.Columns.Add("ItemImage", typeof(Image));
                        dt.Columns.Add("ItemPath", typeof(string));

                        while (reader.Read())
                        {
                            int itemId = reader.GetInt32(reader.GetOrdinal("ItemID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string category = reader.GetString(reader.GetOrdinal("Category"));
                            int price = reader.GetInt32(reader.GetOrdinal("RentPerDay"));
                            string imagePath = reader.GetString(reader.GetOrdinal("ItemImage"));

                            Image itemImage = null;
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                try
                                {
                                    itemImage = Image.FromFile(imagePath);
                                    itemImage = ResizeImage(itemImage, 200, 200);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error loading image: " + ex.Message);

                                }
                            }
                            dt.Rows.Add(itemId, name, category, price, itemImage, imagePath);
                        }
                    }
                    connection.Close();
                    return dt;
                }
            }
        }

        public Boolean AddtoCart(Cart cart)
        {
            Cart cart1 = cart;

            string studentID = cart.StudentId;
            string itemName = cart.Name;
            string itemCategory = cart.Category;
            int itemPrice = cart.RentPerDay;
            string itemImage = cart.ItemImage;
            int rentDays = cart.NoOfRentDays;
            int totalrent = cart.TotalPrice;

            string checkQuery = $"SELECT * FROM Cart WHERE ItemID = '{cart1.ItemId}'";
            string insertQuery = $"INSERT intO Cart (ItemID, StudentID, Name, Category, RentPerDay, ItemImage, TotalPrice) VALUES ('{cart1.ItemId}', '{cart1.StudentId}', '{cart1.Name}', '{cart1.Category}', '{cart1.RentPerDay}', '{cart1.ItemImage}', '{cart1.TotalPrice}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    using (SqlDataReader checkReader = checkCommand.ExecuteReader())
                    {
                        if (checkReader.Read())
                        {
                            MessageBox.Show("Item is currently being rented.");
                            connection.Close();
                            return false;
                        }
                    }
                }

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
        }

        private Image ResizeImage(Image imgToResize, int width, int height)
        {
            return (Image)(new Bitmap(imgToResize, new Size(width, height)));
        }
    }
}
