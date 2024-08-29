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
    public partial class section : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public section()
        {
            InitializeComponent();
        }
        public void selection_tableausection()
        {
            try
            {
                tableausection.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from section", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tableausection.Rows.Add(dr[0].ToString(), dr[1].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
        }

        private void section_Load(object sender, EventArgs e)
        {
            txtidsection.Visible = false;
            selection_tableausection();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into section(idsection, designationsection) values('" + txtidsection.Text + "', '" + txtsection.Text + "')", con);
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                MessageBox.Show("Enregistrement effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selection_tableausection();

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
                MySqlCommand cmd = new MySqlCommand("Update section set desigentionsection='" + txtsection.Text + "' where idsection='" + txtidsection.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Modification effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableausection();


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
                MySqlCommand cmd = new MySqlCommand("delete from section  where idsection='" + txtidsection.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selection_tableausection();


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
            txtidsection.Text = "";
            txtsection.Text = "";
        }

        private void tableausection_SelectionChanged(object sender, EventArgs e)
        {
            if (tableausection.CurrentRow.Cells[0].Value != null)
            {
                txtidsection.Text = tableausection.CurrentRow.Cells[0].Value.ToString();
                txtsection.Text = tableausection.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
