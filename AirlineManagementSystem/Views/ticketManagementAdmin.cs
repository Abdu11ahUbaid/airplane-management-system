using AirlineManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AirlineManagementSystem.Views
{
    public partial class ticketManagementAdmin : Form
    {
        public ticketManagementAdmin()
        {
            InitializeComponent();
            RefreshDataGridView();
        }
        public void RefreshDataGridView()
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve registered customers and their booked tickets
                string selectCustomersQuery = "SELECT Customers.CustomerID, Customers.Name, Customers.Email," +
                                      "Planes.PlaneName, PlanePrices.TicketPrice, Tickets.PurchaseDate, Tickets.Status " +
                                      "FROM Customers " +
                                      "LEFT JOIN Tickets ON Customers.CustomerID = Tickets.CustomerID " +
                                      "LEFT JOIN Planes ON Tickets.PlaneID = Planes.PlaneID " +
                                      "LEFT JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCustomersQuery, con))
                {
                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the DataSource for the DataGridView
                TicketsGridAdmin.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
        }

        public void RefreshDataGridViewSearch(string searchTerm)
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve customer details based on the search term
                string selectCustomersQuery = "SELECT Customers.CustomerID, Customers.Name, Customers.Email," +
                                              "Tickets.TicketID, Planes.PlaneName, Planes.PlaneType, PlanePrices.TicketPrice, Tickets.PurchaseDate, " +
                                              "FlightRoutes.DepartureTime, FlightRoutes.ArrivalTime, Tickets.Status " +
                                              "FROM Customers " +
                                              "LEFT JOIN Tickets ON Customers.CustomerID = Tickets.CustomerID " +
                                              "LEFT JOIN Planes ON Tickets.PlaneID = Planes.PlaneID " +
                                              "LEFT JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID " +
                                              "LEFT JOIN FlightRoutes ON Planes.PlaneID = FlightRoutes.PlaneID " +
                                              "WHERE Customers.Name LIKE @SearchTerm";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCustomersQuery, con))
                {
                    // Set the search parameter
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the DataSource for the DataGridView
                TicketsGridAdmin.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
        }


        private void showAll_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void ticketsSearch_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewSearch(SearchTicketsAdmin.Text);
        }
    }
}
