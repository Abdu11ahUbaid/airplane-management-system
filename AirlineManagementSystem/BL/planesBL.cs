using AirlineManagementSystem.Exception_Handling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem.BL
{
    internal class planesBL
    {

        private static planesBL instance;

        public static planesBL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new planesBL();
                }
                return instance;
            }
        }

        private string planeName;
        private string planeType;
        private decimal ticketPrice;
        private DateTime arrivalTime;
        private DateTime departureTime;
        private string departureCity; 
        private string arrivalCity;
        private int selectedPlaneID;

        public string PlaneName { get => planeName; set => planeName = value; }
        public string PlaneType { get => planeType; set => planeType = value; }
        public decimal TicketPrice { get => ticketPrice; set => ticketPrice = value; }
        public DateTime ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }

        public string DepartureCity { get => departureCity; set => departureCity = value; }
        public string ArrivalCity { get => arrivalCity; set => arrivalCity = value; }

        public int SelectedPlaneID { get => selectedPlaneID; set => selectedPlaneID = value; }



        public static int GetCityID(string cityName)
        {
            int cityID = -1; // Default value if city is not found

            try
            {
                var con = configuration.getInstance().getConnection();

                // Write an SQL query to retrieve the CityID based on the CityName
                string selectCityIDQuery = "SELECT CityID FROM Cities WHERE CityName = @CityName";

                // Execute the query
                using (SqlCommand command = new SqlCommand(selectCityIDQuery, con))
                {
                    command.Parameters.AddWithValue("@CityName", cityName);

                    // Retrieve the CityID
                    object result = command.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null)
                    {
                        cityID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                //LogException function call to write/log exception into database
                exceptionHandling.LogException(ex, "planesBL", "GetCityID");
                MessageBox.Show("Error in GetCityID: " + ex.Message);
            }

            return cityID;
        }




    }
}
