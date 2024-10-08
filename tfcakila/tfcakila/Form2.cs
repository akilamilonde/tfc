﻿using System;
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
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        MySqlConnection conn = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                 MySqlCommand cmd = new MySqlCommand("SELECT COUNT(idinscri)  from inscription where (idinscri) NOT IN (SELECT inscription FROM brassage)", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    int nb = int.Parse(dr[0].ToString());
                    label1.Text = nb.ToString();
                    con.Close();
                    for (int i = 0; i <= nb; i++)
                    {
                        MySqlCommand cmdr = new MySqlCommand("SELECT COUNT(idjury) FROM jury", con);
                        con.Open();
                        MySqlDataReader drr = cmdr.ExecuteReader();
                        if (drr.Read())
                        {
                            int nbjury = int.Parse(drr[0].ToString());
                            label2.Text = nbjury.ToString();
                            con.Close();
                            MySqlCommand cmdrr = new MySqlCommand("SELECT * from jury;", con);
                            con.Open();
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
                                        MessageBox.Show("Enregistrement effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        
                                        
                                    }
                                    
                                    else
                                    {
                                        MessageBox.Show("Enregistrement Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                            con.Close();
                            drrr.Close();

                        }
                        con.Close();
                        drr.Close();

                        
                    }
                    
                }
                con.Close();
                dr.Close();
        }
    }
}
