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
using AirlineManagementSystem.Views;
using AirlineManagementSystem.BL;
using AirlineManagementSystem.Exception_Handling;

namespace AirlineManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Get user input from the login form
            string email = txtUsernameLogin.Text.Trim();
            string password = txtPasswordLogin.Text;

            // Check if email and password are provided
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            try
            {
                var con = configuration.getInstance().getConnection();

                // SQL query to check customer credentials and IsActive status
                string selectQuery = "SELECT COUNT(*) FROM Customers WHERE Email = @Email AND Password = @Password AND IsActive = 1";

                using (SqlCommand command = new SqlCommand(selectQuery, con))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Store the Email for creating a specific user session
                        customerBL.Instance.LoggedInEmail = email;
                        // Redirect to the application's main page or dashboard
                        OpenMainPage();
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Invalid email or password, or the account is inactive.");
                    }
                }
            }
            catch (Exception ex)
            {
                //LogException function call to write/log exception into database
                exceptionHandling.LogException(ex, "frmLogin", "RegisterButton_Click");
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void OpenMainPage()
        {
            CustomerDaashboard customerDaashboard = new CustomerDaashboard();
            customerDaashboard.Show();
            this.Close();
        }

        private void chkBxShwPass_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // When the checkbox is checked, show the password.
            if (ShowLogin.Checked)
            {
                txtPasswordLogin.PasswordChar = '\0'; // Show password as plain text
            }
            else
            {
                txtPasswordLogin.PasswordChar = '*'; // Hide password with bullet characters
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            formRegistration RegistrationForm = new formRegistration();

            RegistrationForm.Show();
            this.Hide();
        }

        private void AdminLoginFormbtn_Click(object sender, EventArgs e)
        {
            adminLoginForm adminLoginForm = new adminLoginForm();
            adminLoginForm.Show();
            this.Hide();
        }
    }
    
}
