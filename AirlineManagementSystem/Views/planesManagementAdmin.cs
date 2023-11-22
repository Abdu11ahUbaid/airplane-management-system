using AirlineManagementSystem.BL;
using AirlineManagementSystem.DL;
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
    public partial class planesManagementAdmin : Form
    {
        public planesManagementAdmin()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void addPlaneBtn_Click(object sender, EventArgs e)
        {
            addPlaneDetailsAdmin addPlaneDetailsAdmin = new addPlaneDetailsAdmin();
            addPlaneDetailsAdmin.ShowDialog();
        }
        // Helper method to refresh the DataGridView
        public void RefreshDataGridView()
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve the added planes and related records
                string selectPlanesQuery = "SELECT PlaneName, PlaneType, TicketPrice, DepartureTime, ArrivalTime, " +
                                   "DepartureCity.CityName AS DepartureCity, ArrivalCity.CityName AS ArrivalCity " +
                                   "FROM Planes " +
                                   "JOIN FlightRoutes ON Planes.PlaneID = FlightRoutes.PlaneID " +
                                   "JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID " +
                                   "JOIN Cities AS DepartureCity ON FlightRoutes.DepartureCityID = DepartureCity.CityID " +
                                   "JOIN Cities AS ArrivalCity ON FlightRoutes.ArrivalCityID = ArrivalCity.CityID " +
                                   "WHERE Planes.IsActive = 1";

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectPlanesQuery, con))
                {
                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the DataSource for the DataGridView
                planesGridAdmin.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during data refresh: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void PlaneUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdatePLaneDetailsAdmin updatePLaneDetails = new UpdatePLaneDetailsAdmin();
            updatePLaneDetails.ShowDialog();
        }

        private void planesGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Define a variable to store the selected PlaneID
       /* planesBL planes = new planesBL();*/

        private void planesGridAdmin_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*// Check if there's a selected row
            if (planesGridAdmin.SelectedCells.Count > 0)
            {
                // Retrieve the value from the selected row's "PlaneName" column
                string selectedPlaneName = planesGridAdmin.SelectedRows[0].Cells["PlaneName"].Value.ToString();

                // Use a method to get the PlaneID based on the selected plane name
                planes.SelectedPlaneID = GetPlaneIDFromName(selectedPlaneName);
            }*/
        }

        // Define a variable to store the selected PlaneID

        // Example method to retrieve PlaneID from the database based on PlaneName
        private int GetPlaneIDFromName(string planeName)
        {
            int planeID = -1; // Default value or error indicator

            try
            {
                var con = configuration.getInstance().getConnection();
                string selectPlaneIDQuery = "SELECT PlaneID FROM Planes WHERE PlaneName = @PlaneName";

                using (SqlCommand command = new SqlCommand(selectPlaneIDQuery, con))
                {
                    command.Parameters.AddWithValue("@PlaneName", planeName);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        planeID = Convert.ToInt32(result);

                        // Log the retrieved PlaneID
                        Console.WriteLine($"Retrieved PlaneID: {planeID}");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return planeID;
        }

        private void planesGridAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "PlaneName" column
            if (e.ColumnIndex == planesGridAdmin.Columns["PlaneName"].Index && e.RowIndex >= 0)
            {
                // Retrieve the value from the clicked cell's "PlaneName" column
                string selectedPlaneName = planesGridAdmin.Rows[e.RowIndex].Cells["PlaneName"].Value.ToString();

                // Use a method to get the PlaneID based on the selected plane name
                planesBL.Instance.SelectedPlaneID = GetPlaneIDFromName(selectedPlaneName);

                // Log the selected PlaneID
                Console.WriteLine($"Selected PlaneID: {planesBL.Instance.SelectedPlaneID}");
            }
        }

        private void deletePlanebtn_Click(object sender, EventArgs e)
        {
            // Assuming you have controls on your form to capture selected data
            string selectedPlaneName = planesGridAdmin.SelectedCells[0].Value.ToString();
            int selectedPlaneID = GetPlaneIDFromName(selectedPlaneName); // Assuming you have the GetPlaneIDFromName method

            try
            {
                var con = configuration.getInstance().getConnection();

                // Write an SQL UPDATE statement to "soft delete" the record by setting IsActive to false
                string deletePlaneQuery = "UPDATE Planes " +
                                          "SET IsActive = 0, " +
                                          "    UpdatedAt = GETDATE() " +
                                          "WHERE PlaneID = @PlaneID";

                // Execute the delete query
                using (SqlCommand command = new SqlCommand(deletePlaneQuery, con))
                {
                    command.Parameters.AddWithValue("@PlaneID", selectedPlaneID);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Plane record deleted successfully from the grid.");

                        // Refresh the DataGridView to reflect the changes
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the plane record.");
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
