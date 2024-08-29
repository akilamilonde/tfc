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
    public partial class classe : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public classe()
        {
            InitializeComponent();
        }
        public void selection_tableau()
        {
            try
            {
                tableauclasse.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT classe.*,section.designationsection from classe, section where classe.idsection=section.idsection;", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tableauclasse.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[3].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }
        private void classe_Load(object sender, EventArgs e)
        {
            selection_tableau();
            txtidclasse.Visible = false;
            try
            {
                
                MySqlCommand cmd = new MySqlCommand("select * from section", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbsection.Items.Add(dr[0].ToString() + "." + dr[1].ToString());
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
            MySqlCommand cmd = new MySqlCommand("insert into classe (idclasse, designationclasse, idsection) values('" + txtidclasse.Text + "', '" + txtpromotion.Text + "','" + cmbsection.Text + "')", con);
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
                MySqlCommand cmd = new MySqlCommand("delete from classe  where idclasse='" + txtidclasse.Text + "'", con);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Update classe set designationclasse='" + txtpromotion.Text + "', idsection='" + cmbsection.Text + "' where idclasse='" + txtidclasse.Text + "'", con);
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

        private void button4_Click(object sender, EventArgs e)
        {
            txtidclasse.Text = "";
            txtpromotion.Text = "";
            cmbsection.Text = "";
        }

        private void tableauclasse_SelectionChanged(object sender, EventArgs e)
        {
            if (tableauclasse.CurrentRow.Cells[0].Value != null)
            {
                txtidclasse.Text = tableauclasse.CurrentRow.Cells[0].Value.ToString();
                txtpromotion.Text = tableauclasse.CurrentRow.Cells[1].Value.ToString();
                cmbsection.Text = tableauclasse.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
