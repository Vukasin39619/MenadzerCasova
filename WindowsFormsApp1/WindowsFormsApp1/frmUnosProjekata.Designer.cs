namespace WindowsFormsApp1
{
    partial class frmUnosProjekata
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
            this.korisnikTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter();
            this.menadzer_CasovaDataSet = new WindowsFormsApp1.Menadzer_CasovaDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxKorisnik = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chboxUplacenoSkroz = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chboxAvans = new System.Windows.Forms.CheckBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chboxOdradjeno = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenovnikProjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenovnikProjektiTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.CenovnikProjektiTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.boxIDCene = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenovnikProjektiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
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
            // boxKorisnik
            // 
            this.boxKorisnik.DataSource = this.korisnikBindingSource1;
            this.boxKorisnik.DisplayMember = "ImePrezime";
            this.boxKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxKorisnik.FormattingEnabled = true;
            this.boxKorisnik.Location = new System.Drawing.Point(175, 142);
            this.boxKorisnik.Name = "boxKorisnik";
            this.boxKorisnik.Size = new System.Drawing.Size(189, 33);
            this.boxKorisnik.TabIndex = 44;
            this.boxKorisnik.ValueMember = "BrojKorisnika";
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataMember = "Korisnik";
            this.korisnikBindingSource1.DataSource = this.menadzer_CasovaDataSet;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Korisnik";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // chboxUplacenoSkroz
            // 
            this.chboxUplacenoSkroz.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxUplacenoSkroz.Location = new System.Drawing.Point(226, 59);
            this.chboxUplacenoSkroz.Name = "chboxUplacenoSkroz";
            this.chboxUplacenoSkroz.Size = new System.Drawing.Size(29, 22);
            this.chboxUplacenoSkroz.TabIndex = 41;
            this.chboxUplacenoSkroz.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 22);
            this.label5.TabIndex = 40;
            this.label5.Text = "UplacenoCelokupno";
            // 
            // chboxAvans
            // 
            this.chboxAvans.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxAvans.Location = new System.Drawing.Point(226, 19);
            this.chboxAvans.Name = "chboxAvans";
            this.chboxAvans.Size = new System.Drawing.Size(29, 22);
            this.chboxAvans.TabIndex = 39;
            this.chboxAvans.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(370, 542);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(116, 43);
            this.btnOtkazi.TabIndex = 38;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(83, 542);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(119, 43);
            this.btnUnesi.TabIndex = 37;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 36;
            this.label4.Text = "Rok";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Uplacen Avans";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 22);
            this.label9.TabIndex = 49;
            this.label9.Text = "Odradjeno";
            // 
            // chboxOdradjeno
            // 
            this.chboxOdradjeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxOdradjeno.Location = new System.Drawing.Point(226, 97);
            this.chboxOdradjeno.Name = "chboxOdradjeno";
            this.chboxOdradjeno.Size = new System.Drawing.Size(29, 22);
            this.chboxOdradjeno.TabIndex = 50;
            this.chboxOdradjeno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chboxOdradjeno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chboxAvans);
            this.groupBox1.Controls.Add(this.chboxUplacenoSkroz);
            this.groupBox1.Location = new System.Drawing.Point(46, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 136);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCeneDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cenovnikProjektiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 153);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idCeneDataGridViewTextBoxColumn
            // 
            this.idCeneDataGridViewTextBoxColumn.DataPropertyName = "IdCene";
            this.idCeneDataGridViewTextBoxColumn.HeaderText = "IdCene";
            this.idCeneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCeneDataGridViewTextBoxColumn.Name = "idCeneDataGridViewTextBoxColumn";
            this.idCeneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // cenovnikProjektiBindingSource
            // 
            this.cenovnikProjektiBindingSource.DataMember = "CenovnikProjekti";
            this.cenovnikProjektiBindingSource.DataSource = this.menadzer_CasovaDataSet;
            // 
            // cenovnikProjektiTableAdapter
            // 
            this.cenovnikProjektiTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 45);
            this.label8.TabIndex = 46;
            this.label8.Text = "Unos Projekata";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // boxIDCene
            // 
            this.boxIDCene.Location = new System.Drawing.Point(454, 277);
            this.boxIDCene.Name = "boxIDCene";
            this.boxIDCene.Size = new System.Drawing.Size(100, 22);
            this.boxIDCene.TabIndex = 53;
            this.boxIDCene.Visible = false;
            // 
            // frmUnosProjekata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 634);
            this.Controls.Add(this.boxIDCene);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxKorisnik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label4);
            this.Name = "frmUnosProjekata";
            this.Text = "frmUnosProjekata";
            this.Load += new System.EventHandler(this.frmUnosProjekata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenovnikProjektiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private Menadzer_CasovaDataSet menadzer_CasovaDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.ComboBox boxKorisnik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chboxUplacenoSkroz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chboxAvans;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chboxOdradjeno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cenovnikProjektiBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.CenovnikProjektiTableAdapter cenovnikProjektiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxIDCene;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
    }
}