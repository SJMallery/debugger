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

namespace debugger
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loginMessage.Hide();
            logError.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            String str1 = "select name,username,password from users where username='" + usernameText.Text + "' and password='" + passwordText.Text + "'";
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataAdapter da = new SqlDataAdapter(str1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                usernameText.Hide();
                passwordText.Hide();
                logUserLabel.Hide();
                logPassLabel.Hide();
                button1.Hide();
                button2.Hide();
                label3.Hide();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    
                    loginMessage.Show();
                    loginMessage.Text = "Welcome " + dr["name"].ToString() + ".";
                }
            }
            else
            {
                logError.Show();
                logError.Text = "Username or password are incorrect";
            }
        }

        private void logError_Click(object sender, EventArgs e)
        {

        }
    }
}
