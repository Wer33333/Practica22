namespace Practica22
{
    partial class fReg
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
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.lPass2 = new System.Windows.Forms.Label();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.lOtch = new System.Windows.Forms.Label();
            this.lTel = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.lFam = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lPass = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.btnReg = new System.Windows.Forms.Button();
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
            this.pLogo.Controls.Add(this.lZag);
            this.pLogo.Controls.Add(this.pictureBox1);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.ForeColor = System.Drawing.Color.Black;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(577, 102);
            this.pLogo.TabIndex = 14;
            // 
            // lZag
            // 
            this.lZag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lZag.AutoSize = true;
            this.lZag.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZag.Location = new System.Drawing.Point(171, 31);
            this.lZag.Name = "lZag";
            this.lZag.Size = new System.Drawing.Size(174, 31);
            this.lZag.TabIndex = 1;
            this.lZag.Text = "Регистрация";
            // 
            // tbPass2
            // 
            this.tbPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbPass2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass2.Location = new System.Drawing.Point(173, 235);
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.PasswordChar = '*';
            this.tbPass2.Size = new System.Drawing.Size(360, 30);
            this.tbPass2.TabIndex = 55;
            // 
            // lPass2
            // 
            this.lPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPass2.AutoSize = true;
            this.lPass2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPass2.Location = new System.Drawing.Point(22, 241);
            this.lPass2.Name = "lPass2";
            this.lPass2.Size = new System.Drawing.Size(145, 24);
            this.lPass2.TabIndex = 54;
            this.lPass2.Text = "Проверка пароля";
            // 
            // tbOtch
            // 
            this.tbOtch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOtch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbOtch.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOtch.Location = new System.Drawing.Point(173, 404);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.PasswordChar = '*';
            this.tbOtch.Size = new System.Drawing.Size(360, 30);
            this.tbOtch.TabIndex = 53;
            // 
            // lOtch
            // 
            this.lOtch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lOtch.AutoSize = true;
            this.lOtch.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOtch.Location = new System.Drawing.Point(22, 407);
            this.lOtch.Name = "lOtch";
            this.lOtch.Size = new System.Drawing.Size(84, 24);
            this.lOtch.TabIndex = 52;
            this.lOtch.Text = "Отчество";
            // 
            // lTel
            // 
            this.lTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTel.AutoSize = true;
            this.lTel.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTel.Location = new System.Drawing.Point(22, 466);
            this.lTel.Name = "lTel";
            this.lTel.Size = new System.Drawing.Size(80, 24);
            this.lTel.TabIndex = 51;
            this.lTel.Text = "Телефон";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbName.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(173, 346);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '*';
            this.tbName.Size = new System.Drawing.Size(360, 30);
            this.tbName.TabIndex = 50;
            // 
            // lName
            // 
            this.lName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(22, 349);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(41, 24);
            this.lName.TabIndex = 49;
            this.lName.Text = "Имя";
            // 
            // tbFam
            // 
            this.tbFam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbFam.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFam.Location = new System.Drawing.Point(173, 288);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(360, 30);
            this.tbFam.TabIndex = 48;
            // 
            // lFam
            // 
            this.lFam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lFam.AutoSize = true;
            this.lFam.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFam.Location = new System.Drawing.Point(22, 291);
            this.lFam.Name = "lFam";
            this.lFam.Size = new System.Drawing.Size(82, 24);
            this.lFam.TabIndex = 47;
            this.lFam.Text = "Фамилия";
            // 
            // tbPass
            // 
            this.tbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbPass.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(173, 179);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(360, 30);
            this.tbPass.TabIndex = 46;
            // 
            // lPass
            // 
            this.lPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPass.AutoSize = true;
            this.lPass.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPass.Location = new System.Drawing.Point(22, 185);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(68, 24);
            this.lPass.TabIndex = 45;
            this.lPass.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbLogin.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(173, 122);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(360, 30);
            this.tbLogin.TabIndex = 44;
            // 
            // lLogin
            // 
            this.lLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.Location = new System.Drawing.Point(22, 128);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(56, 24);
            this.lLogin.TabIndex = 43;
            this.lLogin.Text = "Логин";
            // 
            // mtbTel
            // 
            this.mtbTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.mtbTel.Location = new System.Drawing.Point(173, 462);
            this.mtbTel.Margin = new System.Windows.Forms.Padding(5);
            this.mtbTel.Mask = "+7(999) 000-00-00";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(202, 28);
            this.mtbTel.TabIndex = 42;
            this.mtbTel.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // btnReg
            // 
            this.btnReg.AutoSize = true;
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReg.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(0, 518);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(577, 52);
            this.btnReg.TabIndex = 56;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Practica22.Properties.Resources.fabric_logo;
            this.pictureBox1.Location = new System.Drawing.Point(475, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 570);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbPass2);
            this.Controls.Add(this.lPass2);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.lOtch);
            this.Controls.Add(this.lTel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.lFam);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.mtbTel);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fReg";
            this.Text = "fReg";
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
        public System.Windows.Forms.TextBox tbPass2;
        public System.Windows.Forms.Label lPass2;
        public System.Windows.Forms.TextBox tbOtch;
        public System.Windows.Forms.Label lOtch;
        public System.Windows.Forms.Label lTel;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.Label lName;
        public System.Windows.Forms.TextBox tbFam;
        public System.Windows.Forms.Label lFam;
        public System.Windows.Forms.TextBox tbPass;
        public System.Windows.Forms.Label lPass;
        public System.Windows.Forms.TextBox tbLogin;
        public System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Button btnReg;
    }
}