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
    public partial class eleve : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public eleve()
        {
            InitializeComponent();
        }
        public void selection_tableaueleve() {
            try
            {
                 tableaueleve.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from eleve", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int nb = 0;
                while (dr.Read()) {
                    nb++;
                   tableaueleve.Rows.Add(dr[0].ToString(), nb,dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {
                
                MessageBox.Show("Erreur"+ msg);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void eleve_Load(object sender, EventArgs e)
        {
            txtideleve.Visible = false;
            cmbgenre.Items.Add ("M");
            cmbgenre.Items.Add("F");
            selection_tableaueleve(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into eleve (ideleve, nom, postnom, prenom, genre, datenaissance, lieunaissance) values('" + txtideleve.Text + "', '" + txtnom.Text + "','" + txtpostnom.Text + "','" + txtprenom.Text + "','" + cmbgenre.Text + "', '" + dtnaissance.Value.ToString("yyMMdd") + "','" + txtlieu.Text + "')", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from eleve  where ideleve='" + txtideleve.Text + "'",con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1) {
                    con.Close();
                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableaueleve() ;
                   

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Update eleve set  nom='" + txtnom.Text + "',postnom='" + txtpostnom.Text + "', prenom'" + txtprenom.Text + "',genre='" + cmbgenre.Text + "', datenaissence'" + dtnaissance.Value.ToString("yyMMdd") + "',lieunaissance='" + txtlieu.Text + "' where ideleve='" + txtideleve.Text + "'",con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1) {
                    con.Close();
                    MessageBox.Show("Modification effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   selection_tableaueleve() ;
                   

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

        private void tableaueleve_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtideleve.Text = "";
            txtnom.Text = "";
            txtpostnom.Text = "";
            txtprenom.Text = "";
            cmbgenre.Text = "";
            txtlieu.Text = "";
        }

        private void tableaueleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableaueleve.CurrentRow.Cells[0].Value != null)
            {
                txtideleve.Text = tableaueleve.CurrentRow.Cells[0].Value.ToString();
                txtnom.Text = tableaueleve.CurrentRow.Cells[2].Value.ToString();
                txtpostnom.Text = tableaueleve.CurrentRow.Cells[3].Value.ToString();
                txtprenom.Text = tableaueleve.CurrentRow.Cells[4].Value.ToString();
                cmbgenre.Text = tableaueleve.CurrentRow.Cells[5].Value.ToString();
                txtlieu.Text = tableaueleve.CurrentRow.Cells[7].Value.ToString();
            }
        }
    }
}
