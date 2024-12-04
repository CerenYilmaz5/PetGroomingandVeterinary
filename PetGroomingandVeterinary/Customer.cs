using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PetGroomingandVeterinary
{
    public partial class Customer : Form
    {
        private int selectedCustomerId;

        // Delegates for handling Add, Update, and Delete operations
        public delegate void AddCustomerDelegate(string customerName, string phoneNumber, string customerEmail, string address);
        public delegate void UpdateCustomerDelegate(int customerId, string customerName, string phoneNumber, string customerEmail, string address);
        public delegate void DeleteCustomerDelegate(int customerId);

        public Customer()
        {
            InitializeComponent();
            LoadCustomerData(); // Load customer data on form initialization
        }

        // Loads customer data into DataGridView and adds Update/Delete buttons
        private void LoadCustomerData()
        {
            try
            {
                List<CustomerData> customers = GetCustomersFromDatabase();
                customerDataGridView.DataSource = customers;

                if (!customerDataGridView.Columns.Contains("Update"))
                {
                    DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn
                    {
                        HeaderText = "Update",
                        Text = "Update",
                        UseColumnTextForButtonValue = true,
                        Name = "Update"
                    };
                    customerDataGridView.Columns.Add(updateButton);
                }

                if (!customerDataGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                    {
                        HeaderText = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true,
                        Name = "Delete"
                    };
                    customerDataGridView.Columns.Add(deleteButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Retrieves customer data from the SQLite database
        private List<CustomerData> GetCustomersFromDatabase()
        {
            List<CustomerData> customers = new List<CustomerData>();

            try
            {
                string query = "SELECT CustomerID, CustomerName, PhoneNumber, CustomerEmail, Address FROM Customers";
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Administrator\\source\\repos\\PetGrooming\\database.db;Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        SQLiteDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            customers.Add(new CustomerData
                            {
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                CustomerName = reader["CustomerName"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                CustomerEmail = reader["CustomerEmail"].ToString(),
                                Address = reader["Address"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return customers;
        }

        // Handles Add button click to create a new customer
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameTextbox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextbox.Text) ||
                string.IsNullOrWhiteSpace(emailTextbox.Text) ||
                string.IsNullOrWhiteSpace(addressTextbox.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = customerNameTextbox.Text;
            string phoneNumber = phoneNumberTextbox.Text;
            string customerEmail = emailTextbox.Text;
            string address = addressTextbox.Text;

            AddCustomerDelegate addCustomer = AddCustomer;
            addCustomer(customerName, phoneNumber, customerEmail, address);
        }

        // Inserts a new customer into the database
        private void AddCustomer(string customerName, string phoneNumber, string customerEmail, string address)
        {
            try
            {
                string query = "INSERT INTO Customers (CustomerName, PhoneNumber, CustomerEmail, Address) VALUES (@CustomerName, @PhoneNumber, @CustomerEmail, @Address)";
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Administrator\\source\\repos\\PetGrooming\\database.db;Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@CustomerEmail", customerEmail);
                        command.Parameters.AddWithValue("@Address", address);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            customerNameTextbox.Clear();
                            phoneNumberTextbox.Clear();
                            emailTextbox.Clear();
                            addressTextbox.Clear();

                            LoadCustomerData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles button clicks within the DataGridView for Update and Delete actions
        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == customerDataGridView.Columns["Update"].Index && e.RowIndex >= 0)
            {
                selectedCustomerId = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["CustomerID"].Value);
                customerNameTextbox.Text = customerDataGridView.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                phoneNumberTextbox.Text = customerDataGridView.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                emailTextbox.Text = customerDataGridView.Rows[e.RowIndex].Cells["CustomerEmail"].Value.ToString();
                addressTextbox.Text = customerDataGridView.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
            else if (e.ColumnIndex == customerDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int customerIdToDelete = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["CustomerID"].Value);

                DeleteCustomerDelegate deleteCustomer = DeleteCustomer;
                deleteCustomer(customerIdToDelete);
            }
        }

        // Deletes a customer from the database
        private void DeleteCustomer(int customerId)
        {
            try
            {
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Administrator\\source\\repos\\PetGrooming\\database.db;Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomerData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles Update button click to modify customer details
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameTextbox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextbox.Text) ||
                string.IsNullOrWhiteSpace(emailTextbox.Text) ||
                string.IsNullOrWhiteSpace(addressTextbox.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = customerNameTextbox.Text;
            string phoneNumber = phoneNumberTextbox.Text;
            string customerEmail = emailTextbox.Text;
            string address = addressTextbox.Text;

            UpdateCustomerDelegate updateCustomer = UpdateCustomer;
            updateCustomer(selectedCustomerId, customerName, phoneNumber, customerEmail, address);
        }

        // Updates customer details in the database
        private void UpdateCustomer(int customerId, string customerName, string phoneNumber, string customerEmail, string address)
        {
            try
            {
                string query = "UPDATE Customers SET CustomerName = @CustomerName, PhoneNumber = @PhoneNumber, CustomerEmail = @CustomerEmail, Address = @Address WHERE CustomerID = @CustomerID";
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Administrator\\source\\repos\\PetGrooming\\database.db;Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@CustomerEmail", customerEmail);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@CustomerID", customerId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadCustomerData();

                            customerNameTextbox.Clear();
                            phoneNumberTextbox.Clear();
                            emailTextbox.Clear();
                            addressTextbox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class CustomerData
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string Address { get; set; }
    }
}
