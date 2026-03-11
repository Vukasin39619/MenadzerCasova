namespace WindowsFormsApp1
{
    partial class frmUnosCasova
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
            this.components = new System.ComponentModel.Container();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxPredmet = new System.Windows.Forms.TextBox();
            this.chboxUplaceno = new System.Windows.Forms.CheckBox();
            this.chboxOdradjeno = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menadzer_CasovaDataSet = new WindowsFormsApp1.Menadzer_CasovaDataSet();
            this.korisnikTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxOpisCasa = new System.Windows.Forms.ComboBox();
            this.boxVreme = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(242, 430);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(92, 36);
            this.btnOtkazi.TabIndex = 19;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(43, 430);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(92, 36);
            this.btnUnesi.TabIndex = 18;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Datum";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Predmet";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Uplaceno";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Opis";
            // 
            // boxPredmet
            // 
            this.boxPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPredmet.Location = new System.Drawing.Point(161, 183);
            this.boxPredmet.Name = "boxPredmet";
            this.boxPredmet.Size = new System.Drawing.Size(179, 28);
            this.boxPredmet.TabIndex = 12;
            // 
            // chboxUplaceno
            // 
            this.chboxUplaceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxUplaceno.Location = new System.Drawing.Point(140, 128);
            this.chboxUplaceno.Name = "chboxUplaceno";
            this.chboxUplaceno.Size = new System.Drawing.Size(29, 22);
            this.chboxUplaceno.TabIndex = 20;
            this.chboxUplaceno.UseVisualStyleBackColor = true;
            // 
            // chboxOdradjeno
            // 
            this.chboxOdradjeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxOdradjeno.Location = new System.Drawing.Point(305, 128);
            this.chboxOdradjeno.Name = "chboxOdradjeno";
            this.chboxOdradjeno.Size = new System.Drawing.Size(29, 22);
            this.chboxOdradjeno.TabIndex = 22;
            this.chboxOdradjeno.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Odradjeno";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Korisnik";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.korisnikBindingSource;
            this.comboBox1.DisplayMember = "ImePrezime";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 33);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "BrojKorisnika";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.menadzer_CasovaDataSet;
            // 
            // menadzer_CasovaDataSet
            // 
            this.menadzer_CasovaDataSet.DataSetName = "Menadzer_CasovaDataSet";
            this.menadzer_CasovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vreme";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 45);
            this.label8.TabIndex = 29;
            this.label8.Text = "UNOS CASOVA";
            // 
            // boxOpisCasa
            // 
            this.boxOpisCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOpisCasa.FormattingEnabled = true;
            this.boxOpisCasa.Items.AddRange(new object[] {
            "jedancas",
            "dvocas"});
            this.boxOpisCasa.Location = new System.Drawing.Point(161, 73);
            this.boxOpisCasa.Name = "boxOpisCasa";
            this.boxOpisCasa.Size = new System.Drawing.Size(189, 33);
            this.boxOpisCasa.TabIndex = 30;
            // 
            // boxVreme
            // 
            this.boxVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxVreme.FormattingEnabled = true;
            this.boxVreme.Items.AddRange(new object[] {
            "11H",
            "12H",
            "13H",
            "14H",
            "15H",
            "16H",
            "17H",
            "18H",
            "19H",
            "20H",
            "21H"});
            this.boxVreme.Location = new System.Drawing.Point(161, 348);
            this.boxVreme.Name = "boxVreme";
            this.boxVreme.Size = new System.Drawing.Size(189, 33);
            this.boxVreme.TabIndex = 31;
            // 
            // frmUnosCasova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 496);
            this.ControlBox = false;
            this.Controls.Add(this.boxVreme);
            this.Controls.Add(this.boxOpisCasa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chboxOdradjeno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chboxUplaceno);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPredmet);
            this.Name = "frmUnosCasova";
            this.Text = "frmUnosCasova";
            this.Load += new System.EventHandler(this.frmUnosCasova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxPredmet;
        private System.Windows.Forms.CheckBox chboxUplaceno;
        private System.Windows.Forms.CheckBox chboxOdradjeno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private Menadzer_CasovaDataSet menadzer_CasovaDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox boxOpisCasa;
        private System.Windows.Forms.ComboBox boxVreme;
    }
}