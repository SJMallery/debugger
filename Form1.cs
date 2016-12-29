using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace debugger
{
    public partial class Form1 : Form
    {
        SqlConnection mySqlConnection;

        public Form1()
        {
            InitializeComponent();

            mySqlConnection =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");

            String selcmd = "SELECT name FROM myTable";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);


            mySqlConnection.Open();


            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


            while (mySqlDataReader.Read())
            {
                Console.WriteLine(mySqlDataReader["name"]);


            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
