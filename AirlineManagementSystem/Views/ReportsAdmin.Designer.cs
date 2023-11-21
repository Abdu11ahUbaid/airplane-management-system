namespace AirlineManagementSystem.Views
{
    partial class ReportsAdmin
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
            this.ReportComboBox = new System.Windows.Forms.ComboBox();
            this.SetTicketPricesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportComboBox
            // 
            this.ReportComboBox.FormattingEnabled = true;
            this.ReportComboBox.Items.AddRange(new object[] {
            "Plane Records",
            "Customer Records"});
            this.ReportComboBox.Location = new System.Drawing.Point(230, 118);
            this.ReportComboBox.Name = "ReportComboBox";
            this.ReportComboBox.Size = new System.Drawing.Size(294, 24);
            this.ReportComboBox.TabIndex = 0;
            // 
            // SetTicketPricesbtn
            // 
            this.SetTicketPricesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SetTicketPricesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTicketPricesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetTicketPricesbtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTicketPricesbtn.ForeColor = System.Drawing.Color.White;
            this.SetTicketPricesbtn.Location = new System.Drawing.Point(279, 157);
            this.SetTicketPricesbtn.Name = "SetTicketPricesbtn";
            this.SetTicketPricesbtn.Size = new System.Drawing.Size(199, 44);
            this.SetTicketPricesbtn.TabIndex = 6;
            this.SetTicketPricesbtn.Text = "Generate Report";
            this.SetTicketPricesbtn.UseVisualStyleBackColor = false;
            this.SetTicketPricesbtn.Click += new System.EventHandler(this.SetTicketPricesbtn_Click);
            // 
            // ReportsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetTicketPricesbtn);
            this.Controls.Add(this.ReportComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsAdmin";
            this.Text = "ReportsAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ReportComboBox;
        private System.Windows.Forms.Button SetTicketPricesbtn;
    }
}