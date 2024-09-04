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
    public partial class rapafec : UserControl
    {
        public rapafec()
        {
            InitializeComponent();
        }

        private void rapafec_Load(object sender, EventArgs e)
        {
            this.DataTable3TableAdapter.Fill(this.DataSet1.DataTable3);
            this.reportViewer1.RefreshReport();
        }
    }
}
