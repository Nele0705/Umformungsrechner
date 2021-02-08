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
    public partial class Gewicht : Form
    {
        public Gewicht()
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

        private void buttonUmrechnen_Click(object sender, EventArgs e)
        {
            // t in X
            double Gewicht1 = double.Parse(textBoxGewicht1.Text);
            if((string)comboBoxGewicht1.Text == "t" && comboBoxGewicht2.Text == "kg")
            {
                double convert = Gewicht1 * 1000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "t" && comboBoxGewicht2.Text == "g")
            {
                double convert = Gewicht1 * 1000000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "t" && comboBoxGewicht2.Text == "mg")
            {
                double convert = Gewicht1 * 1000000000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "t" && comboBoxGewicht2.Text == "Pfund")
            {
                double convert = Gewicht1 * 2204.62;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "t" && comboBoxGewicht2.Text == "t")
            {
                textBoxGewicht2.Text = "ungültig";
            }

            // kg in X 
            if ((string)comboBoxGewicht1.Text == "kg" && comboBoxGewicht2.Text == "t")
            {
                double convert = Gewicht1 / 1000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "kg" && comboBoxGewicht2.Text == "g")
            {
                double convert = Gewicht1 * 1000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "kg" && comboBoxGewicht2.Text == "mg")
            {
                double convert = Gewicht1 * 1000000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "kg" && comboBoxGewicht2.Text == "Pfund")
            {
                double convert = Gewicht1 * 2.20462;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "kg" && comboBoxGewicht2.Text == "kg")
            {
                textBoxGewicht2.Text = "ungültig";
            }
            // g zu X 
            if ((string)comboBoxGewicht1.Text == "g" && comboBoxGewicht2.Text == "t")
            {
                double convert = Gewicht1 / 1000000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "g" && comboBoxGewicht2.Text == "kg")
            {
                double convert = Gewicht1 / 1000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "g" && comboBoxGewicht2.Text == "mg")
            {
                double convert = Gewicht1 * 1000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "g" && comboBoxGewicht2.Text == "Pfund")
            {
                double convert = Gewicht1 * 0.00220462;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "g" && comboBoxGewicht2.Text == "mg")
            {
                textBoxGewicht2.Text = "ungültig";
            }
            // mg zu X 
            if ((string)comboBoxGewicht1.Text == "mg" && comboBoxGewicht2.Text == "t")
            {
                double convert = Gewicht1 / 1000000000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "mg" && comboBoxGewicht2.Text == "kg")
            {
                double convert = Gewicht1 / 1000000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "mg" && comboBoxGewicht2.Text == "g")
            {
                double convert = Gewicht1 / 1000;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "mg" && comboBoxGewicht2.Text == "Pfund")
            {
                double convert = Gewicht1 * 0.00000220462;
                textBoxGewicht2.Text = "" + convert;
            }
            else if ((string)comboBoxGewicht1.Text == "mg" && comboBoxGewicht2.Text == "mg")
            {
                textBoxGewicht2.Text = "ungültig";
            }
        }
    }
}
