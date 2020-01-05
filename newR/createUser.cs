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
    public partial class createUser : Form
    {
        String gender="";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGI2P8R;Initial Catalog=Restaurant;Integrated Security=True");
        public createUser()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new account().Show();
            this.Hide();
        }
        private bool IsValid()
        {

            if (name.Text.Trim() == string.Empty)
            {
                label8.Text = "Name cannot be empty.";
                return false;
            }

            if (username.Text.Trim() == string.Empty)
            {
                label9.Text="This is a required field";
                return false;
            }
            if (email.Text.Trim() == string.Empty)
            {
                label10.Text="Please enter an email";
                return false;
            }

            if (phone.Text.Trim() == string.Empty)
            {
                label11.Text="This field can't be empty";
                return false;
            }
            if (password.Text.Trim() == string.Empty)
            {
                label12.Text="Please enter a valid password";
                return false;
            }
            if (gender== string.Empty)
            {
                label13.Text = "Please select a gender";
                return false;
            }
            else
            {

            }
            return true;
        }


        private void createUser_Load(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
        public void clear()
        {
            name.Text = "";
            username.Text = "";
            email.Text = "";
            phone.Text = "";
            password.Text = "";
            gender = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    con.Open();

                    String qry = "insert into userAccount values('" + name.Text + "','" + username.Text + "','" + password.Text + "','" + email.Text + "','" + gender + "','" + phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    int i = cmd.ExecuteNonQuery(); // No. of rows affected
                    if (i >= 1)
                    {
                        MessageBox.Show(" Created Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Please fill carefully");
                    }

                    con.Close();
                    clear();

                }
                catch (Exception exp)
                {
                    MessageBox.Show("This username is already taken. Please try another");
                    //MessageBox.Show(" "+exp);
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
    }
}
