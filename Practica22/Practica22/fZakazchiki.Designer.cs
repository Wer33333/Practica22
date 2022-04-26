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
            System.Windows.Forms.Label countfurLabel;
            System.Windows.Forms.Label countIzdLabel;
            System.Windows.Forms.Label nameIzdLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lZag = new System.Windows.Forms.Label();
            this.tcZak = new System.Windows.Forms.TabControl();
            this.tbKatalog = new System.Windows.Forms.TabPage();
            this.tpNewZakaz = new System.Windows.Forms.TabPage();
            this.tpZakazStory = new System.Windows.Forms.TabPage();
            this.fabricaDataSet = new Practica22.FabricaDataSet();
            this.furnituraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnituraTableAdapter = new Practica22.FabricaDataSetTableAdapters.FurnituraTableAdapter();
            this.tableAdapterManager = new Practica22.FabricaDataSetTableAdapters.TableAdapterManager();
            this.izdelieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdelieTableAdapter = new Practica22.FabricaDataSetTableAdapters.IzdelieTableAdapter();
            this.tcanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcanTableAdapter = new Practica22.FabricaDataSetTableAdapters.TcanTableAdapter();
            this.zakaziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakaziTableAdapter = new Practica22.FabricaDataSetTableAdapters.ZakaziTableAdapter();
            this.countfurNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countIzdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tcanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameIzdComboBox = new System.Windows.Forms.ComboBox();
            this.furnituraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bProfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.furnituraTableAdapter1 = new Practica22.FabricaDataSetTableAdapters.FurnituraTableAdapter();
            countfurLabel = new System.Windows.Forms.Label();
            countIzdLabel = new System.Windows.Forms.Label();
            nameIzdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.pLogo.SuspendLayout();
            this.tcZak.SuspendLayout();
            this.tbKatalog.SuspendLayout();
            this.tpNewZakaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdelieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countfurNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countIzdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pLogo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(843, 171);
            this.pLogo.TabIndex = 15;
            // 
            // lZag
            // 
            this.lZag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lZag.AutoSize = true;
            this.lZag.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZag.Location = new System.Drawing.Point(227, 52);
            this.lZag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lZag.Name = "lZag";
            this.lZag.Size = new System.Drawing.Size(147, 31);
            this.lZag.TabIndex = 1;
            this.lZag.Text = "Заказчики";
            // 
            // tcZak
            // 
            this.tcZak.Controls.Add(this.tbKatalog);
            this.tcZak.Controls.Add(this.tpNewZakaz);
            this.tcZak.Controls.Add(this.tpZakazStory);
            this.tcZak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcZak.HotTrack = true;
            this.tcZak.Location = new System.Drawing.Point(0, 171);
            this.tcZak.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tcZak.Name = "tcZak";
            this.tcZak.SelectedIndex = 0;
            this.tcZak.Size = new System.Drawing.Size(843, 478);
            this.tcZak.TabIndex = 20;
            // 
            // tbKatalog
            // 
            this.tbKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(26)))));
            this.tbKatalog.Controls.Add(countfurLabel);
            this.tbKatalog.Controls.Add(this.countfurNumericUpDown);
            this.tbKatalog.Controls.Add(countIzdLabel);
            this.tbKatalog.Controls.Add(this.countIzdNumericUpDown);
            this.tbKatalog.Controls.Add(this.tcanDataGridView);
            this.tbKatalog.Controls.Add(nameIzdLabel);
            this.tbKatalog.Controls.Add(this.nameIzdComboBox);
            this.tbKatalog.Controls.Add(this.furnituraDataGridView);
            this.tbKatalog.Location = new System.Drawing.Point(4, 31);
            this.tbKatalog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbKatalog.Name = "tbKatalog";
            this.tbKatalog.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbKatalog.Size = new System.Drawing.Size(835, 443);
            this.tbKatalog.TabIndex = 0;
            this.tbKatalog.Text = "Каталог";
            // 
            // tpNewZakaz
            // 
            this.tpNewZakaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tpNewZakaz.Controls.Add(label1);
            this.tpNewZakaz.Controls.Add(this.numericUpDown1);
            this.tpNewZakaz.Controls.Add(label2);
            this.tpNewZakaz.Controls.Add(this.numericUpDown2);
            this.tpNewZakaz.Controls.Add(this.dataGridView1);
            this.tpNewZakaz.Controls.Add(label3);
            this.tpNewZakaz.Controls.Add(this.comboBox1);
            this.tpNewZakaz.Controls.Add(this.dataGridView2);
            this.tpNewZakaz.Location = new System.Drawing.Point(4, 31);
            this.tpNewZakaz.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpNewZakaz.Name = "tpNewZakaz";
            this.tpNewZakaz.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpNewZakaz.Size = new System.Drawing.Size(835, 443);
            this.tpNewZakaz.TabIndex = 1;
            this.tpNewZakaz.Text = "Новый заказ";
            // 
            // tpZakazStory
            // 
            this.tpZakazStory.AutoScroll = true;
            this.tpZakazStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tpZakazStory.Location = new System.Drawing.Point(4, 31);
            this.tpZakazStory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpZakazStory.Name = "tpZakazStory";
            this.tpZakazStory.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpZakazStory.Size = new System.Drawing.Size(835, 443);
            this.tpZakazStory.TabIndex = 2;
            this.tpZakazStory.Text = "История заказов";
            // 
            // fabricaDataSet
            // 
            this.fabricaDataSet.DataSetName = "FabricaDataSet";
            this.fabricaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnituraBindingSource
            // 
            this.furnituraBindingSource.DataMember = "Furnitura";
            this.furnituraBindingSource.DataSource = this.fabricaDataSet;
            // 
            // furnituraTableAdapter
            // 
            this.furnituraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Practica22.FabricaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // izdelieBindingSource
            // 
            this.izdelieBindingSource.DataMember = "Izdelie";
            this.izdelieBindingSource.DataSource = this.fabricaDataSet;
            // 
            // izdelieTableAdapter
            // 
            this.izdelieTableAdapter.ClearBeforeFill = true;
            // 
            // tcanBindingSource
            // 
            this.tcanBindingSource.DataMember = "Tcan";
            this.tcanBindingSource.DataSource = this.fabricaDataSet;
            // 
            // tcanTableAdapter
            // 
            this.tcanTableAdapter.ClearBeforeFill = true;
            // 
            // zakaziBindingSource
            // 
            this.zakaziBindingSource.DataMember = "Zakazi";
            this.zakaziBindingSource.DataSource = this.fabricaDataSet;
            // 
            // zakaziTableAdapter
            // 
            this.zakaziTableAdapter.ClearBeforeFill = true;
            // 
            // countfurLabel
            // 
            countfurLabel.AutoSize = true;
            countfurLabel.Location = new System.Drawing.Point(37, 357);
            countfurLabel.Name = "countfurLabel";
            countfurLabel.Size = new System.Drawing.Size(72, 22);
            countfurLabel.TabIndex = 14;
            countfurLabel.Text = "countfur:";
            // 
            // countfurNumericUpDown
            // 
            this.countfurNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.furnituraBindingSource, "countfur", true));
            this.countfurNumericUpDown.Location = new System.Drawing.Point(115, 357);
            this.countfurNumericUpDown.Name = "countfurNumericUpDown";
            this.countfurNumericUpDown.Size = new System.Drawing.Size(120, 28);
            this.countfurNumericUpDown.TabIndex = 15;
            // 
            // countIzdLabel
            // 
            countIzdLabel.AutoSize = true;
            countIzdLabel.Location = new System.Drawing.Point(27, 391);
            countIzdLabel.Name = "countIzdLabel";
            countIzdLabel.Size = new System.Drawing.Size(83, 22);
            countIzdLabel.TabIndex = 12;
            countIzdLabel.Text = "Count Izd:";
            // 
            // countIzdNumericUpDown
            // 
            this.countIzdNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zakaziBindingSource, "CountIzd", true));
            this.countIzdNumericUpDown.Location = new System.Drawing.Point(116, 391);
            this.countIzdNumericUpDown.Name = "countIzdNumericUpDown";
            this.countIzdNumericUpDown.Size = new System.Drawing.Size(120, 28);
            this.countIzdNumericUpDown.TabIndex = 13;
            // 
            // tcanDataGridView
            // 
            this.tcanDataGridView.AutoGenerateColumns = false;
            this.tcanDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tcanDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcanDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tcanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcanDataGridView.ColumnHeadersVisible = false;
            this.tcanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tcanDataGridView.DataSource = this.tcanBindingSource;
            this.tcanDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tcanDataGridView.Location = new System.Drawing.Point(442, 9);
            this.tcanDataGridView.Name = "tcanDataGridView";
            this.tcanDataGridView.RowHeadersVisible = false;
            this.tcanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tcanDataGridView.Size = new System.Drawing.Size(370, 278);
            this.tcanDataGridView.TabIndex = 11;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Photo";
            this.dataGridViewImageColumn2.DividerWidth = 10;
            this.dataGridViewImageColumn2.HeaderText = "Фото ткани";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameTcan";
            this.dataGridViewTextBoxColumn3.DividerWidth = 10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Название ткани";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameIzdLabel
            // 
            nameIzdLabel.AutoSize = true;
            nameIzdLabel.Location = new System.Drawing.Point(22, 324);
            nameIzdLabel.Name = "nameIzdLabel";
            nameIzdLabel.Size = new System.Drawing.Size(87, 22);
            nameIzdLabel.TabIndex = 9;
            nameIzdLabel.Text = "Name Izd:";
            // 
            // nameIzdComboBox
            // 
            this.nameIzdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izdelieBindingSource, "NameIzd", true));
            this.nameIzdComboBox.FormattingEnabled = true;
            this.nameIzdComboBox.Location = new System.Drawing.Point(115, 321);
            this.nameIzdComboBox.Name = "nameIzdComboBox";
            this.nameIzdComboBox.Size = new System.Drawing.Size(121, 30);
            this.nameIzdComboBox.TabIndex = 10;
            // 
            // furnituraDataGridView
            // 
            this.furnituraDataGridView.AllowUserToAddRows = false;
            this.furnituraDataGridView.AllowUserToDeleteRows = false;
            this.furnituraDataGridView.AllowUserToResizeColumns = false;
            this.furnituraDataGridView.AllowUserToResizeRows = false;
            this.furnituraDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.furnituraDataGridView.AutoGenerateColumns = false;
            this.furnituraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.furnituraDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.furnituraDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.furnituraDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.furnituraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnituraDataGridView.ColumnHeadersVisible = false;
            this.furnituraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1});
            this.furnituraDataGridView.DataSource = this.furnituraBindingSource;
            this.furnituraDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.furnituraDataGridView.Location = new System.Drawing.Point(13, 9);
            this.furnituraDataGridView.MultiSelect = false;
            this.furnituraDataGridView.Name = "furnituraDataGridView";
            this.furnituraDataGridView.ReadOnly = true;
            this.furnituraDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.furnituraDataGridView.RowHeadersWidth = 100;
            this.furnituraDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.furnituraDataGridView.Size = new System.Drawing.Size(423, 278);
            this.furnituraDataGridView.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "photo";
            this.dataGridViewImageColumn1.DividerWidth = 10;
            this.dataGridViewImageColumn1.FillWeight = 101.5228F;
            this.dataGridViewImageColumn1.HeaderText = "Фото фурнитуры";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "namefur";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn1.DividerWidth = 10;
            this.dataGridViewTextBoxColumn1.FillWeight = 98.47717F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Название фурнитуры";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 357);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 22);
            label1.TabIndex = 22;
            label1.Text = "countfur:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.furnituraBindingSource, "countfur", true));
            this.numericUpDown1.Location = new System.Drawing.Point(120, 357);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(32, 391);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 22);
            label2.TabIndex = 20;
            label2.Text = "Count Izd:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zakaziBindingSource, "CountIzd", true));
            this.numericUpDown2.Location = new System.Drawing.Point(121, 391);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.tcanBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataGridView1.Location = new System.Drawing.Point(447, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(370, 278);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "Photo";
            this.dataGridViewImageColumn3.DividerWidth = 10;
            this.dataGridViewImageColumn3.HeaderText = "Фото ткани";
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameTcan";
            this.dataGridViewTextBoxColumn2.DividerWidth = 10;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название ткани";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 324);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 22);
            label3.TabIndex = 17;
            label3.Text = "Name Izd:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izdelieBindingSource, "NameIzd", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn4,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.furnituraBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataGridView2.Location = new System.Drawing.Point(8, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 10;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(423, 278);
            this.dataGridView2.TabIndex = 16;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.DataPropertyName = "photo";
            this.dataGridViewImageColumn4.DividerWidth = 10;
            this.dataGridViewImageColumn4.FillWeight = 101.5228F;
            this.dataGridViewImageColumn4.HeaderText = "Фото фурнитуры";
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn4.MinimumWidth = 10;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "namefur";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn4.DividerWidth = 10;
            this.dataGridViewTextBoxColumn4.FillWeight = 98.47717F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Название фурнитуры";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bProfil
            // 
            this.bProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(26)))));
            this.bProfil.Location = new System.Drawing.Point(3, 129);
            this.bProfil.Name = "bProfil";
            this.bProfil.Size = new System.Drawing.Size(110, 33);
            this.bProfil.TabIndex = 2;
            this.bProfil.Text = "Профиль";
            this.bProfil.UseVisualStyleBackColor = false;
            this.bProfil.Click += new System.EventHandler(this.bProfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Practica22.Properties.Resources.fabric_logo;
            this.pictureBox1.Location = new System.Drawing.Point(676, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // furnituraTableAdapter1
            // 
            this.furnituraTableAdapter1.ClearBeforeFill = true;
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "fZakazchiki";
            this.Text = "Заказчики";
            this.Load += new System.EventHandler(this.fZakazchiki_Load);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            this.tcZak.ResumeLayout(false);
            this.tbKatalog.ResumeLayout(false);
            this.tbKatalog.PerformLayout();
            this.tpNewZakaz.ResumeLayout(false);
            this.tpNewZakaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdelieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countfurNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countIzdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private FabricaDataSet fabricaDataSet;
        private System.Windows.Forms.BindingSource furnituraBindingSource;
        private FabricaDataSetTableAdapters.FurnituraTableAdapter furnituraTableAdapter;
        private FabricaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource izdelieBindingSource;
        private FabricaDataSetTableAdapters.IzdelieTableAdapter izdelieTableAdapter;
        private System.Windows.Forms.BindingSource tcanBindingSource;
        private FabricaDataSetTableAdapters.TcanTableAdapter tcanTableAdapter;
        private System.Windows.Forms.BindingSource zakaziBindingSource;
        private FabricaDataSetTableAdapters.ZakaziTableAdapter zakaziTableAdapter;
        private System.Windows.Forms.NumericUpDown countfurNumericUpDown;
        private System.Windows.Forms.NumericUpDown countIzdNumericUpDown;
        private System.Windows.Forms.DataGridView tcanDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox nameIzdComboBox;
        private System.Windows.Forms.DataGridView furnituraDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button bProfil;
        private FabricaDataSetTableAdapters.FurnituraTableAdapter furnituraTableAdapter1;
    }
}