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
    public partial class listemixqge : UserControl
    {
         MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public listemixqge()
        {
            InitializeComponent();
        }

        private void listemixqge_Load(object sender, EventArgs e)
        {
              try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * from jury", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbjury.Items.Add(dr[0].ToString());
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
            this.DataTable4TableAdapter.Fill(this.DataSet1.DataTable4, int.Parse(cmbjury.Text));
            this.reportViewer1.RefreshReport();
        }

        private void cmbjury_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 MySqlCommand cmd = new MySqlCommand("SELECT * from jury where idjury='" + cmbjury.Text + "'", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbl.Text=dr[1].ToString();
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException msg)
            {
                
                MessageBox.Show("Erreur" + msg);
            }
        }
    }
}
