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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                nameUpdateBox.Text = row.Cells["name"].Value.ToString();
                langUpdateBox.Text = row.Cells["language"].Value.ToString();
                idUpdateBox.Text = row.Cells["Id"].Value.ToString();
                descUpdateBox.Text = row.Cells["description"].Value.ToString();
                codeUpdateBox.Text = row.Cells["code"].Value.ToString();
                solvedUpdateBox.Text = row.Cells["solved"].Value.ToString();
            }    

        }
    }
}
