using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umformungsrechner
{
    public partial class FormAuswahl : Form
    {
        public FormAuswahl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Währung WährungFM = new Währung();
            WährungFM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Länge LängeFM = new Länge();
            LängeFM.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGewicht_Click(object sender, EventArgs e)
        {
            Gewicht ge = new Gewicht();
            ge.Show();
            this.Hide();
        }
    }
}
