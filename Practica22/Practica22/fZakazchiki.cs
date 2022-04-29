using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica22
{
    public partial class fZakazchiki : Form
    {
        public fZakazchiki()
        {
            InitializeComponent();
        }


        class ItemPanelFur : Panel
        {

            public System.Windows.Forms.Panel pf;
            public System.Windows.Forms.Label lCntFur;
            public System.Windows.Forms.Label lNazvFur;
            public System.Windows.Forms.PictureBox pbFur;
            public string IDFur;
            public ItemPanelFur()
            {
                this.pf = new System.Windows.Forms.Panel();
                this.lCntFur = new System.Windows.Forms.Label();
                this.lNazvFur = new System.Windows.Forms.Label();
                this.pbFur = new System.Windows.Forms.PictureBox();
                // 
                // pf
                // 
                this.pf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
                this.pf.Controls.Add(this.lCntFur);
                this.pf.Controls.Add(this.lNazvFur);
                this.pf.Controls.Add(this.pbFur);
                this.pf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.pf.Location = new System.Drawing.Point(12, 12);
                this.pf.Name = "pf";
                this.pf.Size = new System.Drawing.Size(346, 128);
                this.pf.TabIndex = 0;
                // 
                // lCntFur
                // 
                this.lCntFur.AutoSize = true;
                this.lCntFur.Location = new System.Drawing.Point(131, 103);
                this.lCntFur.Name = "lCntFur";
                this.lCntFur.Size = new System.Drawing.Size(58, 22);
                this.lCntFur.TabIndex = 2;
                this.lCntFur.Text = "label2";
                // 
                // lNazvFur
                // 
                this.lNazvFur.AutoSize = true;
                this.lNazvFur.Location = new System.Drawing.Point(132, 4);
                this.lNazvFur.Name = "lNazvFur";
                this.lNazvFur.Size = new System.Drawing.Size(58, 22);
                this.lNazvFur.TabIndex = 1;
                this.lNazvFur.Text = "label1";
                // 
                // pbFur
                // 
                this.pbFur.Location = new System.Drawing.Point(3, 3);
                this.pbFur.Name = "pbFur";
                this.pbFur.Size = new System.Drawing.Size(122, 122);
                this.pbFur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pbFur.TabIndex = 0;
                this.pbFur.TabStop = false;
            }
        }

        class ItemPanelHis : Panel
        {

            public System.Windows.Forms.Panel pZ;
            public System.Windows.Forms.Label lCntF;
            public System.Windows.Forms.Label lCntIzd;
            public System.Windows.Forms.Label lI;
            public System.Windows.Forms.Label lF;
            public System.Windows.Forms.Label lT;
            public System.Windows.Forms.Label lM;
            public System.Windows.Forms.Label lZ;
            public System.Windows.Forms.PictureBox PbT;
            public System.Windows.Forms.PictureBox PbF;

            public ItemPanelHis()
            {
                this.pZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
                this.pZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.pZ.Controls.Add(this.lCntF);
                this.pZ.Controls.Add(this.lCntIzd);
                this.pZ.Controls.Add(this.lI);
                this.pZ.Controls.Add(this.lF);
                this.pZ.Controls.Add(this.lT);
                this.pZ.Controls.Add(this.lM);
                this.pZ.Controls.Add(this.lZ);
                this.pZ.Controls.Add(this.PbT);
                this.pZ.Controls.Add(this.PbF);
                this.pZ.Location = new System.Drawing.Point(12, 12);
                this.pZ.Name = "pZ";
                this.pZ.Size = new System.Drawing.Size(504, 232);
                this.pZ.TabIndex = 0;
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
                // PbT
                // 
                this.PbT.Location = new System.Drawing.Point(3, 126);
                this.PbT.Name = "PbT";
                this.PbT.Size = new System.Drawing.Size(100, 100);
                this.PbT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.PbT.TabIndex = 1;
                this.PbT.TabStop = false;
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
                // lM
                // 
                this.lM.AutoSize = true;
                this.lM.Location = new System.Drawing.Point(-1, 39);
                this.lM.Name = "lM";
                this.lM.Size = new System.Drawing.Size(257, 22);
                this.lM.TabIndex = 3;
                this.lM.Text = "Менеджер: Иванов Иван Иванович";
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
                // lF
                // 
                this.lF.AutoSize = true;
                this.lF.Location = new System.Drawing.Point(196, 101);
                this.lF.Name = "lF";
                this.lF.Size = new System.Drawing.Size(176, 22);
                this.lF.TabIndex = 5;
                this.lF.Text = "Фурнитура: Пуговицы 3";
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
                // lCntIzd
                // 
                this.lCntIzd.AutoSize = true;
                this.lCntIzd.Location = new System.Drawing.Point(325, 10);
                this.lCntIzd.Name = "lCntIzd";
                this.lCntIzd.Size = new System.Drawing.Size(121, 22);
                this.lCntIzd.TabIndex = 7;
                this.lCntIzd.Text = "кол во изделий";
                // 
                // lCntF
                // 
                this.lCntF.AutoSize = true;
                this.lCntF.Location = new System.Drawing.Point(305, 204);
                this.lCntF.Name = "lCntF";
                this.lCntF.Size = new System.Drawing.Size(141, 22);
                this.lCntF.TabIndex = 8;
                this.lCntF.Text = "кол-во фурнитуры";
            }
        }



        class ItemPanelTcan : Panel
        {
            #region 千引く七
            public System.Windows.Forms.Panel PanelMain;
            public System.Windows.Forms.Label lHeigth;
            public System.Windows.Forms.Label lWidth;
            public System.Windows.Forms.Label lDesc;
            public System.Windows.Forms.Label lColor;
            public System.Windows.Forms.Label lName;
            public System.Windows.Forms.PictureBox pbPhotoTcan;
            public string IDTcan;
            #endregion
            public ItemPanelTcan()
            {
                this.PanelMain = new System.Windows.Forms.Panel();
                this.lHeigth = new System.Windows.Forms.Label();
                this.lWidth = new System.Windows.Forms.Label();
                this.lDesc = new System.Windows.Forms.Label();
                this.lColor = new System.Windows.Forms.Label();
                this.lName = new System.Windows.Forms.Label();
                this.pbPhotoTcan = new System.Windows.Forms.PictureBox();
                // 
                // PanelMain
                // 
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Controls.Add(this.lHeigth);
                this.Controls.Add(this.lWidth);
                this.Controls.Add(this.lDesc);
                this.Controls.Add(this.lColor);
                this.Controls.Add(this.lName);
                this.Controls.Add(this.pbPhotoTcan);
                this.Location = new System.Drawing.Point(12, 41);
                this.Name = "panelMain";
                this.Size = new System.Drawing.Size(569, 128);
                this.TabIndex = 1;
                // 
                // lHeigth
                // 
                this.lHeigth.AutoSize = true;
                this.lHeigth.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lHeigth.Location = new System.Drawing.Point(243, 104);
                this.lHeigth.Name = "lHeigth";
                this.lHeigth.Size = new System.Drawing.Size(107, 19);
                this.lHeigth.TabIndex = 7;
                this.lHeigth.Text = "Высота: 120 см";
                // 
                // lWidth
                // 
                this.lWidth.AutoSize = true;
                this.lWidth.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lWidth.Location = new System.Drawing.Point(243, 77);
                this.lWidth.Name = "lWidth";
                this.lWidth.Size = new System.Drawing.Size(109, 19);
                this.lWidth.TabIndex = 6;
                this.lWidth.Text = "Ширина: 120 см";
                // 
                // lDesc
                // 
                this.lDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                this.lDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.lDesc.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lDesc.Location = new System.Drawing.Point(375, 0);
                this.lDesc.Name = "lDesc";
                this.lDesc.Size = new System.Drawing.Size(193, 126);
                this.lDesc.TabIndex = 5;
                this.lDesc.Text = "Описание:";
                // 
                // lColor
                // 
                this.lColor.AutoSize = true;
                this.lColor.Location = new System.Drawing.Point(129, 34);
                this.lColor.Name = "lColor";
                this.lColor.Size = new System.Drawing.Size(117, 22);
                this.lColor.TabIndex = 2;
                this.lColor.Text = "Цвет: Бежевый";
                // 
                // lName
                // 
                this.lName.AutoSize = true;
                this.lName.Location = new System.Drawing.Point(129, 3);
                this.lName.Name = "lName";
                this.lName.Size = new System.Drawing.Size(128, 22);
                this.lName.TabIndex = 1;
                this.lName.Text = "Название: Плюш";
                // 
                // pbPhotoTcan
                // 
                this.pbPhotoTcan.Location = new System.Drawing.Point(3, 3);
                this.pbPhotoTcan.Name = "pbPhoto";
                this.pbPhotoTcan.Size = new System.Drawing.Size(120, 120);
                this.pbPhotoTcan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pbPhotoTcan.TabIndex = 0;
                this.pbPhotoTcan.TabStop = false;
            }
        }

        private void fZakazchiki_Load(object sender, EventArgs e)
        {
            GetDateTcanFromDB();
            GetDateFurnFromDB();
            FillPanel();
            lZag.Text = fAutoriz.ばかじゃない.FIO;
        }

        List<Tcan> LstTcan=new List<Tcan>();
        List<Furn> LstFurn = new List<Furn>();
        ItemPanelTcan CurrentItemTcan;
        ItemPanelFur CurrentItemFur;

        #region GetDB

        void GetDateFurnFromDB()
        {
            fAutoriz.SqlConn(@"select * from furnitura", true);
            LstFurn.Clear();
            while (fAutoriz.rd.Read())
            {
                Furn furn = new Furn();
                furn.Name = "Название: " + fAutoriz.rd["namefur"].ToString();
                furn.ID = fAutoriz.rd["idfur"].ToString();
                furn.Cnt= fAutoriz.rd["countfur"].ToString();
                byte[] ByteImage = (byte[])fAutoriz.rd["photo"];
                furn.PhotoFur = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                LstFurn.Add(furn);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }

        void GetDateTcanFromDB()
        {
            fAutoriz.SqlConn(@"select Whidth,IDTcan,Length,Photo,NameTcan,NameColor,Primech from Tcan,Color where Tcan.IDColor=Color.IDColor", true);
            LstTcan.Clear();
            while(fAutoriz.rd.Read())
            {
                Tcan tcan = new Tcan();
                tcan.Name ="Название: "+fAutoriz.rd["NameTcan"].ToString();
                tcan.Color= "Цвет: "+fAutoriz.rd["NameColor"].ToString();
                tcan.Desk= "Описание: "+fAutoriz.rd["Primech"].ToString();
                tcan.W= "Ширина: "+fAutoriz.rd["Whidth"].ToString();
                tcan.H= "Высота: "+fAutoriz.rd["Length"].ToString();
                tcan.ID= fAutoriz.rd["IDTcan"].ToString();
                byte[] ByteImage = (byte[])fAutoriz.rd["Photo"];
                tcan.PhotoTcan = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                LstTcan.Add(tcan);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }
        #endregion

        #region FillPanel
        void FillPanel()
        {
            pTcan.Controls.Clear();

            foreach (Tcan tcan in LstTcan)
            {
                ItemPanelTcan ItemPanelTcan = new ItemPanelTcan();
                ItemPanelTcan.lColor.Text = tcan.Color;
                ItemPanelTcan.lDesc.Text = tcan.Desk;
                ItemPanelTcan.lHeigth.Text = tcan.H;
                ItemPanelTcan.lWidth.Text = tcan.W;
                ItemPanelTcan.lName.Text = tcan.Name;
                ItemPanelTcan.IDTcan= tcan.ID;

                try
                {
                    ItemPanelTcan.pbPhotoTcan.Image = tcan.PhotoTcan;
                }
                catch
                {

                }
                pTcan.Controls.Add(ItemPanelTcan);

                ItemPanelTcan.Click += ItemPanelTcan_Click;
                ItemPanelTcan.pbPhotoTcan.Click += Object_Click;
                ItemPanelTcan.lColor.Click += Object_Click;
                ItemPanelTcan.lDesc.Click+=Object_Click;
                ItemPanelTcan.lHeigth.Click+=Object_Click;
                ItemPanelTcan.lWidth.Click+=Object_Click;
                ItemPanelTcan.lName.Click+=Object_Click;

                if(pTcan.Controls.Count == 1)
                {
                    CurrentItemTcan = ItemPanelTcan;
                    CurrentItemTcan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                }
            }

            pFur.Controls.Clear();

            foreach (Furn furn in LstFurn)
            {
                ItemPanelFur ItemPanelf = new ItemPanelFur();
                ItemPanelf.lNazvFur.Text = furn.Name;
                ItemPanelf.lCntFur.Text = furn.Cnt;
                ItemPanelf.IDFur = furn.ID;
                

                try
                {
                    ItemPanelf.pbFur.Image = furn.PhotoFur;
                }
                catch
                {

                }
                pFur.Controls.Add(ItemPanelf);

                ItemPanelf.Click += itemFur;
                ItemPanelf.pbFur.Click += ObjectFur;
                ItemPanelf.lCntFur.Click += ObjectFur;
                ItemPanelf.lNazvFur.Click += ObjectFur;


                if (pFur.Controls.Count == 1)
                {
                    CurrentItemFur = ItemPanelf;
                    CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                }
            }

        }
        #endregion

        private void ObjectFur(object sender, EventArgs e)
        {
            CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            CurrentItemFur = (sender as Control).Parent as ItemPanelFur;
            CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }
        
        private void itemFur(object sender, EventArgs e)
        {
            CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            CurrentItemFur = sender as ItemPanelFur;
            CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }

        private void Object_Click(object sender, EventArgs e)
        {
            CurrentItemTcan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            CurrentItemTcan = (sender as Control).Parent as ItemPanelTcan;
            CurrentItemTcan.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }

        private void ItemPanelTcan_Click(object sender, EventArgs e)
        {
            CurrentItemTcan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            CurrentItemTcan = sender as ItemPanelTcan;
            CurrentItemTcan.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }

        struct Tcan
        {
            public string Name, Color, Desk, W, H, ID;
            public Image PhotoTcan;
        }
        struct Furn
        {
            public string ID, Name, Cnt;
            public Image PhotoFur;
        }


        private void bProfil_Click(object sender, EventArgs e)
        {
            fProfil fp=new fProfil();
            fp.ShowDialog();

        }
    }
}
