using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tfcakila
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtmotdepasse.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("Select * from utilisateur where username= '" + txtusername.Text + "' and motdepasse='" + txtmotdepasse.Text + "'", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr[3].ToString() == "Administrateur")
                    {
                        administrateur administrateur = new administrateur();
                        administrateur.Show();
                        con.Close();
                        this.Hide();
                    }
                    else if (dr[3].ToString() == "Secretaire")
                    {
                        secretaire sec = new secretaire();
                        sec.Show();
                        con.Close();
                        this.Hide();
                    }

                }
                else
                {

                    MessageBox.Show("Mot de passe ou User name incorecte", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            else {
                MessageBox.Show("Il ya un champs vide, Veiller remplir tout les champs", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtmotdepasse.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtmotdepasse.UseSystemPasswordChar = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtmotdepasse_TextChanged(object sender, EventArgs e)
        {
            txtmotdepasse.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtmotdepasse.UseSystemPasswordChar = false;
        }
    }
}
