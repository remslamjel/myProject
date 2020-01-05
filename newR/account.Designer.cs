namespace newR
{
    partial class account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pwdPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.passtext1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminPnl = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.circularPicture1 = new newR.CircularPicture();
            this.password = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pwdPanel.SuspendLayout();
            this.adminPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 59);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(3, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 33);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1073, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 34);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(506, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Account";
            // 
            // pwdPanel
            // 
            this.pwdPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwdPanel.Controls.Add(this.label9);
            this.pwdPanel.Controls.Add(this.label8);
            this.pwdPanel.Controls.Add(this.password);
            this.pwdPanel.Controls.Add(this.label6);
            this.pwdPanel.Controls.Add(this.label5);
            this.pwdPanel.Controls.Add(this.label2);
            this.pwdPanel.Controls.Add(this.passText);
            this.pwdPanel.Controls.Add(this.passtext1);
            this.pwdPanel.Controls.Add(this.label4);
            this.pwdPanel.Location = new System.Drawing.Point(190, 158);
            this.pwdPanel.Name = "pwdPanel";
            this.pwdPanel.Size = new System.Drawing.Size(758, 389);
            this.pwdPanel.TabIndex = 1;
            this.pwdPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pwdPanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(413, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Create New User";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(138, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Old Password";
            // 
            // passText
            // 
            this.passText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText.Location = new System.Drawing.Point(290, 82);
            this.passText.Multiline = true;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(254, 29);
            this.passText.TabIndex = 10;
            this.passText.Leave += new System.EventHandler(this.passText_Leave);
            // 
            // passtext1
            // 
            this.passtext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext1.Location = new System.Drawing.Point(290, 175);
            this.passtext1.Multiline = true;
            this.passtext1.Name = "passtext1";
            this.passtext1.Size = new System.Drawing.Size(254, 29);
            this.passtext1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "New Password";
            // 
            // adminPnl
            // 
            this.adminPnl.BackColor = System.Drawing.Color.White;
            this.adminPnl.Controls.Add(this.label7);
            this.adminPnl.Controls.Add(this.button3);
            this.adminPnl.Controls.Add(this.button4);
            this.adminPnl.Controls.Add(this.textBox1);
            this.adminPnl.Controls.Add(this.label3);
            this.adminPnl.Controls.Add(this.circularPicture1);
            this.adminPnl.Location = new System.Drawing.Point(190, 158);
            this.adminPnl.Name = "adminPnl";
            this.adminPnl.Size = new System.Drawing.Size(763, 410);
            this.adminPnl.TabIndex = 13;
            this.adminPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(719, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 29);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(465, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 28);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(216, 272);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(243, 28);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "*********";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "   Admin";
            // 
            // circularPicture1
            // 
            this.circularPicture1.BackColor = System.Drawing.SystemColors.GrayText;
            this.circularPicture1.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture1.Image")));
            this.circularPicture1.Location = new System.Drawing.Point(323, 42);
            this.circularPicture1.Name = "circularPicture1";
            this.circularPicture1.Size = new System.Drawing.Size(94, 84);
            this.circularPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPicture1.TabIndex = 5;
            this.circularPicture1.TabStop = false;
            // 
            // password
            // 
            this.password.ActiveBorderThickness = 1;
            this.password.ActiveCornerRadius = 20;
            this.password.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.password.ActiveForecolor = System.Drawing.Color.White;
            this.password.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password.BackgroundImage")));
            this.password.ButtonText = "Change Password";
            this.password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.SeaGreen;
            this.password.IdleBorderThickness = 1;
            this.password.IdleCornerRadius = 20;
            this.password.IdleFillColor = System.Drawing.Color.Maroon;
            this.password.IdleForecolor = System.Drawing.Color.White;
            this.password.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.password.Location = new System.Drawing.Point(323, 259);
            this.password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(184, 49);
            this.password.TabIndex = 14;
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(237, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(232, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(232, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 15;
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 630);
            this.Controls.Add(this.adminPnl);
            this.Controls.Add(this.pwdPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pwdPanel.ResumeLayout(false);
            this.pwdPanel.PerformLayout();
            this.adminPnl.ResumeLayout(false);
            this.adminPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pwdPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox passtext1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel adminPnl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private CircularPicture circularPicture1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}