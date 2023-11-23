using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineManagementSystem.BL;

namespace AirlineManagementSystem.Views
{
    public partial class CustomerHome : Form
    {
        public CustomerHome()
        {
            InitializeComponent();
            int customerID = customerBL.GetCustomerIDFromDatabase(customerBL.Instance.LoggedInEmail);
            LoadTicketHistory(customerID);
        }

        private void LoadTicketHistory(int customerID)
        {
            DataTable ticketHistory = ticketsBL.GetTicketHistory(customerID);
            ticketsHistoryGridCustomer.DataSource = ticketHistory;
        }
    }
}
