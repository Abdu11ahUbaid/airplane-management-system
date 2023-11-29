namespace AirlineManagementSystem.Views
{
    partial class CustomerDaashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDaashboard));
            this.PanelCustomerMain = new System.Windows.Forms.Panel();
            this.PanelCustomerSide = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signOutCustomerbtn = new System.Windows.Forms.Button();
            this.HomeCustomer = new System.Windows.Forms.Button();
            this.PanelCustomerheader = new System.Windows.Forms.Panel();
            this.welcometxtlabelCustomer = new System.Windows.Forms.Label();
            this.CloseAppCustomerbtn = new System.Windows.Forms.Button();
            this.PanelCustomerSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelCustomerheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCustomerMain
            // 
            this.PanelCustomerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCustomerMain.Location = new System.Drawing.Point(200, 38);
            this.PanelCustomerMain.Name = "PanelCustomerMain";
            this.PanelCustomerMain.Size = new System.Drawing.Size(745, 520);
            this.PanelCustomerMain.TabIndex = 8;
            // 
            // PanelCustomerSide
            // 
            this.PanelCustomerSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.PanelCustomerSide.Controls.Add(this.button1);
            this.PanelCustomerSide.Controls.Add(this.pictureBox1);
            this.PanelCustomerSide.Controls.Add(this.signOutCustomerbtn);
            this.PanelCustomerSide.Controls.Add(this.HomeCustomer);
            this.PanelCustomerSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelCustomerSide.Location = new System.Drawing.Point(0, 38);
            this.PanelCustomerSide.Name = "PanelCustomerSide";
            this.PanelCustomerSide.Size = new System.Drawing.Size(200, 520);
            this.PanelCustomerSide.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Planes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signOutCustomerbtn
            // 
            this.signOutCustomerbtn.FlatAppearance.BorderSize = 0;
            this.signOutCustomerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutCustomerbtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutCustomerbtn.ForeColor = System.Drawing.Color.White;
            this.signOutCustomerbtn.Location = new System.Drawing.Point(0, 460);
            this.signOutCustomerbtn.Name = "signOutCustomerbtn";
            this.signOutCustomerbtn.Size = new System.Drawing.Size(200, 39);
            this.signOutCustomerbtn.TabIndex = 0;
            this.signOutCustomerbtn.Text = "Sign out";
            this.signOutCustomerbtn.UseVisualStyleBackColor = true;
            this.signOutCustomerbtn.Click += new System.EventHandler(this.signOutCustomerbtn_Click);
            // 
            // HomeCustomer
            // 
            this.HomeCustomer.FlatAppearance.BorderSize = 0;
            this.HomeCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeCustomer.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeCustomer.ForeColor = System.Drawing.Color.White;
            this.HomeCustomer.Location = new System.Drawing.Point(0, 123);
            this.HomeCustomer.Name = "HomeCustomer";
            this.HomeCustomer.Size = new System.Drawing.Size(200, 39);
            this.HomeCustomer.TabIndex = 0;
            this.HomeCustomer.Text = "Home";
            this.HomeCustomer.UseVisualStyleBackColor = true;
            this.HomeCustomer.Click += new System.EventHandler(this.HomeCustomer_Click);
            // 
            // PanelCustomerheader
            // 
            this.PanelCustomerheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.PanelCustomerheader.Controls.Add(this.welcometxtlabelCustomer);
            this.PanelCustomerheader.Controls.Add(this.CloseAppCustomerbtn);
            this.PanelCustomerheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCustomerheader.Location = new System.Drawing.Point(0, 0);
            this.PanelCustomerheader.Name = "PanelCustomerheader";
            this.PanelCustomerheader.Size = new System.Drawing.Size(945, 38);
            this.PanelCustomerheader.TabIndex = 7;
            // 
            // welcometxtlabelCustomer
            // 
            this.welcometxtlabelCustomer.AutoSize = true;
            this.welcometxtlabelCustomer.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometxtlabelCustomer.ForeColor = System.Drawing.Color.White;
            this.welcometxtlabelCustomer.Location = new System.Drawing.Point(437, 8);
            this.welcometxtlabelCustomer.Name = "welcometxtlabelCustomer";
            this.welcometxtlabelCustomer.Size = new System.Drawing.Size(84, 23);
            this.welcometxtlabelCustomer.TabIndex = 0;
            this.welcometxtlabelCustomer.Text = "Welcome";
            // 
            // CloseAppCustomerbtn
            // 
            this.CloseAppCustomerbtn.FlatAppearance.BorderSize = 0;
            this.CloseAppCustomerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppCustomerbtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAppCustomerbtn.ForeColor = System.Drawing.Color.White;
            this.CloseAppCustomerbtn.Location = new System.Drawing.Point(857, 0);
            this.CloseAppCustomerbtn.Name = "CloseAppCustomerbtn";
            this.CloseAppCustomerbtn.Size = new System.Drawing.Size(88, 39);
            this.CloseAppCustomerbtn.TabIndex = 0;
            this.CloseAppCustomerbtn.Text = "X close";
            this.CloseAppCustomerbtn.UseVisualStyleBackColor = true;
            this.CloseAppCustomerbtn.Click += new System.EventHandler(this.CloseAppCustomerbtn_Click);
            // 
            // CustomerDaashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 558);
            this.Controls.Add(this.PanelCustomerMain);
            this.Controls.Add(this.PanelCustomerSide);
            this.Controls.Add(this.PanelCustomerheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDaashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDaashboard";
            this.PanelCustomerSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelCustomerheader.ResumeLayout(false);
            this.PanelCustomerheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCustomerMain;
        private System.Windows.Forms.Panel PanelCustomerSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signOutCustomerbtn;
        private System.Windows.Forms.Button HomeCustomer;
        private System.Windows.Forms.Panel PanelCustomerheader;
        private System.Windows.Forms.Label welcometxtlabelCustomer;
        private System.Windows.Forms.Button CloseAppCustomerbtn;
        private System.Windows.Forms.Button button1;
    }
}