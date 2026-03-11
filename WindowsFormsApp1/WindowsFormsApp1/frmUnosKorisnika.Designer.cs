namespace WindowsFormsApp1
{
    partial class frmUnosKorisnika
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
            this.boxIme = new System.Windows.Forms.TextBox();
            this.boxIndeks = new System.Windows.Forms.TextBox();
            this.boxTelefon = new System.Windows.Forms.TextBox();
            this.boxOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxIme
            // 
            this.boxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIme.Location = new System.Drawing.Point(188, 121);
            this.boxIme.Name = "boxIme";
            this.boxIme.Size = new System.Drawing.Size(157, 28);
            this.boxIme.TabIndex = 0;
            // 
            // boxIndeks
            // 
            this.boxIndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIndeks.Location = new System.Drawing.Point(188, 185);
            this.boxIndeks.Name = "boxIndeks";
            this.boxIndeks.Size = new System.Drawing.Size(157, 28);
            this.boxIndeks.TabIndex = 1;
            // 
            // boxTelefon
            // 
            this.boxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTelefon.Location = new System.Drawing.Point(182, 252);
            this.boxTelefon.Name = "boxTelefon";
            this.boxTelefon.Size = new System.Drawing.Size(163, 28);
            this.boxTelefon.TabIndex = 2;
            // 
            // boxOpis
            // 
            this.boxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOpis.Location = new System.Drawing.Point(153, 296);
            this.boxOpis.Multiline = true;
            this.boxOpis.Name = "boxOpis";
            this.boxOpis.Size = new System.Drawing.Size(192, 47);
            this.boxOpis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime i prezime";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj Indeksa";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj Telefona";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opis";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(54, 372);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(92, 36);
            this.btnUnesi.TabIndex = 8;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(253, 372);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(92, 36);
            this.btnOtkazi.TabIndex = 9;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 45);
            this.label8.TabIndex = 47;
            this.label8.Text = "Unos Korisnika";
            // 
            // frmUnosKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 445);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxOpis);
            this.Controls.Add(this.boxTelefon);
            this.Controls.Add(this.boxIndeks);
            this.Controls.Add(this.boxIme);
            this.Name = "frmUnosKorisnika";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxIme;
        private System.Windows.Forms.TextBox boxIndeks;
        private System.Windows.Forms.TextBox boxTelefon;
        private System.Windows.Forms.TextBox boxOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label label8;
    }
}