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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.testDBDataSet.bugs);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
            String str = "select name from bugs where solved = 'yes'";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["name"]);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bugsTableAdapter.FillBy(this.testDBDataSet.bugs);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

                nameInsertBox.Text = nameValue;
                langInsertBox.Text = langValue;
                //idUpdateBox.Text = idValue;
                descInsertBox.Text = descValue;
                codeInsertBox.Text = codeValue;
                solvedInsertBox.Text = solvedValue;

                //nameUpdateBox.Text = row.Cells["name"].Value.ToString();
                //langUpdateBox.Text = row.Cells["language"].Value.ToString();
                //idUpdateBox.Text = row.Cells["Id"].Value.ToString();
                //descUpdateBox.Text = row.Cells["description"].Value.ToString();
                //codeUpdateBox.Text = row.Cells["code"].Value.ToString();
                //solvedUpdateBox.Text = row.Cells["solved"].Value.ToString();
            }
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
                nameInsertBox.Text = dr["name"].ToString();
                langInsertBox.Text = dr["language"].ToString();
                descInsertBox.Text = dr["description"].ToString();
                codeInsertBox.Text = dr["code"].ToString();
                solvedInsertBox.Text = dr["solved"].ToString();

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samjm\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from bugs where name ='" + nameInsertBox.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Code has been deleted");
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
    }
}
