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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projet_login_1
{
    public partial class Form1 : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=commercia;Integrated Security=True");// for connection c# with sql
        /*SqlCommand cmd;*/ // for command ya3ni bih kanarbto had lma3lomat likanktboha hna bach tamchilna l sql
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void button1_Click(object sender, EventArgs e)
        {
            // Check Username befor save :
            SqlDataAdapter da = new SqlDataAdapter("select UserI from Inscreption where UserI='" + PostCode.Text + "'", cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            // genre
            string a;
            if (radioButton1.Checked == true)
            {
                a = "femme";
            }
            else a = "homme";
            if (bTextbox1.Text == "" || bTextbox2.Text == "" || Telephone.Text == "" || PostCode.Text == "" || password.Text == "" || bTextbox6.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields");//ila l9alna chi case khawya 3ad kayt2afiha had lmsg
            }  
            else if (password.Text!= bTextbox6.Text)
            {
                MessageBox.Show("Password dont match"); //kayt2akad lina man mot de pass wach sa7i7
            }
            else if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("UsernameL existing");//kaychoflina dak User wach deja msajlin bih wala nn
            }
           
            else
            {
                DialogResult rus = MessageBox.Show("Done", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rus == DialogResult.Yes)
                {
                    try
                    {
                        // Save UsernameL in the databese table :
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand(" insert into  Inscreption (NomI,PrenomI ,EmailI,UserI ,PasswordI,DateI,GenreI) values('" + bTextbox1.Text + "' , '" + bTextbox2.Text + "' , '" + Telephone.Text + "' , '" + PostCode.Text + "' , '" + password.Text + "' , '" + a+ "')", cnx);
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                        MessageBox.Show("Congratulation");
                        //Clear();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("some Error was occured  " + ex.Message);
                    }
                    finally // ya3ni swa khadmat wala makhdmatch khaso yatbala3 
                    {
                        cnx.Close();
                    }
                }
            }
        }
        void Clear() // bach kindiro inscreption dok les cases ywaliw vide
        {
            bTextbox1.Text = bTextbox2.Text = Telephone.Text = PostCode.Text = password.Text = bTextbox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();// rir dik la page likatbala3
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // Check Username befor save :
            SqlDataAdapter da = new SqlDataAdapter("select username from utilisateur where username='" + username.Text + "'", cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // genre
            string a;
            if (radioButton1.Checked == true)
            {
                a = "Female";
            }
            else a = "male";
            if (bTextbox1.Text == "" || bTextbox2.Text == "" || Telephone.Text == "" || PostCode.Text == "" || password.Text == "" || bTextbox6.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields");//ila l9alna chi case khawya 3ad kayt2afiha had lmsg
                
               
            }
            else
            {
                if (password.Text != bTextbox6.Text)
                {
                    MessageBox.Show("Password doesn't match"); //kayt2akad lina man mot de pass wach sa7i7
                   
                }
                else
                {
                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("Username existing");//kaychoflina dak User wach deja msajlin bih wala nn
                    }

                    else
                    {
                        DialogResult rus = MessageBox.Show("are you sure", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (rus == DialogResult.Yes)
                        {
                            try
                            {
                                // Save UsernameL in the databese table :
                                cnx.Open();

                                SqlCommand cmd = new SqlCommand("insert into  utilisateur (Nom,Prenom ,Email,username ,password,gender, Telephone  ,Ville,PostCode) values('" + bTextbox1.Text + "' , '" + bTextbox2.Text + "' , '" + email.Text + "' , '" + username.Text + "' , '" + password.Text + "', '" + a + "', '" + Telephone.Text + "' , '" + Ville.Text + "' , '" + PostCode.Text + "')", cnx);
                                cmd.ExecuteNonQuery();
                                cnx.Close();
                                MessageBox.Show("Congratulation");
                                this.Hide();
                                Login l = new Login();
                                l.Show();
                                //Clear();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("some Error was occured  " + ex.Message);
                            }
                            finally // ya3ni swa khadmat wala makhdmatch khaso yatbala3 
                            {
                                cnx.Close();
                            }
                        }
                    }
                }
            }
            
        }
    }
}
