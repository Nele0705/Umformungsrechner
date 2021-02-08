
namespace Umformungsrechner
{
    partial class Gewicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSchließenWährung = new System.Windows.Forms.Button();
            this.buttonZurück = new System.Windows.Forms.Button();
            this.buttonUmrechnen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGewicht2 = new System.Windows.Forms.ComboBox();
            this.comboBoxGewicht1 = new System.Windows.Forms.ComboBox();
            this.textBoxGewicht2 = new System.Windows.Forms.TextBox();
            this.textBoxGewicht1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 117);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gewichtsrechner";
            // 
            // buttonSchließenWährung
            // 
            this.buttonSchließenWährung.BackColor = System.Drawing.Color.Green;
            this.buttonSchließenWährung.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchließenWährung.ForeColor = System.Drawing.Color.White;
            this.buttonSchließenWährung.Location = new System.Drawing.Point(658, 359);
            this.buttonSchließenWährung.Name = "buttonSchließenWährung";
            this.buttonSchließenWährung.Size = new System.Drawing.Size(136, 49);
            this.buttonSchließenWährung.TabIndex = 12;
            this.buttonSchließenWährung.Text = "Schließen";
            this.buttonSchließenWährung.UseVisualStyleBackColor = false;
            this.buttonSchließenWährung.Click += new System.EventHandler(this.buttonSchließenWährung_Click);
            // 
            // buttonZurück
            // 
            this.buttonZurück.BackColor = System.Drawing.Color.Green;
            this.buttonZurück.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZurück.ForeColor = System.Drawing.Color.White;
            this.buttonZurück.Location = new System.Drawing.Point(-1, 359);
            this.buttonZurück.Name = "buttonZurück";
            this.buttonZurück.Size = new System.Drawing.Size(146, 49);
            this.buttonZurück.TabIndex = 13;
            this.buttonZurück.Text = "Zurück";
            this.buttonZurück.UseVisualStyleBackColor = false;
            this.buttonZurück.Click += new System.EventHandler(this.buttonZurück_Click);
            // 
            // buttonUmrechnen
            // 
            this.buttonUmrechnen.BackColor = System.Drawing.Color.Green;
            this.buttonUmrechnen.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUmrechnen.ForeColor = System.Drawing.Color.White;
            this.buttonUmrechnen.Location = new System.Drawing.Point(336, 283);
            this.buttonUmrechnen.Name = "buttonUmrechnen";
            this.buttonUmrechnen.Size = new System.Drawing.Size(124, 37);
            this.buttonUmrechnen.TabIndex = 26;
            this.buttonUmrechnen.Text = "umrechnen";
            this.buttonUmrechnen.UseVisualStyleBackColor = false;
            this.buttonUmrechnen.Click += new System.EventHandler(this.buttonUmrechnen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(506, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 60);
            this.label4.TabIndex = 24;
            this.label4.Text = "zu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(200, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 60);
            this.label3.TabIndex = 25;
            this.label3.Text = "von";
            // 
            // comboBoxGewicht2
            // 
            this.comboBoxGewicht2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGewicht2.FormattingEnabled = true;
            this.comboBoxGewicht2.Items.AddRange(new object[] {
            "t",
            "kg",
            "g",
            "mg",
            "Pfund"});
            this.comboBoxGewicht2.Location = new System.Drawing.Point(466, 231);
            this.comboBoxGewicht2.Name = "comboBoxGewicht2";
            this.comboBoxGewicht2.Size = new System.Drawing.Size(143, 28);
            this.comboBoxGewicht2.TabIndex = 22;
            // 
            // comboBoxGewicht1
            // 
            this.comboBoxGewicht1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGewicht1.FormattingEnabled = true;
            this.comboBoxGewicht1.Items.AddRange(new object[] {
            "t",
            "kg",
            "g",
            "mg",
            "Pfund"});
            this.comboBoxGewicht1.Location = new System.Drawing.Point(181, 231);
            this.comboBoxGewicht1.Name = "comboBoxGewicht1";
            this.comboBoxGewicht1.Size = new System.Drawing.Size(143, 28);
            this.comboBoxGewicht1.TabIndex = 23;
            // 
            // textBoxGewicht2
            // 
            this.textBoxGewicht2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGewicht2.Location = new System.Drawing.Point(466, 273);
            this.textBoxGewicht2.Multiline = true;
            this.textBoxGewicht2.Name = "textBoxGewicht2";
            this.textBoxGewicht2.Size = new System.Drawing.Size(143, 47);
            this.textBoxGewicht2.TabIndex = 20;
            // 
            // textBoxGewicht1
            // 
            this.textBoxGewicht1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGewicht1.Location = new System.Drawing.Point(181, 273);
            this.textBoxGewicht1.Multiline = true;
            this.textBoxGewicht1.Name = "textBoxGewicht1";
            this.textBoxGewicht1.Size = new System.Drawing.Size(143, 47);
            this.textBoxGewicht1.TabIndex = 21;
            // 
            // Gewicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(792, 403);
            this.Controls.Add(this.buttonUmrechnen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGewicht2);
            this.Controls.Add(this.comboBoxGewicht1);
            this.Controls.Add(this.textBoxGewicht2);
            this.Controls.Add(this.textBoxGewicht1);
            this.Controls.Add(this.buttonZurück);
            this.Controls.Add(this.buttonSchließenWährung);
            this.Controls.Add(this.label1);
            this.Name = "Gewicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gewicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSchließenWährung;
        private System.Windows.Forms.Button buttonZurück;
        private System.Windows.Forms.Button buttonUmrechnen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGewicht2;
        private System.Windows.Forms.ComboBox comboBoxGewicht1;
        private System.Windows.Forms.TextBox textBoxGewicht2;
        private System.Windows.Forms.TextBox textBoxGewicht1;
    }
}