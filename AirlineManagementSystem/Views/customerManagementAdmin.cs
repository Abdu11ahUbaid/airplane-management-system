using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        private void RefreshDataGridViewSearchResults()
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve customer records based on the search term
                string searchQuery = "SELECT CustomerID, Username, Email, PhoneNo FROM Customers WHERE Username LIKE @SearchTerm OR Email LIKE @SearchTerm";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con))
                {
                    // Set the search parameter
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + SearchCustomerAdmin.Text + "%");

                    adapter.Fill(dataTable);
                }

                // Check if there are no records found
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the search term: " + SearchCustomerAdmin.Text, "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Set the DataTable as the DataSource for the DataGridView
                    customerGridAdmin.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
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

        private void customerSearch_Click(object sender, EventArgs e)
        {
            // Trigger the search when the button is clicked
            RefreshDataGridViewSearchResults();
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
