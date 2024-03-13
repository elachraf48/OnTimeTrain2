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
    public partial class cherchier : Form
    {
        commerciaEntities db = new commerciaEntities();

        public cherchier()
        {
            InitializeComponent();
          
            
        }

        private void cherchier_Load(object sender, EventArgs e)
        {
            SERVECE.SelectedItem = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                try
                {

                    string x = Convert.ToString(bureau.SelectedValue);
                    int mt = Convert.ToInt32(typr_matr.SelectedValue);
                    //dataGridView1.DataSource = db.materiel.Where(w => w.id_bureau == x && w.id_type_materiel == mt && w.detail_materiel.etat == "difectue").Select(b => new { b.bureau.nom_bureau, catigorie = b.type_materiel.libelle, b.detail_materiel.fiche_technique, b.detail_materiel.etat, b.detail_materiel.materiel_difectue.description_MD }).ToList();

                }
                catch { }
            }
            else comboBox5_SelectedIndexChanged(sender, e);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SERVECE.Text != "")
            {
                try
                {
                    int k = Convert.ToInt32(SERVECE.SelectedValue);
                    //comboBox2.DataSource = from i in db.bureau where i.id_service == k select i;
                    //db.bureau.Where(w => w.id_service == j).ToList();
                    bureau.DisplayMember = "nom_bureau";
                    bureau.ValueMember = "id_bureau";
                    //bureau.DataSource = db.bureau.Where(w => w.id_service == k).ToList();
                }
                catch { }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bureau.Text != "")
            {

                //typr_matr.DataSource = db.type_materiel.ToList();
                typr_matr.DisplayMember = "libelle";
                typr_matr.ValueMember = "id_type_materiel";
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string x = Convert.ToString(bureau.SelectedValue);
                int mt = Convert.ToInt32(typr_matr.SelectedValue);
                //dataGridView1.DataSource = db.materiel.Where(w => w.id_bureau == x && w.id_type_materiel == mt).Select(b => new { b.bureau.nom_bureau, catigorie = b.type_materiel.libelle, b.detail_materiel.fiche_technique, b.detail_materiel.etat }).ToList();

            }
            catch { }
        }

        private void bButton1_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(comboBox8.SelectedValue);
            //dataGridView1.DataSource = db.materiel.Where(w => w.id_bureau == x).Select(b => new { b.bureau.nom_bureau, catigorie = b.type_materiel.libelle, b.detail_materiel.fiche_technique, b.detail_materiel.etat }).ToList();

        }

    }
}
