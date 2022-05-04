namespace Practica22
{
    partial class KladMen
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
            this.pLogo = new System.Windows.Forms.Panel();
            this.lZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bSaveIzd = new System.Windows.Forms.Button();
            this.lH = new System.Windows.Forms.Label();
            this.lW = new System.Windows.Forms.Label();
            this.lNazv = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbW = new System.Windows.Forms.TextBox();
            this.tbNaz = new System.Windows.Forms.TextBox();
            this.Cm1 = new System.Windows.Forms.Label();
            this.Cm2 = new System.Windows.Forms.Label();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pLogo.Size = new System.Drawing.Size(520, 171);
            this.pLogo.TabIndex = 16;
            // 
            // lZag
            // 
            this.lZag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lZag.AutoSize = true;
            this.lZag.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZag.Location = new System.Drawing.Point(8, 53);
            this.lZag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lZag.Name = "lZag";
            this.lZag.Size = new System.Drawing.Size(343, 39);
            this.lZag.TabIndex = 1;
            this.lZag.Text = "Изменение Изделия";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Practica22.Properties.Resources.fabric_logo;
            this.pictureBox1.Location = new System.Drawing.Point(353, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bSaveIzd
            // 
            this.bSaveIzd.AutoSize = true;
            this.bSaveIzd.Location = new System.Drawing.Point(151, 340);
            this.bSaveIzd.Name = "bSaveIzd";
            this.bSaveIzd.Size = new System.Drawing.Size(111, 38);
            this.bSaveIzd.TabIndex = 31;
            this.bSaveIzd.Text = "изменить";
            this.bSaveIzd.UseVisualStyleBackColor = true;
            this.bSaveIzd.Click += new System.EventHandler(this.bSaveIzd_Click);
            // 
            // lH
            // 
            this.lH.AutoSize = true;
            this.lH.Location = new System.Drawing.Point(6, 276);
            this.lH.Name = "lH";
            this.lH.Size = new System.Drawing.Size(68, 28);
            this.lH.TabIndex = 30;
            this.lH.Text = "Длина";
            // 
            // lW
            // 
            this.lW.AutoSize = true;
            this.lW.Location = new System.Drawing.Point(6, 239);
            this.lW.Name = "lW";
            this.lW.Size = new System.Drawing.Size(80, 28);
            this.lW.TabIndex = 29;
            this.lW.Text = "Ширина";
            // 
            // lNazv
            // 
            this.lNazv.AutoSize = true;
            this.lNazv.Location = new System.Drawing.Point(6, 202);
            this.lNazv.Name = "lNazv";
            this.lNazv.Size = new System.Drawing.Size(99, 28);
            this.lNazv.TabIndex = 28;
            this.lNazv.Text = "Название";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(120, 268);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(252, 33);
            this.tbH.TabIndex = 27;
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(120, 234);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(252, 33);
            this.tbW.TabIndex = 26;
            // 
            // tbNaz
            // 
            this.tbNaz.Location = new System.Drawing.Point(120, 200);
            this.tbNaz.Name = "tbNaz";
            this.tbNaz.Size = new System.Drawing.Size(252, 33);
            this.tbNaz.TabIndex = 25;
            // 
            // Cm1
            // 
            this.Cm1.AutoSize = true;
            this.Cm1.Location = new System.Drawing.Point(378, 274);
            this.Cm1.Name = "Cm1";
            this.Cm1.Size = new System.Drawing.Size(43, 28);
            this.Cm1.TabIndex = 32;
            this.Cm1.Text = "Cm";
            // 
            // Cm2
            // 
            this.Cm2.AutoSize = true;
            this.Cm2.Location = new System.Drawing.Point(378, 237);
            this.Cm2.Name = "Cm2";
            this.Cm2.Size = new System.Drawing.Size(43, 28);
            this.Cm2.TabIndex = 33;
            this.Cm2.Text = "Cm";
            // 
            // KladMen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 414);
            this.Controls.Add(this.Cm2);
            this.Controls.Add(this.Cm1);
            this.Controls.Add(this.bSaveIzd);
            this.Controls.Add(this.lH);
            this.Controls.Add(this.lW);
            this.Controls.Add(this.lNazv);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbW);
            this.Controls.Add(this.tbNaz);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KladMen";
            this.Load += new System.EventHandler(this.KladMen_Load);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Label lZag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bSaveIzd;
        private System.Windows.Forms.Label lH;
        private System.Windows.Forms.Label lW;
        private System.Windows.Forms.Label lNazv;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.TextBox tbW;
        private System.Windows.Forms.TextBox tbNaz;
        private System.Windows.Forms.Label Cm1;
        private System.Windows.Forms.Label Cm2;
    }
}