using AirlineManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem.Views
{
    public partial class CustomerDaashboard : Form
    {
        public CustomerDaashboard()
        {
            InitializeComponent();
            // Capture the Username/Name of the Customer by using it Email at the login Time
            //string loggedInEmail = customerBL.Instance.LoggedInEmail;
            //string username = customerBL.GetUsernameFromEmail(loggedInEmail);

            // Now 'username' contains the username of the logged-in customer
            //nameCustomerLabel.Text = username;
            loadform(new CustomerHome());

        }

        private void CloseAppCustomerbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutCustomerbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();

            login.Show();
        }

        public void loadform(object Form)
        {
            if (this.PanelCustomerMain.Controls.Count > 0)
                this.PanelCustomerMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelCustomerMain.Controls.Add(f);
            this.PanelCustomerMain.Tag = f;
            f.Show();
        }

        private void HomeCustomer_Click(object sender, EventArgs e)
        {
            loadform(new CustomerHome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new SearchFlightsCustomerForm());
        }

        

        private void nameCustomerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
