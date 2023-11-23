namespace AirlineManagementSystem.Views
{
    partial class revenueAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.PlaneRevenueSearch = new System.Windows.Forms.TextBox();
            this.TotalRevenueAdmin = new System.Windows.Forms.Button();
            this.TotalRevenue = new System.Windows.Forms.Label();
            this.SearchPlaneNameToSeeRevenue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.AllowUserToAddRows = false;
            this.dataGridViewRevenue.AllowUserToDeleteRows = false;
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(66, 125);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.ReadOnly = true;
            this.dataGridViewRevenue.RowHeadersWidth = 51;
            this.dataGridViewRevenue.RowTemplate.Height = 24;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(470, 264);
            this.dataGridViewRevenue.TabIndex = 0;
            // 
            // PlaneRevenueSearch
            // 
            this.PlaneRevenueSearch.Location = new System.Drawing.Point(91, 86);
            this.PlaneRevenueSearch.Name = "PlaneRevenueSearch";
            this.PlaneRevenueSearch.Size = new System.Drawing.Size(331, 22);
            this.PlaneRevenueSearch.TabIndex = 1;
            this.PlaneRevenueSearch.Text = "Enter Plane name to see Revenue ";
            // 
            // TotalRevenueAdmin
            // 
            this.TotalRevenueAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalRevenueAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TotalRevenueAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalRevenueAdmin.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRevenueAdmin.ForeColor = System.Drawing.Color.White;
            this.TotalRevenueAdmin.Location = new System.Drawing.Point(622, 161);
            this.TotalRevenueAdmin.Name = "TotalRevenueAdmin";
            this.TotalRevenueAdmin.Size = new System.Drawing.Size(85, 60);
            this.TotalRevenueAdmin.TabIndex = 2;
            this.TotalRevenueAdmin.Text = "Total Revenue";
            this.TotalRevenueAdmin.UseVisualStyleBackColor = false;
            // 
            // TotalRevenue
            // 
            this.TotalRevenue.AutoSize = true;
            this.TotalRevenue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRevenue.Location = new System.Drawing.Point(632, 224);
            this.TotalRevenue.Name = "TotalRevenue";
            this.TotalRevenue.Size = new System.Drawing.Size(65, 28);
            this.TotalRevenue.TabIndex = 3;
            this.TotalRevenue.Text = "00.00";
            // 
            // SearchPlaneNameToSeeRevenue
            // 
            this.SearchPlaneNameToSeeRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SearchPlaneNameToSeeRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPlaneNameToSeeRevenue.FlatAppearance.BorderSize = 0;
            this.SearchPlaneNameToSeeRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPlaneNameToSeeRevenue.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPlaneNameToSeeRevenue.ForeColor = System.Drawing.Color.White;
            this.SearchPlaneNameToSeeRevenue.Location = new System.Drawing.Point(437, 80);
            this.SearchPlaneNameToSeeRevenue.Name = "SearchPlaneNameToSeeRevenue";
            this.SearchPlaneNameToSeeRevenue.Size = new System.Drawing.Size(75, 34);
            this.SearchPlaneNameToSeeRevenue.TabIndex = 4;
            this.SearchPlaneNameToSeeRevenue.Text = "Search";
            this.SearchPlaneNameToSeeRevenue.UseVisualStyleBackColor = false;
            // 
            // revenueAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchPlaneNameToSeeRevenue);
            this.Controls.Add(this.TotalRevenue);
            this.Controls.Add(this.TotalRevenueAdmin);
            this.Controls.Add(this.PlaneRevenueSearch);
            this.Controls.Add(this.dataGridViewRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "revenueAdmin";
            this.Text = "revenueAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private System.Windows.Forms.TextBox PlaneRevenueSearch;
        private System.Windows.Forms.Button TotalRevenueAdmin;
        private System.Windows.Forms.Label TotalRevenue;
        private System.Windows.Forms.Button SearchPlaneNameToSeeRevenue;
    }
}