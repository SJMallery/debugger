using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace debugger
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
            String str = "insert into bugs(name,language,description,code,solved) values('" + nameInsertBox.Text + "','" + langInsertBox.Text + "','" + descInsertBox.Text + "','" + codeInsertBox + "', '" + solvedInsertBox + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your bug has been submitted");


        }
    }
}
