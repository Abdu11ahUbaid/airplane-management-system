using System;
using System.Data;
using System.Data.SqlClient;
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
        { }

        private void ArrivalcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                //SQL query to retrieve active planes based on selected departure and arrival cities
                string selectPlanesQuery = "SELECT PlaneName, PlaneType, TicketPrice, DepartureTime, ArrivalTime " +
                                           "FROM Planes " +
                                           "JOIN FlightRoutes ON Planes.PlaneID = FlightRoutes.PlaneID " +
                                           "JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID " +
                                           "JOIN Cities AS DepartureCity ON FlightRoutes.DepartureCityID = DepartureCity.CityID " +
                                           "JOIN Cities AS ArrivalCity ON FlightRoutes.ArrivalCityID = ArrivalCity.CityID " +
                                           "WHERE Planes.IsActive = 1 " +
                                           "AND DepartureCity.CityName = @DepartureCity " +
                                           "AND ArrivalCity.CityName = @ArrivalCity";

                // DataTable to store the results
                DataTable dataTable = new DataTable();

                // SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectPlanesQuery, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@DepartureCity", DeparturecomboBox.SelectedItem.ToString());
                    adapter.SelectCommand.Parameters.AddWithValue("@ArrivalCity", ArrivalcomboBox.SelectedItem.ToString());

                    adapter.Fill(dataTable);
                }

                //DataTable as the DataSource for the DataGridView
                PlanesSearchGridCustomer.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                //LogException function call to write/log exception into database
                Exception_Handling.exceptionHandling.LogException(ex, "SearchFlightsCustomerForm", "RefreshGridView");
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

                int selectedCustomerID = customerBL.GetCustomerIDFromDatabase(customerBL.Instance.LoggedInEmail);

                // Book the ticket
                ticketsBL.BookTicketMethod(selectedPlaneDetails.PlaneID, selectedCustomerID);
            }
            else
            {
                MessageBox.Show("Please select a plane to book.");
            }
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
                //LogException function call to write/log exception into database
                Exception_Handling.exceptionHandling.LogException(ex, "SearchFlightsCustomerForm", "GetPlaneDetails");
                MessageBox.Show("Error: " + ex.Message);
            }

            return planeDetails;
        }

        private void PlanesSearchGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
