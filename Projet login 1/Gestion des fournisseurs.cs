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
    public partial class Gestion_des_fournisseurs : Form
    {
        commerciaEntities db = new commerciaEntities();

        public Gestion_des_fournisseurs()
        {
            InitializeComponent();
            rempli();
        }
        public void rempli()
        {
            comboID.DataSource = db.fournisseur.Select(s => s.Num_F).ToList();
            dataGridView1.DataSource = db.fournisseur.ToList();
            dataGridView1.Columns[6].Visible = false;
        }
        public bool verfier_combo()
        {
            if (textNOM_ETR.Text != "" && textTEL.Text != "" && textVL.Text != "" && textEML.Text != "" && richTextADS.Text != "")
            {
                return true;
            }

            else return false;
        }
       

      
       
       
        private void comboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = int.Parse(comboID.Text);
            fournisseur fr = db.fournisseur.Where(w => w.Num_F == ID).FirstOrDefault();
            textNOM_ETR.Text = fr.Nom_Entreprise;
           
            textTEL.Text = fr.Telephone;
            textVL.Text = fr.Ville;
            textEML.Text = fr.Email;
            richTextADS.Text = fr.Adresse;
        }
        public void updat()
        {
            String idEmp = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String nom = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            String prenom = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String tele = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            String email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            String ideq = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
           // ajoute_client s = new ajoute_client(idEmp, nom, prenom, tele, email, ideq);
          //  s.ShowDialog();
        }
        private void bButton1_Click_1(object sender, EventArgs e)
        {
            fournisseur fr = new fournisseur();

            fr.Nom_Entreprise = textNOM_ETR.Text;
            fr.Telephone = textTEL.Text;
            fr.Ville = textVL.Text;
            fr.Email = textEML.Text;
            fr.Adresse = richTextADS.Text;
            if (verfier_combo() == true)
            {
                db.fournisseur.Add(fr);
                db.SaveChanges();
                rempli();
                MessageBox.Show("Bien ajoute !!", "ajoute un fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("complete les donne SVP !!", "ajoute un fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            int ID = int.Parse(comboID.Text);

            if (comboID.Text != "")
            {
                fournisseur fr = db.fournisseur.Where(w => w.Num_F == ID).FirstOrDefault();
                db.fournisseur.Remove(fr);
                db.SaveChanges();
                rempli();
                MessageBox.Show("Bien supprimer !!", "supprimer un fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("choise un numero de fournisseur SVP !!", "supprimer un fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(comboID.Text);

            if (verfier_combo() == true)
            {
                fournisseur fr = db.fournisseur.Where(w => w.Num_F == ID).FirstOrDefault();

                fr.Nom_Entreprise = textNOM_ETR.Text;
                fr.Telephone = textTEL.Text;
                fr.Ville = textVL.Text;
                fr.Email = textEML.Text;
                fr.Adresse = richTextADS.Text;
                db.SaveChanges();
                rempli();
                MessageBox.Show("Bien modufier !!", "modufier un fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("complete les donne SVP !!", "modufier un fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            rempli();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            var req = db.fournisseur.Where(w => w.Nom_Entreprise == textrecherch.Text).ToList();
            dataGridView1.DataSource = req.ToList();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(comboID.Text);
            var req = db.commande_achat.Where(w => w.fournisseur1.Num_F == ID).Select(s => new { s.fournisseur1.Nom_Entreprise, s.Num_C_A, s.Date_C }).ToList();
            dataGridView1.DataSource = req.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    comboID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Gestion_des_fournisseurs_Load(object sender, EventArgs e)
        {

        }
    }
}
