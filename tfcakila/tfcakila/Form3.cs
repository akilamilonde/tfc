using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tfcakila
{
    public partial class Form3 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost; uid='root';pwd='';database= brassageinska");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'brassageinskaDataSet.brassage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.brassageTableAdapter.Fill(this.brassageinskaDataSet.brassage);

        }

        private void brassageBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
