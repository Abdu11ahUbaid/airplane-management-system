namespace AirlineManagementSystem.Views
{
    partial class ticketManagementAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticketManagementAdmin));
            this.showAll = new System.Windows.Forms.Button();
            this.ticketsSearch = new System.Windows.Forms.Button();
            this.TicketsGridAdmin = new System.Windows.Forms.DataGridView();
            this.SearchTicketsAdmin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsGridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.Color.White;
            this.showAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showAll.BackgroundImage")));
            this.showAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAll.FlatAppearance.BorderSize = 0;
            this.showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll.Location = new System.Drawing.Point(119, 51);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(52, 51);
            this.showAll.TabIndex = 12;
            this.showAll.Text = " ";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // ticketsSearch
            // 
            this.ticketsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ticketsSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketsSearch.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsSearch.ForeColor = System.Drawing.Color.White;
            this.ticketsSearch.Location = new System.Drawing.Point(564, 51);
            this.ticketsSearch.Name = "ticketsSearch";
            this.ticketsSearch.Size = new System.Drawing.Size(75, 33);
            this.ticketsSearch.TabIndex = 11;
            this.ticketsSearch.Text = "Search";
            this.ticketsSearch.UseVisualStyleBackColor = false;
            this.ticketsSearch.Click += new System.EventHandler(this.ticketsSearch_Click);
            // 
            // TicketsGridAdmin
            // 
            this.TicketsGridAdmin.AllowUserToAddRows = false;
            this.TicketsGridAdmin.AllowUserToDeleteRows = false;
            this.TicketsGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsGridAdmin.Location = new System.Drawing.Point(85, 108);
            this.TicketsGridAdmin.Name = "TicketsGridAdmin";
            this.TicketsGridAdmin.ReadOnly = true;
            this.TicketsGridAdmin.RowHeadersWidth = 51;
            this.TicketsGridAdmin.RowTemplate.Height = 24;
            this.TicketsGridAdmin.Size = new System.Drawing.Size(600, 346);
            this.TicketsGridAdmin.TabIndex = 9;
            // 
            // SearchTicketsAdmin
            // 
            this.SearchTicketsAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTicketsAdmin.Location = new System.Drawing.Point(209, 58);
            this.SearchTicketsAdmin.Name = "SearchTicketsAdmin";
            this.SearchTicketsAdmin.Size = new System.Drawing.Size(335, 22);
            this.SearchTicketsAdmin.TabIndex = 10;
            // 
            // ticketManagementAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 504);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.ticketsSearch);
            this.Controls.Add(this.SearchTicketsAdmin);
            this.Controls.Add(this.TicketsGridAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ticketManagementAdmin";
            this.Text = "ticketManagementAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.TicketsGridAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Button ticketsSearch;
        private System.Windows.Forms.DataGridView TicketsGridAdmin;
        private System.Windows.Forms.TextBox SearchTicketsAdmin;
    }
}