using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfcakila
{
    public partial class proviseur : Form
    {
        public proviseur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jury jur = new jury();
            panel2.Controls.Clear();
            panel2.Controls.Add(jur);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel2.Controls.Clear();
            panel2.Controls.Add(ac);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brassage bra = new brassage();
            panel2.Controls.Clear();
            panel2.Controls.Add(bra);
        }
    }
}
