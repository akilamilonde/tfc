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
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public Form4()
        {
            InitializeComponent();
        }
        public void Brassages()
        {
            try
            {
                brassage.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT eleve.nom,eleve.postnom,eleve.prenom,classe.designationclasse,section.designationsection,jury.designation FROM eleve,classe,section,inscription,jury,brassage where eleve.ideleve=inscription.ideleve and inscription.idclasse=classe.idclasse and classe.idsection=section.idsection and inscription.idinscri=brassage.inscription and jury.idjury=brassage.jury;", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int nb = 0;
                while (dr.Read())
                {
                    nb++;
                    brassage.Rows.Add(nb, dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString(), dr[3].ToString() + " " + dr[4].ToString(), dr[5].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Brassages();
        }
    }
}
