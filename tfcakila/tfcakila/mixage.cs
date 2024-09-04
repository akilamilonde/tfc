using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tfcakila
{
    public partial class mixage : UserControl
    {
         MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        MySqlConnection conn = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public mixage()
        {
            InitializeComponent();
        }
        public void Brassages()
        {
            try
            {
                con.Close();
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
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand trn = new MySqlCommand("TRUNCATE table brassage");
           MySqlCommand cmd = new MySqlCommand("SELECT COUNT(idinscri)  from inscription where (idinscri) NOT IN (SELECT inscription FROM brassage)", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    int nb = int.Parse(dr[0].ToString());
                   
                    con.Close();
                    for (int i = 0; i <= nb; i++)
                    {
                        MySqlCommand cmdr = new MySqlCommand("SELECT COUNT(idjury) FROM jury", con);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                      
                        MySqlDataReader drr = cmdr.ExecuteReader();
                        if (drr.Read())
                        {
                            int nbjury = int.Parse(drr[0].ToString());
                           
                            con.Close();
                            MySqlCommand cmdrr = new MySqlCommand("SELECT * from jury;", con);
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                   
                            MySqlDataReader drrr = cmdrr.ExecuteReader();
                            while (drrr.Read())
                            {
                               
                               
                                int jury = int.Parse(drrr[0].ToString());
                                
                                MySqlCommand cmdrrrr = new MySqlCommand("SELECT idinscri from inscription where (idinscri) NOT IN (SELECT inscription FROM brassage) order by idinscri limit 1", conn);
                                if (conn.State == ConnectionState.Closed)
                                {
                                    conn.Open();
                                }
                            

                                MySqlDataReader drrrr = cmdrrrr.ExecuteReader();
                                if (drrrr.Read())
                                {
                                    int eleve = int.Parse(drrrr[0].ToString());
                                    conn.Close();
                                    
                                    MySqlCommand ins = new MySqlCommand("insert into brassage (inscription,jury) values ('" + eleve + "', '" + jury + "')", conn);
                                    conn.Open();
                                    if (ins.ExecuteNonQuery() == 1)
                                    {
                                        conn.Close();
                                        
                                   
                                        
                                    }
                                    else
                                    {
                                       
                                        conn.Close();
                                    }
                                }
                                else
                                {
                                    //con.Close();
                                    drrrr.Close(); 
                                }
                            }
                            nb = nb - nbjury;
                            
                            
                            drrr.Close();
                        }
                        //con.Close();
                        drr.Close();
                        
                    }
                    
                }
                con.Close();
                dr.Close();
                MessageBox.Show("Brassage  reussie avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Brassages();

        }

        private void mixage_Load(object sender, EventArgs e)
        {
            Brassages();
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
