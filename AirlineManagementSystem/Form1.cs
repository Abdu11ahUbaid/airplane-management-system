using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AirlineManagementSystem
{
    public partial class formRegistration : Form
    {
        public formRegistration()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            login.Show();
            this.Hide();
        }

        private void formRegistration_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Get user input from the registration form
            string username = txtUsername.Text.Trim();
            string email = txtbxEmail.Text.Trim();
            string phone = txtBoxPhoneNumber.Text.Trim();
            string password = txtPassword.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            try
            {
                var con = configuration.getInstance().getConnection();

                // Define the SQL query to insert a new customer
                string insertQuery = "INSERT INTO Customers (Name, Email, Phone, Password, IsActive) " +
                                     "VALUES (@Name, @Email, @Phone, @Password, 1)";

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@Name", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful.");
                        // Clear the registration form fields
                        ClearRegistrationFields();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void ClearRegistrationFields()
        {
            txtBoxPhoneNumber.Clear();
            txtbxEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void chkBxShwPass_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void showPassReg_CheckedChanged(object sender, EventArgs e)
        {
            // When the checkbox is checked, show the password.
            if (showPassReg.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Show password as plain text
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Hide password with bullet characters
            }
        }
    }
    
}
