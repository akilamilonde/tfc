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
    public partial class rapportsec : UserControl
    {
        public rapportsec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllisteinscri incris = new controllisteinscri();
            panel2.Controls.Clear();
            panel2.Controls.Add(incris);
        }
    }
}
