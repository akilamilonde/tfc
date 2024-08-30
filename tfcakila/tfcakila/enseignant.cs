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
    public partial class enseignant : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public enseignant()
        {
            InitializeComponent();
        }
        public void selection_tableau()
        {
            try
            {
                tableauenseignant.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from enseignant", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int nb = 0;
                while (dr.Read())
                {
                    nb++;
                    tableauenseignant.Rows.Add(dr[0].ToString(),nb, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }
        private void enseignant_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            selection_tableau();
            cmbgenre.Items.Add("M");
            cmbgenre.Items.Add("F");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into enseignant (idenseingant, matricule, nom, postnom, prenom, genre, datenaissance, lieunaissance) values('" + txtid.Text + "', '" + txtmatricule.Text + "','" + txtnom.Text + "','" + txtpostnom.Text + "','" + txtprenom.Text + "','" + cmbgenre.Text + "', '" + datene.Value.ToString("yyMMdd") + "','" + txtlieu.Text + "')", con);
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                MessageBox.Show("Enregistrement effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selection_tableau();
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
                MySqlCommand cmd = new MySqlCommand("Update enseignant set matricule= '" + txtmatricule.Text + "', nom='" + txtnom.Text + "',postnom='" + txtpostnom.Text + "', prenom'" + txtprenom.Text + "',genre='" + cmbgenre.Text + "', datenaissence'" + datene.Value.ToString("yyMMdd") + "',lieunaissance='" + txtlieu.Text + "' where idenseignant='" + txtid.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Modification effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableau();


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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from enseignant  where idenseignant='" + txtid.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableau();


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
            txtmatricule.Text = "";
            txtnom.Text = "";
            txtpostnom.Text = "";
            txtprenom.Text = "";
            cmbgenre.Text = "";
            txtlieu.Text = "";
        }

        private void tableauenseignant_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void tableauenseignant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableauenseignant.CurrentRow.Cells[0].Value != null)
            {
                txtid.Text = tableauenseignant.CurrentRow.Cells[0].Value.ToString();
                txtmatricule.Text = tableauenseignant.CurrentRow.Cells[2].Value.ToString();
                txtnom.Text = tableauenseignant.CurrentRow.Cells[3].Value.ToString();
                txtpostnom.Text = tableauenseignant.CurrentRow.Cells[4].Value.ToString();
                txtprenom.Text = tableauenseignant.CurrentRow.Cells[5].Value.ToString();
                cmbgenre.Text = tableauenseignant.CurrentRow.Cells[6].Value.ToString();
                txtlieu.Text = tableauenseignant.CurrentRow.Cells[8].Value.ToString();
            }
        }
    }
}
