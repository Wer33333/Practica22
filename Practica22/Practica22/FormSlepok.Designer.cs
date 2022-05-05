namespace Practica22
{
    partial class FormSlepok
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
            this.p = new System.Windows.Forms.Panel();
            this.lCntF = new System.Windows.Forms.Label();
            this.lCntIzd = new System.Windows.Forms.Label();
            this.lI = new System.Windows.Forms.Label();
            this.lF = new System.Windows.Forms.Label();
            this.lT = new System.Windows.Forms.Label();
            this.lM = new System.Windows.Forms.Label();
            this.lZ = new System.Windows.Forms.Label();
            this.PbT = new System.Windows.Forms.PictureBox();
            this.PbF = new System.Windows.Forms.PictureBox();
            this.p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbF)).BeginInit();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p.Controls.Add(this.lCntF);
            this.p.Controls.Add(this.lCntIzd);
            this.p.Controls.Add(this.lI);
            this.p.Controls.Add(this.lF);
            this.p.Controls.Add(this.lT);
            this.p.Controls.Add(this.lM);
            this.p.Controls.Add(this.lZ);
            this.p.Controls.Add(this.PbT);
            this.p.Controls.Add(this.PbF);
            this.p.Location = new System.Drawing.Point(12, 12);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(504, 232);
            this.p.TabIndex = 0;
            // 
            // lCntF
            // 
            this.lCntF.AutoSize = true;
            this.lCntF.Location = new System.Drawing.Point(305, 204);
            this.lCntF.Name = "lCntF";
            this.lCntF.Size = new System.Drawing.Size(141, 22);
            this.lCntF.TabIndex = 8;
            this.lCntF.Text = "кол-во фурнитуры";
            // 
            // lCntIzd
            // 
            this.lCntIzd.AutoSize = true;
            this.lCntIzd.Location = new System.Drawing.Point(325, 10);
            this.lCntIzd.Name = "lCntIzd";
            this.lCntIzd.Size = new System.Drawing.Size(121, 22);
            this.lCntIzd.TabIndex = 7;
            this.lCntIzd.Text = "кол во изделий";
            // 
            // lI
            // 
            this.lI.AutoSize = true;
            this.lI.Location = new System.Drawing.Point(-1, 70);
            this.lI.Name = "lI";
            this.lI.Size = new System.Drawing.Size(184, 22);
            this.lI.TabIndex = 6;
            this.lI.Text = "Изделие: Пододеяльник";
            // 
            // lF
            // 
            this.lF.AutoSize = true;
            this.lF.Location = new System.Drawing.Point(196, 101);
            this.lF.Name = "lF";
            this.lF.Size = new System.Drawing.Size(176, 22);
            this.lF.TabIndex = 5;
            this.lF.Text = "Фурнитура: Пуговицы 3";
            // 
            // lT
            // 
            this.lT.AutoSize = true;
            this.lT.Location = new System.Drawing.Point(-1, 101);
            this.lT.Name = "lT";
            this.lT.Size = new System.Drawing.Size(117, 22);
            this.lT.TabIndex = 4;
            this.lT.Text = "Ткань: Завитки";
            // 
            // lM
            // 
            this.lM.AutoSize = true;
            this.lM.Location = new System.Drawing.Point(-1, 39);
            this.lM.Name = "lM";
            this.lM.Size = new System.Drawing.Size(257, 22);
            this.lM.TabIndex = 3;
            this.lM.Text = "Менеджер: Иванов Иван Иванович";
            // 
            // lZ
            // 
            this.lZ.AutoSize = true;
            this.lZ.Location = new System.Drawing.Point(-1, 10);
            this.lZ.Name = "lZ";
            this.lZ.Size = new System.Drawing.Size(250, 22);
            this.lZ.TabIndex = 2;
            this.lZ.Text = "Заказчик: Иванов Иван Иванович";
            // 
            // PbT
            // 
            this.PbT.Location = new System.Drawing.Point(3, 126);
            this.PbT.Name = "PbT";
            this.PbT.Size = new System.Drawing.Size(100, 100);
            this.PbT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbT.TabIndex = 1;
            this.PbT.TabStop = false;
            // 
            // PbF
            // 
            this.PbF.Location = new System.Drawing.Point(200, 126);
            this.PbF.Name = "PbF";
            this.PbF.Size = new System.Drawing.Size(100, 100);
            this.PbF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbF.TabIndex = 0;
            this.PbF.TabStop = false;
            // 
            // FormSlepok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 452);
            this.Controls.Add(this.p);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSlepok";
            this.Text = "FormSlepok";
            this.p.ResumeLayout(false);
            this.p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p;
        private System.Windows.Forms.Label lCntF;
        private System.Windows.Forms.Label lCntIzd;
        private System.Windows.Forms.Label lI;
        private System.Windows.Forms.Label lF;
        private System.Windows.Forms.Label lT;
        private System.Windows.Forms.Label lM;
        private System.Windows.Forms.Label lZ;
        private System.Windows.Forms.PictureBox PbT;
        private System.Windows.Forms.PictureBox PbF;
    }
}