
namespace Umformungsrechner
{
    partial class Länge
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
            this.buttonumrechnen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLänge2 = new System.Windows.Forms.ComboBox();
            this.comboBoxLänge1 = new System.Windows.Forms.ComboBox();
            this.textBoxLänge2 = new System.Windows.Forms.TextBox();
            this.textBoxLänge1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 117);
            this.label1.TabIndex = 2;
            this.label1.Text = "Längenumrechner";
            // 
            // buttonSchließenWährung
            // 
            this.buttonSchließenWährung.BackColor = System.Drawing.Color.Red;
            this.buttonSchließenWährung.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchließenWährung.ForeColor = System.Drawing.Color.White;
            this.buttonSchließenWährung.Location = new System.Drawing.Point(658, 356);
            this.buttonSchließenWährung.Name = "buttonSchließenWährung";
            this.buttonSchließenWährung.Size = new System.Drawing.Size(136, 49);
            this.buttonSchließenWährung.TabIndex = 11;
            this.buttonSchließenWährung.Text = "Schließen";
            this.buttonSchließenWährung.UseVisualStyleBackColor = false;
            this.buttonSchließenWährung.Click += new System.EventHandler(this.buttonSchließenWährung_Click);
            // 
            // buttonZurück
            // 
            this.buttonZurück.BackColor = System.Drawing.Color.Red;
            this.buttonZurück.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZurück.ForeColor = System.Drawing.Color.White;
            this.buttonZurück.Location = new System.Drawing.Point(-1, 356);
            this.buttonZurück.Name = "buttonZurück";
            this.buttonZurück.Size = new System.Drawing.Size(136, 49);
            this.buttonZurück.TabIndex = 12;
            this.buttonZurück.Text = "Zurück";
            this.buttonZurück.UseVisualStyleBackColor = false;
            this.buttonZurück.Click += new System.EventHandler(this.buttonZurück_Click);
            // 
            // buttonumrechnen
            // 
            this.buttonumrechnen.BackColor = System.Drawing.Color.Red;
            this.buttonumrechnen.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonumrechnen.ForeColor = System.Drawing.Color.White;
            this.buttonumrechnen.Location = new System.Drawing.Point(330, 282);
            this.buttonumrechnen.Name = "buttonumrechnen";
            this.buttonumrechnen.Size = new System.Drawing.Size(124, 37);
            this.buttonumrechnen.TabIndex = 19;
            this.buttonumrechnen.Text = "umrechnen";
            this.buttonumrechnen.UseVisualStyleBackColor = false;
            this.buttonumrechnen.Click += new System.EventHandler(this.buttonumrechnen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(500, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 60);
            this.label4.TabIndex = 17;
            this.label4.Text = "zu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(194, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 60);
            this.label3.TabIndex = 18;
            this.label3.Text = "von";
            // 
            // comboBoxLänge2
            // 
            this.comboBoxLänge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLänge2.FormattingEnabled = true;
            this.comboBoxLänge2.Items.AddRange(new object[] {
            "km",
            "m",
            "dm",
            "cm",
            "mm",
            "Meile",
            "Zoll"});
            this.comboBoxLänge2.Location = new System.Drawing.Point(460, 230);
            this.comboBoxLänge2.Name = "comboBoxLänge2";
            this.comboBoxLänge2.Size = new System.Drawing.Size(143, 28);
            this.comboBoxLänge2.TabIndex = 15;
            // 
            // comboBoxLänge1
            // 
            this.comboBoxLänge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLänge1.FormattingEnabled = true;
            this.comboBoxLänge1.Items.AddRange(new object[] {
            "km",
            "m",
            "dm",
            "cm",
            "mm",
            "Meile",
            "Zoll"});
            this.comboBoxLänge1.Location = new System.Drawing.Point(175, 230);
            this.comboBoxLänge1.Name = "comboBoxLänge1";
            this.comboBoxLänge1.Size = new System.Drawing.Size(143, 28);
            this.comboBoxLänge1.TabIndex = 16;
            // 
            // textBoxLänge2
            // 
            this.textBoxLänge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLänge2.Location = new System.Drawing.Point(460, 272);
            this.textBoxLänge2.Multiline = true;
            this.textBoxLänge2.Name = "textBoxLänge2";
            this.textBoxLänge2.Size = new System.Drawing.Size(143, 47);
            this.textBoxLänge2.TabIndex = 13;
            // 
            // textBoxLänge1
            // 
            this.textBoxLänge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLänge1.Location = new System.Drawing.Point(175, 272);
            this.textBoxLänge1.Multiline = true;
            this.textBoxLänge1.Name = "textBoxLänge1";
            this.textBoxLänge1.Size = new System.Drawing.Size(143, 47);
            this.textBoxLänge1.TabIndex = 14;
            // 
            // Länge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(792, 403);
            this.Controls.Add(this.buttonumrechnen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLänge2);
            this.Controls.Add(this.comboBoxLänge1);
            this.Controls.Add(this.textBoxLänge2);
            this.Controls.Add(this.textBoxLänge1);
            this.Controls.Add(this.buttonZurück);
            this.Controls.Add(this.buttonSchließenWährung);
            this.Controls.Add(this.label1);
            this.Name = "Länge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Länge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSchließenWährung;
        private System.Windows.Forms.Button buttonZurück;
        private System.Windows.Forms.Button buttonumrechnen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLänge2;
        private System.Windows.Forms.ComboBox comboBoxLänge1;
        private System.Windows.Forms.TextBox textBoxLänge2;
        private System.Windows.Forms.TextBox textBoxLänge1;
    }
}