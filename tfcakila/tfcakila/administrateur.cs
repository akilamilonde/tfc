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
    public partial class administrateur : Form
    {
        public administrateur()
        {
            InitializeComponent();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel1.Controls.Clear();
            panel1.Controls.Add(ac);
        }

        private void rapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilisateur ut = new utilisateur();
            panel1.Controls.Clear();
            panel1.Controls.Add(ut);
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void administrateur_Load(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel1.Controls.Clear();
            panel1.Controls.Add(ac);
        }
    }
}
