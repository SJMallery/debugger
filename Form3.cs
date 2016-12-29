using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugger
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_load(object sender, EventArgs e)
        {
            passLabel.Hide();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == passwordBox2.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
                String str = "insert into users(name,username,password) values('" + nameBox.Text + "','" + usernameBox.Text + "','" + passwordBox.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have registered");
            }
            else
            {
                passLabel.Show();
                passLabel.Text = "password missmatch";
            }
        }

        private void regLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
