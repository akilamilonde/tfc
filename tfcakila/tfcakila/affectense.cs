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
    public partial class affectense : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        MySqlConnection conn = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public affectense()
        {
            InitializeComponent();
        }
        public void Brassages()
        {
            try
            {
                brassage.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT enseignant.nom,enseignant.postnom,enseignant.prenom,jury.designation FROM enseignant,jury,affectation where enseignant.idenseingant=affectation.idenseingant and affectation.idjury= jury.idjury;", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MySqlDataReader dr = cmd.ExecuteReader();
                int nb = 0;
                while (dr.Read())
                {
                    nb++;
                    brassage.Rows.Add(nb, dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString(), dr[3].ToString());
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
            try
            {
                MySqlCommand trn = new MySqlCommand("TRUNCATE table affectation",con);
                con.Open();
                if (trn.ExecuteNonQuery() == 1)
                {
                    con.Close();
                }
                else
                {
                    con.Close();
                }
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
            
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(idenseingant ) from enseignant where (idenseingant ) NOT IN (SELECT idenseingant FROM affectation)", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    int nb = int.Parse(dr[0].ToString());
                    
                    con.Close();
                    for (int i = 0; i <= nb; i++)
                    {
                        MySqlCommand cmdr = new MySqlCommand("SELECT COUNT(idjury) FROM jury", con);
                        con.Open();
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
                                MySqlCommand cmdrrrr = new MySqlCommand("SELECT idenseingant   from enseignant where (idenseingant  ) NOT IN (SELECT idenseingant FROM affectation) order by idenseingant   limit 1", conn);
                                if (conn.State == ConnectionState.Closed)
                                {
                                    conn.Open();
                                }
                                MySqlDataReader drrrr = cmdrrrr.ExecuteReader();
                                if (drrrr.Read())
                                {
                                    int enseignant = int.Parse(drrrr[0].ToString());
                                    conn.Close();

                                    MySqlCommand ins = new MySqlCommand("insert into affectation (idenseingant,idjury) values ('" + enseignant + "', '" + jury + "')", conn);
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
                        con.Close();
                        drr.Close();
                        
                    }
                    
                }
                con.Close();
                dr.Close();
                MessageBox.Show("Affectation  avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                      
                Brassages();
        
        }

        private void affectense_Load(object sender, EventArgs e)
        {
            Brassages();
        }
    }
}
