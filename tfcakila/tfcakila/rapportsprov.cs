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
    public partial class rapportsprov : UserControl
    {
        public rapportsprov()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rapafec incris = new rapafec();
            panel1.Controls.Clear();
            panel1.Controls.Add(incris);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listemixqge incr = new listemixqge();
            panel1.Controls.Clear();
            panel1.Controls.Add(incr);
        }
    }
}
