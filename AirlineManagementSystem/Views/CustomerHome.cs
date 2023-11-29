using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AirlineManagementSystem.BL;

namespace AirlineManagementSystem.Views
{
    public partial class CustomerHome : Form
    {
        public CustomerHome()
        {
            InitializeComponent();
            // Catpure the Customer ID at the time of login 
             customerID = customerBL.GetCustomerIDFromDatabase(customerBL.Instance.LoggedInEmail);
            // Load the ticket history for the logged in customer using the captured ID
            LoadTicketHistory(customerID);
        }
            int customerID; // To store the customer ID who is currently logged in

        // Method to Load Ticket History
        private void LoadTicketHistory(int customerID)
        {
            DataTable ticketHistory = ticketsBL.GetTicketHistory(customerID);
            // Populate the Grid with the Ticket History of the currently Logged in customer
            ticketsHistoryGridCustomer.DataSource = ticketHistory;
        }

        private void SearchTickets_Click(object sender, EventArgs e)
        {

        }

        private void CancelTicket_Click(object sender, EventArgs e)
        {
            // Check if a cell in the "PlaneName" column is selected
            if (ticketsHistoryGridCustomer.SelectedCells.Count > 0)
            {
                // Get the index of the selected cell
                int selectedCellIndex = ticketsHistoryGridCustomer.SelectedCells[0].ColumnIndex;

                // Check if the selected cell is in the "PlaneName" column
                if (ticketsHistoryGridCustomer.Columns[selectedCellIndex].Name == "PlaneName")
                {
                    // Retrieve the value from the selected cell's "PlaneName" column
                    string selectedPlaneName = ticketsHistoryGridCustomer.SelectedCells[0].Value.ToString();

                    // Get the ticket details based on the selected plane name
                    ticketsBL ticketDetails = GetTicketDetails(selectedPlaneName, customerID);

                    // Check if the ticket is booked
                    if (ticketDetails != null && ticketDetails.Status == "Booked")
                    {
                        // Cancel the ticket (update the status to "Cancelled" in the database)
                        UpdateTicketStatus(ticketDetails.TicketID, "Cancelled");

                        // Refresh the DataGridView to reflect the changes
                        RefreshDataGridView(customerID);
                    }
                    else
                    {
                        MessageBox.Show("Selected ticket is not in 'Booked' status.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a cell in the 'PlaneName' column before clicking Cancel Ticket.");
                }
            }
            else
            {
                MessageBox.Show("Please select a cell in the 'PlaneName' column before clicking Cancel Ticket.");
            }
        }

        // Method to retrieve ticket details based on the plane name
        private ticketsBL GetTicketDetails(string planeName, int customerid)
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // SQL Query to fetch ticket details based on the plane name
                string selectQuery = "SELECT t.TicketID, t.Status " +
                     "FROM Tickets t " +
                     "JOIN Planes p ON t.PlaneID = p.PlaneID " +
                     "JOIN Customers c ON t.CustomerID = c.CustomerID " +
                     "WHERE p.PlaneName = @PlaneName AND c.CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(selectQuery, con))
                {
                    command.Parameters.AddWithValue("@PlaneName", planeName);
                    command.Parameters.AddWithValue("@CustomerID", customerid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            return new ticketsBL
                            {
                                TicketID = reader.GetInt32(0),
                                Status = reader.GetString(1),
                                
                            };
                        }
                        else
                        {
                            // Ticket not found
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Add the exception into the exception table
                Exception_Handling.exceptionHandling.LogException(ex, "CustomerHome", "GetTicketDetails");
                MessageBox.Show("Error fetching ticket details: " + ex.Message);
                return null;
            }
        }

        // Method to update the ticket status in the database
        private void UpdateTicketStatus(int ticketID, string newStatus)
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Replace the following query with your actual logic to update the ticket status
                string updateQuery = "UPDATE Tickets SET Status = @NewStatus WHERE TicketID = @TicketID";

                using (SqlCommand command = new SqlCommand(updateQuery, con))
                {
                    command.Parameters.AddWithValue("@NewStatus", newStatus);
                    command.Parameters.AddWithValue("@TicketID", ticketID);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Add the exception into the exception table
                Exception_Handling.exceptionHandling.LogException(ex, "CustomerHome", "UpdateTicketStatus");
                MessageBox.Show("Error updating ticket status: " + ex.Message);
            }
        }

        // Method to refresh the DataGridView after canceling a ticket
        private void RefreshDataGridView(int customerid)
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                string refreshQuery = "SELECT p.PlaneName, t.PurchaseDate, t.Status, pp.TicketPrice, departureCity.CityName AS DepartureCity, arrivalCity.CityName AS ArrivalCity " +
                                                    "FROM Tickets t " +
                                                    "JOIN Planes p ON t.PlaneID = p.PlaneID " +
                                                    "JOIN PlanePrices pp ON p.PlaneID = pp.PlaneID " +
                                                    "JOIN FlightRoutes fr ON t.PlaneID = fr.PlaneID " +
                                                    "JOIN Cities departureCity ON fr.DepartureCityID = departureCity.CityID " +
                                                    "JOIN Cities arrivalCity ON fr.ArrivalCityID = arrivalCity.CityID " +
                                                    "WHERE t.CustomerID = @CustomerID AND(t.Status = 'Booked' OR t.Status = 'Cancelled')"; ; // Query to see the data based on the condition of book and cancel ticket

                DataTable dataTable = new DataTable();

                using (SqlCommand command = new SqlCommand(refreshQuery, con))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerid);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                ticketsHistoryGridCustomer.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Add the exception into the exception table
                Exception_Handling.exceptionHandling.LogException(ex, "CustomerHome", "RefreshDataGridView");
                MessageBox.Show("Error refreshing DataGridView: " + ex.Message);
            }
        }

    }
}
