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

        class ItemPanel : Panel
        {
            #region 千引く七
            public System.Windows.Forms.Panel PanelMain;
            public System.Windows.Forms.Label lHeigth;
            public System.Windows.Forms.Label lWidth;
            public System.Windows.Forms.Label lDesc;
            public System.Windows.Forms.Label lColor;
            public System.Windows.Forms.Label lName;
            public System.Windows.Forms.PictureBox pbPhotoTcan;
            public string ID;
            #endregion
            public ItemPanel()
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
            FillPanel();
            lZag.Text = fAutoriz.ばかじゃない.FIO;
        }

        List<Tcan> LstTcan=new List<Tcan>();
        ItemPanel CurrentItem;

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

        void FillPanel()
        {
            pTcan.Controls.Clear();

            foreach (Tcan tcan in LstTcan)
            {
                ItemPanel itempanel = new ItemPanel();
                itempanel.lColor.Text = tcan.Color;
                itempanel.lDesc.Text = tcan.Desk;
                itempanel.lHeigth.Text = tcan.H;
                itempanel.lWidth.Text = tcan.W;
                itempanel.lName.Text = tcan.Name;
                itempanel.ID= tcan.ID;

                try
                {
                    itempanel.pbPhotoTcan.Image = tcan.PhotoTcan;
                }
                catch
                {

                }
                pTcan.Controls.Add(itempanel);

                itempanel.Click += Itempanel_Click;
                itempanel.pbPhotoTcan.Click += Object_Click;
                itempanel.lColor.Click += Object_Click;
                itempanel.lDesc.Click+=Object_Click;
                itempanel.lHeigth.Click+=Object_Click;
                itempanel.lWidth.Click+=Object_Click;
                itempanel.lName.Click+=Object_Click;

                if(pTcan.Controls.Count == 1)
                {
                    CurrentItem = itempanel;
                    CurrentItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                }
            }

        }


        private void Object_Click(object sender, EventArgs e)
        {
            CurrentItem.BackColor = Color.White;
            CurrentItem = (sender as Control).Parent as ItemPanel;
            CurrentItem.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }

        private void Itempanel_Click(object sender, EventArgs e)
        {
            CurrentItem.BackColor = Color.White;
            CurrentItem = sender as ItemPanel;
            CurrentItem.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }

        struct Tcan
        {
            public string Name, Color, Desk, W, H, ID;
            public Image PhotoTcan;
        }


        private void bProfil_Click(object sender, EventArgs e)
        {
            fProfil fp=new fProfil();
            fp.ShowDialog();

        }
    }
}
