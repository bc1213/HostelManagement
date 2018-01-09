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

namespace fridaytest1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\USERS\BHARATH\DOCUMENTS\SAMPLE.MDF; Integrated Security=True;User Instance=True");
           // SqlDataAdapter sda=new SqlDataAdapter("select count(*)from bharath where Emailid='"+textBox1.Text.Trim() +"'and Password='"+textBox2.Text+"'",con);
           // DataTable dt = new DataTable();
            //sda.Fill(dt);

          //  if (dt.Rows[0][0].ToString() == "1")
          if(textBox1.Text=="bharathr636@gmail.com" && textBox2.Text=="1996")
            {
                this.Hide();
                welcome ss = new welcome();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please Check your username and password");
            }
        }
    }
}
