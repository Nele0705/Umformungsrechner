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
    public partial class Länge : Form
    {
        public Länge()
        {
            InitializeComponent();
        }

        private void buttonSchließenWährung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonZurück_Click(object sender, EventArgs e)
        {
            FormAuswahl fa = new FormAuswahl();
            fa.Show();
            this.Hide();
        }

        private void umrechnen_Click(object sender, EventArgs e)
        {
        }

        private void buttonumrechnen_Click(object sender, EventArgs e)
        {
            //KM ZU X
            double Länge1 = double.Parse(textBoxLänge1.Text);
            if ((string)comboBoxLänge1.Text == "km" && (string)comboBoxLänge2.Text == "m")
            {
                double conver = Länge1 * 1000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "km" && (string)comboBoxLänge2.Text == "cm")
            {
                double conver = Länge1 * 100000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "km" && (string)comboBoxLänge2.Text == "dm")
            {
                double conver = Länge1 * 10000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "km" && (string)comboBoxLänge2.Text == "mm")
            {
                double conver = Länge1 * 1000000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "km" && (string)comboBoxLänge2.Text == "Meile")
            {
                double conver = Länge1 * 0.621371;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "km" && (string)comboBoxLänge2.Text == "Z")
            {
                double conver = Länge1 * 1000000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "km" && (string)comboBoxLänge2.Text == "km")
            {
                textBoxLänge2.Text = "ungültig";
            }

            // M ZU X
            if ((string)comboBoxLänge1.Text == "m" && (string)comboBoxLänge2.Text == "KM")
            {
                double conver = Länge1 / 1000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "m" && (string)comboBoxLänge2.Text == "dm")
            {
                double conver = Länge1 * 10;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "m" && (string)comboBoxLänge2.Text == "cm")
            {
                double conver = Länge1 * 100;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "m" && (string)comboBoxLänge2.Text == "mm")
            {
                double conver = Länge1 * 1000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "m" && (string)comboBoxLänge2.Text == "Meile")
            {
                double conver = Länge1 * 0.000621371;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "m" && (string)comboBoxLänge2.Text == "Zoll")
            {
                double conver = Länge1 * 37.37;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "m" && (string)comboBoxLänge2.Text == "m")
            {
                textBoxLänge2.Text = "ungültig";
            }
            // DM ZU X 
            if ((string)comboBoxLänge1.Text == "dm" && (string)comboBoxLänge2.Text == "km")
            {
                double conver = Länge1 * 0.0001;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "dm" && (string)comboBoxLänge2.Text == "m")
            {
                double conver = Länge1 / 10;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "dm" && (string)comboBoxLänge2.Text == "cm")
            {
                double conver = Länge1 * 10;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "dm" && (string)comboBoxLänge2.Text == "mm")
            {
                double conver = Länge1 * 100;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "dm" && (string)comboBoxLänge2.Text == "Meile")
            {
                double conver = Länge1 * 62137100000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "dm" && (string)comboBoxLänge2.Text == "Zoll")
            {
                double conver = Länge1 * 3.93701;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "dm" && (string)comboBoxLänge2.Text == "dm")
            {
                textBoxLänge2.Text = "ungültig";
            }

            // CM ZU X 
            if ((string)comboBoxLänge1.Text == "cm" && (string)comboBoxLänge2.Text == "km")
            {
                double conver = Länge1 / 100000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "cm" && (string)comboBoxLänge2.Text == "m")
            {
                double conver = Länge1 / 100;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "cm" && (string)comboBoxLänge2.Text == "dm")
            {
                double conver = Länge1 / 10;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "cm" && (string)comboBoxLänge2.Text == "mm")
            {
                double conver = Länge1 * 10;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "cm" && (string)comboBoxLänge2.Text == "Meile")
            {
                double conver = Länge1 / 160934;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "cm" && (string)comboBoxLänge2.Text == "Zoll")
            {
                double conver = Länge1 * 0.393701;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "cm" && (string)comboBoxLänge2.Text == "cm")
            {
                textBoxLänge2.Text = "ungültig";
            }
            // MM ZU X 
            if ((string)comboBoxLänge1.Text == "mm" && (string)comboBoxLänge2.Text == "km")
            {
                double conver = Länge1 / 1000000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "mm" && (string)comboBoxLänge2.Text == "m")
            {
                double conver = Länge1 / 1000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "mm" && (string)comboBoxLänge2.Text == "cm")
            {
                double conver = Länge1 / 10;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "mm" && (string)comboBoxLänge2.Text == "dm")
            {
                double conver = Länge1 / 100;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "mm" && (string)comboBoxLänge2.Text == "Meile")
            {
                double conver = Länge1 * 0.000006213;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "mm" && (string)comboBoxLänge2.Text == "Zoll")
            {
                double conver = Länge1 * 0.0392701;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "mm" && (string)comboBoxLänge2.Text == "mm")
            {
                textBoxLänge2.Text = "ungültig";
            }
            // MEILE IN X 
            if ((string)comboBoxLänge1.Text == "Meile" && (string)comboBoxLänge2.Text == "km")
            {
                double conver = Länge1 * 1.60934;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Meile" && (string)comboBoxLänge2.Text == "m")
            {
                double conver = Länge1 * 1609.34;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Meile" && (string)comboBoxLänge2.Text == "dm")
            {
                double conver = Länge1 * 16093.4;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Meile" && (string)comboBoxLänge2.Text == "cm")
            {
                double conver = Länge1 * 160934;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Meile" && (string)comboBoxLänge2.Text == "mm")
            {
                double conver = Länge1 * 1609340;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Meile" && (string)comboBoxLänge2.Text == "Zoll")
            {
                double conver = Länge1 * 63360;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Meile" && (string)comboBoxLänge2.Text == "Meile")
            {
                textBoxLänge2.Text = "ungültig";
            }
            // ZOLL ZU X 
            if ((string)comboBoxLänge1.Text == "Zoll" && (string)comboBoxLänge2.Text == "km")
            {
                double conver = Länge1 * 39370.1;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Zoll" && (string)comboBoxLänge2.Text == "m")
            {
                double conver = Länge1 * 0.0254;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Zoll" && (string)comboBoxLänge2.Text == "dm")
            {
                double conver = Länge1 * 0.254;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Zoll" && (string)comboBoxLänge2.Text == "cm")
            {
                double conver = Länge1 * 2.54;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Zoll" && (string)comboBoxLänge2.Text == "mm")
            {
                double conver = Länge1 * 25.4;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Zoll" && (string)comboBoxLänge2.Text == "Meile")
            {
                double conver = Länge1 * 15782800000;
                textBoxLänge2.Text = "" + conver;
            }
            else if ((string)comboBoxLänge1.Text == "Zoll" && (string)comboBoxLänge2.Text == "Zoll")
            {
                textBoxLänge2.Text = "ungültig";
            }



        }
    }
}
