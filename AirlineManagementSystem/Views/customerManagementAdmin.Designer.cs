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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchCustomerAdmin = new System.Windows.Forms.TextBox();
            this.customerGridAdmin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // SearchCustomerAdmin
            // 
            this.SearchCustomerAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchCustomerAdmin.Location = new System.Drawing.Point(214, 30);
            this.SearchCustomerAdmin.Name = "SearchCustomerAdmin";
            this.SearchCustomerAdmin.Size = new System.Drawing.Size(434, 22);
            this.SearchCustomerAdmin.TabIndex = 6;
            // 
            // customerGridAdmin
            // 
            this.customerGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridAdmin.Location = new System.Drawing.Point(55, 85);
            this.customerGridAdmin.Name = "customerGridAdmin";
            this.customerGridAdmin.RowHeadersWidth = 51;
            this.customerGridAdmin.RowTemplate.Height = 24;
            this.customerGridAdmin.Size = new System.Drawing.Size(690, 346);
            this.customerGridAdmin.TabIndex = 4;
            this.customerGridAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridAdmin_CellContentClick);
            // 
            // customerManagementAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchCustomerAdmin;
        private System.Windows.Forms.DataGridView customerGridAdmin;
    }
}