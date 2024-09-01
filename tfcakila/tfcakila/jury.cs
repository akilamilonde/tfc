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
    public partial class jury : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public jury()
        {
            InitializeComponent();
        }
        public void selection_tableau()
        {
            try
            {
                tableaujury.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from jury", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int nb = 0;
                while (dr.Read())
                {
                    nb++;
                    tableaujury.Rows.Add(dr[0].ToString(), nb, dr[1].ToString(), dr[2].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             MySqlCommand cmd = new MySqlCommand("insert into jury (idjury, designation, nbreplace) values('" + txtid.Text + "', '" + txtdesign.Text + "','" + txtplace.Text + "')", con);
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                MessageBox.Show("Enregistrement effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdesign.Text = " ";
                txtid.Text = " ";
                txtplace.Text = " ";
                selection_tableau();
            }
            else
            {
                MessageBox.Show("Enregistrement Echoué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Update jury set designation= '" + txtdesign.Text + "', nbreplace='" + txtplace.Text + "' where idjury='" + txtid.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Modification effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdesign.Text = " ";
                    txtid.Text = " ";
                    txtplace.Text = " ";
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
                MySqlCommand cmd = new MySqlCommand("delete from jury  where idjury='" + txtid.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdesign.Text = " ";
                    txtid.Text = " ";
                    txtplace.Text = " ";
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

        private void jury_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            selection_tableau();
        }

        private void tableaujury_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableaujury.CurrentRow.Cells[0].Value != null)
            {
                txtid.Text = tableaujury.CurrentRow.Cells[0].Value.ToString();
                txtdesign.Text = tableaujury.CurrentRow.Cells[2].Value.ToString();
                txtplace.Text = tableaujury.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
