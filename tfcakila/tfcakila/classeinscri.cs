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
    public partial class classeinscri : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public classeinscri()
        {
            InitializeComponent();
        }

        private void classeinscri_Load(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * from classe", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbclasse1.Items.Add(dr[0].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {

                MessageBox.Show("Erreur" + msg);
            }
            
        }

        private void cmbclasse1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT classe.*,section.designationsection from classe, section where classe.idsection=section.idsection and classe.idclasse='" + cmbclasse1.Text + "'", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblclasse.Text = dr[1].ToString() + " " + dr[3].ToString();
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
            this.DataTable5TableAdapter.Fill(this.DataSet1.DataTable5, int.Parse(cmbclasse1.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
