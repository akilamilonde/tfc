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
    public partial class mwalimu : UserControl
    {
        public mwalimu()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void mwalimu_Load(object sender, EventArgs e)
        {
            this.enseignantTableAdapter.Fill(this.DataSet1.enseignant);
            this.reportViewer1.RefreshReport();
        }
    }
}
