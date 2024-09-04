using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfcakila
{
    public partial class utrap : UserControl
    {
        public utrap()
        {
            InitializeComponent();
        }

        private void utrap_Load(object sender, EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.DataSet1.utilisateur);
            this.reportViewer1.RefreshReport();
        }
    }
}
