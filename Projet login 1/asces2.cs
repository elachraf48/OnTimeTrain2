using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_login_1
{
    public partial class asces2 : Form
    {
        commerciaEntities db = new commerciaEntities();

        public asces2()
        {
            InitializeComponent();
            rempli();
        }
        public void rempli()
        {
           
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        verf cls = new verf();
        private void bButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBureau.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboTYP_mtr.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            comboID_MTR.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void comboTYP_mtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
