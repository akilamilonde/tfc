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
    public partial class utilisateur : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public utilisateur()
        {
            InitializeComponent();
        }
        public void selection_tableau() {
            try
            {
                tableau.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from utilisateur", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    tableau.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur"+ msg);
            }
        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into utilisateur(idutilisateur, username, motdepasse, fonction) values('" + txtid.Text + "', '" + txtusername.Text + "','" + txtmotdepasse.Text + "','" + cmbfonction.Text + "')", con);
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                MessageBox.Show("Enregistrement effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selection_tableau();

            }
            else {
                MessageBox.Show("Enregistrement Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void utilisateur_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            cmbfonction.Items.Add("Administrateur");
            cmbfonction.Items.Add("Directeurdesetudes");
            cmbfonction.Items.Add("Secretaire");
            selection_tableau();

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Update utilisateur set username='" + txtusername.Text + "', motdepasse='" + txtmotdepasse.Text + "',fonction='" + cmbfonction.Text + "' where idutilisateur='" + txtid.Text + "'",con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1) {
                    con.Close();
                    MessageBox.Show("Modification effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableau();
                   

                }
                else {
                MessageBox.Show("Modification Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }

        private void tableau_SelectionChanged(object sender, EventArgs e)
        {
            if (tableau.CurrentRow.Cells[0].Value != null) {
                txtid.Text = tableau.CurrentRow.Cells[0].Value.ToString();
                txtusername.Text = tableau.CurrentRow.Cells[1].Value.ToString();
                txtmotdepasse.Text = tableau.CurrentRow.Cells[2].Value.ToString();
                cmbfonction.Text = tableau.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from utilisateur  where idutilisateur='" + txtid.Text + "'",con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1) {
                    con.Close();
                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableau();
                   

                }
                else {
                MessageBox.Show("Suppression Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            }
            catch (MySqlException msg)
            {
                
                MessageBox.Show("Erreur" + msg);
            }
        }

        private void vider_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtmotdepasse.Text = "";
            txtusername.Text = "";
            cmbfonction.Text = "";
            
        }
    }
}
