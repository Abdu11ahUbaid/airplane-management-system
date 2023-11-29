using System;
using System.Windows.Forms;

namespace AirlineManagementSystem.Views
{
    public partial class AdminDashboardMain : Form
    {
        public AdminDashboardMain()
        {
            InitializeComponent();
            loadform(new HomeAdmin());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Method to Load the child Forms into the Parent Panel
        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        
        private void AdminDashboardMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeaderMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeAdmin_Click_1(object sender, EventArgs e)
        {
            // Load The Home Form in the Parent Panel
            loadform(new HomeAdmin());
        }

        private void PlaneManagementAdminbtn_Click_1(object sender, EventArgs e)
        {
            // Load The Planes Management Form in the Parent Panel
            loadform(new planesManagementAdmin());
        }

        private void customerManagementBtn_Click_1(object sender, EventArgs e)
        {
            // Load The Customer Management Form in the Parent Panel
            loadform(new customerManagementAdmin());
        }

        

        private void ReportsAdminBtn_Click_1(object sender, EventArgs e)
        {
            // Load The Report Form in the Parent Panel
            loadform(new ReportsAdmin());
        }

        private void signOutAdminbtn_Click_1(object sender, EventArgs e)
        {
            // Sign Out/Closes the Admin account
            this.Close();
            // Creating the new Login form 
            frmLogin login = new frmLogin();
            // Display the Login screen
            login.Show();
        }

        private void CloseAppAdminbtn_Click_1(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
            
            
        }

        private void TicketsManagementAdmin_Click(object sender, EventArgs e)
        {
            // Load The TicketManagement Form in the Parent Panel
            loadform(new ticketManagementAdmin());
        }

        private void RevenueAdmin_Click(object sender, EventArgs e)
        {

            // Load The Revenue Form in the Parent Panel
            loadform(new revenueAdmin());
        }
    }
}
