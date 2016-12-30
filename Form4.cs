using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.testDBDataSet.bugs);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                string nameValue = dataGridView1.SelectedRows[0].Cells[0].Value + String.Empty;
                string langValue = dataGridView1.SelectedRows[0].Cells[1].Value + String.Empty;
                string idValue = dataGridView1.SelectedRows[0].Cells[2].Value + String.Empty;
                string descValue = dataGridView1.SelectedRows[0].Cells[3].Value + String.Empty;
                string codeValue = dataGridView1.SelectedRows[0].Cells[4].Value + String.Empty;
                string solvedValue = dataGridView1.SelectedRows[0].Cells[5].Value + String.Empty;

                nameUpdateBox.Text = nameValue;
                langUpdateBox.Text = langValue;
                idLabel.Text = idValue;
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

        }
    }
}
