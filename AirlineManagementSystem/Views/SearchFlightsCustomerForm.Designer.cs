namespace AirlineManagementSystem.Views
{
    partial class SearchFlightsCustomerForm
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
            this.PlanesSearchGridCustomer = new System.Windows.Forms.DataGridView();
            this.ArrivalcomboBox = new System.Windows.Forms.ComboBox();
            this.DeparturecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlanesSearchGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanesSearchGridCustomer
            // 
            this.PlanesSearchGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanesSearchGridCustomer.Location = new System.Drawing.Point(101, 113);
            this.PlanesSearchGridCustomer.Name = "PlanesSearchGridCustomer";
            this.PlanesSearchGridCustomer.RowHeadersWidth = 51;
            this.PlanesSearchGridCustomer.RowTemplate.Height = 24;
            this.PlanesSearchGridCustomer.Size = new System.Drawing.Size(595, 316);
            this.PlanesSearchGridCustomer.TabIndex = 2;
            // 
            // ArrivalcomboBox
            // 
            this.ArrivalcomboBox.FormattingEnabled = true;
            this.ArrivalcomboBox.Items.AddRange(new object[] {
            "Lahore",
            "Karachi",
            "Attock",
            "Abbottabad",
            "Bahawalpur",
            "Bahawalnagar",
            "Sargodha",
            "Chitral",
            "Giglit",
            "Skardu",
            "Faisalabad",
            "Islamabad",
            "Hyderabad"});
            this.ArrivalcomboBox.Location = new System.Drawing.Point(418, 53);
            this.ArrivalcomboBox.Name = "ArrivalcomboBox";
            this.ArrivalcomboBox.Size = new System.Drawing.Size(252, 24);
            this.ArrivalcomboBox.TabIndex = 7;
            this.ArrivalcomboBox.Text = "To...";
            this.ArrivalcomboBox.SelectedIndexChanged += new System.EventHandler(this.ArrivalcomboBox_SelectedIndexChanged);
            // 
            // DeparturecomboBox
            // 
            this.DeparturecomboBox.FormattingEnabled = true;
            this.DeparturecomboBox.Items.AddRange(new object[] {
            "Lahore",
            "Karachi",
            "Attock",
            "Abbottabad",
            "Bahawalpur",
            "Bahawalnagar",
            "Sargodha",
            "Chitral",
            "Giglit",
            "Skardu",
            "Faisalabad",
            "Islamabad",
            "Hyderabad"});
            this.DeparturecomboBox.Location = new System.Drawing.Point(116, 53);
            this.DeparturecomboBox.Name = "DeparturecomboBox";
            this.DeparturecomboBox.Size = new System.Drawing.Size(252, 24);
            this.DeparturecomboBox.TabIndex = 8;
            this.DeparturecomboBox.Text = "From...";
            this.DeparturecomboBox.SelectedIndexChanged += new System.EventHandler(this.DeparturecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select City:";
            // 
            // BookTicket
            // 
            this.BookTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BookTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookTicket.ForeColor = System.Drawing.Color.White;
            this.BookTicket.Location = new System.Drawing.Point(358, 84);
            this.BookTicket.Name = "BookTicket";
            this.BookTicket.Size = new System.Drawing.Size(75, 23);
            this.BookTicket.TabIndex = 10;
            this.BookTicket.Text = "Book";
            this.BookTicket.UseVisualStyleBackColor = false;
            this.BookTicket.Click += new System.EventHandler(this.BookTicket_Click);
            // 
            // SearchFlightsCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrivalcomboBox);
            this.Controls.Add(this.DeparturecomboBox);
            this.Controls.Add(this.PlanesSearchGridCustomer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchFlightsCustomerForm";
            this.Text = "SearchFlightsCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.PlanesSearchGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PlanesSearchGridCustomer;
        private System.Windows.Forms.ComboBox ArrivalcomboBox;
        private System.Windows.Forms.ComboBox DeparturecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BookTicket;
    }
}