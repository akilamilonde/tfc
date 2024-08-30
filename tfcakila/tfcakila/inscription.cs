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
    public partial class inscription : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public inscription()
        {
            InitializeComponent();
        }
        public void selection_tableauinscri()
        {
            try
            {
                tableauinscri.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT inscription. * ,eleve.nom,eleve.postnom,eleve.prenom,classe.designationclasse, section.designationsection FROM eleve, inscription, classe, section WHERE inscription.ideleve=eleve.ideleve and inscription.idclasse=classe.idclasse and section.idsection=classe.idsection", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int nb = 0;
                while (dr.Read())
                {
                    nb++;
                    tableauinscri.Rows.Add(dr[0].ToString(), nb, dr[1].ToString(), dr[4].ToString() + " " + dr[5].ToString() + " " + dr[6].ToString(), dr[7].ToString() + " " + dr[8].ToString(), dr[2].ToString(), dr[3].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inscription_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            selection_tableauinscri();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT classe.*,section.designationsection from classe, section where classe.idsection=section.idsection;", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbclasse.Items.Add(dr[0].ToString() + "." + dr[1].ToString() + " " + dr[3].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
            try
            {

                MySqlCommand cmd = new MySqlCommand("select * from eleve", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbeleve.Items.Add(dr[0].ToString() + "." + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString());
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
            MySqlCommand cmd = new MySqlCommand("insert into inscription (idinscri, dateinscri, ideleve, idclasse) values ('" + txtid.Text + "', '" + dtinscri.Value.ToString("yyMMdd") + "','" + cmbeleve.Text + "','" + cmbclasse.Text + "')", con);
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                MessageBox.Show("Enregistrement effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selection_tableauinscri();
            }
            else
            {
                MessageBox.Show("Enregistrement Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from inscription  where idinscri='" + txtid.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableauinscri();


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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Update inscription set  dateinscri='" + dtinscri.Value.ToString("yyMMdd") + "', ideleve='" + cmbeleve.Text + "', idclasse='" + cmbclasse.Text + "'where idinscri='" + txtid.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Modification effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableauinscri();


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

        private void button4_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            cmbclasse.Text = "";
            cmbeleve.Text = "";
        }

        private void tableauinscri_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void tableauinscri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableauinscri.CurrentRow.Cells[0].Value != null)
            {
                txtid.Text = tableauinscri.CurrentRow.Cells[0].Value.ToString();
                cmbeleve.Text = tableauinscri.CurrentRow.Cells[5].Value.ToString()+ "." + tableauinscri.CurrentRow.Cells[3].Value.ToString();
                cmbclasse.Text = tableauinscri.CurrentRow.Cells[6].Value.ToString() + "." + tableauinscri.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
