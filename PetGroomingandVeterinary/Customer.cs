using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGroomingandVeterinary
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextbox.Text;
            string phoneNumber = phoneNumberTextbox.Text;
            string customerEmail = emailTextbox.Text;
            string address = addressTextbox.Text;

            try
            {
                string query = "INSERT INTO Customers (CustomerName, PhoneNumber, CustomerEmail, Address) VALUES (@CustomerName, @PhoneNumber, @CustomerEmail, @Address)";
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\HP\\source\\repos\\PetGroomingandVeterinary\\PetDb.db;Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Parametreler ekleniyor
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@CustomerEmail", customerEmail);
                        command.Parameters.AddWithValue("@Address", address);

                        int rowsAffected = command.ExecuteNonQuery(); // Sorgu çalıştırılıyor

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Form alanlarını temizle
                            customerNameTextbox.Clear();
                            phoneNumberTextbox.Clear();
                            emailTextbox.Clear();
                            addressTextbox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
