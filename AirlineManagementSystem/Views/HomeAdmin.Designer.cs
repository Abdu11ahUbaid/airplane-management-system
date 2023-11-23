namespace AirlineManagementSystem.Views
{
    partial class HomeAdmin
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
            this.HomeGridAdmin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HomeGridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeGridAdmin
            // 
            this.HomeGridAdmin.AllowUserToAddRows = false;
            this.HomeGridAdmin.AllowUserToDeleteRows = false;
            this.HomeGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomeGridAdmin.Location = new System.Drawing.Point(54, 78);
            this.HomeGridAdmin.Name = "HomeGridAdmin";
            this.HomeGridAdmin.ReadOnly = true;
            this.HomeGridAdmin.RowHeadersWidth = 51;
            this.HomeGridAdmin.RowTemplate.Height = 24;
            this.HomeGridAdmin.Size = new System.Drawing.Size(690, 346);
            this.HomeGridAdmin.TabIndex = 0;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeGridAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeGridAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HomeGridAdmin;
    }
}