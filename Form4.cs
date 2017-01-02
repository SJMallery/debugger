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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
                 
        //cmd.ExecuteNonQuery();
                
        //int selectedRow;

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.testDBDataSet.bugs);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
            String str = "select name from bugs where solved = 'no'";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["name"]);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                string nameValue = dataGridView1.SelectedRows[0].Cells[1].Value + String.Empty;
                string langValue = dataGridView1.SelectedRows[0].Cells[2].Value + String.Empty;
                string idValue = dataGridView1.SelectedRows[0].Cells[0].Value + String.Empty;
                string descValue = dataGridView1.SelectedRows[0].Cells[3].Value + String.Empty;
                string codeValue = dataGridView1.SelectedRows[0].Cells[4].Value + String.Empty;
                string solvedValue = dataGridView1.SelectedRows[0].Cells[5].Value + String.Empty;

                nameUpdateBox.Text = nameValue;
                langUpdateBox.Text = langValue;
                idUpdateBox.Text = idValue;
                descUpdateBox.Text = descValue;
                codeUpdateBox.Text = codeValue;
                solvedUpdateBox.Text = solvedValue;

                //nameUpdateBox.Text = row.Cells["name"].Value.ToString();
                //langUpdateBox.Text = row.Cells["language"].Value.ToString();
                //idUpdateBox.Text = row.Cells["Id"].Value.ToString();
                //descUpdateBox.Text = row.Cells["description"].Value.ToString();
                //codeUpdateBox.Text = row.Cells["code"].Value.ToString();
                //solvedUpdateBox.Text = row.Cells["solved"].Value.ToString();
            }

            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update bugs set code='"+ codeUpdateBox.Text +"', solved = '"+ solvedUpdateBox.Text+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Code has been updated");
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();

            //DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            //newDataRow.Cells[0].Value = idUpdateBox.Text;
            //newDataRow.Cells[1].Value = nameUpdateBox.Text;
            //newDataRow.Cells[2].Value = langUpdateBox.Text;
            //newDataRow.Cells[3].Value = descUpdateBox.Text;
            //newDataRow.Cells[4].Value = codeUpdateBox.Text;
            //newDataRow.Cells[5].Value = solvedUpdateBox.Text;

            //int idNumber;
            //idNumber = Convert.ToInt32(idUpdateBox.Text);
            //idNumber = int.Parse(idUpdateBox.Text);
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");            
            //String str = "UPDATE bugs SET name = nameUpdateBox.Text, language = langUpdateBox.Text, description = descUpdateBox.Text, code = codeUpdateBox.Text, solved = solvedUpdateBox.Text WHERE Id = idNumber";
            //con.Open();
            //SqlCommand cmd = new SqlCommand(str, con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Your solution has been updated.");

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
            //String str = "update bugs set name = '" + this.nameUpdateBox.Text + "',language = '" + this.langUpdateBox.Text + "',description = '" + this.descUpdateBox.Text + "',code = '" + this.codeUpdateBox.Text + "',solved ='" + this.solvedUpdateBox.Text + "' WHERE Id = idNumber ";
            //SqlCommand cmd = new SqlCommand(str, con);
            //SqlDataReader myReader;
            //con.Open();
            //myReader = cmd.ExecuteReader();
            //MessageBox.Show("Your solution has been updated.");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from bugs where name = '" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                nameUpdateBox.Text = dr["name"].ToString();
                langUpdateBox.Text = dr["language"].ToString();
                descUpdateBox.Text = dr["description"].ToString();
                codeUpdateBox.Text = dr["code"].ToString();
                solvedUpdateBox.Text = dr["solved"].ToString();

            }
        }
    }
}
    