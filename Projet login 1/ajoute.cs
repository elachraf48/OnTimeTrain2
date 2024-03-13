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
    public partial class ajoute : Form
    {
        commerciaEntities db = new commerciaEntities();
        public ajoute()
        {
            InitializeComponent();
            
        }

        private void difectue_CheckedChanged(object sender, EventArgs e)
        {
            if (difectue.Checked == true)
            {
                richTextBox1.Visible = true;
                label5.Visible = true;

            }
            else
            {
                richTextBox1.Visible = false;
                richTextBox1.Text = "";
                label5.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string etat;
        private void bButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           

        }

        private void combID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void ajoute_Load(object sender, EventArgs e)
        {
            
           

        }
    }
}
