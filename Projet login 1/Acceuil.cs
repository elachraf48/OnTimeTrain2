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
    public partial class Acceuil : Form
    {
        commerciaEntities db = new commerciaEntities();
       
        
        public Acceuil()
        {
            InitializeComponent();
           
            //materiel m = new materiel();
            
           
          
            //label7.Text = db.detail_materiel.Count(c => c.id_type_materiel == 4).ToString();
            //label8.Text = db.detail_materiel.Count(c => c.id_type_materiel == 5).ToString();
            //label9.Text = db.detail_materiel.Count(c => c.id_type_materiel == 6).ToString();
            //label10.Text = db.detail_materiel.Count(c => c.id_type_materiel == 1).ToString();
            //label11.Text = db.detail_materiel.Count(c => c.id_type_materiel == 2).ToString();
            //label12.Text = db.detail_materiel.Count(c => c.id_type_materiel == 3).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // katal3ab 3la surface dyal panel (width)
            if (panel1.Width == 200)
            {
                panel1.Width =60;
            }
            else
            {
                panel1.Width = 200;
            }
        }

        private void ClientFormInPanel(object Formijo)// bach t aficher form fwasst panel
        {
            //if (this.panel3.Controls.Count > 0)
            //{
            //    this.panel3.Controls.RemoveAt(0);
            //}
            //Form th = Formijo as Form;
            ////th.TopLevel = false;
            //th.Dock = DockStyle.Fill;
            //this.panel3.Controls.Add(th);
            //this.panel3.Tag = th;
            //th.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            // lpanel librit t afficha fiha form
            panMove.Top = btnClient.Top;
            if (panel3.Visible == true) { panel3.Visible = false; }
            Gestion_Client f = new Gestion_Client();
            
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            //ClientFormInPanel(new Client_0());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // fin ma clikit 3la button wa7ed panel kat7arak m3ak
            panMove.Top = btnFourni.Top;
            if (panel3.Visible == true) { panel3.Visible = false; }
            Gestion_des_fournisseurs f1 = new Gestion_des_fournisseurs();
           
            f1.MdiParent = this;
            f1.Show();
            f1.Dock = DockStyle.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panMove.Top = bntComs.Top;
            if (panel3.Visible == true) { panel3.Visible = false; }
            asces2 f2 = new asces2();
            
            f2.MdiParent = this;
            f2.Show();
            f2.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panMove.Top = btnStats.Top;
            panel3.Visible = true;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panel3.Visible == true){ panel3.Visible = false; }
            panMove.Top = btnOption.Top;
            //ClientFormInPanel(new UserControl1());
            Options f3 = new Options();
            
            f3.MdiParent = this;
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }
       
        private void butpro_Click(object sender, EventArgs e)
        {
            panMove.Top = btnPro.Top;
            if (panel3.Visible == true) { panel3.Visible = false; }
            Gestion_des_produits f4 = new Gestion_des_produits();
            f4.MdiParent = this;
            f4.Show();
            f4.Dock = DockStyle.Fill;
            //ClientFormInPanel(new F_Produit());


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show(); // bach kan afichiw page inscreption
            this.Hide();//login matab9ach
            
        }

       

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            if(this.WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panMove.Top = button1.Top;
            if (panel3.Visible == true) { panel3.Visible = false; }
            cherchier f5 = new cherchier();
            f5.MdiParent = this;
            f5.Show();
            f5.Dock = DockStyle.Fill;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panMove.Top = button1.Top;
            if (panel3.Visible == true) { panel3.Visible = false; }
            cherchier f6 = new cherchier();
            f6.MdiParent = this;
            f6.Show();
            f6.Dock = DockStyle.Fill;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (panel3.Visible == true) { panel3.Visible = false; }
            panMove.Top = button2.Top;
            //ClientFormInPanel(new UserControl1());
            ajoute f = new ajoute();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
