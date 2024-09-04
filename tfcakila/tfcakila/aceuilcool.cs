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
    public partial class aceuilcool : Form
    {
        public aceuilcool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel3.Controls.Clear();
            panel3.Controls.Add(ac);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            utilisateur ut = new utilisateur();
            panel3.Controls.Clear();
            panel3.Controls.Add(ut);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            utrap utu = new utrap();
            panel3.Controls.Clear();
            panel3.Controls.Add(utu);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aceuilcool_Load(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            panel3.Controls.Clear();
            panel3.Controls.Add(ac);
        }
    }
}
