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
    public partial class Gestion_des_produits : Form
    {
        commerciaEntities db = new commerciaEntities();

        public Gestion_des_produits()
        {
            InitializeComponent();
            rempli();
        }
        public void rempli()
        {
           comboID.DataSource = db.produit.Select(s => s.Num_P).ToList();
            comboTYP.DataSource = db.type_produit.ToList();
            dataGridView1.DataSource = db.produit.ToList();
            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
        }
        public bool verfier_combo()
        {
            if ( textLBL.Text != "" && comboTYP.Text != "" && textPRX.Text != "" && textQT.Text != "" && textEMG.Text != "" && richTextADS.Text != "")
            {
                return true;
            }

            else return false;
        }
        private void Controle_et_contentien_Load(object sender, EventArgs e)
        {
            
        }

        private void comboTYP_mtr_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
       

        private void bButton1_Click(object sender, EventArgs e)
        {
            produit pr = new produit();
            pr.Libelle = textLBL.Text;
            pr.Type_P = comboTYP.Text;
            pr.Prix = int.Parse(textPRX.Text);
            pr.Quantite = int.Parse(textQT.Text);
            pr.Image_Nom = textEMG.Text;
            pr.Description_P = richTextADS.Text;
            if (verfier_combo() == true)
            {
                db.produit.Add(pr);
                db.SaveChanges();
                rempli();
                MessageBox.Show("Bien ajoute !!", "ajoute un client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("complete les donne SVP !!", "ajoute un client", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "all Image | *.pnj; *.JPG; *.BMP";
           // openFileDialog1.ShowDialog = DialogResult.OK;
            
                pictureBox1.Image =Image.FromFile( openFileDialog1.FileName);
            
        }
    }
}
