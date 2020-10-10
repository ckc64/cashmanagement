namespace CashSystem.admin
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAccountTransact = new System.Windows.Forms.Button();
            this.btnDepositTransact = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAccountTransact);
            this.panel1.Controls.Add(this.btnDepositTransact);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 494);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create Account";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 173);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 432);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(243, 59);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAccountTransact
            // 
            this.btnAccountTransact.BackColor = System.Drawing.Color.Firebrick;
            this.btnAccountTransact.FlatAppearance.BorderSize = 0;
            this.btnAccountTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountTransact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountTransact.ForeColor = System.Drawing.Color.White;
            this.btnAccountTransact.Location = new System.Drawing.Point(1, 270);
            this.btnAccountTransact.Name = "btnAccountTransact";
            this.btnAccountTransact.Size = new System.Drawing.Size(243, 59);
            this.btnAccountTransact.TabIndex = 3;
            this.btnAccountTransact.Text = "Accounts";
            this.btnAccountTransact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountTransact.UseVisualStyleBackColor = false;
            this.btnAccountTransact.Click += new System.EventHandler(this.btnAccountTransact_Click);
            // 
            // btnDepositTransact
            // 
            this.btnDepositTransact.BackColor = System.Drawing.Color.Firebrick;
            this.btnDepositTransact.FlatAppearance.BorderSize = 0;
            this.btnDepositTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositTransact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositTransact.ForeColor = System.Drawing.Color.White;
            this.btnDepositTransact.Location = new System.Drawing.Point(1, 211);
            this.btnDepositTransact.Name = "btnDepositTransact";
            this.btnDepositTransact.Size = new System.Drawing.Size(243, 59);
            this.btnDepositTransact.TabIndex = 2;
            this.btnDepositTransact.Text = "Transactions";
            this.btnDepositTransact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepositTransact.UseVisualStyleBackColor = false;
            this.btnDepositTransact.Click += new System.EventHandler(this.btnDepositTransact_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAccountTransact;
        private System.Windows.Forms.Button btnDepositTransact;
        private System.Windows.Forms.Button button1;
    }
}