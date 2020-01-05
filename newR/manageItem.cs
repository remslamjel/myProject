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
    
    public partial class manageItem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGI2P8R;Initial Catalog=Restaurant;Integrated Security=True");
        public manageItem()
        {
            InitializeComponent();
            show();
            ID();
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception exp)
            {
               // MessageBox.Show("Select Row");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from menu where Item_Name='" + textBox5.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void manageItem_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private bool IsValid()
        {

            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Item Name is requred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return false;
            }
           
            if (textBox4.Text.Trim() == string.Empty)
            {
                 MessageBox.Show("Price is requred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 textBox4.Focus();
                 return false;
            }
            else
            {
                int tempPrice;
                bool isNumber = int.TryParse(textBox4.Text.Trim(), out tempPrice);

                if(!isNumber)
                {
                    MessageBox.Show("Price should be integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Clear();
                    textBox4.Focus();
                    return false;
                }
           }
          return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    con.Open();
                    String category = comboBox1.SelectedItem.ToString();
                    // ID();
                    String qry = "insert into menu values('" + category + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    int i = cmd.ExecuteNonQuery(); // No. of rows affected
                    if (i >= 1)
                    {
                        MessageBox.Show(i + " Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Not inserted");
                        MessageBox.Show("Check Item_ID");
                    }
                    con.Close();
                    clear();
                    show();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("error" + exp);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String qry = "delete from menu where Item_ID='" + textBox1.Text + "'";
                
                SqlCommand cmd = new SqlCommand(qry, con);
                int i = cmd.ExecuteNonQuery(); // No. of rows affected
                if (i >= 1)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Not deleted");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("error" + exp);
            }
            con.Close();
            clear();
            show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    con.Open();
                    String category = comboBox1.SelectedItem.ToString();
                    String qry = "update menu set Category='" + category + "',Item_ID='" + textBox1.Text + "',Item_Name='" + textBox2.Text +"',Price='" + textBox4.Text + "',Description='" + textBox6.Text + "' where Item_ID='" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    int i = cmd.ExecuteNonQuery(); // No. of rows affected
                    if (i >= 1)
                    {
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        MessageBox.Show("Updation failed");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("error" + exp);
                }
                con.Close();
                clear();
                show();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            show();
        }
        public void show()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from menu", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void clear()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        
            textBox4.Text = "";
            textBox6.Text = "";
            ID();

        }
        public void ID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Item_ID from menu order by Item_ID", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr["Item_ID"].ToString();
            }

            int i = Convert.ToInt32(textBox1.Text);
            i++;
            textBox1.Text=i.ToString();
            con.Close();
            dr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
           // textBox1.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
