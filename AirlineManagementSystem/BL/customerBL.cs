using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem.BL
{
    internal class customerBL
    {
        private string loggedInEmail;
        private string loggedInName;
        public string LoggedInEmail { get => loggedInEmail; set => loggedInEmail = value; }

        public string LoggedInName { get => loggedInName; set => loggedInName = value; }

        private static customerBL instance;

        public static customerBL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new customerBL();
                }
                return instance;
            }
        }

        public static int GetCustomerIDFromDatabase(string username)
        {
            // Building Connection with database
            String ConnectionStr = @"Data Source=(local);Initial Catalog=AirplaneManagementSystem;Integrated Security=True";
            var con = configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con = new SqlConnection(ConnectionStr);
                con.Open();
            }
            // Query to get the ID of the customer based on his Email which we stored at the login time
            string selectCustomerIDQuery = "SELECT CustomerID FROM Customers WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(selectCustomerIDQuery, con))
                {
                    command.Parameters.AddWithValue("@Email", username);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            

            return -1; // Return a default value or handle the absence of the customer ID based on your application's logic
        }

        public static string GetUsernameFromEmail(string loggedInEmail)
        {
            string username = null;

            try
            {
                var con = configuration.getInstance().getConnection();

                string selectUsernameQuery = "SELECT Username FROM Customers WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(selectUsernameQuery, con))
                {
                    command.Parameters.AddWithValue("@Email", loggedInEmail);

                    con.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        username = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return username;
        }

        // Add other methods for customer-related operations
    }
}
