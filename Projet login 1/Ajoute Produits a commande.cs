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
    public partial class Ajoute_Produits_a_commande : Form
    {
        commerciaEntities db = new commerciaEntities();
        public Ajoute_Produits_a_commande()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Nouvelle_commande nv = new Nouvelle_commande("", 0, 0);
            nv.Show();
            this.Close();
        }

        private void Ajoute_Produits_a_commande_Load(object sender, EventArgs e)
        {
            comboTYP.DataSource = db.type_produit.Select(s=>s.Libelle).ToList();
            
        }

        private void comboTYP_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPRD.DataSource = db.produit.Where(w => w.Type_P == comboTYP.Text).ToList();
            comboPRD.DisplayMember = "Libelle";
            comboPRD.ValueMember = "Num_P";
        }

        private void comboPRD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pr = Convert.ToInt32(comboPRD.SelectedValue);
            var p = db.produit.Where(w => w.Num_P == pr).Select(s => s.Prix).Single();
            label2.Text = (int.Parse(p.Value.ToString()) * int.Parse(Qt.Value.ToString())).ToString()+"DH";
            }
            catch (Exception)
            {

                
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int pr = Convert.ToInt32(comboPRD.SelectedValue);
                var p = db.produit.Where(w => w.Num_P == pr).Select(s => s.Prix).Single();
                label2.Text = (int.Parse(p.Value.ToString()) * int.Parse(Qt.Value.ToString())).ToString()+"DH";
            }
            catch (Exception)
            {

                
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string type = comboTYP.Text;
            int nump = int.Parse(comboPRD.SelectedValue.ToString());
            int QNT= int.Parse(Qt.Value.ToString());
            Nouvelle_commande nv = new Nouvelle_commande(type,nump,QNT);
            nv.Show();
            this.Close();
        }
    }
}
