namespace Practica22
{
    partial class fAutoriz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAutoriz));
            this.pLogo = new System.Windows.Forms.Panel();
            this.lZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lPass = new System.Windows.Forms.Label();
            this.llReg = new System.Windows.Forms.LinkLabel();
            this.lCapcha = new System.Windows.Forms.Label();
            this.BtnAutor = new System.Windows.Forms.Button();
            this.tbCapcha = new System.Windows.Forms.TextBox();
            this.pbUpC = new System.Windows.Forms.PictureBox();
            this.bHidePass = new System.Windows.Forms.Button();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpC)).BeginInit();
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
            this.pLogo.Size = new System.Drawing.Size(538, 102);
            this.pLogo.TabIndex = 0;
            // 
            // lZag
            // 
            this.lZag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lZag.AutoSize = true;
            this.lZag.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZag.Location = new System.Drawing.Point(152, 31);
            this.lZag.Name = "lZag";
            this.lZag.Size = new System.Drawing.Size(178, 31);
            this.lZag.TabIndex = 1;
            this.lZag.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Practica22.Properties.Resources.fabric_logo;
            this.pictureBox1.Location = new System.Drawing.Point(436, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lLogin
            // 
            this.lLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.Location = new System.Drawing.Point(81, 138);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(56, 24);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbLogin.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(85, 165);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(360, 30);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbPass.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(85, 241);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(360, 30);
            this.tbPass.TabIndex = 4;
            // 
            // lPass
            // 
            this.lPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPass.AutoSize = true;
            this.lPass.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPass.Location = new System.Drawing.Point(81, 214);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(68, 24);
            this.lPass.TabIndex = 3;
            this.lPass.Text = "Пароль";
            // 
            // llReg
            // 
            this.llReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llReg.AutoSize = true;
            this.llReg.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llReg.Location = new System.Drawing.Point(338, 274);
            this.llReg.Name = "llReg";
            this.llReg.Size = new System.Drawing.Size(107, 24);
            this.llReg.TabIndex = 5;
            this.llReg.TabStop = true;
            this.llReg.Text = "Регистрация";
            this.llReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llReg_LinkClicked);
            // 
            // lCapcha
            // 
            this.lCapcha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCapcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.lCapcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lCapcha.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCapcha.Location = new System.Drawing.Point(198, 298);
            this.lCapcha.Name = "lCapcha";
            this.lCapcha.Size = new System.Drawing.Size(133, 67);
            this.lCapcha.TabIndex = 6;
            // 
            // BtnAutor
            // 
            this.BtnAutor.AutoSize = true;
            this.BtnAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.BtnAutor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAutor.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutor.Location = new System.Drawing.Point(0, 434);
            this.BtnAutor.Name = "BtnAutor";
            this.BtnAutor.Size = new System.Drawing.Size(538, 54);
            this.BtnAutor.TabIndex = 7;
            this.BtnAutor.Text = "Авторизация";
            this.BtnAutor.UseVisualStyleBackColor = false;
            this.BtnAutor.Click += new System.EventHandler(this.BtnAutor_Click);
            // 
            // tbCapcha
            // 
            this.tbCapcha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCapcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tbCapcha.Location = new System.Drawing.Point(198, 368);
            this.tbCapcha.Name = "tbCapcha";
            this.tbCapcha.Size = new System.Drawing.Size(133, 28);
            this.tbCapcha.TabIndex = 8;
            // 
            // pbUpC
            // 
            this.pbUpC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUpC.Image = ((System.Drawing.Image)(resources.GetObject("pbUpC.Image")));
            this.pbUpC.Location = new System.Drawing.Point(124, 315);
            this.pbUpC.Name = "pbUpC";
            this.pbUpC.Size = new System.Drawing.Size(64, 50);
            this.pbUpC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpC.TabIndex = 9;
            this.pbUpC.TabStop = false;
            this.pbUpC.Click += new System.EventHandler(this.pbUpC_Click);
            // 
            // bHidePass
            // 
            this.bHidePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bHidePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.bHidePass.Location = new System.Drawing.Point(448, 241);
            this.bHidePass.Name = "bHidePass";
            this.bHidePass.Size = new System.Drawing.Size(89, 30);
            this.bHidePass.TabIndex = 10;
            this.bHidePass.Text = "Показать";
            this.bHidePass.UseVisualStyleBackColor = false;
            this.bHidePass.Click += new System.EventHandler(this.bHidePass_Click);
            // 
            // fAutoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 488);
            this.Controls.Add(this.bHidePass);
            this.Controls.Add(this.pbUpC);
            this.Controls.Add(this.tbCapcha);
            this.Controls.Add(this.BtnAutor);
            this.Controls.Add(this.lCapcha);
            this.Controls.Add(this.llReg);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAutoriz";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.fAutoriz_Load);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lZag;
        private System.Windows.Forms.Button BtnAutor;
        public System.Windows.Forms.Label lLogin;
        public System.Windows.Forms.TextBox tbLogin;
        public System.Windows.Forms.TextBox tbPass;
        public System.Windows.Forms.Label lPass;
        public System.Windows.Forms.LinkLabel llReg;
        public System.Windows.Forms.Label lCapcha;
        private System.Windows.Forms.TextBox tbCapcha;
        private System.Windows.Forms.PictureBox pbUpC;
        private System.Windows.Forms.Button bHidePass;
    }
}

