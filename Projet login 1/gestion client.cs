using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_login_1
{
    public partial class Gestion_Client : Form
    {
        commerciaEntities db = new commerciaEntities();
        public Gestion_Client()
        {
            InitializeComponent();
        }
        public void rempli()
        {
            comboID.DataSource = db.client.Select(s => s.Num_C).ToList();
            c.ad_cl.Fill(c.ds, "cl");
            if (c.ds.Tables["cl"].Rows.Count!=0) { c.ds.Tables["cl"].Rows.Clear(); }
            c.ad_cl.Fill(c.ds, "cl");
            richTextBox1.Text = "";
            for (int i = 0; i < c.ds.Tables["cl"].Rows.Count; i++)
            {

                richTextBox1.Text += c.ds.Tables["cl"].Rows[i][1].ToString() + "  " + c.ds.Tables["cl"].Rows[i][2].ToString() + "\n";

            }
            var req = db.ligne_commande_vente.Select(s => new { s.commande_vente.Num_C_V, s.commande_vente.Date_C, Montant = s.Quantite * s.produit1.Prix }).ToList();
            dataGridView1.DataSource = req.ToList();
            var req1 = db.ligne_commande_vente.Select(s => new { s.produit1.Libelle, s.Quantite, s.produit1.Prix }).ToList();
            dataGridView2.DataSource = req1.ToList();
        }
        private void Assiette_Load(object sender, EventArgs e)
        {
            
            //dataGridView1.DataSource = db.client.Local.ToBindingList();

            //dataGridView1.Columns[7].Visible = false;
            rempli();
        }

        public bool verfier_combo()
        {
            if (comboID.Text!="" && textNOM.Text!="" && textPRN.Text!="" && textTEL.Text!="" && textVL.Text!="" && textEML.Text!="" && richTextADS.Text!="")
            {
                return true;
            }

           else return false;
        }
        bool mth;
       

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                   // comboID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
               
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            

        }

        private void comboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = int.Parse(comboID.Text);
            client cl = db.client.Where(w => w.Num_C == ID).FirstOrDefault();
            textNOM.Text = cl.Nom;
            textPRN.Text = cl.Prenom;
            textTEL.Text = cl.Telephone;
            textVL.Text = cl.Ville;
            textEML.Text = cl.Email;
            richTextADS.Text = cl.Adresse;
           
            var req = db.ligne_commande_vente.Where(w => w.commande_vente.client1.Num_C == ID).Select(s => new { s.commande_vente.Num_C_V, s.commande_vente.Date_C, Montant = s.Quantite * s.produit1.Prix }).ToList();
            dataGridView1.DataSource = req.ToList();
            var req1 = db.ligne_commande_vente.Where(w => w.commande_vente.client1.Num_C == ID).Select(s => new { s.produit1.Libelle, s.Quantite, s.produit1.Prix }).ToList();
            dataGridView2.DataSource = req1.ToList();
        }

        public void display()
        {
            if(textEML.Enabled == false)
            {
                textEML.Enabled = true;
                textNOM.Enabled = true;
                textPRN.Enabled = true;
                textTEL.Enabled = true;
                textVL.Enabled = true;
                richTextADS.Enabled = true;
                return;
            }
            else if (textEML.Enabled == true)
            {
                textEML.Enabled = false;
                textNOM.Enabled = false;
                textPRN.Enabled = false;
                textTEL.Enabled = false;
                textVL.Enabled = false;
                richTextADS.Enabled = false;
                return;
            }

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
           
            var req = db.client.Where(w => w.Nom == textrecherch.Text).ToList();
            dataGridView1.DataSource = req.ToList();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            rempli();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           
        }

        private void bButton1_Click_1(object sender, EventArgs e)
        {
            //if (bButton1.ButtonText == "nouveau client")
            //{
            //    display();
            //    bButton1.ButtonText = "AJOUTE";
            //}
            //else
            //{
            //    display();
            //    bButton1.ButtonText = "nouveau client";
            //}
            
            mth = true;
            string nom = textNOM.Text;
            string prenom = textPRN.Text;
            string tel = textTEL.Text;
            string villle = textVL.Text;
            string email = textEML.Text;
            string adresse = richTextADS.Text;
            string ID = comboID.Text;
          
            ajoute_client aj = new ajoute_client(mth, ID, nom, prenom, tel, email, villle, adresse);
           
            
            
            aj.ShowDialog();
        }
        
        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            mth = false;
            string nom = textNOM.Text;
            string prenom = textPRN.Text;
            string tel = textTEL.Text;
            string villle = textVL.Text;
            string email = textEML.Text;
            string adresse = richTextADS.Text;
            string ID = comboID.Text;

            ajoute_client aj = new ajoute_client(mth, ID, nom, prenom, tel, email, villle, adresse);
            
            aj.ShowDialog();

        }

        private void bunifuThinButton25_Click_1(object sender, EventArgs e)
        {
            Nouvelle_commande nv = new Nouvelle_commande("",0,0);
            nv.ShowDialog();
        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {
            rempli();
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(comboID.Text);

            if (comboID.Text != "")
            {
                client cl = db.client.Where(w => w.Num_C == ID).FirstOrDefault();
                db.client.Remove(cl);
                db.SaveChanges();
                rempli();
                MessageBox.Show("Bien supprimer !!", "supprimer un client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("choise un numero de client SVP !!", "supprimer un client", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
