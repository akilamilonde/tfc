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

            mixage mix = new mixage();
            panel2.Controls.Clear();
            panel2.Controls.Add(mix);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            affectense aff = new affectense();
            panel2.Controls.Clear();
            panel2.Controls.Add(aff);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rapportsprov af = new rapportsprov();
            panel2.Controls.Clear();
            panel2.Controls.Add(af);
        }
    }
}
