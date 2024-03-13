using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projet_login_1
{
    public partial class Login : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=commercia;Integrated Security=True");// for connection c# with sql
        public Login()
        {
            InitializeComponent();
            bButton1.Focus();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);





       
        int j = 0 ,ss=0, s = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show(); // bach kan afichiw page inscreption
            this.Hide();//login matab9ach
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    Application.Exit(); //program kaytbala3
        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //program kaytbala3
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bTextbox1_Enter(object sender, EventArgs e)
        {
            //vider le txtbox
            if (bTextbox1.Text == "Utilisateur")
            {
                bTextbox1.Text = "";
                bTextbox1.ForeColor = Color.WhiteSmoke;//changer le couleur de txt
                bLabel1.Visible = true;
            }
        }

        private void bTextbox1_Leave(object sender, EventArgs e)
        {
            if (bTextbox1.Text == "")
            {
                bTextbox1.Text = "Utilisateur";
                bTextbox1.ForeColor = Color.Silver;
                bLabel1.Visible = false;
            }
        }

        private void bTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bTextbox2_Enter(object sender, EventArgs e)
        {
            //vider le txtbox
            if (bTextbox2.Text == "Mot De Passe")
            {
                bTextbox2.Text = "";
                bTextbox2.ForeColor = Color.WhiteSmoke;//changer le couleur de txt
                bLabel2.Visible = true;
            }
        }

        private void bTextbox2_Leave(object sender, EventArgs e)
        {
            if (bTextbox2.Text == "")
            {
                bTextbox2.Text = "Mot De Passe";
                bTextbox2.ForeColor = Color.Silver;
                bLabel2.Visible = false;
            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
        }

        private void bCheckbox1_OnChange(object sender, EventArgs e)
        {
            // Show password 
            if (bCheckbox1.Checked == true)
            {
                bTextbox2.isPassword = false;
                bTextbox2.Focus();
                closeye.Visible = false;
                openeye.Visible = true;
            }
            else
            { 

                 bTextbox2.isPassword = true;
                 bTextbox2.Focus();
                 openeye.Visible = false;
                 closeye.Visible = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //string V = "SELECT * FROM Inscreption WHERE UserI ='" + bTextbox1.Text + "'AND PasswordI ='" + bTextbox2.Text + "'";
            //string G = "SELECT * FROM Gerant WHERE UserG ='" + bTextbox1.Text + "'AND passwordG ='" + bTextbox2.Text + "'";
            //string M = "SELECT * FROM Magasinier WHERE UserM ='" + bTextbox1.Text + "'AND passwordM ='" + bTextbox2.Text + "'";

            //SqlDataAdapter daV = new SqlDataAdapter(V, cnx);
            //SqlDataAdapter daG = new SqlDataAdapter(G, cnx);
            //SqlDataAdapter daM = new SqlDataAdapter(M, cnx);

            //DataTable dat = new DataTable();
            //DataTable date = new DataTable();
            //DataTable datM = new DataTable();

            //daV.Fill(dat);
            //daG.Fill(date);
            //daM.Fill(datM);

            if (bTextbox1.Text != "" && bTextbox2.Text != "")
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select username from utilisateur where username='" + bTextbox1.Text + "' and password='" + bTextbox2.Text +"'", cnx);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //if (bTextbox1.Text == "admin" && bTextbox2.Text == "admin")
                    //{
                    if (dt.Rows.Count >= 1)
                    {
                        Acceuil st = new Acceuil();
                        bTextbox1.Text = "";
                        bTextbox2.Text = "";
                        bTextbox2.isPassword = true;
                        bCheckbox1.Checked = false;
                        this.Hide();
                        st.Show();

                    }
                    else
                    {
                        j += 1;
                        if (j > 2)
                        {
                            MessageBox.Show("attendre 30 seconde");
                            timer1.Enabled = true;
                            bPanel1.Visible = true;
                            bLabel3.Visible = true;
                            bButton1.Enabled = false;
                            bCheckbox1.Enabled = false;
                            bTextbox1.Enabled = false;
                            bTextbox2.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("donne incorect");
                            bTextbox1.Select();
                            bTextbox1.Text = "";
                            bTextbox2.Text = "";
                            bTextbox1.Focus();

                        }

                    }
                }
                catch
                {
                    MessageBox.Show("please entre logine and password");
                    bTextbox1.Focus();
                    //bTextbox1.SelectAll();
                }

            }
            else MessageBox.Show("Veuillez compléter les informations", "logine", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show(); // bach kan afichiw page inscreption
            /*this.Hide();*///login matab9ach
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            s += 1;

            if (s >= 30)
            {
                s = 0;
                timer1.Enabled = false;

                bLabel3.Visible = false;
                bLabel3.Text = "30";
                bPanel1.Visible = false;
                bButton1.Enabled = true;
                bCheckbox1.Enabled = true;
                bTextbox1.Enabled = true;
                bTextbox2.Enabled = true;
                bTextbox1.Focus();
                j = 0;
            }
            else if (s < 30) { bLabel3.Text = (int.Parse(bLabel3.Text) - 1).ToString(); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string V = "SELECT * FROM Inscreption WHERE UserI ='" + bTextbox1.Text + "'AND PasswordI ='" + bTextbox2.Text + "'";
            string G = "SELECT * FROM Gerant WHERE UserG ='" + bTextbox1.Text + "'AND passwordG ='" + bTextbox2.Text + "'";
            string M = "SELECT * FROM Magasinier WHERE UserM ='" + bTextbox1.Text + "'AND passwordM ='" + bTextbox2.Text + "'";

            SqlDataAdapter daV = new SqlDataAdapter(V, cnx);
            SqlDataAdapter daG = new SqlDataAdapter(G, cnx);
            SqlDataAdapter daM = new SqlDataAdapter(M, cnx);

            DataTable dat = new DataTable();
            DataTable date = new DataTable();
            DataTable datM = new DataTable();

            daV.Fill(dat);
            daG.Fill(date);
            daM.Fill(datM);

            if (bTextbox1.Text != "" && bTextbox2.Text != "")
            {
                try
                {
                    if (date.Rows.Count == 1)
                    {
                        // Gerant :
                        Acceuil ad = new Acceuil(); // pour afficher la form when login correct
                        bTextbox1.Text = "";// kiyt afichaw makhashomch yab9aw 3amrin
                        bTextbox2.Text = "";
                        bTextbox2.isPassword = true;//mot pas maybanch
                        bCheckbox1.Checked = false; //mot pass khasso ykon maybach 
                        ad.Show();//la form libriniha t afficha  radi t afficha
                        this.Hide();//la form dyal login matab9ach tban
                        
                    }
                   else if (datM.Rows.Count == 1)
                    {
                        //Magasinier :
                        
                        bTextbox1.Text = "";
                        bTextbox2.Text = "";
                        bTextbox2.isPassword = true;
                        bCheckbox1.Checked = false;  
                        this.Hide();
                   
                    }
                    else if (dat.Rows.Count == 1)
                    {
                        //Vendure :
                       
                        bTextbox1.Text = "";
                        bTextbox2.Text = "";
                        bTextbox2.isPassword = true;
                        bCheckbox1.Checked = false;
                        this.Hide();
                      
                    
                    }
                    else
                    {
                        j += 1;
                        if (j > 2)
                        {
                            MessageBox.Show("attendre 30 seconde");
                            timer1.Enabled = true;
                            bPanel1.Visible = true;
                            bLabel3.Visible = true;
                            bButton1.Enabled = false;
                            bCheckbox1.Enabled = false;
                            bTextbox1.Enabled = false;
                            bTextbox2.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("donne incorect");
                            bTextbox1.Select();
                            bTextbox1.Text = "";
                            bTextbox2.Text = "";
                            bTextbox1.Focus();

                        }

                    }
                }
                catch
                {
                    MessageBox.Show("please entre logine and password");
                    bTextbox1.Focus();
                    //bTextbox1.SelectAll();
                }

            }
            else MessageBox.Show("Veuillez compléter les informations", "logine", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

    }
              
                
    }
}
