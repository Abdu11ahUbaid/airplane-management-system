namespace AirlineManagementSystem.Views
{
    partial class customerManagementAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerManagementAdmin));
            this.SearchCustomerAdmin = new System.Windows.Forms.TextBox();
            this.customerGridAdmin = new System.Windows.Forms.DataGridView();
            this.customerSearch = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchCustomerAdmin
            // 
            this.SearchCustomerAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchCustomerAdmin.Location = new System.Drawing.Point(184, 35);
            this.SearchCustomerAdmin.Name = "SearchCustomerAdmin";
            this.SearchCustomerAdmin.Size = new System.Drawing.Size(335, 22);
            this.SearchCustomerAdmin.TabIndex = 6;
            // 
            // customerGridAdmin
            // 
            this.customerGridAdmin.AllowUserToAddRows = false;
            this.customerGridAdmin.AllowUserToDeleteRows = false;
            this.customerGridAdmin.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.customerGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridAdmin.Location = new System.Drawing.Point(55, 85);
            this.customerGridAdmin.Name = "customerGridAdmin";
            this.customerGridAdmin.ReadOnly = true;
            this.customerGridAdmin.RowHeadersWidth = 51;
            this.customerGridAdmin.RowTemplate.Height = 24;
            this.customerGridAdmin.Size = new System.Drawing.Size(619, 346);
            this.customerGridAdmin.TabIndex = 4;
            this.customerGridAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridAdmin_CellContentClick);
            // 
            // customerSearch
            // 
            this.customerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.customerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerSearch.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearch.ForeColor = System.Drawing.Color.White;
            this.customerSearch.Location = new System.Drawing.Point(540, 28);
            this.customerSearch.Name = "customerSearch";
            this.customerSearch.Size = new System.Drawing.Size(75, 33);
            this.customerSearch.TabIndex = 7;
            this.customerSearch.Text = "Search";
            this.customerSearch.UseVisualStyleBackColor = false;
            this.customerSearch.Click += new System.EventHandler(this.customerSearch_Click);
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.Color.White;
            this.showAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showAll.BackgroundImage")));
            this.showAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAll.FlatAppearance.BorderSize = 0;
            this.showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll.Location = new System.Drawing.Point(89, 28);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(52, 51);
            this.showAll.TabIndex = 8;
            this.showAll.Text = " ";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // customerManagementAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.customerSearch);
            this.Controls.Add(this.SearchCustomerAdmin);
            this.Controls.Add(this.customerGridAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerManagementAdmin";
            this.Text = "customerManagementAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchCustomerAdmin;
        private System.Windows.Forms.DataGridView customerGridAdmin;
        private System.Windows.Forms.Button customerSearch;
        private System.Windows.Forms.Button showAll;
    }
}