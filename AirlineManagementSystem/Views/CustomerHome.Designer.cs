﻿namespace AirlineManagementSystem.Views
{
    partial class CustomerHome
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
            this.ticketsHistoryGridCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsHistoryGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsHistoryGridCustomer
            // 
            this.ticketsHistoryGridCustomer.AllowUserToAddRows = false;
            this.ticketsHistoryGridCustomer.AllowUserToDeleteRows = false;
            this.ticketsHistoryGridCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ticketsHistoryGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsHistoryGridCustomer.Location = new System.Drawing.Point(80, 69);
            this.ticketsHistoryGridCustomer.Name = "ticketsHistoryGridCustomer";
            this.ticketsHistoryGridCustomer.ReadOnly = true;
            this.ticketsHistoryGridCustomer.RowHeadersWidth = 51;
            this.ticketsHistoryGridCustomer.RowTemplate.Height = 24;
            this.ticketsHistoryGridCustomer.Size = new System.Drawing.Size(623, 322);
            this.ticketsHistoryGridCustomer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets History";
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketsHistoryGridCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerHome";
            this.Text = "CustomerHome";
            ((System.ComponentModel.ISupportInitialize)(this.ticketsHistoryGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketsHistoryGridCustomer;
        private System.Windows.Forms.Label label1;
    }
}