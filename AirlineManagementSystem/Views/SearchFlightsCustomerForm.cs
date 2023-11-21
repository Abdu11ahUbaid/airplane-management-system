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
using AirlineManagementSystem.DL;

namespace AirlineManagementSystem.Views
{
    public partial class SearchFlightsCustomerForm : Form
    {
        public SearchFlightsCustomerForm()
        {
            InitializeComponent();
        }

        private void DeparturecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // RefreshGridView();
        }

        private void ArrivalcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve active planes based on selected departure and arrival cities
                string selectPlanesQuery = "SELECT PlaneName, PlaneType, TicketPrice, DepartureTime, ArrivalTime " +
                                           "FROM Planes " +
                                           "JOIN FlightRoutes ON Planes.PlaneID = FlightRoutes.PlaneID " +
                                           "JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID " +
                                           "JOIN Cities AS DepartureCity ON FlightRoutes.DepartureCityID = DepartureCity.CityID " +
                                           "JOIN Cities AS ArrivalCity ON FlightRoutes.ArrivalCityID = ArrivalCity.CityID " +
                                           "WHERE Planes.IsActive = 1 " +
                                           "AND DepartureCity.CityName = @DepartureCity " +
                                           "AND ArrivalCity.CityName = @ArrivalCity";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectPlanesQuery, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@DepartureCity", DeparturecomboBox.SelectedItem.ToString());
                    adapter.SelectCommand.Parameters.AddWithValue("@ArrivalCity", ArrivalcomboBox.SelectedItem.ToString());

                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the DataSource for the DataGridView
                PlanesSearchGridCustomer.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
        }

        private void BookTicket_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (PlanesSearchGridCustomer.SelectedRows.Count > 0)
            {
                // Retrieve the value from the selected row's "PlaneName" column
                string selectedPlaneName = PlanesSearchGridCustomer.SelectedRows[0].Cells["PlaneName"].Value.ToString();

                // Get the plane details based on the selected plane name
                PlaneManagement selectedPlaneDetails = GetPlaneDetails(selectedPlaneName);

                // Book the ticket
                BookTicketMethod(selectedPlaneDetails.PlaneID, selectedCustomerID);
            }
            else
            {
                MessageBox.Show("Please select a plane to book.");
            }
        }
        private void BookTicketMethod(int planeID, int customerID)
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write an SQL INSERT statement to add a new record to the Tickets table
                string bookTicketQuery = "INSERT INTO Tickets (PlaneID, CustomerID, Status, PurchaseDate) " +
                                         "VALUES (@PlaneID, @CustomerID, 'Booked', GETDATE())";

                // Execute the insert query
                using (SqlCommand command = new SqlCommand(bookTicketQuery, con))
                {
                    command.Parameters.AddWithValue("@PlaneID", planeID);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Optionally, you can perform additional actions after booking the ticket
                    MessageBox.Show("Ticket booked successfully!");

                    // Refresh the GridView to reflect the changes
                    RefreshGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private PlaneManagement GetPlaneDetails(string planeName)
        {
            // Initialize an instance of PlaneDetails
            PlaneManagement planeDetails = null;

            try
            {
                var con = configuration.getInstance().getConnection();

                // Write an SQL query to retrieve plane details based on the selected plane name
                string selectPlaneQuery = "SELECT PlaneID, PlaneType, TicketPrice, DepartureTime, ArrivalTime " +
                                          "FROM Planes " +
                                          "WHERE PlaneName = @PlaneName";

                // Execute the query
                using (SqlCommand command = new SqlCommand(selectPlaneQuery, con))
                {
                    command.Parameters.AddWithValue("@PlaneName", planeName);

                    // Read the result
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve values from the database
                            int planeID = reader.GetInt32(reader.GetOrdinal("PlaneID"));
                            string planeType = reader.GetString(reader.GetOrdinal("PlaneType"));
                            decimal ticketPrice = reader.GetDecimal(reader.GetOrdinal("TicketPrice"));
                            DateTime departureTime = reader.GetDateTime(reader.GetOrdinal("DepartureTime"));
                            DateTime arrivalTime = reader.GetDateTime(reader.GetOrdinal("ArrivalTime"));

                            // Create a PlaneDetails object
                            planeDetails = new PlaneManagement(planeID, planeName, planeType, ticketPrice, departureTime, arrivalTime);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return planeDetails;
        }

    }
}
