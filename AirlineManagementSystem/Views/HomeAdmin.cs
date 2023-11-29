using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem.Views
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void RefreshDataGridView()
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // SQL query to retrieve customer records who booked tickets
                string query = "SELECT Customers.Name, Customers.Email, Planes.PlaneName, Tickets.PurchaseDate, Tickets.Status " +
                               "FROM Customers " +
                               "JOIN Tickets ON Customers.CustomerID = Tickets.CustomerID " +
                               "JOIN Planes ON Tickets.PlaneID = Planes.PlaneID";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the DataSource for the DataGridView
                HomeGridAdmin.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Add the exception into the exception table
                Exception_Handling.exceptionHandling.LogException(ex, "HomeAdmin", "RefreshDataGridView");
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
        }

    }
}
