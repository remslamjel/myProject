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
    public partial class report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGI2P8R;Initial Catalog=Restaurant;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlCommand cmd;
        
        public report()
        {
            InitializeComponent();
           // show();
           // count();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }
        public void show()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from menu", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void show2()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from orderItem", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void count()
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText="select count(Item_ID) from menu";
              //  con.Close();
                int r=(int)cmd.ExecuteScalar();
                label2.Text=r.ToString();
                
            }
            catch(Exception e){
                MessageBox.Show("No items"+e);
            }
            finally{
                if(con.State==ConnectionState.Open){
                    con.Close();
                }
            }
        }

        private void stock_Click(object sender, EventArgs e)
        {
            show();
            count();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            show2();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void stock1_Click(object sender, EventArgs e)
        {
            show();
            count();
        }

        private void Sales1_Click(object sender, EventArgs e)
        {
            show2();
        }

        private void stock1_Click_1(object sender, EventArgs e)
        {
            show();
            count();
        }
    }
}
