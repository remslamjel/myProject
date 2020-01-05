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
using newR.Cart;
using newR.Properties;

namespace newR
{
    public partial class item : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGI2P8R;Initial Catalog=Restaurant;Integrated Security=True");
        public item()
        {
            InitializeComponent();
            //show();
        }
        private List<cart> cartItem = new List<cart>();

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
       
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox5.Text.Length > 0)
            {
                int total = Convert.ToInt32(textBox4.Text);
                int d = Convert.ToInt32(textBox5.Text);
                float d1 = total *d/100;
                float net = total-d1;
                textBox6.Text = net.ToString();
            }
        
        }

        private void item_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*new home().Show();
            this.Hide();*/
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void show(String qry)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr[1].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr[2].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr[4].ToString();
                }
                con.Close();
            }
            catch (Exception e)
            {
               
            }
        }
        public void clear()
        {
            textBox8.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
              String qry="select * from menu where Category='Foods'";
              show(qry);
             
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            String qry ="select * from menu where Item_Name='" + textBox7.Text + "'";
            show(qry);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            String qry = "select * from menu where Category='Pizza/Burger'";
            show(qry);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String qry = "select * from menu where Category='Drinks'";
            show(qry);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String qry = "select * from menu where Category='Desserts'";
            show(qry);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception )
            {
                MessageBox.Show("Select Row");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public bool valid()
        {

            int tempQuantity;
            bool isNumeric = int.TryParse(textBox2.Text.Trim(), out tempQuantity);

            if (!isNumeric)
            {
                MessageBox.Show("Quantity should be integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
                return false;
            }
            return true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            
                if (textBox2.Text.Length > 0)
                {
                    long p, q, t;
                    q = Convert.ToInt64(textBox2.Text);
                    p = Convert.ToInt64(textBox1.Text);
                    t = q * p;
                    textBox3.Text = t.ToString();
                }
            
        }
        public void total()
        {
            long It, Ft, net;
            It = Convert.ToInt64(textBox3.Text);
            Ft = Convert.ToInt64(textBox4.Text);
            net = It + Ft;
            textBox4.Text = net.ToString();
            textBox6.Text = net.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (IsValid())
            {
                insert();
                cart c = new cart() {
                    ItemName = textBox8.Text,
                    Price = Convert.ToDecimal(textBox1.Text.Trim()),
                    Quantity = Convert.ToInt16(textBox2.Text.Trim()),
                    Total = Convert.ToInt16(textBox2.Text.Trim()) * Convert.ToDecimal(textBox1.Text.Trim())
                
                };
                cartItem.Add(c);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = cartItem;
                total();
                clear(); 
            }
               

        }

        private bool IsValid()
        {
           

            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity is requred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return false;
            }
            else
            {
                int tempQuantity;
                bool isNumeric = int.TryParse(textBox2.Text.Trim(), out tempQuantity);

                if (!isNumeric)
                {
                    MessageBox.Show("Quantity should be integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox2.Focus();
                    return false;
                }
                return true ;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog() ;

        }

        public void insert()
        {
            try
            {
                con.Open();
               
                String qry = "insert into orderItem values('" + textBox8.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','"+dateTimePicker1.Text+"')";
                SqlCommand cmd = new SqlCommand(qry, con);
                int i = cmd.ExecuteNonQuery(); // No. of rows affected
                con.Close();
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
        public void stockDec()
        {
            con.Open();
            String qry = "update menu set Qty=Qty-1 where Item_ID='" + textBox8.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            int i = cmd.ExecuteNonQuery(); // No. of rows affected
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
           
           // stockDec();
            printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image =Resources.Rlogo;
            e.Graphics.DrawImage(image, 25, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date:" + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("Items", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("Total", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(660, 255));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            int yPos = 295;
            foreach(var i in cartItem)
            {
                
                e.Graphics.DrawString(i.ItemName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(i.Price.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(390, yPos));
                e.Graphics.DrawString(i.Quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(529, yPos));
                e.Graphics.DrawString(i.Total.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(665, yPos));

                yPos += 30;
            }

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString("Total Amount:      " + textBox4.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(535, yPos + 30));
            e.Graphics.DrawString("Discount (%):      " + textBox5.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(535, yPos + 60));
            e.Graphics.DrawString("Total To Pay:       " + textBox6.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(535, yPos + 90));
            }

        private void button2_Click(object sender, EventArgs e)
        {
            
          //  dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
        }
       
     }
 }
  

