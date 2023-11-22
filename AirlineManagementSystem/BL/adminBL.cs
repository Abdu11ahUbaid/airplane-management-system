using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem.BL
{
    internal class adminBL
    {
        public bool ValidateAdminLogin(string username, string password)
        {
            // Implement logic to validate admin login credentials
            // Return true if credentials are valid, otherwise false
            // You may want to hash the password and compare it with the stored hash
            return false;
        }

        public static DataTable GetReportData(string reportType)
        {
           
            if (reportType == "Plane Records")
            {
                return GetPlaneRecords();
            }
            else if (reportType == "Customer Records")
            {
                return GetCustomerRecords();
            }

            return null;
        }

        private static DataTable GetPlaneRecords()
        {
            DataTable planeRecords = new DataTable();

            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve plane records with related information
                string selectPlaneRecordsQuery = "SELECT " +
                                                 "Planes.PlaneName, " +
                                                 "Planes.PlaneType, " +
                                                 "PlanePrices.TicketPrice, " +
                                                 "DepartureCity.CityName AS DepartureCity, " +
                                                 "ArrivalCity.CityName AS ArrivalCity, " +
                                                 "FlightRoutes.DepartureTime, " +
                                                 "FlightRoutes.ArrivalTime " +
                                                 "FROM Planes " +
                                                 "JOIN PlanePrices ON Planes.PlaneID = PlanePrices.PlaneID " +
                                                 "JOIN FlightRoutes ON Planes.PlaneID = FlightRoutes.PlaneID " +
                                                 "JOIN Cities AS DepartureCity ON FlightRoutes.DepartureCityID = DepartureCity.CityID " +
                                                 "JOIN Cities AS ArrivalCity ON FlightRoutes.ArrivalCityID = ArrivalCity.CityID " +
                                                 "WHERE Planes.IsActive = 1";

                using (SqlCommand command = new SqlCommand(selectPlaneRecordsQuery, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(planeRecords);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching plane records: " + ex.Message);
            }

            return planeRecords;
        }

        private static DataTable GetCustomerRecords()
        {
            DataTable customerRecords = new DataTable();

            try
            {
                var con = configuration.getInstance().getConnection();

                // Write a SQL query to retrieve customer records with related information
                string selectCustomerRecordsQuery = "SELECT " +
                                                    "Customers.Name AS CustomerName, " +
                                                    "Customers.Email, " +
                                                    "Customers.Phone, " +
                                                    "Tickets.PurchaseDate, " +
                                                    "Tickets.Status " +
                                                    "FROM Customers " +
                                                    "JOIN Tickets ON Customers.CustomerID = Tickets.CustomerID";

                using (SqlCommand command = new SqlCommand(selectCustomerRecordsQuery, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(customerRecords);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching customer records: " + ex.Message);
            }

            return customerRecords;
        }

        public static void SaveReportToExcel(DataTable data, string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Create a new worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Report");

                // Load the data into the worksheet
                worksheet.Cells.LoadFromDataTable(data, true);

                // Save the Excel package
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }
        }
    }
}
