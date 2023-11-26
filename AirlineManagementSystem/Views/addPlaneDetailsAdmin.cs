using AirlineManagementSystem.BL;
using AirlineManagementSystem.DL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AirlineManagementSystem.Views
{
    public partial class addPlaneDetailsAdmin : Form
    {
        public addPlaneDetailsAdmin()
        {
            InitializeComponent();
        }

        private void AddPlaneAdminBtnOkay_Click(object sender, EventArgs e)
        {
            planesBL planes = new planesBL();

           // Capture input data from the form
            planes.PlaneName = PlaneNametxtBox.Text;
            planes.PlaneType = PlaneTypeTxtbox.Text;

            // Validate and parse TicketPrice
            if (decimal.TryParse(TicketPriceTxtBox.Text, out decimal ticketPrice))
            {
                planes.TicketPrice = ticketPrice;
            }
            else
            {
                MessageBox.Show("Invalid Ticket Price. Please enter a valid decimal value.");
                return;
            }

            planes.ArrivalTime = PlaneArrivaldateTimePicker.Value;
            planes.DepartureTime = PlaneDeptdateTimePicker.Value;

            // Validate Departure City and Arrival City
            if (DeparturecomboBox.SelectedItem == null || ArrivalcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select both Departure and Arrival Cities.");
                return;
            }

            planes.DepartureCity = DeparturecomboBox.SelectedItem.ToString();
            planes.ArrivalCity = ArrivalcomboBox.SelectedItem.ToString();

            try
            {
                // Establish a connection to your database
                var con = configuration.getInstance().getConnection();

                // Begin a transaction to ensure atomicity
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Write an SQL INSERT statement to add a new record to the Cities table for Departure City
                        string insertDepartureCityQuery = "INSERT INTO Cities (CityName, CreatedAt, UpdatedAt, IsActive) " +
                                                          "VALUES (@DepartureCity, GETDATE(), GETDATE(), 1); SELECT SCOPE_IDENTITY();";

                        int departureCityId;

                        // Execute the query and retrieve the newly inserted DepartureCityID
                        using (SqlCommand command = new SqlCommand(insertDepartureCityQuery, con, transaction))
                        {
                            command.Parameters.AddWithValue("@DepartureCity", planes.DepartureCity);

                            departureCityId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Write an SQL INSERT statement to add a new record to the Cities table for Arrival City
                        string insertArrivalCityQuery = "INSERT INTO Cities (CityName, CreatedAt, UpdatedAt, IsActive) " +
                                                        "VALUES (@ArrivalCity, GETDATE(), GETDATE(), 1); SELECT SCOPE_IDENTITY();";

                        int arrivalCityId;

                        // Execute the query and retrieve the newly inserted ArrivalCityID
                        using (SqlCommand command = new SqlCommand(insertArrivalCityQuery, con, transaction))
                        {
                            command.Parameters.AddWithValue("@ArrivalCity", planes.ArrivalCity);

                            arrivalCityId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Write an SQL INSERT statement to add a new record to the Planes table
                        string insertPlaneQuery = "INSERT INTO Planes (PlaneName, PlaneType, CreatedAt, UpdatedAt, IsActive) " +
                                                  "VALUES (@PlaneName, @PlaneType, GETDATE(), GETDATE(), 1); SELECT SCOPE_IDENTITY();";

                        int planeId;

                        // Execute the query and retrieve the newly inserted PlaneID
                        using (SqlCommand command = new SqlCommand(insertPlaneQuery, con, transaction))
                        {
                            command.Parameters.AddWithValue("@PlaneName", planes.PlaneName);
                            command.Parameters.AddWithValue("@PlaneType", planes.PlaneType);

                            planeId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Write an SQL INSERT statement to add a new record to the FlightRoutes table
                        string insertFlightRouteQuery = "INSERT INTO FlightRoutes (DepartureCityID, ArrivalCityID, PlaneID, DepartureTime, ArrivalTime, CreatedAt, UpdatedAt, IsActive) " +
                                                         "VALUES (@DepartureCityID, @ArrivalCityID, @PlaneID, @DepartureTime, @ArrivalTime, GETDATE(), GETDATE(), 1)";
                        using (SqlCommand command = new SqlCommand(insertFlightRouteQuery, con, transaction))
                        {
                            command.Parameters.AddWithValue("@DepartureCityID", departureCityId);
                            command.Parameters.AddWithValue("@ArrivalCityID", arrivalCityId);
                            command.Parameters.AddWithValue("@PlaneID", planeId);
                            command.Parameters.AddWithValue("@DepartureTime", planes.DepartureTime);
                            command.Parameters.AddWithValue("@ArrivalTime", planes.ArrivalTime);

                            command.ExecuteNonQuery();
                        }

                        // Optionally, insert data into other related tables (e.g., PlanePrices, etc.)
                        // Example: Insert into PlanePrices table
                        string insertPlanePriceQuery = "INSERT INTO PlanePrices (PlaneID, TicketPrice, CreatedAt, UpdatedAt, IsActive) " +
                                                       "VALUES (@PlaneID, @TicketPrice, GETDATE(), GETDATE(), 1)";
                        using (SqlCommand command = new SqlCommand(insertPlanePriceQuery, con, transaction))
                        {
                            command.Parameters.AddWithValue("@PlaneID", planeId);
                            command.Parameters.AddWithValue("@TicketPrice", planes.TicketPrice);

                            command.ExecuteNonQuery();
                        }

                        // Commit the transaction if all operations are successful
                        transaction.Commit();

                        MessageBox.Show("Plane and related records added successfully.");
                       
                        this.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction in case of an exception
                        transaction.Rollback();
                        //LogException function call to write/log exception into database
                        Exception_Handling.exceptionHandling.LogException(ex, "addPlaneDetailsAdmin", "AddPlaneAdminBtnOkay_Click");
                        //Show Error message on the screen
                        MessageBox.Show("Error: " + ex.Message);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                //LogException function call to write/log exception into database
                Exception_Handling.exceptionHandling.LogException(ex, "addPlaneDetailsAdmin", "AddPlaneAdminBtnOkay_Click");
                //Show Error message on the screen
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
