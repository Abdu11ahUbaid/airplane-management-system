namespace AirlineManagementSystem.Views
{
    partial class planesManagementAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(planesManagementAdmin));
            this.SearchPlaneAdmin = new System.Windows.Forms.TextBox();
            this.addPlaneBtn = new System.Windows.Forms.Button();
            this.planesGridAdmin = new System.Windows.Forms.DataGridView();
            this.PlaneUpdateBtn = new System.Windows.Forms.Button();
            this.deletePlanebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planesGridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPlaneAdmin
            // 
            this.SearchPlaneAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPlaneAdmin.Location = new System.Drawing.Point(137, 20);
            this.SearchPlaneAdmin.Name = "SearchPlaneAdmin";
            this.SearchPlaneAdmin.Size = new System.Drawing.Size(434, 22);
            this.SearchPlaneAdmin.TabIndex = 6;
            this.SearchPlaneAdmin.Text = "Search planes";
            // 
            // addPlaneBtn
            // 
            this.addPlaneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addPlaneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlaneBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlaneBtn.ForeColor = System.Drawing.Color.White;
            this.addPlaneBtn.Location = new System.Drawing.Point(55, 48);
            this.addPlaneBtn.Name = "addPlaneBtn";
            this.addPlaneBtn.Size = new System.Drawing.Size(127, 38);
            this.addPlaneBtn.TabIndex = 5;
            this.addPlaneBtn.Text = "Add Plane";
            this.addPlaneBtn.UseVisualStyleBackColor = false;
            this.addPlaneBtn.Click += new System.EventHandler(this.addPlaneBtn_Click);
            // 
            // planesGridAdmin
            // 
            this.planesGridAdmin.AllowUserToAddRows = false;
            this.planesGridAdmin.AllowUserToDeleteRows = false;
            this.planesGridAdmin.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.planesGridAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.planesGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.planesGridAdmin.DefaultCellStyle = dataGridViewCellStyle5;
            this.planesGridAdmin.Location = new System.Drawing.Point(55, 92);
            this.planesGridAdmin.Name = "planesGridAdmin";
            this.planesGridAdmin.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.planesGridAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.planesGridAdmin.RowHeadersWidth = 51;
            this.planesGridAdmin.RowTemplate.Height = 24;
            this.planesGridAdmin.Size = new System.Drawing.Size(690, 346);
            this.planesGridAdmin.TabIndex = 4;
            this.planesGridAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planesGridAdmin_CellClick);
            this.planesGridAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planesGridAdmin_CellContentClick);
            this.planesGridAdmin.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.planesGridAdmin_CellMouseClick);
            // 
            // PlaneUpdateBtn
            // 
            this.PlaneUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.PlaneUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaneUpdateBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaneUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.PlaneUpdateBtn.Location = new System.Drawing.Point(221, 48);
            this.PlaneUpdateBtn.Name = "PlaneUpdateBtn";
            this.PlaneUpdateBtn.Size = new System.Drawing.Size(154, 38);
            this.PlaneUpdateBtn.TabIndex = 5;
            this.PlaneUpdateBtn.Text = "Update Plane";
            this.PlaneUpdateBtn.UseVisualStyleBackColor = false;
            this.PlaneUpdateBtn.Click += new System.EventHandler(this.PlaneUpdateBtn_Click);
            // 
            // deletePlanebtn
            // 
            this.deletePlanebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.deletePlanebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlanebtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlanebtn.ForeColor = System.Drawing.Color.White;
            this.deletePlanebtn.Location = new System.Drawing.Point(419, 48);
            this.deletePlanebtn.Name = "deletePlanebtn";
            this.deletePlanebtn.Size = new System.Drawing.Size(152, 38);
            this.deletePlanebtn.TabIndex = 5;
            this.deletePlanebtn.Text = "Delete Plane";
            this.deletePlanebtn.UseVisualStyleBackColor = false;
            this.deletePlanebtn.Click += new System.EventHandler(this.deletePlanebtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(629, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(496, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // planesManagementAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchPlaneAdmin);
            this.Controls.Add(this.deletePlanebtn);
            this.Controls.Add(this.PlaneUpdateBtn);
            this.Controls.Add(this.addPlaneBtn);
            this.Controls.Add(this.planesGridAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "planesManagementAdmin";
            this.Text = "planesManagementAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.planesGridAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchPlaneAdmin;
        private System.Windows.Forms.Button addPlaneBtn;
        private System.Windows.Forms.Button PlaneUpdateBtn;
        private System.Windows.Forms.Button deletePlanebtn;
        public System.Windows.Forms.DataGridView planesGridAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}