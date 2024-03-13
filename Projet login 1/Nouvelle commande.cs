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
    public partial class Nouvelle_commande : Form
    {
        commerciaEntities db = new commerciaEntities();
        string tp ;
        int num ;
        int qt ;
        public Nouvelle_commande(string type,int nump,int QTT)
        {
            InitializeComponent();
             tp = type;
             num = nump;
             qt = QTT;
            dataGridView2.Columns.Add("f", "c");
            dataGridView2.Columns.Add("p", "p");
            dataGridView2.Columns.Add("j", "j");
           
        }

        private void Nouvelle_commande_Load(object sender, EventArgs e)
        {
            if (tp != "")
            {
             dataGridView2.Rows.Add(tp, num, qt);
                
            }
            
            // dataGridView2.DataSource = db.produit.Select(s => new { s.Libelle, s.Prix, s.Quantite, Soustotal = s.Quantite * s.Prix }).ToList();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Ajoute_Produits_a_commande aj = new Ajoute_Produits_a_commande();
            this.Hide();
            aj.ShowDialog();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
