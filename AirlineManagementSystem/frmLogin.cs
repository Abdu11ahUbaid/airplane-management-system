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
            string Username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            try
            {
                var con = configuration.getInstance().getConnection();

                // Define the SQL query to check customer credentials
                string selectQuery = "SELECT COUNT(*) FROM Customers WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(selectQuery, con))
                    {
                        command.Parameters.AddWithValue("@Email", Username);
                        command.Parameters.AddWithValue("@Password", password);

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful.");
                            // Redirect to the application's main page or dashboard
                            OpenMainPage();
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Invalid email or password.");
                        }
                    }
                
            }
            catch (Exception ex)
            {
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
