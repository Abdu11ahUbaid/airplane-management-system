namespace AirlineManagementSystem.Views
{
    partial class TicketsCustomerForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchPlanetobookTicketsbtn = new System.Windows.Forms.Button();
            this.AvailableTicketsGridCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableTicketsGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter plane name to book tickets";
            // 
            // SearchPlanetobookTicketsbtn
            // 
            this.SearchPlanetobookTicketsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SearchPlanetobookTicketsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPlanetobookTicketsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPlanetobookTicketsbtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPlanetobookTicketsbtn.ForeColor = System.Drawing.Color.White;
            this.SearchPlanetobookTicketsbtn.Location = new System.Drawing.Point(311, 70);
            this.SearchPlanetobookTicketsbtn.Name = "SearchPlanetobookTicketsbtn";
            this.SearchPlanetobookTicketsbtn.Size = new System.Drawing.Size(95, 39);
            this.SearchPlanetobookTicketsbtn.TabIndex = 1;
            this.SearchPlanetobookTicketsbtn.Text = "Search";
            this.SearchPlanetobookTicketsbtn.UseVisualStyleBackColor = false;
            // 
            // AvailableTicketsGridCustomer
            // 
            this.AvailableTicketsGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableTicketsGridCustomer.Location = new System.Drawing.Point(47, 159);
            this.AvailableTicketsGridCustomer.Name = "AvailableTicketsGridCustomer";
            this.AvailableTicketsGridCustomer.RowHeadersWidth = 51;
            this.AvailableTicketsGridCustomer.RowTemplate.Height = 24;
            this.AvailableTicketsGridCustomer.Size = new System.Drawing.Size(669, 279);
            this.AvailableTicketsGridCustomer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Ticket";
            // 
            // TicketsCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailableTicketsGridCustomer);
            this.Controls.Add(this.SearchPlanetobookTicketsbtn);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketsCustomerForm";
            this.Text = "TicketsCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.AvailableTicketsGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchPlanetobookTicketsbtn;
        private System.Windows.Forms.DataGridView AvailableTicketsGridCustomer;
        private System.Windows.Forms.Label label1;
    }
}