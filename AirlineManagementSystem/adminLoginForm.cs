using AirlineManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem
{
    public partial class adminLoginForm : Form
    {
        public adminLoginForm()
        {
            InitializeComponent();
        }

        private void LoginAdminBtn_Click(object sender, EventArgs e)
        {
            // Get user input from the login form
            string Username = txtUsernameAdminLogin.Text;
            string password = txtAdminPasswordLogin.Text;

            try
            {
                var con = configuration.getInstance().getConnection();

                //SQL query to check customer credentials
                string selectQuery = "SELECT COUNT(*) FROM Admins WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(selectQuery, con))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", password);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
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
                // Add the exception into the exception table
                Exception_Handling.exceptionHandling.LogException(ex, "adminLoginForm", "LoginAdminBtn_Click");
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        private void OpenMainPage()
        {
            AdminDashboardMain adminDashboard = new AdminDashboardMain();

            adminDashboard.Show();
            this.Close();
        }

        private void Gobacklabel_Click(object sender, EventArgs e)
        {
            frmLogin cutomerLogin = new frmLogin();
            cutomerLogin.Show();
            this.Close();
        }
       

      

        private void ShowLogin_CheckedChanged(object sender, EventArgs e)
        {
            // When the checkbox is checked, show the password.
            if (ShowLogin.Checked)
            {
                txtAdminPasswordLogin.PasswordChar = '\0'; // Show password as plain text
            }
            else
            {
                txtAdminPasswordLogin.PasswordChar = '*'; // Hide password with bullet characters
            }
        }
    }
}
