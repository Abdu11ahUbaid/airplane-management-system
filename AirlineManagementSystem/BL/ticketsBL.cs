using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem.BL
{
    internal class ticketsBL
    {
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

                string selectTicketHistoryQuery = "SELECT t.TicketID, p.PlaneName, t.PurchaseDate, t.Status " +
                                                  "FROM Tickets t " +
                                                  "JOIN Planes p ON t.PlaneID = p.PlaneID " +
                                                  "WHERE t.CustomerID = @CustomerID";

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

    }
}
