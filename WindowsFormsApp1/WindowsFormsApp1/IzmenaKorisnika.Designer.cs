namespace WindowsFormsApp1
{
    partial class IzmenaKorisnika
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menadzer_CasovaDataSet = new WindowsFormsApp1.Menadzer_CasovaDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter();
            this.brojKorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brIndeksaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxOpis = new System.Windows.Forms.TextBox();
            this.boxTelefon = new System.Windows.Forms.TextBox();
            this.boxIndeks = new System.Windows.Forms.TextBox();
            this.boxIme = new System.Windows.Forms.TextBox();
            this.boxSifra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojKorisnikaDataGridViewTextBoxColumn,
            this.brIndeksaDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn,
            this.brojTelefonaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.korisnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menadzer_CasovaDataSet
            // 
            this.menadzer_CasovaDataSet.DataSetName = "Menadzer_CasovaDataSet";
            this.menadzer_CasovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.menadzer_CasovaDataSet;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // brojKorisnikaDataGridViewTextBoxColumn
            // 
            this.brojKorisnikaDataGridViewTextBoxColumn.DataPropertyName = "BrojKorisnika";
            this.brojKorisnikaDataGridViewTextBoxColumn.HeaderText = "BrojKorisnika";
            this.brojKorisnikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojKorisnikaDataGridViewTextBoxColumn.Name = "brojKorisnikaDataGridViewTextBoxColumn";
            this.brojKorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brIndeksaDataGridViewTextBoxColumn
            // 
            this.brIndeksaDataGridViewTextBoxColumn.DataPropertyName = "BrIndeksa";
            this.brIndeksaDataGridViewTextBoxColumn.HeaderText = "BrIndeksa";
            this.brIndeksaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brIndeksaDataGridViewTextBoxColumn.Name = "brIndeksaDataGridViewTextBoxColumn";
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            // 
            // brojTelefonaDataGridViewTextBoxColumn
            // 
            this.brojTelefonaDataGridViewTextBoxColumn.DataPropertyName = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.HeaderText = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojTelefonaDataGridViewTextBoxColumn.Name = "brojTelefonaDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 45);
            this.label8.TabIndex = 58;
            this.label8.Text = "Edit Korisnika";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(414, 586);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(92, 36);
            this.btnOtkazi.TabIndex = 57;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(215, 586);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(92, 36);
            this.btnUnesi.TabIndex = 56;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 55;
            this.label4.Text = "Opis";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Broj Telefona";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Broj Indeksa";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ime i prezime";
            // 
            // boxOpis
            // 
            this.boxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOpis.Location = new System.Drawing.Point(314, 510);
            this.boxOpis.Multiline = true;
            this.boxOpis.Name = "boxOpis";
            this.boxOpis.Size = new System.Drawing.Size(192, 47);
            this.boxOpis.TabIndex = 51;
            // 
            // boxTelefon
            // 
            this.boxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTelefon.Location = new System.Drawing.Point(343, 466);
            this.boxTelefon.Name = "boxTelefon";
            this.boxTelefon.Size = new System.Drawing.Size(163, 28);
            this.boxTelefon.TabIndex = 50;
            // 
            // boxIndeks
            // 
            this.boxIndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIndeks.Location = new System.Drawing.Point(349, 399);
            this.boxIndeks.Name = "boxIndeks";
            this.boxIndeks.Size = new System.Drawing.Size(157, 28);
            this.boxIndeks.TabIndex = 49;
            // 
            // boxIme
            // 
            this.boxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIme.Location = new System.Drawing.Point(349, 335);
            this.boxIme.Name = "boxIme";
            this.boxIme.Size = new System.Drawing.Size(157, 28);
            this.boxIme.TabIndex = 48;
            // 
            // boxSifra
            // 
            this.boxSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSifra.Location = new System.Drawing.Point(651, 335);
            this.boxSifra.Name = "boxSifra";
            this.boxSifra.Size = new System.Drawing.Size(73, 28);
            this.boxSifra.TabIndex = 59;
            this.boxSifra.Visible = false;
            // 
            // IzmenaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 665);
            this.Controls.Add(this.boxSifra);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "IzmenaKorisnika";
            this.Text = "IzmenaKorisnika";
            this.Load += new System.EventHandler(this.IzmenaKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Menadzer_CasovaDataSet menadzer_CasovaDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojKorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brIndeksaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxOpis;
        private System.Windows.Forms.TextBox boxTelefon;
        private System.Windows.Forms.TextBox boxIndeks;
        private System.Windows.Forms.TextBox boxIme;
        private System.Windows.Forms.TextBox boxSifra;
    }
}