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
using AirlineManagementSystem.BL;
using System.Configuration;

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
            if (PlanesSearchGridCustomer.SelectedCells.Count > 0)
            {
                // Retrieve the value from the selected cell's "PlaneName" column
                string selectedPlaneName = PlanesSearchGridCustomer.SelectedCells[0].Value.ToString();

                // Get the plane details based on the selected plane name
                PlaneManagement selectedPlaneDetails = GetPlaneDetails(selectedPlaneName);

                int selectedCustomerID = GetCustomerIDFromDatabase(customerBL.Instance.LoggedInEmail);

                // Book the ticket
                BookTicketMethod(selectedPlaneDetails.PlaneID, selectedCustomerID);
            }
            else
            {
                MessageBox.Show("Please select a plane to book.");
            }
        }

        private int GetCustomerIDFromDatabase(string username)
        {
            // Building Connection with database
            using (var con = configuration.getInstance().getConnection())
            {   // Query to get the ID of the customer based on his Email which we stored at the login time
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
            }
           
            return -1; // Return a default value or handle the absence of the customer ID based on your application's logic
        }


        private void BookTicketMethod(int planeID, int customerID)
        {
            try
            {              
                // Check if the ticket is already booked for the selected plane and customer
                if (!IsTicketAlreadyBooked(planeID, customerID))
                {
                    String ConnectionStr = @"Data Source=(local);Initial Catalog=AirplaneManagementSystem;Integrated Security=True";
                    var con = configuration.getInstance().getConnection();
                    if (con.State == ConnectionState.Closed)
                    {
                        con = new SqlConnection(ConnectionStr);
                        con.Open();
                    }
                    // The ticket is not booked, proceed with booking
                    string bookTicketQuery = "INSERT INTO Tickets (PlaneID, CustomerID, PurchaseDate, Status) " +
                                             "VALUES (@PlaneID, @CustomerID, GETDATE(), 'Booked')";

                    using (SqlCommand command = new SqlCommand(bookTicketQuery, con))
                    {
                        command.Parameters.AddWithValue("@PlaneID", planeID);
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ticket booked successfully!");
                            // Optionally, you can update the status in the grid or refresh the grid
                            //RefreshPlanesGridCustomer();
                        }
                        else
                        {
                            MessageBox.Show("Failed to book the ticket.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ticket is already booked for this plane and customer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsTicketAlreadyBooked(int planeID, int customerID)
        {
            String ConnectionStr = @"Data Source=(local);Initial Catalog=AirplaneManagementSystem;Integrated Security=True";
            var con = configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con = new SqlConnection(ConnectionStr);
                con.Open();
            }
            string checkBookingQuery = "SELECT COUNT(*) FROM Tickets WHERE PlaneID = @PlaneID AND CustomerID = @CustomerID";

            using (SqlCommand command = new SqlCommand(checkBookingQuery, con))
            {
                command.Parameters.AddWithValue("@PlaneID", planeID);
                command.Parameters.AddWithValue("@CustomerID", customerID);

                // Execute the query and check if any rows are returned
                int rowCount = (int)command.ExecuteScalar();

                return rowCount > 0;
            }
                // Check if the ticket is already booked for the selected plane and customer
                
        }


        private PlaneManagement GetPlaneDetails(string planeName)
        {
            // Initialize an instance of PlaneDetails
            PlaneManagement planeDetails = null;

            try
            {
                var con = configuration.getInstance().getConnection();

                // SQL query to retrieve plane details based on the selected plane name
                string selectPlaneQuery = "SELECT p.PlaneID, p.PlaneType, pp.TicketPrice, fr.DepartureTime, fr.ArrivalTime " +
                          "FROM Planes p " +
                          "JOIN PlanePrices pp ON p.PlaneID = pp.PlaneID " +
                          "JOIN FlightRoutes fr ON p.PlaneID = fr.PlaneID " +
                          "WHERE p.PlaneName = @PlaneName";

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

        private void PlanesSearchGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*// Check if the clicked cell is in the "PlaneName" column
            if (e.ColumnIndex == PlanesSearchGridCustomer.Columns["PlaneName"].Index && e.RowIndex >= 0)
            {
                // Retrieve the value from the clicked cell's "PlaneName" column
                string selectedPlaneName = PlanesSearchGridCustomer.Rows[e.RowIndex].Cells["PlaneName"].Value.ToString();

                // Get the plane details based on the selected plane name
                PlaneManagement selectedPlaneDetails = GetPlaneDetails(selectedPlaneName);

                int selectedCustomerID = GetCustomerIDFromDatabase(customerBL.Instance.LoggedInEmail);

                // Book the ticket
                BookTicketMethod(selectedPlaneDetails.PlaneID, selectedCustomerID);
            }
            else
            {
                MessageBox.Show("Please select a plane to book.");
            }*/
        }
    }
}
