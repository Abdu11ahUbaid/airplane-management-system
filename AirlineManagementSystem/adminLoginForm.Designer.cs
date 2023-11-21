namespace AirlineManagementSystem
{
    partial class adminLoginForm
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
            this.ShowLogin = new System.Windows.Forms.CheckBox();
            this.LoginAdminBtn = new System.Windows.Forms.Button();
            this.txtAdminPasswordLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameAdminLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gobacklabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowLogin
            // 
            this.ShowLogin.AutoSize = true;
            this.ShowLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLogin.Location = new System.Drawing.Point(95, 257);
            this.ShowLogin.Name = "ShowLogin";
            this.ShowLogin.Size = new System.Drawing.Size(121, 20);
            this.ShowLogin.TabIndex = 25;
            this.ShowLogin.Text = "Show Password";
            this.ShowLogin.UseVisualStyleBackColor = true;
            this.ShowLogin.CheckedChanged += new System.EventHandler(this.ShowLogin_CheckedChanged);
            // 
            // LoginAdminBtn
            // 
            this.LoginAdminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LoginAdminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAdminBtn.FlatAppearance.BorderSize = 0;
            this.LoginAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginAdminBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAdminBtn.ForeColor = System.Drawing.Color.White;
            this.LoginAdminBtn.Location = new System.Drawing.Point(30, 290);
            this.LoginAdminBtn.Name = "LoginAdminBtn";
            this.LoginAdminBtn.Size = new System.Drawing.Size(216, 35);
            this.LoginAdminBtn.TabIndex = 24;
            this.LoginAdminBtn.Text = "LOGIN";
            this.LoginAdminBtn.UseVisualStyleBackColor = false;
            this.LoginAdminBtn.Click += new System.EventHandler(this.LoginAdminBtn_Click);
            // 
            // txtAdminPasswordLogin
            // 
            this.txtAdminPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAdminPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminPasswordLogin.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPasswordLogin.Location = new System.Drawing.Point(30, 223);
            this.txtAdminPasswordLogin.Multiline = true;
            this.txtAdminPasswordLogin.Name = "txtAdminPasswordLogin";
            this.txtAdminPasswordLogin.PasswordChar = '*';
            this.txtAdminPasswordLogin.Size = new System.Drawing.Size(216, 28);
            this.txtAdminPasswordLogin.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // txtUsernameAdminLogin
            // 
            this.txtUsernameAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsernameAdminLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameAdminLogin.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameAdminLogin.Location = new System.Drawing.Point(30, 156);
            this.txtUsernameAdminLogin.Multiline = true;
            this.txtUsernameAdminLogin.Name = "txtUsernameAdminLogin";
            this.txtUsernameAdminLogin.Size = new System.Drawing.Size(216, 28);
            this.txtUsernameAdminLogin.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Get Started";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Not an Admin?";
            // 
            // Gobacklabel
            // 
            this.Gobacklabel.AutoSize = true;
            this.Gobacklabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gobacklabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gobacklabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Gobacklabel.Location = new System.Drawing.Point(103, 348);
            this.Gobacklabel.Name = "Gobacklabel";
            this.Gobacklabel.Size = new System.Drawing.Size(75, 23);
            this.Gobacklabel.TabIndex = 27;
            this.Gobacklabel.Text = "Go Back";
            this.Gobacklabel.Click += new System.EventHandler(this.Gobacklabel_Click);
            // 
            // adminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Gobacklabel);
            this.Controls.Add(this.ShowLogin);
            this.Controls.Add(this.LoginAdminBtn);
            this.Controls.Add(this.txtAdminPasswordLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsernameAdminLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowLogin;
        private System.Windows.Forms.Button LoginAdminBtn;
        private System.Windows.Forms.TextBox txtAdminPasswordLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameAdminLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Gobacklabel;
    }
}