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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.pLogo = new System.Windows.Forms.Panel();
            this.bProfil = new System.Windows.Forms.Button();
            this.lZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcZak = new System.Windows.Forms.TabControl();
            this.tbKatalog = new System.Windows.Forms.TabPage();
            this.tcFurnit = new System.Windows.Forms.TabControl();
            this.tpTcan = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tpNewZakaz = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tpZakazStory = new System.Windows.Forms.TabPage();
            this.pTcan = new System.Windows.Forms.FlowLayoutPanel();
            this.lFindTcan = new System.Windows.Forms.Label();
            this.tbFindTcan = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcZak.SuspendLayout();
            this.tbKatalog.SuspendLayout();
            this.tcFurnit.SuspendLayout();
            this.tpTcan.SuspendLayout();
            this.tpNewZakaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(32, 391);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 22);
            label2.TabIndex = 20;
            label2.Text = "Count Izd:";
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
            this.pLogo.Size = new System.Drawing.Size(843, 171);
            this.pLogo.TabIndex = 15;
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
            // tcZak
            // 
            this.tcZak.Controls.Add(this.tbKatalog);
            this.tcZak.Controls.Add(this.tpNewZakaz);
            this.tcZak.Controls.Add(this.tpZakazStory);
            this.tcZak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcZak.HotTrack = true;
            this.tcZak.Location = new System.Drawing.Point(0, 171);
            this.tcZak.Margin = new System.Windows.Forms.Padding(5);
            this.tcZak.Name = "tcZak";
            this.tcZak.SelectedIndex = 0;
            this.tcZak.Size = new System.Drawing.Size(843, 478);
            this.tcZak.TabIndex = 20;
            // 
            // tbKatalog
            // 
            this.tbKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(26)))));
            this.tbKatalog.Controls.Add(this.tcFurnit);
            this.tbKatalog.Location = new System.Drawing.Point(4, 31);
            this.tbKatalog.Margin = new System.Windows.Forms.Padding(5);
            this.tbKatalog.Name = "tbKatalog";
            this.tbKatalog.Padding = new System.Windows.Forms.Padding(5);
            this.tbKatalog.Size = new System.Drawing.Size(835, 443);
            this.tbKatalog.TabIndex = 0;
            this.tbKatalog.Text = "Каталог";
            // 
            // tcFurnit
            // 
            this.tcFurnit.Controls.Add(this.tpTcan);
            this.tcFurnit.Controls.Add(this.tabPage2);
            this.tcFurnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFurnit.Location = new System.Drawing.Point(5, 5);
            this.tcFurnit.Name = "tcFurnit";
            this.tcFurnit.SelectedIndex = 0;
            this.tcFurnit.Size = new System.Drawing.Size(825, 433);
            this.tcFurnit.TabIndex = 1;
            // 
            // tpTcan
            // 
            this.tpTcan.Controls.Add(this.tbFindTcan);
            this.tpTcan.Controls.Add(this.lFindTcan);
            this.tpTcan.Controls.Add(this.pTcan);
            this.tpTcan.Location = new System.Drawing.Point(4, 31);
            this.tpTcan.Name = "tpTcan";
            this.tpTcan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTcan.Size = new System.Drawing.Size(817, 398);
            this.tpTcan.TabIndex = 0;
            this.tpTcan.Text = "Ткань";
            this.tpTcan.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tpNewZakaz.Margin = new System.Windows.Forms.Padding(5);
            this.tpNewZakaz.Name = "tpNewZakaz";
            this.tpNewZakaz.Padding = new System.Windows.Forms.Padding(5);
            this.tpNewZakaz.Size = new System.Drawing.Size(835, 443);
            this.tpNewZakaz.TabIndex = 1;
            this.tpNewZakaz.Text = "Новый заказ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 357);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown1.TabIndex = 23;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(121, 391);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataGridView1.Location = new System.Drawing.Point(447, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(370, 278);
            this.dataGridView1.TabIndex = 19;
            // 
            // comboBox1
            // 
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
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
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
            // tpZakazStory
            // 
            this.tpZakazStory.AutoScroll = true;
            this.tpZakazStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tpZakazStory.Location = new System.Drawing.Point(4, 31);
            this.tpZakazStory.Margin = new System.Windows.Forms.Padding(5);
            this.tpZakazStory.Name = "tpZakazStory";
            this.tpZakazStory.Padding = new System.Windows.Forms.Padding(5);
            this.tpZakazStory.Size = new System.Drawing.Size(835, 443);
            this.tpZakazStory.TabIndex = 2;
            this.tpZakazStory.Text = "История заказов";
            // 
            // pTcan
            // 
            this.pTcan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTcan.AutoScroll = true;
            this.pTcan.Location = new System.Drawing.Point(0, 47);
            this.pTcan.Name = "pTcan";
            this.pTcan.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pTcan.Size = new System.Drawing.Size(815, 351);
            this.pTcan.TabIndex = 0;
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
            // tbFindTcan
            // 
            this.tbFindTcan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFindTcan.Location = new System.Drawing.Point(578, 8);
            this.tbFindTcan.Name = "tbFindTcan";
            this.tbFindTcan.Size = new System.Drawing.Size(199, 28);
            this.tbFindTcan.TabIndex = 2;
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
            this.Text = "Заказчики";
            this.Load += new System.EventHandler(this.fZakazchiki_Load);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcZak.ResumeLayout(false);
            this.tbKatalog.ResumeLayout(false);
            this.tcFurnit.ResumeLayout(false);
            this.tpTcan.ResumeLayout(false);
            this.tpTcan.PerformLayout();
            this.tpNewZakaz.ResumeLayout(false);
            this.tpNewZakaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bProfil;
        private System.Windows.Forms.TabControl tcFurnit;
        private System.Windows.Forms.TabPage tpTcan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel pTcan;
        private System.Windows.Forms.TextBox tbFindTcan;
        private System.Windows.Forms.Label lFindTcan;
    }
}