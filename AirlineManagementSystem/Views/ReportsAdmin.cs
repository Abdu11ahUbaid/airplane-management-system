using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using AirlineManagementSystem.BL;

namespace AirlineManagementSystem.Views
{
    public partial class ReportsAdmin : Form
    {
        public ReportsAdmin()
        {
            InitializeComponent();
        }

        private void SetTicketPricesbtn_Click(object sender, EventArgs e)
        {
            string selectedReportType = ReportComboBox.SelectedItem.ToString();

            // Get the data for the selected report type
            DataTable reportData = adminBL.GetReportData(selectedReportType);

            // Save the data to an Excel file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Report File";
            saveFileDialog.FileName = $"{selectedReportType}_Report_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                adminBL.SaveReportToExcel(reportData, saveFileDialog.FileName);
                MessageBox.Show("Report generated successfully.");
            }
        }

    }
}
