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
    public partial class cours : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public cours()
        {
            InitializeComponent();
        }
        public void selection_tableaueleve()
        {
            try
            {
                tableaucours.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT cours. *, enseignant.nom, enseignant.postnom, enseignant.prenom FROM cours, enseignant WHERE cours.idenseignant=enseignant.idenseingant; ", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int nb=0;
                while (dr.Read())
                {
                    nb++;
                    tableaucours.Rows.Add(dr[0].ToString(),nb, dr[1].ToString(), dr[3].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString() + " " + dr[5].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }

        private void cours_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            selection_tableaueleve();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select * from enseignant", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
            
                while (dr.Read())
                {
                   
                    cmbenseignant.Items.Add(dr[0].ToString() + "." + dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString());
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
            MySqlCommand cmd = new MySqlCommand("insert into cours (idcours, designation, idenseignant) values('" + txtid.Text + "', '" + txtdesi.Text + "','" + cmbenseignant.Text + "')", con);
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                MessageBox.Show("Enregistrement effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selection_tableaueleve();
            }
            else
            {
                MessageBox.Show("Enregistrement Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Update cours set  designation='" + txtdesi.Text + "', idenseignant='" + cmbenseignant.Text + "'where idcours='" + txtid.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Modification effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableaueleve();


                }
                else
                {
                    MessageBox.Show("Modification Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from cours  where idcours='" + txtid.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableaueleve();


                }
                else
                {
                    MessageBox.Show("Suppression Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }

            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtdesi.Text = "";
            cmbenseignant.Text = "";
        }

        private void tableaucours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableaucours.CurrentRow.Cells[0].Value != null)
            {
                txtid.Text = tableaucours.CurrentRow.Cells[0].Value.ToString();
                txtdesi.Text = tableaucours.CurrentRow.Cells[2].Value.ToString();
                cmbenseignant.Text = tableaucours.CurrentRow.Cells[3].Value.ToString() ;
            }
        }
    }
}
