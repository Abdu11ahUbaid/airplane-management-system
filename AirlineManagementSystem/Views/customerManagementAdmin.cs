// Form where Admin can see the details of all the customers 

using AirlineManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                string searchQuery = "SELECT CustomerID, Name, Email, Phone FROM Customers WHERE Name LIKE @SearchTerm OR Email LIKE @SearchTerm";

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
                // Add the exception into the exception table
                Exception_Handling.exceptionHandling.LogException(ex, "customerManagementAdmin", "RefreshDataGridViewSearchResults");
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
        }


        public void RefreshDataGridView()
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve all customer details
                string allCustomersQuery = "SELECT Name, Phone, Email FROM Customers";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(allCustomersQuery, con))
                {
                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the DataSource for the DataGridView
                customerGridAdmin.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Add the exception into the exception table
                Exception_Handling.exceptionHandling.LogException(ex, "customerManagementAdmin", "RefreshDataGridView");
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
