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
    public partial class account : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGI2P8R;Initial Catalog=Restaurant;Integrated Security=True");
        public string user;
        public account()
        {
            InitializeComponent();
            adminPnl.Visible = false;
           
        }
        public void getValue(string str)
        {
            user = str;
            label2.Text = str;
           
        }
     
        private void button2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
         
        }
   
        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void account_Load(object sender, EventArgs e)
        {

        }

        private void pwsBtn_Click(object sender, EventArgs e)
        {
            pwdPanel.Visible = true;
            adminPnl.Visible = false;
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            pwdPanel.Visible = false;
            adminPnl.Visible = true;
         
        }

        private void pwdPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool Valid()
        {
            try
            {
                String username = "Rems";
                con.Open();
                String query = "select UserName,Password from Login where UserName='" + username + "' and Password='" + textBox1.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;

        }
        public bool isEmpty1()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                label7.Text = "Password field is empty";
                return false;
            }
            return true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (isEmpty1())
            {
                if (Valid())
                {
                    try
                    {
                        new createUser().Show();
                        this.Hide();
                        textBox1.Text = "";
                    }
                    catch (Exception exe) { }
                }
                else
                {
                    label7.Text = "Incorrect password";
                    textBox1.Text = "";
                }
            }
            else { }   
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pwdPanel.Visible = false;
            adminPnl.Visible = true;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.Green;
        }

        public bool isValid()
        {
            try
            {
                con.Open();
                String query = "select Username, Password from userAccount where Username='" + user + "' and Password='" + passText.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;
        }
        public bool isEmpty()
        {
            if (passText.Text.Trim() == string.Empty)
            {
                label8.Text = "This is a required field";
                return false;
            }

            if (passtext1.Text.Trim() == string.Empty)
            {
                label9.Text = "Password cannot be empty";
                return false;
            }
            return true;
        }
        private void password_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                if (isValid())
                {
                    try
                    {
                        con.Open();
                        String qry = "update userAccount set Password='" + passtext1.Text + "' where Username='" + user + "'";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        int i = cmd.ExecuteNonQuery(); // No. of rows affected
                        if (i >= 1)
                        {
                            MessageBox.Show("Password Changed Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("error" + exp);
                    }
                    passtext1.Text = "";
                    passText.Text = "";
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passtext1.Text = "";
                    passText.Text = "";
                }
            }
            else { }
        }

        private void passText_Leave(object sender, EventArgs e)
        {

           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
