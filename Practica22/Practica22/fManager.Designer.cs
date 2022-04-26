namespace Practica22
{
    partial class fManager
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
            this.bProfil = new System.Windows.Forms.Button();
            this.lZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pLogo.SuspendLayout();
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
            this.pLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(844, 171);
            this.pLogo.TabIndex = 17;
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
            this.lZag.Location = new System.Drawing.Point(228, 52);
            this.lZag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lZag.Name = "lZag";
            this.lZag.Size = new System.Drawing.Size(173, 31);
            this.lZag.TabIndex = 1;
            this.lZag.Text = "Кладовщики";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Practica22.Properties.Resources.fabric_logo;
            this.pictureBox1.Location = new System.Drawing.Point(677, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 624);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "fManager";
            this.Text = "Менеджены";
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Button bProfil;
        private System.Windows.Forms.Label lZag;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}