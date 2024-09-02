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
    public partial class controllisteinscri : UserControl
    {
        public controllisteinscri()
        {
            InitializeComponent();
        }

        private void controllisteinscri_Load(object sender, EventArgs e)
        {
            this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);
            this.reportViewer1.RefreshReport();
        }
    }
}
