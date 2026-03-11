namespace WindowsFormsApp1
{
    partial class ZavrseniCasoviFrmcs
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
            this.sifraPomociDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menadzer_CasovaDataSet = new WindowsFormsApp1.Menadzer_CasovaDataSet();
            this.vremeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odradjenoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.odradjeniCasoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odradjeniCasoviTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.OdradjeniCasoviTableAdapter();
            this.korisnikTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxTrenutnaZarada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odradjeniCasoviBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraPomociDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.vremeDataGridViewTextBoxColumn,
            this.odradjenoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.odradjeniCasoviBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // sifraPomociDataGridViewTextBoxColumn
            // 
            this.sifraPomociDataGridViewTextBoxColumn.DataPropertyName = "SifraPomoci";
            this.sifraPomociDataGridViewTextBoxColumn.HeaderText = "SifraPomoci";
            this.sifraPomociDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifraPomociDataGridViewTextBoxColumn.Name = "sifraPomociDataGridViewTextBoxColumn";
            this.sifraPomociDataGridViewTextBoxColumn.ReadOnly = true;
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
            // uplacenoCelokupnoDataGridViewCheckBoxColumn
            // 
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn.DataPropertyName = "UplacenoCelokupno";
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn.HeaderText = "UplacenoCelokupno";
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn.Name = "uplacenoCelokupnoDataGridViewCheckBoxColumn";
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.DataSource = this.korisnikBindingSource;
            this.korisnikDataGridViewTextBoxColumn.DisplayMember = "ImePrezime";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.korisnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.korisnikDataGridViewTextBoxColumn.ValueMember = "BrojKorisnika";
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
            // vremeDataGridViewTextBoxColumn
            // 
            this.vremeDataGridViewTextBoxColumn.DataPropertyName = "Vreme";
            this.vremeDataGridViewTextBoxColumn.HeaderText = "Vreme";
            this.vremeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vremeDataGridViewTextBoxColumn.Name = "vremeDataGridViewTextBoxColumn";
            // 
            // odradjenoDataGridViewCheckBoxColumn
            // 
            this.odradjenoDataGridViewCheckBoxColumn.DataPropertyName = "Odradjeno";
            this.odradjenoDataGridViewCheckBoxColumn.HeaderText = "Odradjeno";
            this.odradjenoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.odradjenoDataGridViewCheckBoxColumn.Name = "odradjenoDataGridViewCheckBoxColumn";
            // 
            // odradjeniCasoviBindingSource
            // 
            this.odradjeniCasoviBindingSource.DataMember = "OdradjeniCasovi";
            this.odradjeniCasoviBindingSource.DataSource = this.menadzer_CasovaDataSet;
            // 
            // odradjeniCasoviTableAdapter
            // 
            this.odradjeniCasoviTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zarada Casova";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boxTrenutnaZarada);
            this.groupBox1.Location = new System.Drawing.Point(44, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 205);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarada Casova";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 18);
            this.label14.TabIndex = 18;
            this.label14.Text = "(Uplaceno)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trenutna zarada";
            // 
            // boxTrenutnaZarada
            // 
            this.boxTrenutnaZarada.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxTrenutnaZarada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTrenutnaZarada.ForeColor = System.Drawing.SystemColors.Window;
            this.boxTrenutnaZarada.Location = new System.Drawing.Point(205, 92);
            this.boxTrenutnaZarada.Name = "boxTrenutnaZarada";
            this.boxTrenutnaZarada.ReadOnly = true;
            this.boxTrenutnaZarada.Size = new System.Drawing.Size(145, 28);
            this.boxTrenutnaZarada.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Stampaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZavrseniCasoviFrmcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZavrseniCasoviFrmcs";
            this.Text = "ZavrseniCasoviFrmcs";
            this.Load += new System.EventHandler(this.ZavrseniCasoviFrmcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odradjeniCasoviBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Menadzer_CasovaDataSet menadzer_CasovaDataSet;
        private System.Windows.Forms.BindingSource odradjeniCasoviBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.OdradjeniCasoviTableAdapter odradjeniCasoviTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraPomociDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uplacenoCelokupnoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odradjenoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxTrenutnaZarada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}