using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AirlineManagementSystem.BL;

namespace AirlineManagementSystem.Views
{
    public partial class revenueAdmin : Form
    {
        public revenueAdmin()
        {
            InitializeComponent();
            
        }

        public void RefreshDataGridViewForPlane(string planeName)
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve ticket details for the specified plane
                string selectTicketsQuery = "SELECT Tickets.TicketID, Customers.Name AS CustomerName, Customers.Email, " +
                                            "Planes.PlaneName, PlanePrices.TicketPrice, Tickets.PurchaseDate, " +
                                            "FlightRoutes.DepartureTime, FlightRoutes.ArrivalTime, Tickets.Status " +
                                            "FROM Tickets " +
                                            "JOIN Customers ON Tickets.CustomerID = Customers.CustomerID " +
                                            "JOIN Planes ON Tickets.PlaneID = Planes.PlaneID " +
                                            "JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID " +
                                            "JOIN FlightRoutes ON Planes.PlaneID = FlightRoutes.PlaneID " +
                                            "WHERE Planes.PlaneName = @PlaneName";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectTicketsQuery, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@PlaneName", planeName);
                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the DataSource for the DataGridView
                dataGridViewRevenue.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
        }

        private void SearchPlaneNameToSeeRevenue_Click(object sender, EventArgs e)
        {
            string planeName = PlaneRevenueSearch.Text;

            if (!string.IsNullOrEmpty(planeName))
            {
                // Call the method to calculate and display the total revenue
                ticketsBL.CalculateTotalRevenue(planeName);
                PerPlaneRevenure.Text = ticketsBL.Labeltext;

                // Call the method to refresh the grid with ticket details for the specified plane
                RefreshDataGridViewForPlane(planeName);
            }
            else
            {
                MessageBox.Show("Please enter a plane name.");
            }
        }

        private void TotalRevenueAdmin_Click(object sender, EventArgs e)
        {
            // Call the method to calculate the total revenue
            decimal totalRevenue = ticketsBL.CalculateTotalRevenue();

            // Display the total revenue in your label or wherever you want
            TotalRevenue.Text = totalRevenue.ToString("0.00");
        }
    }
}
