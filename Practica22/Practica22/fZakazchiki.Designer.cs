namespace Practica22
{
    partial class fZakazchiki
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
            System.Windows.Forms.Label namefurLabel;
            System.Windows.Forms.Label nameIzdLabel;
            System.Windows.Forms.Label nameTcanLabel;
            this.pLogo = new System.Windows.Forms.Panel();
            this.bProfil = new System.Windows.Forms.Button();
            this.lZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcZak = new System.Windows.Forms.TabControl();
            this.tbKatalog = new System.Windows.Forms.TabPage();
            this.tcZar = new System.Windows.Forms.TabControl();
            this.tpTcan = new System.Windows.Forms.TabPage();
            this.bSPT = new System.Windows.Forms.Button();
            this.tbFindTcan = new System.Windows.Forms.TextBox();
            this.lFindTcan = new System.Windows.Forms.Label();
            this.pTcan = new System.Windows.Forms.FlowLayoutPanel();
            this.tpFurnit = new System.Windows.Forms.TabPage();
            this.bSpFT = new System.Windows.Forms.Button();
            this.bAddFT = new System.Windows.Forms.Button();
            this.pFurn = new System.Windows.Forms.FlowLayoutPanel();
            this.tpIzd = new System.Windows.Forms.TabPage();
            this.bAddIzd = new System.Windows.Forms.Button();
            this.izdelieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdelieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricaDataSet = new Practica22.FabricaDataSet();
            this.tpNewZakaz = new System.Windows.Forms.TabPage();
            this.pbTcan = new System.Windows.Forms.PictureBox();
            this.tcanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbFur = new System.Windows.Forms.PictureBox();
            this.furnituraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bNewZak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTcanComboBox = new System.Windows.Forms.ComboBox();
            this.tbCntFur = new System.Windows.Forms.TextBox();
            this.tbCntIzd = new System.Windows.Forms.TextBox();
            this.nameIzdComboBox = new System.Windows.Forms.ComboBox();
            this.namefurComboBox = new System.Windows.Forms.ComboBox();
            this.tpZakazStory = new System.Windows.Forms.TabPage();
            this.bWord = new System.Windows.Forms.Button();
            this.bCsv = new System.Windows.Forms.Button();
            this.pHistoryZ = new System.Windows.Forms.FlowLayoutPanel();
            this.izdelieTableAdapter = new Practica22.FabricaDataSetTableAdapters.IzdelieTableAdapter();
            this.tableAdapterManager = new Practica22.FabricaDataSetTableAdapters.TableAdapterManager();
            this.furnituraTableAdapter = new Practica22.FabricaDataSetTableAdapters.FurnituraTableAdapter();
            this.tcanTableAdapter = new Practica22.FabricaDataSetTableAdapters.TcanTableAdapter();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            namefurLabel = new System.Windows.Forms.Label();
            nameIzdLabel = new System.Windows.Forms.Label();
            nameTcanLabel = new System.Windows.Forms.Label();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcZak.SuspendLayout();
            this.tbKatalog.SuspendLayout();
            this.tcZar.SuspendLayout();
            this.tpTcan.SuspendLayout();
            this.tpFurnit.SuspendLayout();
            this.tpIzd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izdelieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdelieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet)).BeginInit();
            this.tpNewZakaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTcan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraBindingSource)).BeginInit();
            this.tpZakazStory.SuspendLayout();
            this.SuspendLayout();
            // 
            // namefurLabel
            // 
            namefurLabel.AutoSize = true;
            namefurLabel.Location = new System.Drawing.Point(71, 34);
            namefurLabel.Name = "namefurLabel";
            namefurLabel.Size = new System.Drawing.Size(84, 22);
            namefurLabel.TabIndex = 0;
            namefurLabel.Text = "Фурнитура";
            // 
            // nameIzdLabel
            // 
            nameIzdLabel.AutoSize = true;
            nameIzdLabel.Location = new System.Drawing.Point(71, 168);
            nameIzdLabel.Name = "nameIzdLabel";
            nameIzdLabel.Size = new System.Drawing.Size(71, 22);
            nameIzdLabel.TabIndex = 2;
            nameIzdLabel.Text = "Изделие";
            // 
            // nameTcanLabel
            // 
            nameTcanLabel.AutoSize = true;
            nameTcanLabel.Location = new System.Drawing.Point(71, 123);
            nameTcanLabel.Name = "nameTcanLabel";
            nameTcanLabel.Size = new System.Drawing.Size(51, 22);
            nameTcanLabel.TabIndex = 7;
            nameTcanLabel.Text = "Ткань";
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.pLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLogo.Controls.Add(this.bProfil);
            this.pLogo.Controls.Add(this.lZag);
            this.pLogo.Controls.Add(this.pictureBox1);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.ForeColor = System.Drawing.Color.Black;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(843, 161);
            this.pLogo.TabIndex = 15;
            // 
            // bProfil
            // 
            this.bProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.bProfil.Location = new System.Drawing.Point(3, 119);
            this.bProfil.Name = "bProfil";
            this.bProfil.Size = new System.Drawing.Size(110, 33);
            this.bProfil.TabIndex = 2;
            this.bProfil.Text = "Профиль";
            this.bProfil.UseVisualStyleBackColor = false;
            this.bProfil.Click += new System.EventHandler(this.bProfil_Click);
            // 
            // lZag
            // 
            this.lZag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lZag.AutoSize = true;
            this.lZag.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZag.Location = new System.Drawing.Point(227, 47);
            this.lZag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lZag.Name = "lZag";
            this.lZag.Size = new System.Drawing.Size(147, 31);
            this.lZag.TabIndex = 1;
            this.lZag.Text = "Заказчики";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Practica22.Properties.Resources.fabric_logo;
            this.pictureBox1.Location = new System.Drawing.Point(676, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tcZak
            // 
            this.tcZak.Controls.Add(this.tbKatalog);
            this.tcZak.Controls.Add(this.tpNewZakaz);
            this.tcZak.Controls.Add(this.tpZakazStory);
            this.tcZak.HotTrack = true;
            this.tcZak.Location = new System.Drawing.Point(0, 161);
            this.tcZak.Margin = new System.Windows.Forms.Padding(5);
            this.tcZak.Name = "tcZak";
            this.tcZak.SelectedIndex = 0;
            this.tcZak.Size = new System.Drawing.Size(843, 488);
            this.tcZak.TabIndex = 20;
            // 
            // tbKatalog
            // 
            this.tbKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(26)))));
            this.tbKatalog.Controls.Add(this.tcZar);
            this.tbKatalog.Location = new System.Drawing.Point(4, 31);
            this.tbKatalog.Margin = new System.Windows.Forms.Padding(5);
            this.tbKatalog.Name = "tbKatalog";
            this.tbKatalog.Padding = new System.Windows.Forms.Padding(5);
            this.tbKatalog.Size = new System.Drawing.Size(835, 453);
            this.tbKatalog.TabIndex = 0;
            this.tbKatalog.Text = "Каталог";
            // 
            // tcZar
            // 
            this.tcZar.Controls.Add(this.tpTcan);
            this.tcZar.Controls.Add(this.tpFurnit);
            this.tcZar.Controls.Add(this.tpIzd);
            this.tcZar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcZar.Location = new System.Drawing.Point(5, 5);
            this.tcZar.Name = "tcZar";
            this.tcZar.SelectedIndex = 0;
            this.tcZar.Size = new System.Drawing.Size(825, 443);
            this.tcZar.TabIndex = 1;
            // 
            // tpTcan
            // 
            this.tpTcan.Controls.Add(this.bSPT);
            this.tpTcan.Controls.Add(this.tbFindTcan);
            this.tpTcan.Controls.Add(this.lFindTcan);
            this.tpTcan.Controls.Add(this.pTcan);
            this.tpTcan.Location = new System.Drawing.Point(4, 31);
            this.tpTcan.Name = "tpTcan";
            this.tpTcan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTcan.Size = new System.Drawing.Size(817, 408);
            this.tpTcan.TabIndex = 0;
            this.tpTcan.Text = "Ткань";
            this.tpTcan.UseVisualStyleBackColor = true;
            // 
            // bSPT
            // 
            this.bSPT.AutoSize = true;
            this.bSPT.Location = new System.Drawing.Point(6, 373);
            this.bSPT.Name = "bSPT";
            this.bSPT.Size = new System.Drawing.Size(226, 32);
            this.bSPT.TabIndex = 9;
            this.bSPT.Text = "Списание Ткани";
            this.bSPT.UseVisualStyleBackColor = true;
            this.bSPT.Click += new System.EventHandler(this.bSPT_Click);
            // 
            // tbFindTcan
            // 
            this.tbFindTcan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFindTcan.Location = new System.Drawing.Point(590, 8);
            this.tbFindTcan.Name = "tbFindTcan";
            this.tbFindTcan.Size = new System.Drawing.Size(199, 28);
            this.tbFindTcan.TabIndex = 2;
            this.tbFindTcan.TextChanged += new System.EventHandler(this.tbFindTcan_TextChanged);
            // 
            // lFindTcan
            // 
            this.lFindTcan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lFindTcan.AutoSize = true;
            this.lFindTcan.Location = new System.Drawing.Point(518, 11);
            this.lFindTcan.Name = "lFindTcan";
            this.lFindTcan.Size = new System.Drawing.Size(54, 22);
            this.lFindTcan.TabIndex = 1;
            this.lFindTcan.Text = "Поиск";
            // 
            // pTcan
            // 
            this.pTcan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTcan.AutoScroll = true;
            this.pTcan.BackColor = System.Drawing.Color.Transparent;
            this.pTcan.Location = new System.Drawing.Point(0, 47);
            this.pTcan.Name = "pTcan";
            this.pTcan.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pTcan.Size = new System.Drawing.Size(815, 311);
            this.pTcan.TabIndex = 0;
            // 
            // tpFurnit
            // 
            this.tpFurnit.Controls.Add(this.bSpFT);
            this.tpFurnit.Controls.Add(this.bAddFT);
            this.tpFurnit.Controls.Add(this.pFurn);
            this.tpFurnit.Location = new System.Drawing.Point(4, 31);
            this.tpFurnit.Name = "tpFurnit";
            this.tpFurnit.Padding = new System.Windows.Forms.Padding(3);
            this.tpFurnit.Size = new System.Drawing.Size(817, 408);
            this.tpFurnit.TabIndex = 1;
            this.tpFurnit.Text = "Фурнитура";
            this.tpFurnit.UseVisualStyleBackColor = true;
            // 
            // bSpFT
            // 
            this.bSpFT.AutoSize = true;
            this.bSpFT.Location = new System.Drawing.Point(258, 370);
            this.bSpFT.Name = "bSpFT";
            this.bSpFT.Size = new System.Drawing.Size(226, 32);
            this.bSpFT.TabIndex = 8;
            this.bSpFT.Text = "Списание фурнитуры";
            this.bSpFT.UseVisualStyleBackColor = true;
            this.bSpFT.Click += new System.EventHandler(this.bSpFT_Click);
            // 
            // bAddFT
            // 
            this.bAddFT.AutoSize = true;
            this.bAddFT.Location = new System.Drawing.Point(6, 370);
            this.bAddFT.Name = "bAddFT";
            this.bAddFT.Size = new System.Drawing.Size(246, 32);
            this.bAddFT.TabIndex = 7;
            this.bAddFT.Text = "Добавление фурнитуры и ткани";
            this.bAddFT.UseVisualStyleBackColor = true;
            this.bAddFT.Click += new System.EventHandler(this.bAddFT_Click);
            // 
            // pFurn
            // 
            this.pFurn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFurn.AutoScroll = true;
            this.pFurn.BackColor = System.Drawing.Color.White;
            this.pFurn.Location = new System.Drawing.Point(1, 6);
            this.pFurn.Name = "pFurn";
            this.pFurn.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pFurn.Size = new System.Drawing.Size(815, 367);
            this.pFurn.TabIndex = 6;
            // 
            // tpIzd
            // 
            this.tpIzd.BackColor = System.Drawing.Color.White;
            this.tpIzd.Controls.Add(this.bAddIzd);
            this.tpIzd.Controls.Add(this.izdelieDataGridView);
            this.tpIzd.Location = new System.Drawing.Point(4, 31);
            this.tpIzd.Name = "tpIzd";
            this.tpIzd.Padding = new System.Windows.Forms.Padding(3);
            this.tpIzd.Size = new System.Drawing.Size(817, 408);
            this.tpIzd.TabIndex = 2;
            this.tpIzd.Text = "Изделие";
            // 
            // bAddIzd
            // 
            this.bAddIzd.AutoSize = true;
            this.bAddIzd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.bAddIzd.Location = new System.Drawing.Point(6, 358);
            this.bAddIzd.Name = "bAddIzd";
            this.bAddIzd.Size = new System.Drawing.Size(194, 38);
            this.bAddIzd.TabIndex = 1;
            this.bAddIzd.Text = "Добавить изделие";
            this.bAddIzd.UseVisualStyleBackColor = false;
            this.bAddIzd.Click += new System.EventHandler(this.bAddIzd_Click);
            // 
            // izdelieDataGridView
            // 
            this.izdelieDataGridView.AllowUserToAddRows = false;
            this.izdelieDataGridView.AllowUserToDeleteRows = false;
            this.izdelieDataGridView.AutoGenerateColumns = false;
            this.izdelieDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.izdelieDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.izdelieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.izdelieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izdelieDataGridView.ColumnHeadersVisible = false;
            this.izdelieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.izdelieDataGridView.DataSource = this.izdelieBindingSource;
            this.izdelieDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.izdelieDataGridView.Location = new System.Drawing.Point(6, 6);
            this.izdelieDataGridView.Name = "izdelieDataGridView";
            this.izdelieDataGridView.ReadOnly = true;
            this.izdelieDataGridView.RowHeadersVisible = false;
            this.izdelieDataGridView.RowHeadersWidth = 51;
            this.izdelieDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.izdelieDataGridView.Size = new System.Drawing.Size(805, 346);
            this.izdelieDataGridView.TabIndex = 0;
            this.izdelieDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.izdelieDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NameIzd";
            this.dataGridViewTextBoxColumn1.HeaderText = "NameIzd";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDIzd";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDIzd";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn3.HeaderText = "Length";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Whidth";
            this.dataGridViewTextBoxColumn4.HeaderText = "Whidth";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // izdelieBindingSource
            // 
            this.izdelieBindingSource.DataMember = "Izdelie";
            this.izdelieBindingSource.DataSource = this.fabricaDataSet;
            // 
            // fabricaDataSet
            // 
            this.fabricaDataSet.DataSetName = "FabricaDataSet";
            this.fabricaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpNewZakaz
            // 
            this.tpNewZakaz.AutoScroll = true;
            this.tpNewZakaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tpNewZakaz.Controls.Add(this.pbTcan);
            this.tpNewZakaz.Controls.Add(this.pbFur);
            this.tpNewZakaz.Controls.Add(this.bNewZak);
            this.tpNewZakaz.Controls.Add(this.label2);
            this.tpNewZakaz.Controls.Add(this.label1);
            this.tpNewZakaz.Controls.Add(nameTcanLabel);
            this.tpNewZakaz.Controls.Add(this.nameTcanComboBox);
            this.tpNewZakaz.Controls.Add(this.tbCntFur);
            this.tpNewZakaz.Controls.Add(this.tbCntIzd);
            this.tpNewZakaz.Controls.Add(nameIzdLabel);
            this.tpNewZakaz.Controls.Add(this.nameIzdComboBox);
            this.tpNewZakaz.Controls.Add(namefurLabel);
            this.tpNewZakaz.Controls.Add(this.namefurComboBox);
            this.tpNewZakaz.Location = new System.Drawing.Point(4, 31);
            this.tpNewZakaz.Margin = new System.Windows.Forms.Padding(5);
            this.tpNewZakaz.Name = "tpNewZakaz";
            this.tpNewZakaz.Padding = new System.Windows.Forms.Padding(5);
            this.tpNewZakaz.Size = new System.Drawing.Size(835, 453);
            this.tpNewZakaz.TabIndex = 1;
            this.tpNewZakaz.Text = "Новый заказ";
            // 
            // pbTcan
            // 
            this.pbTcan.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tcanBindingSource, "Photo", true));
            this.pbTcan.Location = new System.Drawing.Point(605, 177);
            this.pbTcan.Name = "pbTcan";
            this.pbTcan.Size = new System.Drawing.Size(140, 140);
            this.pbTcan.TabIndex = 14;
            this.pbTcan.TabStop = false;
            // 
            // tcanBindingSource
            // 
            this.tcanBindingSource.DataMember = "Tcan";
            this.tcanBindingSource.DataSource = this.fabricaDataSet;
            // 
            // pbFur
            // 
            this.pbFur.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.furnituraBindingSource, "photo", true));
            this.pbFur.Location = new System.Drawing.Point(605, 31);
            this.pbFur.Name = "pbFur";
            this.pbFur.Size = new System.Drawing.Size(140, 140);
            this.pbFur.TabIndex = 12;
            this.pbFur.TabStop = false;
            // 
            // furnituraBindingSource
            // 
            this.furnituraBindingSource.DataMember = "Furnitura";
            this.furnituraBindingSource.DataSource = this.fabricaDataSet;
            // 
            // bNewZak
            // 
            this.bNewZak.AutoSize = true;
            this.bNewZak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.bNewZak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNewZak.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewZak.Location = new System.Drawing.Point(5, 372);
            this.bNewZak.Name = "bNewZak";
            this.bNewZak.Size = new System.Drawing.Size(825, 76);
            this.bNewZak.TabIndex = 11;
            this.bNewZak.Text = "Новый заказ";
            this.bNewZak.UseVisualStyleBackColor = false;
            this.bNewZak.Click += new System.EventHandler(this.bNewZak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кол-во фурнитуры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кол-во Изделий";
            // 
            // nameTcanComboBox
            // 
            this.nameTcanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcanBindingSource, "NameTcan", true));
            this.nameTcanComboBox.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.nameTcanComboBox.FormattingEnabled = true;
            this.nameTcanComboBox.Location = new System.Drawing.Point(208, 120);
            this.nameTcanComboBox.Name = "nameTcanComboBox";
            this.nameTcanComboBox.Size = new System.Drawing.Size(317, 33);
            this.nameTcanComboBox.TabIndex = 8;
            this.nameTcanComboBox.SelectedIndexChanged += new System.EventHandler(this.nameTcanComboBox_SelectedIndexChanged);
            // 
            // tbCntFur
            // 
            this.tbCntFur.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.tbCntFur.Location = new System.Drawing.Point(208, 76);
            this.tbCntFur.Name = "tbCntFur";
            this.tbCntFur.Size = new System.Drawing.Size(317, 32);
            this.tbCntFur.TabIndex = 7;
            // 
            // tbCntIzd
            // 
            this.tbCntIzd.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.tbCntIzd.Location = new System.Drawing.Point(208, 210);
            this.tbCntIzd.Name = "tbCntIzd";
            this.tbCntIzd.Size = new System.Drawing.Size(317, 32);
            this.tbCntIzd.TabIndex = 6;
            // 
            // nameIzdComboBox
            // 
            this.nameIzdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izdelieBindingSource, "NameIzd", true));
            this.nameIzdComboBox.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.nameIzdComboBox.FormattingEnabled = true;
            this.nameIzdComboBox.Location = new System.Drawing.Point(208, 165);
            this.nameIzdComboBox.Name = "nameIzdComboBox";
            this.nameIzdComboBox.Size = new System.Drawing.Size(317, 33);
            this.nameIzdComboBox.TabIndex = 3;
            // 
            // namefurComboBox
            // 
            this.namefurComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnituraBindingSource, "namefur", true));
            this.namefurComboBox.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namefurComboBox.FormattingEnabled = true;
            this.namefurComboBox.Location = new System.Drawing.Point(208, 31);
            this.namefurComboBox.Name = "namefurComboBox";
            this.namefurComboBox.Size = new System.Drawing.Size(317, 33);
            this.namefurComboBox.TabIndex = 1;
            this.namefurComboBox.SelectedIndexChanged += new System.EventHandler(this.namefurComboBox_SelectedIndexChanged);
            // 
            // tpZakazStory
            // 
            this.tpZakazStory.AutoScroll = true;
            this.tpZakazStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tpZakazStory.Controls.Add(this.bWord);
            this.tpZakazStory.Controls.Add(this.bCsv);
            this.tpZakazStory.Controls.Add(this.pHistoryZ);
            this.tpZakazStory.Location = new System.Drawing.Point(4, 31);
            this.tpZakazStory.Margin = new System.Windows.Forms.Padding(5);
            this.tpZakazStory.Name = "tpZakazStory";
            this.tpZakazStory.Padding = new System.Windows.Forms.Padding(5);
            this.tpZakazStory.Size = new System.Drawing.Size(835, 453);
            this.tpZakazStory.TabIndex = 2;
            this.tpZakazStory.Text = "История заказов";
            // 
            // bWord
            // 
            this.bWord.AutoSize = true;
            this.bWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.bWord.Location = new System.Drawing.Point(238, 406);
            this.bWord.Name = "bWord";
            this.bWord.Size = new System.Drawing.Size(192, 39);
            this.bWord.TabIndex = 5;
            this.bWord.Text = "Экспорт данных в word";
            this.bWord.UseVisualStyleBackColor = false;
            this.bWord.Click += new System.EventHandler(this.bWord_Click);
            // 
            // bCsv
            // 
            this.bCsv.AutoSize = true;
            this.bCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.bCsv.Location = new System.Drawing.Point(8, 406);
            this.bCsv.Name = "bCsv";
            this.bCsv.Size = new System.Drawing.Size(224, 38);
            this.bCsv.TabIndex = 4;
            this.bCsv.Text = "Экспорт данных в csv";
            this.bCsv.UseVisualStyleBackColor = false;
            this.bCsv.Click += new System.EventHandler(this.bCsv_Click);
            // 
            // pHistoryZ
            // 
            this.pHistoryZ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHistoryZ.AutoScroll = true;
            this.pHistoryZ.Location = new System.Drawing.Point(8, 8);
            this.pHistoryZ.Name = "pHistoryZ";
            this.pHistoryZ.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pHistoryZ.Size = new System.Drawing.Size(831, 400);
            this.pHistoryZ.TabIndex = 3;
            // 
            // izdelieTableAdapter
            // 
            this.izdelieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Practica22.FabricaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // furnituraTableAdapter
            // 
            this.furnituraTableAdapter.ClearBeforeFill = true;
            // 
            // tcanTableAdapter
            // 
            this.tcanTableAdapter.ClearBeforeFill = true;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // fZakazchiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 649);
            this.Controls.Add(this.tcZak);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fZakazchiki";
            this.Load += new System.EventHandler(this.fZakazchiki_Load);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcZak.ResumeLayout(false);
            this.tbKatalog.ResumeLayout(false);
            this.tcZar.ResumeLayout(false);
            this.tpTcan.ResumeLayout(false);
            this.tpTcan.PerformLayout();
            this.tpFurnit.ResumeLayout(false);
            this.tpFurnit.PerformLayout();
            this.tpIzd.ResumeLayout(false);
            this.tpIzd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izdelieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdelieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet)).EndInit();
            this.tpNewZakaz.ResumeLayout(false);
            this.tpNewZakaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTcan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraBindingSource)).EndInit();
            this.tpZakazStory.ResumeLayout(false);
            this.tpZakazStory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Label lZag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tcZak;
        private System.Windows.Forms.TabPage tbKatalog;
        private System.Windows.Forms.TabPage tpNewZakaz;
        private System.Windows.Forms.TabPage tpZakazStory;
        private System.Windows.Forms.Button bProfil;
        private System.Windows.Forms.TabControl tcZar;
        private System.Windows.Forms.TabPage tpTcan;
        private System.Windows.Forms.TabPage tpFurnit;
        private System.Windows.Forms.FlowLayoutPanel pTcan;
        private System.Windows.Forms.TextBox tbFindTcan;
        private System.Windows.Forms.Label lFindTcan;
        private System.Windows.Forms.FlowLayoutPanel pHistoryZ;
        private System.Windows.Forms.FlowLayoutPanel pFurn;
        private System.Windows.Forms.TabPage tpIzd;
        private FabricaDataSet fabricaDataSet;
        private System.Windows.Forms.BindingSource izdelieBindingSource;
        private FabricaDataSetTableAdapters.IzdelieTableAdapter izdelieTableAdapter;
        private FabricaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView izdelieDataGridView;
        private System.Windows.Forms.Button bAddIzd;
        private System.Windows.Forms.BindingSource furnituraBindingSource;
        private FabricaDataSetTableAdapters.FurnituraTableAdapter furnituraTableAdapter;
        private System.Windows.Forms.ComboBox nameIzdComboBox;
        private System.Windows.Forms.ComboBox namefurComboBox;
        private System.Windows.Forms.BindingSource tcanBindingSource;
        private FabricaDataSetTableAdapters.TcanTableAdapter tcanTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nameTcanComboBox;
        private System.Windows.Forms.TextBox tbCntFur;
        private System.Windows.Forms.TextBox tbCntIzd;
        private System.Windows.Forms.Button bNewZak;
        private System.Windows.Forms.PictureBox pbTcan;
        private System.Windows.Forms.PictureBox pbFur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button bCsv;
        private System.Windows.Forms.Button bWord;
        private System.Windows.Forms.Button bSpFT;
        private System.Windows.Forms.Button bAddFT;
        private System.Windows.Forms.Button bSPT;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}