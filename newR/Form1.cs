using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace newR
{
    public partial class login : Form
    {
        public string usrname;
        public login()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        public void passValue()
        {
            home ob = new home();
            ob.getValue(textBox1.Text.Trim());
            ob.Show();
            this.Hide();
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String src = "Data Source=DESKTOP-TGI2P8R;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection con = new SqlConnection(src);
            con.Open();
            String query = "select UserName,Password from userAccount where Username='" + textBox1.Text.Trim() + "' and Password='" + textBox2.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                passValue();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            con.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
           // label1.BackColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new forgotPassword().Show();
            this.Hide();
        }
    }
}
