using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace PetGroomingandVeterinary
{
    public partial class LoginForm : Form
    {
        // Define the delegate
        public delegate bool ValidateUserDelegate(string username, string password);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextbox.Text;
            string password = passwordTextbox.Text;

            // Create the delegate instance and pass the method to validate the user
            ValidateUserDelegate validateUser = ValidateUser;

            try
            {
                // Execute the delegate to validate the user
                if (validateUser(username, password))
                {
                    // Success logic
                    WorkSpace wp = new WorkSpace();
                    wp.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delegate method to validate user using LINQ
        private bool ValidateUser(string username, string password)
        {
            List<Employee> employees = GetEmployeesFromDatabase();

            // Use LINQ to check if the employee exists with the given username and password
            return employees.Any(e => e.EmployeeName == username && e.Password == password);
        }

        // Method to fetch employees from the database and return them as a list
        private List<Employee> GetEmployeesFromDatabase()
        {
            List<Employee> employees = new List<Employee>();

            string query = "SELECT EmployeeName, Password FROM Employees";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Administrator\\source\\repos\\PetGrooming\\database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            EmployeeName = reader["EmployeeName"].ToString(),
                            Password = reader["Password"].ToString()
                        });
                    }
                }
            }

            return employees;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }

    // Employee class to represent the employee data
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string Password { get; set; }
    }
}
