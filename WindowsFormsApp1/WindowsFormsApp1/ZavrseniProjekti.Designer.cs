namespace WindowsFormsApp1
{
    partial class ZavrseniProjekti
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
            this.rokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplacenAvansDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menadzer_CasovaDataSet = new WindowsFormsApp1.Menadzer_CasovaDataSet();
            this.odradjenoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odradjeniProjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxTrenutnaZarada = new System.Windows.Forms.TextBox();
            this.odradjeniProjektiTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.OdradjeniProjektiTableAdapter();
            this.korisnikTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odradjeniProjektiBindingSource)).BeginInit();
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
            this.rokDataGridViewTextBoxColumn,
            this.uplacenAvansDataGridViewCheckBoxColumn,
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.odradjenoDataGridViewCheckBoxColumn,
            this.idCeneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odradjeniProjektiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 253);
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
            // rokDataGridViewTextBoxColumn
            // 
            this.rokDataGridViewTextBoxColumn.DataPropertyName = "Rok";
            this.rokDataGridViewTextBoxColumn.HeaderText = "Rok";
            this.rokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rokDataGridViewTextBoxColumn.Name = "rokDataGridViewTextBoxColumn";
            // 
            // uplacenAvansDataGridViewCheckBoxColumn
            // 
            this.uplacenAvansDataGridViewCheckBoxColumn.DataPropertyName = "UplacenAvans";
            this.uplacenAvansDataGridViewCheckBoxColumn.HeaderText = "UplacenAvans";
            this.uplacenAvansDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.uplacenAvansDataGridViewCheckBoxColumn.Name = "uplacenAvansDataGridViewCheckBoxColumn";
            // 
            // uplacenoCelokupnoDataGridViewCheckBoxColumn
            // 
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn.DataPropertyName = "UplacenoCelokupno";
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn.HeaderText = "UplacenoCelokupno";
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn.Name = "uplacenoCelokupnoDataGridViewCheckBoxColumn";
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
            // odradjenoDataGridViewCheckBoxColumn
            // 
            this.odradjenoDataGridViewCheckBoxColumn.DataPropertyName = "Odradjeno";
            this.odradjenoDataGridViewCheckBoxColumn.HeaderText = "Odradjeno";
            this.odradjenoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.odradjenoDataGridViewCheckBoxColumn.Name = "odradjenoDataGridViewCheckBoxColumn";
            // 
            // idCeneDataGridViewTextBoxColumn
            // 
            this.idCeneDataGridViewTextBoxColumn.DataPropertyName = "IdCene";
            this.idCeneDataGridViewTextBoxColumn.HeaderText = "IdCene";
            this.idCeneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCeneDataGridViewTextBoxColumn.Name = "idCeneDataGridViewTextBoxColumn";
            this.idCeneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // odradjeniProjektiBindingSource
            // 
            this.odradjeniProjektiBindingSource.DataMember = "OdradjeniProjekti";
            this.odradjeniProjektiBindingSource.DataSource = this.menadzer_CasovaDataSet;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(132, 322);
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
            this.groupBox1.Location = new System.Drawing.Point(61, 357);
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
            // odradjeniProjektiTableAdapter
            // 
            this.odradjeniProjektiTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(614, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "Stampaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZavrseniProjekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZavrseniProjekti";
            this.Text = "ZavrseniProjekti";
            this.Load += new System.EventHandler(this.ZavrseniProjekti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odradjeniProjektiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Menadzer_CasovaDataSet menadzer_CasovaDataSet;
        private System.Windows.Forms.BindingSource odradjeniProjektiBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.OdradjeniProjektiTableAdapter odradjeniProjektiTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxTrenutnaZarada;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraPomociDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uplacenAvansDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uplacenoCelokupnoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odradjenoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}