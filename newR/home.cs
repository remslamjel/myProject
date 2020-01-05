using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newR
{
    public partial class home : Form
    {
        public string user;
        public home()
        {
            InitializeComponent();
        }
        public void getValue(string str)
        {
            user = str;
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new item().Show();
            this.Hide(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new manageItem().Show();
            this.Hide();  
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new report().Show();
            this.Hide(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new contactUs().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void home_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void items_Click(object sender, EventArgs e)
        {
            new item().Show();
            this.Hide(); 
        }

        private void manageItems_Click(object sender, EventArgs e)
        {

        }

        private void support_Click(object sender, EventArgs e)
        {
            new contactUs().Show();
            this.Hide();
        }

        private void manageItems_Click_1(object sender, EventArgs e)
        {

            new manageItem().Show();
            this.Hide();  
        }

        private void report_Click(object sender, EventArgs e)
        {
            new report().Show();
            this.Hide(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new about().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void items_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void about_Click(object sender, EventArgs e)
        {
            new about().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account ob = new account();
            ob.getValue(user);
            ob.Show();
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }
    }
}
