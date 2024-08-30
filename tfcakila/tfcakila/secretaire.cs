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
    public partial class secretaire : Form
    {
        public secretaire()
        {
            InitializeComponent();
        }

        private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel1.Controls.Clear();
            panel1.Controls.Add(ac);
        }

        private void enregistrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eleve el = new eleve();
            panel1.Controls.Clear();
            panel1.Controls.Add(el);
        }

        private void séctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            section sect = new section();
            panel1.Controls.Clear();
            panel1.Controls.Add(sect);
        }

        private void secretaire_Load(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel1.Controls.Clear();
            panel1.Controls.Add(ac);
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classe clas = new classe();
            panel1.Controls.Clear();
            panel1.Controls.Add(clas);
        }

        private void enseignantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enseignant ens = new enseignant();
            panel1.Controls.Clear();
            panel1.Controls.Add(ens);
        }

        private void coursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cours cr = new cours();
            panel1.Controls.Clear();
            panel1.Controls.Add(cr);
        }
    }
}
