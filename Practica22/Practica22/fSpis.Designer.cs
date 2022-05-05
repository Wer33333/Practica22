namespace Practica22
{
    partial class fSpis
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
            this.tcSpis = new System.Windows.Forms.TabControl();
            this.tpFur = new System.Windows.Forms.TabPage();
            this.bDelListF = new System.Windows.Forms.Button();
            this.bAddListF = new System.Windows.Forms.Button();
            this.pFur = new System.Windows.Forms.FlowLayoutPanel();
            this.tpTc = new System.Windows.Forms.TabPage();
            this.bDelListT = new System.Windows.Forms.Button();
            this.bAddListT = new System.Windows.Forms.Button();
            this.pTcan = new System.Windows.Forms.FlowLayoutPanel();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bAddPost = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.lCnt = new System.Windows.Forms.Label();
            this.tcSpis.SuspendLayout();
            this.tpFur.SuspendLayout();
            this.tpTc.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcSpis
            // 
            this.tcSpis.Controls.Add(this.tpFur);
            this.tcSpis.Controls.Add(this.tpTc);
            this.tcSpis.Location = new System.Drawing.Point(0, 124);
            this.tcSpis.Name = "tcSpis";
            this.tcSpis.SelectedIndex = 0;
            this.tcSpis.Size = new System.Drawing.Size(803, 290);
            this.tcSpis.TabIndex = 0;
            // 
            // tpFur
            // 
            this.tpFur.Controls.Add(this.bDelListF);
            this.tpFur.Controls.Add(this.bAddListF);
            this.tpFur.Controls.Add(this.pFur);
            this.tpFur.Location = new System.Drawing.Point(4, 31);
            this.tpFur.Name = "tpFur";
            this.tpFur.Padding = new System.Windows.Forms.Padding(3);
            this.tpFur.Size = new System.Drawing.Size(795, 255);
            this.tpFur.TabIndex = 0;
            this.tpFur.Text = "Фурнитура";
            this.tpFur.UseVisualStyleBackColor = true;
            // 
            // bDelListF
            // 
            this.bDelListF.AutoSize = true;
            this.bDelListF.Location = new System.Drawing.Point(170, 7);
            this.bDelListF.Name = "bDelListF";
            this.bDelListF.Size = new System.Drawing.Size(153, 32);
            this.bDelListF.TabIndex = 2;
            this.bDelListF.Text = "Удалить из списка";
            this.bDelListF.UseVisualStyleBackColor = true;
            this.bDelListF.Click += new System.EventHandler(this.bDelListF_Click);
            // 
            // bAddListF
            // 
            this.bAddListF.AutoSize = true;
            this.bAddListF.Location = new System.Drawing.Point(8, 7);
            this.bAddListF.Name = "bAddListF";
            this.bAddListF.Size = new System.Drawing.Size(156, 32);
            this.bAddListF.TabIndex = 1;
            this.bAddListF.Text = "Добавить в список";
            this.bAddListF.UseVisualStyleBackColor = true;
            this.bAddListF.Click += new System.EventHandler(this.bAddListF_Click);
            // 
            // pFur
            // 
            this.pFur.Location = new System.Drawing.Point(8, 45);
            this.pFur.Name = "pFur";
            this.pFur.Size = new System.Drawing.Size(784, 204);
            this.pFur.TabIndex = 0;
            // 
            // tpTc
            // 
            this.tpTc.Controls.Add(this.bDelListT);
            this.tpTc.Controls.Add(this.bAddListT);
            this.tpTc.Controls.Add(this.pTcan);
            this.tpTc.Location = new System.Drawing.Point(4, 31);
            this.tpTc.Name = "tpTc";
            this.tpTc.Padding = new System.Windows.Forms.Padding(3);
            this.tpTc.Size = new System.Drawing.Size(795, 255);
            this.tpTc.TabIndex = 1;
            this.tpTc.Text = "Ткань";
            this.tpTc.UseVisualStyleBackColor = true;
            // 
            // bDelListT
            // 
            this.bDelListT.AutoSize = true;
            this.bDelListT.Location = new System.Drawing.Point(170, 6);
            this.bDelListT.Name = "bDelListT";
            this.bDelListT.Size = new System.Drawing.Size(153, 32);
            this.bDelListT.TabIndex = 5;
            this.bDelListT.Text = "Удалить из списка";
            this.bDelListT.UseVisualStyleBackColor = true;
            this.bDelListT.Click += new System.EventHandler(this.bDelListT_Click);
            // 
            // bAddListT
            // 
            this.bAddListT.AutoSize = true;
            this.bAddListT.Location = new System.Drawing.Point(8, 6);
            this.bAddListT.Name = "bAddListT";
            this.bAddListT.Size = new System.Drawing.Size(156, 32);
            this.bAddListT.TabIndex = 4;
            this.bAddListT.Text = "Добавить в список";
            this.bAddListT.UseVisualStyleBackColor = true;
            this.bAddListT.Click += new System.EventHandler(this.bAddListT_Click);
            // 
            // pTcan
            // 
            this.pTcan.Location = new System.Drawing.Point(8, 44);
            this.pTcan.Name = "pTcan";
            this.pTcan.Size = new System.Drawing.Size(775, 211);
            this.pTcan.TabIndex = 3;
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.pLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLogo.Controls.Add(this.lZag);
            this.pLogo.Controls.Add(this.pictureBox1);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.ForeColor = System.Drawing.Color.Black;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(803, 125);
            this.pLogo.TabIndex = 16;
            // 
            // lZag
            // 
            this.lZag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lZag.AutoSize = true;
            this.lZag.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZag.Location = new System.Drawing.Point(207, 29);
            this.lZag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lZag.Name = "lZag";
            this.lZag.Size = new System.Drawing.Size(176, 31);
            this.lZag.TabIndex = 1;
            this.lZag.Text = "Добавление ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Practica22.Properties.Resources.fabric_logo;
            this.pictureBox1.Location = new System.Drawing.Point(636, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bClose
            // 
            this.bClose.AutoSize = true;
            this.bClose.Location = new System.Drawing.Point(225, 420);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 32);
            this.bClose.TabIndex = 18;
            this.bClose.Text = "Отмена";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // bAddPost
            // 
            this.bAddPost.AutoSize = true;
            this.bAddPost.Location = new System.Drawing.Point(16, 420);
            this.bAddPost.Name = "bAddPost";
            this.bAddPost.Size = new System.Drawing.Size(203, 32);
            this.bAddPost.TabIndex = 17;
            this.bAddPost.Text = "Добавить на поступление";
            this.bAddPost.UseVisualStyleBackColor = true;
            this.bAddPost.Click += new System.EventHandler(this.bAddPost_Click);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(468, 424);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(82, 28);
            this.tbCount.TabIndex = 19;
            // 
            // lCnt
            // 
            this.lCnt.AutoSize = true;
            this.lCnt.Location = new System.Drawing.Point(323, 424);
            this.lCnt.Name = "lCnt";
            this.lCnt.Size = new System.Drawing.Size(139, 22);
            this.lCnt.TabIndex = 20;
            this.lCnt.Text = "Кол-во продукции";
            // 
            // fSpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 455);
            this.Controls.Add(this.lCnt);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAddPost);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.tcSpis);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSpis";
            this.Text = "fSpis";
            this.Load += new System.EventHandler(this.fSpis_Load);
            this.tcSpis.ResumeLayout(false);
            this.tpFur.ResumeLayout(false);
            this.tpFur.PerformLayout();
            this.tpTc.ResumeLayout(false);
            this.tpTc.PerformLayout();
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcSpis;
        private System.Windows.Forms.TabPage tpFur;
        private System.Windows.Forms.FlowLayoutPanel pFur;
        private System.Windows.Forms.TabPage tpTc;
        private System.Windows.Forms.Button bDelListF;
        private System.Windows.Forms.Button bAddListF;
        private System.Windows.Forms.Button bDelListT;
        private System.Windows.Forms.Button bAddListT;
        private System.Windows.Forms.FlowLayoutPanel pTcan;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Label lZag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bAddPost;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label lCnt;
    }
}