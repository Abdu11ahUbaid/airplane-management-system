using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem.Views
{
    public partial class customerManagementAdmin : Form
    {
        public customerManagementAdmin()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void customerGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void RefreshDataGridView()
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve registered customers and their booked tickets
                string selectCustomersQuery = "SELECT Customers.CustomerID, Customers.Name, Customers.Email, " +
                                              "Tickets.TicketID, Tickets.PlaneID, Tickets.PurchaseDate, Tickets.Status " +
                                              "FROM Customers " +
                                              "LEFT JOIN Tickets ON Customers.CustomerID = Tickets.CustomerID";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCustomersQuery, con))
                {
                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the DataSource for the DataGridView
                customerGridAdmin.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
        }

    }
}
