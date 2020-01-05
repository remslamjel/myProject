namespace newR
{
    partial class report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.stock1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Sales1 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(845, 406);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(599, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 592);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total items:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(701, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 65);
            this.panel1.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1282, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 37);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 42);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // stock1
            // 
            this.stock1.ActiveBorderThickness = 1;
            this.stock1.ActiveCornerRadius = 20;
            this.stock1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.stock1.ActiveForecolor = System.Drawing.Color.White;
            this.stock1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.stock1.BackColor = System.Drawing.SystemColors.Control;
            this.stock1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stock1.BackgroundImage")));
            this.stock1.ButtonText = "Stock";
            this.stock1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stock1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock1.ForeColor = System.Drawing.Color.SeaGreen;
            this.stock1.IdleBorderThickness = 1;
            this.stock1.IdleCornerRadius = 20;
            this.stock1.IdleFillColor = System.Drawing.Color.DarkRed;
            this.stock1.IdleForecolor = System.Drawing.Color.White;
            this.stock1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.stock1.Location = new System.Drawing.Point(45, 297);
            this.stock1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(151, 55);
            this.stock1.TabIndex = 11;
            this.stock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stock1.Click += new System.EventHandler(this.stock1_Click_1);
            // 
            // Sales1
            // 
            this.Sales1.ActiveBorderThickness = 1;
            this.Sales1.ActiveCornerRadius = 20;
            this.Sales1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Sales1.ActiveForecolor = System.Drawing.Color.White;
            this.Sales1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Sales1.BackColor = System.Drawing.SystemColors.Control;
            this.Sales1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sales1.BackgroundImage")));
            this.Sales1.ButtonText = "View Sales";
            this.Sales1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sales1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Sales1.IdleBorderThickness = 1;
            this.Sales1.IdleCornerRadius = 20;
            this.Sales1.IdleFillColor = System.Drawing.Color.DarkRed;
            this.Sales1.IdleForecolor = System.Drawing.Color.White;
            this.Sales1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Sales1.Location = new System.Drawing.Point(1124, 297);
            this.Sales1.Margin = new System.Windows.Forms.Padding(9);
            this.Sales1.Name = "Sales1";
            this.Sales1.Size = new System.Drawing.Size(166, 55);
            this.Sales1.TabIndex = 11;
            this.Sales1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sales1.Click += new System.EventHandler(this.Sales1_Click);
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 687);
            this.Controls.Add(this.Sales1);
            this.Controls.Add(this.stock1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 stock1;
        private Bunifu.Framework.UI.BunifuThinButton2 Sales1;
      
    }
}