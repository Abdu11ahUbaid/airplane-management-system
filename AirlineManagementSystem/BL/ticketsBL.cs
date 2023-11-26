using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AirlineManagementSystem.BL
{
    internal class ticketsBL
    {
        private static string labeltext;

        private int ticketID;

        private string status;

        public int TicketID { get => ticketID; set => ticketID = value; } 

        public string Status { get => status; set => status = value; }

        public static string Labeltext { get => labeltext; set => labeltext = value; }

        private static ticketsBL instance;
        public static ticketsBL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ticketsBL();
                }
                return instance;
            }
        }


        public static void BookTicketMethod(int planeID, int customerID)
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

        private static bool IsTicketAlreadyBooked(int planeID, int customerID)
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

        public bool CancelTicket(int ticketId)
        {
            // Implement logic to cancel a ticket
            // Return true if cancellation is successful, otherwise false
            return false;
        }

        public static DataTable GetTicketHistory(int customerID)
        {
            DataTable dataTable = new DataTable();

            try
            {
                String ConnectionStr = @"Data Source=(local);Initial Catalog=AirplaneManagementSystem;Integrated Security=True";
                var con = configuration.getInstance().getConnection();
                if (con.State == ConnectionState.Closed)
                {
                    con = new SqlConnection(ConnectionStr);
                    con.Open();
                }

                string selectTicketHistoryQuery = "SELECT p.PlaneName, t.PurchaseDate, t.Status, pp.TicketPrice, departureCity.CityName AS DepartureCity, arrivalCity.CityName AS ArrivalCity " +
                                                    "FROM Tickets t " +
                                                    "JOIN Planes p ON t.PlaneID = p.PlaneID " +
                                                    "JOIN PlanePrices pp ON p.PlaneID = pp.PlaneID " +
                                                    "JOIN FlightRoutes fr ON t.PlaneID = fr.PlaneID " +
                                                    "JOIN Cities departureCity ON fr.DepartureCityID = departureCity.CityID " +
                                                    "JOIN Cities arrivalCity ON fr.ArrivalCityID = arrivalCity.CityID " +
                                                    "WHERE t.CustomerID = @CustomerID AND(t.Status = 'Booked' OR t.Status = 'Cancelled')" ;

                using (SqlCommand command = new SqlCommand(selectTicketHistoryQuery, con))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dataTable;
        }
        public static void CalculateTotalRevenue(string planeName)
        {
            try
            {
                String ConnectionStr = @"Data Source=(local);Initial Catalog=AirplaneManagementSystem;Integrated Security=True";
                var con = configuration.getInstance().getConnection();
                if (con.State == ConnectionState.Closed)
                {
                    con = new SqlConnection(ConnectionStr);
                    con.Open();
                }

                // SQL query to retrieve the total revenue for the specified plane
                string totalRevenueQuery = "SELECT SUM(PlanePrices.TicketPrice) AS TotalRevenue " +
                                           "FROM Planes " +
                                           "JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID " +
                                           "WHERE Planes.PlaneName = @PlaneName";

                using (SqlCommand command = new SqlCommand(totalRevenueQuery, con))
                {
                    command.Parameters.AddWithValue("@PlaneName", planeName);

                    //con.Open();

                    // Execute the query
                    object result = command.ExecuteScalar();

                    // Close the connection
                    //con.Close();

                    // Update the label with the total revenue
                    if (result != null && result != DBNull.Value)
                    {
                        Labeltext = $"Total Revenue for {planeName}: {result}";
                    }
                    else
                    {
                        Labeltext = "No revenue data available.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total revenue: " + ex.Message);
            }
        }

        public static decimal CalculateTotalRevenue()
        {
            decimal totalRevenue = 0;

            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve ticket prices for all booked tickets
                string selectTotalRevenueQuery = "SELECT SUM(PlanePrices.TicketPrice) AS TotalRevenue " +
                                                 "FROM Tickets " +
                                                 "JOIN Planes ON Tickets.PlaneID = Planes.PlaneID " +
                                                 "JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID " +
                                                 "WHERE Tickets.Status = 'Booked'";

                // Execute the query
                using (SqlCommand command = new SqlCommand(selectTotalRevenueQuery, con))
                {
                    // Read the result
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        totalRevenue = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total revenue: " + ex.Message);
            }

            return totalRevenue;
        }


    }
}
