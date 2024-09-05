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
    public partial class sec : Form
    {
        public sec()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cours cr = new cours();
            panel2.Controls.Clear();
            panel2.Controls.Add(cr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel2.Controls.Clear();
            panel2.Controls.Add(ac);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eleve el = new eleve();
            panel2.Controls.Clear();
            panel2.Controls.Add(el);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            classe clas = new classe();
            panel2.Controls.Clear();
            panel2.Controls.Add(clas);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            section sect = new section();
            panel2.Controls.Clear();
            panel2.Controls.Add(sect);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            enseignant ens = new enseignant();
            panel2.Controls.Clear();
            panel2.Controls.Add(ens);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inscription ins = new inscription();
            panel2.Controls.Clear();
            panel2.Controls.Add(ins);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rapportsec rp = new rapportsec();
            panel2.Controls.Clear();
            panel2.Controls.Add(rp);
        }

        private void sec_Load(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel2.Controls.Clear();
            panel2.Controls.Add(ac);
        }
    }
}
