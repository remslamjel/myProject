namespace newR
{
    partial class createUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createUser));
            this.userPnl = new System.Windows.Forms.Panel();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.userPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPnl
            // 
            this.userPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userPnl.Controls.Add(this.addBtn);
            this.userPnl.Controls.Add(this.label10);
            this.userPnl.Controls.Add(this.label9);
            this.userPnl.Controls.Add(this.label13);
            this.userPnl.Controls.Add(this.label12);
            this.userPnl.Controls.Add(this.label11);
            this.userPnl.Controls.Add(this.label8);
            this.userPnl.Controls.Add(this.female);
            this.userPnl.Controls.Add(this.male);
            this.userPnl.Controls.Add(this.label3);
            this.userPnl.Controls.Add(this.email);
            this.userPnl.Controls.Add(this.phone);
            this.userPnl.Controls.Add(this.name);
            this.userPnl.Controls.Add(this.label5);
            this.userPnl.Controls.Add(this.label2);
            this.userPnl.Controls.Add(this.label4);
            this.userPnl.Controls.Add(this.username);
            this.userPnl.Controls.Add(this.label1);
            this.userPnl.Controls.Add(this.password);
            this.userPnl.Controls.Add(this.label6);
            this.userPnl.ForeColor = System.Drawing.Color.White;
            this.userPnl.Location = new System.Drawing.Point(188, 110);
            this.userPnl.Name = "userPnl";
            this.userPnl.Size = new System.Drawing.Size(754, 473);
            this.userPnl.TabIndex = 3;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.Color.White;
            this.female.Location = new System.Drawing.Point(553, 86);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 22);
            this.female.TabIndex = 11;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.Color.White;
            this.male.Location = new System.Drawing.Point(451, 86);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(58, 22);
            this.male.TabIndex = 11;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(447, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(85, 320);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(212, 29);
            this.email.TabIndex = 10;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(451, 197);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(212, 29);
            this.phone.TabIndex = 10;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(85, 79);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(212, 29);
            this.name.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(81, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(447, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(447, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(85, 197);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(212, 29);
            this.username.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(451, 320);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(212, 29);
            this.password.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(81, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(456, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Create Account";
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1081, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 29);
            this.exit.TabIndex = 9;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(3, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(36, 29);
            this.back.TabIndex = 10;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 41);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label8.Location = new System.Drawing.Point(96, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label9.Location = new System.Drawing.Point(96, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label10.Location = new System.Drawing.Point(96, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label11.Location = new System.Drawing.Point(463, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label12.Location = new System.Drawing.Point(463, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label13.Location = new System.Drawing.Point(463, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 18);
            this.label13.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.ActiveBorderThickness = 1;
            this.addBtn.ActiveCornerRadius = 20;
            this.addBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.ButtonText = "Create User";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addBtn.IdleBorderThickness = 1;
            this.addBtn.IdleCornerRadius = 20;
            this.addBtn.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.addBtn.IdleForecolor = System.Drawing.Color.White;
            this.addBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addBtn.Location = new System.Drawing.Point(290, 389);
            this.addBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(173, 49);
            this.addBtn.TabIndex = 15;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // createUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createUser";
            this.Load += new System.EventHandler(this.createUser_Load);
            this.userPnl.ResumeLayout(false);
            this.userPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPnl;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuThinButton2 addBtn;
    }
}