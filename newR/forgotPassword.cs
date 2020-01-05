using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace newR
{
    public partial class forgotPassword : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGI2P8R;Initial Catalog=Restaurant;Integrated Security=True");
        string randomC;
        public static string to;
      
        public forgotPassword()
        {
            InitializeComponent();
          //  resetPnl.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool isValid()
        {
            try
            {
                con.Open();
                String query = "select Email from userAccount where Email='" + email.Text + "'";
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
            catch (Exception e){}
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
          
                string from, password, messageBody;
                Random rnd = new Random();
                randomC = (rnd.Next(9999)).ToString();
                MailMessage msg = new MailMessage();
                to = (email.Text).ToString();
                from = "remk948@gmail.com";
                password = "12345";
                messageBody = "Your reset code is " + randomC;
                msg.To.Add(to);
                msg.From = new MailAddress(from);
                msg.Body = messageBody;
                msg.Subject = "Password reset code";
                SmtpClient sm = new SmtpClient("sm.gmail.com");
                sm.EnableSsl = true;
                sm.Port = 587;
                sm.DeliveryMethod = SmtpDeliveryMethod.Network;
                sm.Credentials = new NetworkCredential(from, password);

                try
                {
                    sm.Send(msg);
                    MessageBox.Show("Code sent successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (randomC == codeTxt.Text.ToString())
            {
                to = email.Text;
                //resetForm f = new resetForm();
                this.Hide();
             //   f.Show();
              
            }
            else
            {
                codeLabel.Text = "Invalid code";
               
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
           
        }
    }
}
