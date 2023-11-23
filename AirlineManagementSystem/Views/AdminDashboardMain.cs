using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            loadform(new HomeAdmin());
        }

        private void PlaneManagementAdminbtn_Click_1(object sender, EventArgs e)
        {
            loadform(new planesManagementAdmin());
        }

        private void customerManagementBtn_Click_1(object sender, EventArgs e)
        {
            loadform(new customerManagementAdmin());
        }

        

        private void ReportsAdminBtn_Click_1(object sender, EventArgs e)
        {
            loadform(new ReportsAdmin());
        }

        private void signOutAdminbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();

            login.Show();
        }

        private void CloseAppAdminbtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
            
        }

        private void TicketsManagementAdmin_Click(object sender, EventArgs e)
        {
            loadform(new ticketManagementAdmin());
        }

        private void RevenueAdmin_Click(object sender, EventArgs e)
        {
            loadform(new revenueAdmin());
        }
    }
}
