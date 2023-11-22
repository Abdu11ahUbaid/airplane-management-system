using AirlineManagementSystem.BL;
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

namespace AirlineManagementSystem.Views
{
    public partial class UpdatePLaneDetailsAdmin : Form
    {
        public UpdatePLaneDetailsAdmin()
        {
            InitializeComponent();

        }

        private void AddPlaneAdminBtnOkay_Click(object sender, EventArgs e)
        {
             
            // Capture the data from the form
            string updatedPlaneName = updatedPlaneNameTextBox.Text;
            string updatedPlaneType = updatedPlaneTypeTextBox.Text;
            decimal updatedTicketPrice = decimal.Parse(updatedTicketPriceTextBox.Text);
            DateTime updatedArrivalTime = updatedArrivalTimeDateTimePicker.Value;
            DateTime updatedDepartureTime = updatedDepartureTimeDateTimePicker.Value;
            int updatedDepartureCityID = planesBL.GetCityID(departureCityComboBox.SelectedItem.ToString()); 
            int updatedArrivalCityID = planesBL.GetCityID(arrivalCityComboBox.SelectedItem.ToString()); 

            Console.WriteLine($"DepartureCityID: {updatedDepartureCityID}, ArrivalCityID: {updatedArrivalCityID}");
            try
            {
                var con = configuration.getInstance().getConnection();

                // Begin a transaction for atomicity
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Write an SQL UPDATE statement to modify an existing record in the Planes table
                        string updatePlaneQuery = "UPDATE Planes " +
                                                  "SET PlaneName = @UpdatedPlaneName, " +
                                                  "    PlaneType = @UpdatedPlaneType, " +
                                                  "    UpdatedAt = GETDATE() " +
                                                  "WHERE PlaneID = @PlaneID";

                        // Execute the update query
                        using (SqlCommand command = new SqlCommand(updatePlaneQuery, con, transaction))
                        {
                            command.Parameters.AddWithValue("@UpdatedPlaneName", updatedPlaneName);
                            command.Parameters.AddWithValue("@UpdatedPlaneType", updatedPlaneType);
                            command.Parameters.AddWithValue("@PlaneID", planesBL.Instance.SelectedPlaneID); // Assuming you have the PlaneID of the selected record

                            // Execute the query
                            command.ExecuteNonQuery();
                        }

                        // Write an SQL UPDATE statement to modify an existing record in the FlightRoutes table
                        string updateFlightRouteQuery = "UPDATE FlightRoutes " +
                                                        "SET DepartureCityID = @UpdatedDepartureCityID, " +
                                                        "    ArrivalCityID = @UpdatedArrivalCityID, " +
                                                        "    DepartureTime = @UpdatedDepartureTime, " +
                                                        "    ArrivalTime = @UpdatedArrivalTime, " +
                                                        "    UpdatedAt = GETDATE() " +
                                                        "WHERE PlaneID = @PlaneID";

                        // Execute the update query for FlightRoutes
                        using (SqlCommand command = new SqlCommand(updateFlightRouteQuery, con, transaction))
                        {
                            command.Parameters.AddWithValue("@UpdatedDepartureCityID", updatedDepartureCityID);
                            command.Parameters.AddWithValue("@UpdatedArrivalCityID", updatedArrivalCityID);
                            command.Parameters.AddWithValue("@UpdatedDepartureTime", updatedDepartureTime);
                            command.Parameters.AddWithValue("@UpdatedArrivalTime", updatedArrivalTime);
                            command.Parameters.AddWithValue("@PlaneID", planesBL.Instance.SelectedPlaneID); // Assuming you have the PlaneID of the selected record

                            // Execute the query
                            command.ExecuteNonQuery();
                        }

                        // Optionally, update data in other related tables (e.g., PlanePrices)
                        string updatePlanePriceQuery = "UPDATE PlanePrices " +
                                                       "SET TicketPrice = @UpdatedTicketPrice, " +
                                                       "    UpdatedAt = GETDATE() " +
                                                       "WHERE PlaneID = @PlaneID";

                        // Execute the update query for PlanePrices
                        using (SqlCommand command = new SqlCommand(updatePlanePriceQuery, con, transaction))
                        {
                            command.Parameters.AddWithValue("@UpdatedTicketPrice", updatedTicketPrice);
                            command.Parameters.AddWithValue("@PlaneID", planesBL.Instance.SelectedPlaneID); // Assuming you have the PlaneID of the selected record

                            // Execute the query
                            command.ExecuteNonQuery();
                        }

                        // Commit the transaction if all operations are successful
                        transaction.Commit();

                        // Log the selected PlaneID after the transaction is committed
                        Console.WriteLine($"Selected PlaneID after update: {planesBL.Instance.SelectedPlaneID}");

                        MessageBox.Show("Plane record updated successfully.");
                        
                        this.Close();

                        // Refresh the DataGridView to reflect the changes
                        /*RefreshDataGridView();*/
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction in case of an exception
                        transaction.Rollback();

                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
    }
}
