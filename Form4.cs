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

           

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                String value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                string value3 = row.Cells[2].Value.ToString();
                string value4 = row.Cells[3].Value.ToString();
                string value5 = row.Cells[4].Value.ToString();
                string value6 = row.Cells[5].Value.ToString();
            }

            value1 = nameUpdateBox.Text;

        }
    }
}
