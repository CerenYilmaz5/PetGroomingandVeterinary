using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SQLite;

namespace PetGroomingandVeterinary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextbox.Text;
            string password = passwordTextbox.Text;

            try
            {
                string query = "SELECT * FROM Employees WHERE EmployeeName = @Username AND Password = @Password";
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\emirh\\source\\repos\\PetAppointmentProject\\PetDB.db;Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
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
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
