namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataGridCasovi = new System.Windows.Forms.DataGridView();
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
            this.Odradjeno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ContextSviCasovi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sviCasoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiZavrseneCasoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridProjekti = new System.Windows.Forms.DataGridView();
            this.sifraPomociDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplacenAvansDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.korisnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.odradjenoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cenovnikProjektiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.IdCene = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cenovnikProjektiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ContextSviProjekti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sviProjektiKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiZavrseneProjekteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektiBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cenovnikProjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menadzer_CasovaDataSet2 = new WindowsFormsApp1.Menadzer_CasovaDataSet();
            this.projektiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.projektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cASOVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJEKTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kORISNIKAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZMENIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kORISNIKAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zAVRSENOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casoviTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.CasoviTableAdapter();
            this.projektiTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.ProjektiTableAdapter();
            this.korisnikTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.KorisnikTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menadzer_CasovaDataSet1 = new WindowsFormsApp1.Menadzer_CasovaDataSet();
            this.projektiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projektiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cenovnikProjektiTableAdapter = new WindowsFormsApp1.Menadzer_CasovaDataSetTableAdapters.CenovnikProjektiTableAdapter();
            this.boxPotencijalnaZarada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTrenutnaZarada = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.boxUkupnaZaradaCasova = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.boxUkupnaZaradaProjekata = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.boxPotZarProjekat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxTrenutnaZarProjekat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.boxMOGUCAUKUPNA = new System.Windows.Forms.TextBox();
            this.boxUKUPNAUKUPNA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.boxUplacenaUKUPNA = new System.Windows.Forms.TextBox();
            this.projektiBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.fKProjektiCenovnikProjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnAktivan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCasovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).BeginInit();
            this.ContextSviCasovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casoviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProjekti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenovnikProjektiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenovnikProjektiBindingSource2)).BeginInit();
            this.ContextSviProjekti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenovnikProjektiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProjektiCenovnikProjektiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridCasovi
            // 
            this.DataGridCasovi.AutoGenerateColumns = false;
            this.DataGridCasovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCasovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCasovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraPomociDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.vremeDataGridViewTextBoxColumn,
            this.Odradjeno});
            this.DataGridCasovi.ContextMenuStrip = this.ContextSviCasovi;
            this.DataGridCasovi.DataSource = this.casoviBindingSource1;
            this.DataGridCasovi.Location = new System.Drawing.Point(27, 65);
            this.DataGridCasovi.Name = "DataGridCasovi";
            this.DataGridCasovi.RowHeadersWidth = 51;
            this.DataGridCasovi.RowTemplate.Height = 24;
            this.DataGridCasovi.Size = new System.Drawing.Size(1589, 265);
            this.DataGridCasovi.TabIndex = 0;
            this.DataGridCasovi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCasovi_CellClick);
            this.DataGridCasovi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCasovi_CellValueChanged);
            this.DataGridCasovi.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridCasovi_CurrentCellDirtyStateChanged);
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
            // Odradjeno
            // 
            this.Odradjeno.DataPropertyName = "Odradjeno";
            this.Odradjeno.HeaderText = "Odradjeno";
            this.Odradjeno.MinimumWidth = 6;
            this.Odradjeno.Name = "Odradjeno";
            // 
            // ContextSviCasovi
            // 
            this.ContextSviCasovi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextSviCasovi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviCasoviToolStripMenuItem,
            this.obrisiZavrseneCasoveToolStripMenuItem});
            this.ContextSviCasovi.Name = "ContextSviCasovi";
            this.ContextSviCasovi.Size = new System.Drawing.Size(141, 52);
            // 
            // sviCasoviToolStripMenuItem
            // 
            this.sviCasoviToolStripMenuItem.Name = "sviCasoviToolStripMenuItem";
            this.sviCasoviToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.sviCasoviToolStripMenuItem.Text = "SviCasovi";
            this.sviCasoviToolStripMenuItem.Click += new System.EventHandler(this.sviCasoviToolStripMenuItem_Click);
            // 
            // obrisiZavrseneCasoveToolStripMenuItem
            // 
            this.obrisiZavrseneCasoveToolStripMenuItem.Name = "obrisiZavrseneCasoveToolStripMenuItem";
            this.obrisiZavrseneCasoveToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.obrisiZavrseneCasoveToolStripMenuItem.Text = "ObrisiCas";
            this.obrisiZavrseneCasoveToolStripMenuItem.Click += new System.EventHandler(this.obrisiZavrseneCasoveToolStripMenuItem_Click);
            // 
            // casoviBindingSource1
            // 
            this.casoviBindingSource1.DataMember = "Casovi";
            this.casoviBindingSource1.DataSource = this.menadzer_CasovaDataSet;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "CASOVI";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(694, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "PROJEKTI";
            // 
            // DataGridProjekti
            // 
            this.DataGridProjekti.AutoGenerateColumns = false;
            this.DataGridProjekti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraPomociDataGridViewTextBoxColumn1,
            this.rokDataGridViewTextBoxColumn,
            this.uplacenAvansDataGridViewCheckBoxColumn,
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn1,
            this.korisnikDataGridViewTextBoxColumn1,
            this.odradjenoDataGridViewCheckBoxColumn,
            this.idCeneDataGridViewTextBoxColumn,
            this.IdCene});
            this.DataGridProjekti.ContextMenuStrip = this.ContextSviProjekti;
            this.DataGridProjekti.DataSource = this.projektiBindingSource4;
            this.DataGridProjekti.Location = new System.Drawing.Point(85, 385);
            this.DataGridProjekti.Name = "DataGridProjekti";
            this.DataGridProjekti.RowHeadersWidth = 51;
            this.DataGridProjekti.RowTemplate.Height = 24;
            this.DataGridProjekti.Size = new System.Drawing.Size(1431, 187);
            this.DataGridProjekti.TabIndex = 4;
            this.DataGridProjekti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.DataGridProjekti.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProjekti_CellValueChanged);
            this.DataGridProjekti.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridProjekti_CurrentCellDirtyStateChanged);
            // 
            // sifraPomociDataGridViewTextBoxColumn1
            // 
            this.sifraPomociDataGridViewTextBoxColumn1.DataPropertyName = "SifraPomoci";
            this.sifraPomociDataGridViewTextBoxColumn1.HeaderText = "SifraPomoci";
            this.sifraPomociDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sifraPomociDataGridViewTextBoxColumn1.Name = "sifraPomociDataGridViewTextBoxColumn1";
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
            // uplacenoCelokupnoDataGridViewCheckBoxColumn1
            // 
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn1.DataPropertyName = "UplacenoCelokupno";
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn1.HeaderText = "UplacenoCelokupno";
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.uplacenoCelokupnoDataGridViewCheckBoxColumn1.Name = "uplacenoCelokupnoDataGridViewCheckBoxColumn1";
            // 
            // korisnikDataGridViewTextBoxColumn1
            // 
            this.korisnikDataGridViewTextBoxColumn1.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn1.DataSource = this.korisnikBindingSource;
            this.korisnikDataGridViewTextBoxColumn1.DisplayMember = "ImePrezime";
            this.korisnikDataGridViewTextBoxColumn1.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.korisnikDataGridViewTextBoxColumn1.Name = "korisnikDataGridViewTextBoxColumn1";
            this.korisnikDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.korisnikDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.korisnikDataGridViewTextBoxColumn1.ValueMember = "BrojKorisnika";
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
            this.idCeneDataGridViewTextBoxColumn.DataSource = this.cenovnikProjektiBindingSource1;
            this.idCeneDataGridViewTextBoxColumn.DisplayMember = "Predmet";
            this.idCeneDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.idCeneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCeneDataGridViewTextBoxColumn.Name = "idCeneDataGridViewTextBoxColumn";
            this.idCeneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCeneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCeneDataGridViewTextBoxColumn.ValueMember = "IdCene";
            // 
            // cenovnikProjektiBindingSource1
            // 
            this.cenovnikProjektiBindingSource1.DataMember = "CenovnikProjekti";
            this.cenovnikProjektiBindingSource1.DataSource = this.menadzer_CasovaDataSet;
            // 
            // IdCene
            // 
            this.IdCene.DataPropertyName = "IdCene";
            this.IdCene.DataSource = this.cenovnikProjektiBindingSource2;
            this.IdCene.DisplayMember = "Cena";
            this.IdCene.HeaderText = "Cena";
            this.IdCene.MinimumWidth = 6;
            this.IdCene.Name = "IdCene";
            this.IdCene.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdCene.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdCene.ValueMember = "IdCene";
            // 
            // cenovnikProjektiBindingSource2
            // 
            this.cenovnikProjektiBindingSource2.DataMember = "CenovnikProjekti";
            this.cenovnikProjektiBindingSource2.DataSource = this.menadzer_CasovaDataSet;
            // 
            // ContextSviProjekti
            // 
            this.ContextSviProjekti.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextSviProjekti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviProjektiKorisnikaToolStripMenuItem,
            this.obrisiZavrseneProjekteToolStripMenuItem});
            this.ContextSviProjekti.Name = "ContextSviProjekti";
            this.ContextSviProjekti.Size = new System.Drawing.Size(208, 52);
            // 
            // sviProjektiKorisnikaToolStripMenuItem
            // 
            this.sviProjektiKorisnikaToolStripMenuItem.Name = "sviProjektiKorisnikaToolStripMenuItem";
            this.sviProjektiKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.sviProjektiKorisnikaToolStripMenuItem.Text = "SviProjektiKorisnika";
            this.sviProjektiKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.sviProjektiKorisnikaToolStripMenuItem_Click);
            // 
            // obrisiZavrseneProjekteToolStripMenuItem
            // 
            this.obrisiZavrseneProjekteToolStripMenuItem.Name = "obrisiZavrseneProjekteToolStripMenuItem";
            this.obrisiZavrseneProjekteToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.obrisiZavrseneProjekteToolStripMenuItem.Text = "ObrisiProjekat";
            this.obrisiZavrseneProjekteToolStripMenuItem.Click += new System.EventHandler(this.obrisiZavrseneProjekteToolStripMenuItem_Click);
            // 
            // projektiBindingSource4
            // 
            this.projektiBindingSource4.DataMember = "Projekti";
            this.projektiBindingSource4.DataSource = this.menadzer_CasovaDataSet;
            // 
            // cenovnikProjektiBindingSource
            // 
            this.cenovnikProjektiBindingSource.DataMember = "CenovnikProjekti";
            this.cenovnikProjektiBindingSource.DataSource = this.menadzer_CasovaDataSet2;
            // 
            // menadzer_CasovaDataSet2
            // 
            this.menadzer_CasovaDataSet2.DataSetName = "Menadzer_CasovaDataSet";
            this.menadzer_CasovaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projektiBindingSource3
            // 
            this.projektiBindingSource3.DataMember = "Projekti";
            this.projektiBindingSource3.DataSource = this.menadzer_CasovaDataSet;
            // 
            // projektiBindingSource
            // 
            this.projektiBindingSource.DataMember = "Projekti";
            this.projektiBindingSource.DataSource = this.menadzer_CasovaDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNOSToolStripMenuItem,
            this.iZMENIToolStripMenuItem,
            this.zAVRSENOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1677, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uNOSToolStripMenuItem
            // 
            this.uNOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cASOVAToolStripMenuItem,
            this.pROJEKTAToolStripMenuItem,
            this.kORISNIKAToolStripMenuItem});
            this.uNOSToolStripMenuItem.Name = "uNOSToolStripMenuItem";
            this.uNOSToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.uNOSToolStripMenuItem.Text = "UNOS";
            // 
            // cASOVAToolStripMenuItem
            // 
            this.cASOVAToolStripMenuItem.Name = "cASOVAToolStripMenuItem";
            this.cASOVAToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.cASOVAToolStripMenuItem.Text = "CASOVA";
            this.cASOVAToolStripMenuItem.Click += new System.EventHandler(this.cASOVAToolStripMenuItem_Click);
            // 
            // pROJEKTAToolStripMenuItem
            // 
            this.pROJEKTAToolStripMenuItem.Name = "pROJEKTAToolStripMenuItem";
            this.pROJEKTAToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.pROJEKTAToolStripMenuItem.Text = "PROJEKTA";
            this.pROJEKTAToolStripMenuItem.Click += new System.EventHandler(this.pROJEKTAToolStripMenuItem_Click);
            // 
            // kORISNIKAToolStripMenuItem
            // 
            this.kORISNIKAToolStripMenuItem.Name = "kORISNIKAToolStripMenuItem";
            this.kORISNIKAToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.kORISNIKAToolStripMenuItem.Text = "KORISNIKA";
            this.kORISNIKAToolStripMenuItem.Click += new System.EventHandler(this.kORISNIKAToolStripMenuItem_Click);
            // 
            // iZMENIToolStripMenuItem
            // 
            this.iZMENIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kORISNIKAToolStripMenuItem1});
            this.iZMENIToolStripMenuItem.Name = "iZMENIToolStripMenuItem";
            this.iZMENIToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.iZMENIToolStripMenuItem.Text = "IZMENI";
            // 
            // kORISNIKAToolStripMenuItem1
            // 
            this.kORISNIKAToolStripMenuItem1.Name = "kORISNIKAToolStripMenuItem1";
            this.kORISNIKAToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.kORISNIKAToolStripMenuItem1.Text = "KORISNIKA";
            this.kORISNIKAToolStripMenuItem1.Click += new System.EventHandler(this.kORISNIKAToolStripMenuItem1_Click);
            // 
            // zAVRSENOToolStripMenuItem
            // 
            this.zAVRSENOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casoviToolStripMenuItem,
            this.projektiToolStripMenuItem});
            this.zAVRSENOToolStripMenuItem.Name = "zAVRSENOToolStripMenuItem";
            this.zAVRSENOToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.zAVRSENOToolStripMenuItem.Text = "ZAVRSENO";
            // 
            // casoviToolStripMenuItem
            // 
            this.casoviToolStripMenuItem.Name = "casoviToolStripMenuItem";
            this.casoviToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.casoviToolStripMenuItem.Text = "Casovi";
            this.casoviToolStripMenuItem.Click += new System.EventHandler(this.casoviToolStripMenuItem_Click);
            // 
            // projektiToolStripMenuItem
            // 
            this.projektiToolStripMenuItem.Name = "projektiToolStripMenuItem";
            this.projektiToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.projektiToolStripMenuItem.Text = "Projekti";
            this.projektiToolStripMenuItem.Click += new System.EventHandler(this.projektiToolStripMenuItem_Click);
            // 
            // casoviBindingSource
            // 
            this.casoviBindingSource.DataMember = "Casovi";
            this.casoviBindingSource.DataSource = this.menadzer_CasovaDataSet;
            // 
            // casoviTableAdapter
            // 
            this.casoviTableAdapter.ClearBeforeFill = true;
            // 
            // projektiTableAdapter
            // 
            this.projektiTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informacije o korisniku";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(26, 636);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(490, 199);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // menadzer_CasovaDataSet1
            // 
            this.menadzer_CasovaDataSet1.DataSetName = "Menadzer_CasovaDataSet";
            this.menadzer_CasovaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projektiBindingSource1
            // 
            this.projektiBindingSource1.DataMember = "Projekti";
            this.projektiBindingSource1.DataSource = this.menadzer_CasovaDataSet1;
            // 
            // projektiBindingSource2
            // 
            this.projektiBindingSource2.DataMember = "Projekti";
            this.projektiBindingSource2.DataSource = this.menadzer_CasovaDataSet1;
            // 
            // cenovnikProjektiTableAdapter
            // 
            this.cenovnikProjektiTableAdapter.ClearBeforeFill = true;
            // 
            // boxPotencijalnaZarada
            // 
            this.boxPotencijalnaZarada.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxPotencijalnaZarada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPotencijalnaZarada.ForeColor = System.Drawing.SystemColors.Window;
            this.boxPotencijalnaZarada.Location = new System.Drawing.Point(205, 36);
            this.boxPotencijalnaZarada.Name = "boxPotencijalnaZarada";
            this.boxPotencijalnaZarada.ReadOnly = true;
            this.boxPotencijalnaZarada.Size = new System.Drawing.Size(145, 28);
            this.boxPotencijalnaZarada.TabIndex = 8;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Potencijalna Zarada";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.boxUkupnaZaradaCasova);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.boxPotencijalnaZarada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boxTrenutnaZarada);
            this.groupBox1.Location = new System.Drawing.Point(903, 630);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 205);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarada Casova";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 22);
            this.label16.TabIndex = 21;
            this.label16.Text = "Ukupna Zarada";
            // 
            // boxUkupnaZaradaCasova
            // 
            this.boxUkupnaZaradaCasova.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxUkupnaZaradaCasova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUkupnaZaradaCasova.ForeColor = System.Drawing.SystemColors.Window;
            this.boxUkupnaZaradaCasova.Location = new System.Drawing.Point(205, 156);
            this.boxUkupnaZaradaCasova.Name = "boxUkupnaZaradaCasova";
            this.boxUkupnaZaradaCasova.ReadOnly = true;
            this.boxUkupnaZaradaCasova.Size = new System.Drawing.Size(145, 28);
            this.boxUkupnaZaradaCasova.TabIndex = 20;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.boxUkupnaZaradaProjekata);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.boxPotZarProjekat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.boxTrenutnaZarProjekat);
            this.groupBox2.Location = new System.Drawing.Point(1281, 630);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 205);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zarada Projekata";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "Ukupna Zarada";
            // 
            // boxUkupnaZaradaProjekata
            // 
            this.boxUkupnaZaradaProjekata.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxUkupnaZaradaProjekata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUkupnaZaradaProjekata.ForeColor = System.Drawing.SystemColors.Window;
            this.boxUkupnaZaradaProjekata.Location = new System.Drawing.Point(205, 162);
            this.boxUkupnaZaradaProjekata.Name = "boxUkupnaZaradaProjekata";
            this.boxUkupnaZaradaProjekata.ReadOnly = true;
            this.boxUkupnaZaradaProjekata.Size = new System.Drawing.Size(145, 28);
            this.boxUkupnaZaradaProjekata.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 18);
            this.label13.TabIndex = 17;
            this.label13.Text = "(Uplaceno)";
            // 
            // boxPotZarProjekat
            // 
            this.boxPotZarProjekat.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxPotZarProjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPotZarProjekat.ForeColor = System.Drawing.SystemColors.Window;
            this.boxPotZarProjekat.Location = new System.Drawing.Point(205, 36);
            this.boxPotZarProjekat.Name = "boxPotZarProjekat";
            this.boxPotZarProjekat.ReadOnly = true;
            this.boxPotZarProjekat.Size = new System.Drawing.Size(145, 28);
            this.boxPotZarProjekat.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Potencijalna Zarada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Trenutna zarada";
            // 
            // boxTrenutnaZarProjekat
            // 
            this.boxTrenutnaZarProjekat.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxTrenutnaZarProjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTrenutnaZarProjekat.ForeColor = System.Drawing.SystemColors.Window;
            this.boxTrenutnaZarProjekat.Location = new System.Drawing.Point(205, 92);
            this.boxTrenutnaZarProjekat.Name = "boxTrenutnaZarProjekat";
            this.boxTrenutnaZarProjekat.ReadOnly = true;
            this.boxTrenutnaZarProjekat.Size = new System.Drawing.Size(145, 28);
            this.boxTrenutnaZarProjekat.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(974, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Zarada Casova";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1348, 595);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "Zarada Projekata";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(636, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ukupna zarada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.boxMOGUCAUKUPNA);
            this.groupBox3.Controls.Add(this.boxUKUPNAUKUPNA);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.boxUplacenaUKUPNA);
            this.groupBox3.Location = new System.Drawing.Point(522, 636);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 199);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ukupna Zarada";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 18);
            this.label18.TabIndex = 22;
            this.label18.Text = "(Uplaceno)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 22);
            this.label17.TabIndex = 23;
            this.label17.Text = "Ukupna Zarada";
            // 
            // boxMOGUCAUKUPNA
            // 
            this.boxMOGUCAUKUPNA.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxMOGUCAUKUPNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMOGUCAUKUPNA.ForeColor = System.Drawing.SystemColors.Window;
            this.boxMOGUCAUKUPNA.Location = new System.Drawing.Point(205, 36);
            this.boxMOGUCAUKUPNA.Name = "boxMOGUCAUKUPNA";
            this.boxMOGUCAUKUPNA.ReadOnly = true;
            this.boxMOGUCAUKUPNA.Size = new System.Drawing.Size(145, 28);
            this.boxMOGUCAUKUPNA.TabIndex = 8;
            // 
            // boxUKUPNAUKUPNA
            // 
            this.boxUKUPNAUKUPNA.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxUKUPNAUKUPNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUKUPNAUKUPNA.ForeColor = System.Drawing.SystemColors.Window;
            this.boxUKUPNAUKUPNA.Location = new System.Drawing.Point(205, 150);
            this.boxUKUPNAUKUPNA.Name = "boxUKUPNAUKUPNA";
            this.boxUKUPNAUKUPNA.ReadOnly = true;
            this.boxUKUPNAUKUPNA.Size = new System.Drawing.Size(145, 28);
            this.boxUKUPNAUKUPNA.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "Potencijalna Zarada";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Trenutna zarada";
            // 
            // boxUplacenaUKUPNA
            // 
            this.boxUplacenaUKUPNA.BackColor = System.Drawing.SystemColors.Highlight;
            this.boxUplacenaUKUPNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUplacenaUKUPNA.ForeColor = System.Drawing.SystemColors.Window;
            this.boxUplacenaUKUPNA.Location = new System.Drawing.Point(205, 92);
            this.boxUplacenaUKUPNA.Name = "boxUplacenaUKUPNA";
            this.boxUplacenaUKUPNA.ReadOnly = true;
            this.boxUplacenaUKUPNA.Size = new System.Drawing.Size(145, 28);
            this.boxUplacenaUKUPNA.TabIndex = 10;
            // 
            // projektiBindingSource5
            // 
            this.projektiBindingSource5.DataMember = "Projekti";
            this.projektiBindingSource5.DataSource = this.menadzer_CasovaDataSet;
            // 
            // fKProjektiCenovnikProjektiBindingSource
            // 
            this.fKProjektiCenovnikProjektiBindingSource.DataMember = "FK_Projekti_CenovnikProjekti";
            this.fKProjektiCenovnikProjektiBindingSource.DataSource = this.cenovnikProjektiBindingSource1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1556, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAktivan
            // 
            this.btnAktivan.Location = new System.Drawing.Point(1556, 488);
            this.btnAktivan.Name = "btnAktivan";
            this.btnAktivan.Size = new System.Drawing.Size(75, 55);
            this.btnAktivan.TabIndex = 18;
            this.btnAktivan.Text = "Aktivan sam";
            this.btnAktivan.UseVisualStyleBackColor = true;
            this.btnAktivan.Click += new System.EventHandler(this.btnAktivan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 856);
            this.Controls.Add(this.btnAktivan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridProjekti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridCasovi);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCasovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet)).EndInit();
            this.ContextSviCasovi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casoviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProjekti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenovnikProjektiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenovnikProjektiBindingSource2)).EndInit();
            this.ContextSviProjekti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenovnikProjektiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menadzer_CasovaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProjektiCenovnikProjektiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridCasovi;
        private Menadzer_CasovaDataSet menadzer_CasovaDataSet;
        private System.Windows.Forms.BindingSource casoviBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.CasoviTableAdapter casoviTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridProjekti;
        private System.Windows.Forms.BindingSource projektiBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.ProjektiTableAdapter projektiTableAdapter;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cASOVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROJEKTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kORISNIKAToolStripMenuItem;
        private System.Windows.Forms.BindingSource casoviBindingSource1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odradjeno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Menadzer_CasovaDataSet menadzer_CasovaDataSet1;
        private System.Windows.Forms.BindingSource projektiBindingSource1;
        private System.Windows.Forms.BindingSource projektiBindingSource2;
        private Menadzer_CasovaDataSet menadzer_CasovaDataSet2;
    
        
        private System.Windows.Forms.BindingSource cenovnikProjektiBindingSource;
        private Menadzer_CasovaDataSetTableAdapters.CenovnikProjektiTableAdapter cenovnikProjektiTableAdapter;
        private System.Windows.Forms.TextBox boxPotencijalnaZarada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxTrenutnaZarada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox boxPotZarProjekat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxTrenutnaZarProjekat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox boxMOGUCAUKUPNA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox boxUplacenaUKUPNA;
        private System.Windows.Forms.BindingSource projektiBindingSource3;
        private System.Windows.Forms.BindingSource projektiBindingSource4;
        private System.Windows.Forms.BindingSource projektiBindingSource5;
        private System.Windows.Forms.BindingSource cenovnikProjektiBindingSource1;
        private System.Windows.Forms.BindingSource cenovnikProjektiBindingSource2;
        private System.Windows.Forms.BindingSource fKProjektiCenovnikProjektiBindingSource;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox boxUkupnaZaradaCasova;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox boxUkupnaZaradaProjekata;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox boxUKUPNAUKUPNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraPomociDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uplacenAvansDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uplacenoCelokupnoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn korisnikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odradjenoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdCene;
        private System.Windows.Forms.ContextMenuStrip ContextSviCasovi;
        private System.Windows.Forms.ToolStripMenuItem sviCasoviToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextSviProjekti;
        private System.Windows.Forms.ToolStripMenuItem sviProjektiKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZMENIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kORISNIKAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zAVRSENOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiZavrseneCasoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiZavrseneProjekteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAktivan;
    }
}

