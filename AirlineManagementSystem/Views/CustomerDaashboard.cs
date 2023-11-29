using AirlineManagementSystem.BL;
using System;
using System.Windows.Forms;

namespace AirlineManagementSystem.Views
{
    public partial class CustomerDaashboard : Form
    {
        public CustomerDaashboard()
        {
            InitializeComponent();
            // Load the Home Screen
            loadform(new CustomerHome());

        }

        private void CloseAppCustomerbtn_Click(object sender, EventArgs e)
        {
            //Close application
            Application.Exit();
        }

        private void signOutCustomerbtn_Click(object sender, EventArgs e)
        {
            // Sign out/Close the Customer Interface
            this.Close();
            // Create  New Login Form
            frmLogin login = new frmLogin();
            // Show the Login Form
            login.Show();
        }

        // Method to load the child forms in the parent panel
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
            // Load Home screen/Form
            loadform(new CustomerHome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load the Search Flights Customer Form
            loadform(new SearchFlightsCustomerForm());
        }
    }
}
