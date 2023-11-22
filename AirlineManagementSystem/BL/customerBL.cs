using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem.BL
{
    internal class customerBL
    {
        public bool ValidateCustomerLogin(string username, string password)
        {
            // Implement logic to validate customer login credentials
            // Return true if credentials are valid, otherwise false
            // You may want to hash the password and compare it with the stored hash
            return false;
        }

        public bool RegisterCustomer(string name, string email, string phone, string address, string password)
        {
            // Implement logic to register a new customer
            // Return true if registration is successful, otherwise false
            // You should hash the password before storing it in the database
            return true;
        }



        private string loggedInEmail;
        public string LoggedInEmail { get => loggedInEmail; set => loggedInEmail = value; }

        private static customerBL instance;

        public static customerBL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new customerBL();
                }
                return instance;
            }
        }

        // Add other methods for customer-related operations
    }
}
