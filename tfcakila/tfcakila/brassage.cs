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
    public partial class brassage : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public brassage()
        {
            InitializeComponent();
        }

        private void brassage_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * from jury", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbjury.Items.Add(dr[0].ToString() + "." + dr[1].ToString() );
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
