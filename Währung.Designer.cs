
namespace Umformungsrechner
{
    partial class Währung
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
            this.textBoxWährung1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWährung1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWährung2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSchließenWährung = new System.Windows.Forms.Button();
            this.textBoxWährung2 = new System.Windows.Forms.TextBox();
            this.lbltest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonZurück = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxWährung1
            // 
            this.textBoxWährung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWährung1.Location = new System.Drawing.Point(145, 278);
            this.textBoxWährung1.Multiline = true;
            this.textBoxWährung1.Name = "textBoxWährung1";
            this.textBoxWährung1.Size = new System.Drawing.Size(165, 47);
            this.textBoxWährung1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "Währungsrechner";
            // 
            // comboBoxWährung1
            // 
            this.comboBoxWährung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWährung1.FormattingEnabled = true;
            this.comboBoxWährung1.Items.AddRange(new object[] {
            "Euro",
            "Dollar",
            "Pfund",
            "kan. Dollar",
            "Schweizer Franken"});
            this.comboBoxWährung1.Location = new System.Drawing.Point(145, 236);
            this.comboBoxWährung1.Name = "comboBoxWährung1";
            this.comboBoxWährung1.Size = new System.Drawing.Size(165, 28);
            this.comboBoxWährung1.TabIndex = 2;
            this.comboBoxWährung1.SelectedIndexChanged += new System.EventHandler(this.comboBoxWährung1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(186, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 60);
            this.label3.TabIndex = 3;
            this.label3.Text = "von";
            // 
            // comboBoxWährung2
            // 
            this.comboBoxWährung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWährung2.FormattingEnabled = true;
            this.comboBoxWährung2.Items.AddRange(new object[] {
            "Euro",
            "Dollar",
            "Pfund",
            "kan. Dollar",
            "Schweizer Franken"});
            this.comboBoxWährung2.Location = new System.Drawing.Point(452, 236);
            this.comboBoxWährung2.Name = "comboBoxWährung2";
            this.comboBoxWährung2.Size = new System.Drawing.Size(170, 28);
            this.comboBoxWährung2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(492, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 60);
            this.label4.TabIndex = 3;
            this.label4.Text = "zu";
            // 
            // buttonSchließenWährung
            // 
            this.buttonSchließenWährung.BackColor = System.Drawing.Color.Tomato;
            this.buttonSchließenWährung.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchließenWährung.ForeColor = System.Drawing.Color.White;
            this.buttonSchließenWährung.Location = new System.Drawing.Point(660, 356);
            this.buttonSchließenWährung.Name = "buttonSchließenWährung";
            this.buttonSchließenWährung.Size = new System.Drawing.Size(136, 49);
            this.buttonSchließenWährung.TabIndex = 4;
            this.buttonSchließenWährung.Text = "Schließen";
            this.buttonSchließenWährung.UseVisualStyleBackColor = false;
            this.buttonSchließenWährung.Click += new System.EventHandler(this.buttonSchließenWährung_Click);
            // 
            // textBoxWährung2
            // 
            this.textBoxWährung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWährung2.Location = new System.Drawing.Point(452, 278);
            this.textBoxWährung2.Multiline = true;
            this.textBoxWährung2.Name = "textBoxWährung2";
            this.textBoxWährung2.Size = new System.Drawing.Size(170, 47);
            this.textBoxWährung2.TabIndex = 0;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.BackColor = System.Drawing.Color.Transparent;
            this.lbltest.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.ForeColor = System.Drawing.Color.Black;
            this.lbltest.Location = new System.Drawing.Point(653, 253);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 39);
            this.lbltest.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(322, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "umrechnen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonZurück
            // 
            this.buttonZurück.BackColor = System.Drawing.Color.Tomato;
            this.buttonZurück.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZurück.ForeColor = System.Drawing.Color.White;
            this.buttonZurück.Location = new System.Drawing.Point(-3, 356);
            this.buttonZurück.Name = "buttonZurück";
            this.buttonZurück.Size = new System.Drawing.Size(127, 49);
            this.buttonZurück.TabIndex = 6;
            this.buttonZurück.Text = "Zurück";
            this.buttonZurück.UseVisualStyleBackColor = false;
            this.buttonZurück.Click += new System.EventHandler(this.buttonZurück_Click);
            // 
            // Währung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(792, 403);
            this.Controls.Add(this.buttonZurück);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSchließenWährung);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxWährung2);
            this.Controls.Add(this.comboBoxWährung1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWährung2);
            this.Controls.Add(this.textBoxWährung1);
            this.Name = "Währung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Währung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWährung1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWährung1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWährung2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSchließenWährung;
        private System.Windows.Forms.TextBox textBoxWährung2;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonZurück;
    }
}