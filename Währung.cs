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
    public partial class Währung : Form
    {
        public Währung()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSchließenWährung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxWährung1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Währung1 = double.Parse(textBoxWährung1.Text);
            if ((string)comboBoxWährung1.SelectedItem == "Euro" && (string)comboBoxWährung2.SelectedItem == "Dollar")
            {
                double conver = Währung1 * 1.21;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Euro" && (string)comboBoxWährung2.SelectedItem == "Pfund")
            {
                double conver = Währung1 * 0.88;

                textBoxWährung2.Text = "" + conver;
            }
             else if((string)comboBoxWährung1.SelectedItem == "Euro" && (string)comboBoxWährung2.SelectedItem == "kan. Dollar")
            {
                double conver = Währung1 * 1.55;

                textBoxWährung2.Text = "" + conver;
            }
            else if((string)comboBoxWährung1.SelectedItem == "Euro" && (string)comboBoxWährung2.SelectedItem == "Schweizer Franken")
            {
                double conver = Währung1 * 1.08;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Euro" && (string)comboBoxWährung2.SelectedItem == "Euro")
            {

                textBoxWährung2.Text = "ungültig";
            }
            // DOLLAR ZU X
            if ((string)comboBoxWährung1.SelectedItem == "Dollar" && (string)comboBoxWährung2.SelectedItem == "Euro")
            {
                double conver = Währung1 * 0.83;
                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Dollar" && (string)comboBoxWährung2.SelectedItem == "Pfund")
            {
                double conver = Währung1 * 0.73;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Dollar" && (string)comboBoxWährung2.SelectedItem == "kan. Dollar")
            {
                double conver = Währung1 * 1.28;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Dollar" && (string)comboBoxWährung2.SelectedItem == "Schweizer Franken")
            {
                double conver = Währung1 * 0.89;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Dollar" && (string)comboBoxWährung2.SelectedItem == "Dollar")
            {

                textBoxWährung2.Text = "ungültig";
            }

            // PFUND ZU X
            if ((string)comboBoxWährung1.SelectedItem == "Pfund" && (string)comboBoxWährung2.SelectedItem == "Euro")
            {
                double conver = Währung1 * 1.14;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Pfund" && (string)comboBoxWährung2.SelectedItem == "Dollar")
            {
                double conver = Währung1 * 1.34;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Pfund" && (string)comboBoxWährung2.SelectedItem == "kan. Dollar")
            {
                double conver = Währung1 * 1.76;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Pfund" && (string)comboBoxWährung2.SelectedItem == "Schweizer Franken")
            {
                double conver = Währung1 * 1.23;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Pfund" && (string)comboBoxWährung2.SelectedItem == "Pfund")
            {
                textBoxWährung2.Text = "ungültig";
            }
            // KAN DOLLAR ZU X
            if ((string)comboBoxWährung1.SelectedItem == "kan. Dollar" && (string)comboBoxWährung2.SelectedItem == "Euro")
            {
                double conver = Währung1 * 0.65;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "kan. Dollar" && (string)comboBoxWährung2.SelectedItem == "Dollar")
            {
                double conver = Währung1 * 0.78;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "kan. Dollar" && (string)comboBoxWährung2.SelectedItem == "Pfund")
            {
                double conver = Währung1 * 0.57;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "kan. Dollar" && (string)comboBoxWährung2.SelectedItem == "Schweizer Franken")
            {
                double conver = Währung1 * 0.7;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "kan. Dollar" && (string)comboBoxWährung2.SelectedItem == "kan. Dollar")
            {

                textBoxWährung2.Text = "ungültig";
            }
            // SCHWEIZER FRANKEN ZU X
            if ((string)comboBoxWährung1.SelectedItem == "Schweizer Franken" && (string)comboBoxWährung2.SelectedItem == "Euro")
            {
                double conver = Währung1 * 0.92;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Schweizer Franken" && (string)comboBoxWährung2.SelectedItem == "Dollar")
            {
                double conver = Währung1 * 1.12;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Schweizer Franken" && (string)comboBoxWährung2.SelectedItem == "Pfund")
            {
                double conver = Währung1 * 0.81;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Schweizer Franken" && (string)comboBoxWährung2.SelectedItem == "kan. Dollar")
            {
                double conver = Währung1 * 1.43;

                textBoxWährung2.Text = "" + conver;
            }
            else if ((string)comboBoxWährung1.SelectedItem == "Schweizer Franken" && (string)comboBoxWährung2.SelectedItem == "Schweizer Franken")
            {

                textBoxWährung2.Text = "ungültig";
            }

        }

            private void buttonZurück_Click(object sender, EventArgs e)
        {
            FormAuswahl fm = new FormAuswahl();
            fm.Show();
            this.Hide();
        }
    }
}
