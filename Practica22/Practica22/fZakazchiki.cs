using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Image = System.Drawing.Image;
using System.Diagnostics;

namespace Practica22
{
    public partial class fZakazchiki : Form
    {
        public fZakazchiki()
        {
            InitializeComponent();
        }


        class ItemPanelFr : Panel
        {

            public System.Windows.Forms.Panel pf;
            public System.Windows.Forms.Label lCntFur;
            public System.Windows.Forms.Label lNazvFur;
            public System.Windows.Forms.PictureBox pbFur;
            public string IDFur;
            public bool isSelected;
            public ItemPanelFr()
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

        class ItemPanelHis1 : Panel
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
            public string IDI, IDT, IDF;

            public ItemPanelHis1()
            {
                this.pZ = new System.Windows.Forms.Panel();
                this.PbF = new System.Windows.Forms.PictureBox();
                this.PbT = new System.Windows.Forms.PictureBox();
                this.lZ = new System.Windows.Forms.Label();
                this.lM = new System.Windows.Forms.Label();
                this.lT = new System.Windows.Forms.Label();
                this.lF = new System.Windows.Forms.Label();
                this.lI = new System.Windows.Forms.Label();
                this.lCntIzd = new System.Windows.Forms.Label();
                this.lCntF = new System.Windows.Forms.Label();

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
            public bool isSelected;
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

        public static int EditDistance(string s, string t)
        {
            int m = s.Length, n = t.Length;
            int[,] ed = new int[m, n];

            for (int i = 0; i < m; ++i)
            {
                ed[i, 0] = i + 1;
            }

            for (int j = 0; j < n; ++j)
            {
                ed[0, j] = j + 1;
            }

            for (int j = 1; j < n; ++j)
            {
                for (int i = 1; i < m; ++i)
                {
                    if (s[i] == t[j])
                    {
                        // Операция не требуется
                        ed[i, j] = ed[i - 1, j - 1];
                    }
                    else
                    {
                        // Минимум между удалением, вставкой и заменой
                        ed[i, j] = Math.Min(ed[i - 1, j] + 1,
                            Math.Min(ed[i, j - 1] + 1, ed[i - 1, j - 1] + 1));
                    }
                }
            }

            return ed[m - 1, n - 1];
        }

        private void fZakazchiki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet.Tcan". При необходимости она может быть перемещена или удалена.
            this.tcanTableAdapter.Fill(this.fabricaDataSet.Tcan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet.Furnitura". При необходимости она может быть перемещена или удалена.
            this.furnituraTableAdapter.Fill(this.fabricaDataSet.Furnitura);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet.Izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter.Fill(this.fabricaDataSet.Izdelie);
            fAutoriz fa = new fAutoriz();
            fa.Close();
            ManagerExport();
            if (fAutoriz.ばかじゃない.Role != "2")
            {
                bCsv.Visible = false;
                bAddIzd.Visible = false;
                bWord.Visible = false;
                izdelieDataGridView.CellContentDoubleClick -= izdelieDataGridView_CellContentDoubleClick;
                if (fAutoriz.ばかじゃない.Role == "1")
                    GetDateHisFromDB();
                if (fAutoriz.ばかじゃない.Role == "3")
                {
                    tcZak.Controls.Remove(tpNewZakaz);
                    GetDateHisFromDBKlad();
                }
                if (fAutoriz.ばかじゃない.Role != "3")
                {
                    bAddFT.Visible = false;
                    bAddIzd.Visible = false;
                }

            }
            else
            {
                tcZak.Controls.RemoveAt(1);
                GetDateHisFromDBMan();
            }
            try
            {
                GetDateFurnFromDB();
                GetDateTcanFromDB();
                GetDateIzdFromDB();

                FillPanel();
            }
            catch
            { }

            lZag.Text = fAutoriz.ばかじゃない.FIO;

            fAutoriz.SqlConn($@"select * from Furnitura", true);
            while (fAutoriz.rd.Read())
            {
                newzak nz = new newzak();
                nz.ID = fAutoriz.rd["idfur"].ToString();
                nz.Name = fAutoriz.rd["namefur"].ToString();
                LstZak.Add(nz);
                namefurComboBox.Items.Add(nz.Name);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();

            fAutoriz.SqlConn($@"select * from Tcan", true);
            while (fAutoriz.rd.Read())
            {
                newzak nz = new newzak();
                nz.ID = fAutoriz.rd["IDTcan"].ToString();
                nz.Name = fAutoriz.rd["NameTcan"].ToString();
                LstZak1.Add(nz);
                nameTcanComboBox.Items.Add(nz.Name);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();

            fAutoriz.SqlConn($@"select * from Izdelie", true);
            while (fAutoriz.rd.Read())
            {
                newzak nz = new newzak();
                nz.ID = fAutoriz.rd["IDIzd"].ToString();
                nz.Name = fAutoriz.rd["NameIzd"].ToString();
                LstZak2.Add(nz);
                nameIzdComboBox.Items.Add(nz.Name);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();

        }

        void ChanPhoto()
        {
            fAutoriz.SqlConn($@"select Furnitura.photo as 'f',Tcan.photo as 't' from Furnitura,Tcan where Furnitura.namefur='{namefurComboBox.SelectedText}' and Tcan.NameTcan='{nameTcanComboBox.SelectedText}'", true);

            byte[] ByteImage = (byte[])fAutoriz.rd["f"];
            pbFur.Image = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
            ByteImage = (byte[])fAutoriz.rd["t"];
            pbTcan.Image = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }

        List<Tcan> LstTcan = new List<Tcan>();
        List<Furn> LstFurn = new List<Furn>();

        // List<Furn> LstFurnSel = new List<Furn>();

        List<His> LstHis = new List<His>();

        List<His> LstHisM = new List<His>();

        List<int> LstIzd = new List<int>();
        List<newzak> LstZak = new List<newzak>();
        List<newzak> LstZak1 = new List<newzak>();
        List<newzak> LstZak2 = new List<newzak>();
        ItemPanelTcan CurrentItemTcan;
        ItemPanelFr CurrentItemFur;
        ItemPanelHis1 CurrentItemHis;
       
        #region GetDB

        void GetDateIzdFromDB()
        {
            fAutoriz.SqlConn(@"select IDIzd from Izdelie", true);
            LstIzd.Clear();
            while (fAutoriz.rd.Read())
            {
                LstIzd.Add(int.Parse(fAutoriz.rd["IDIzd"].ToString()));
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }

        void GetDateFurnFromDB()
        {
            fAutoriz.SqlConn(@"select * from furnitura", true);
            LstFurn.Clear();
            while (fAutoriz.rd.Read())
            {
                Furn furn = new Furn();
                furn.Name = "Название: " + fAutoriz.rd["namefur"].ToString();
                furn.ID = fAutoriz.rd["idfur"].ToString();
                furn.Cnt = fAutoriz.rd["countfur"].ToString();
                byte[] ByteImage = (byte[])fAutoriz.rd["photo"];
                furn.PhotoFur = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                LstFurn.Add(furn);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }

        void GetDateHisFromDB()
        {
            fAutoriz.SqlConn($@"select (select fam+' '+Name+' '+Otch from Users where IDUser=z.IDZacazchik) as 'zakazchik'
      ,(select fam+' '+Name+' '+Otch from Users where IDUser=z.IDManager) as 'manager'
	  ,f.countfur as 'cntf' ,f.namefur as 'namef' ,f.photo as 'pf',f.idfur as 'idf'
	  ,i.NameIzd as 'namei' ,i.Length as 'cnti',i.IDIzd as 'idi'
	  ,t.Photo as 'pt' ,t.NameTcan as 'namet',t.IDTcan as 'idt'

from Furnitura f
    ,Izdelie i
	,Tcan t
	,Zakazi z

where z.IDIzd=i.IDIzd 
  and z.IDFurn=f.idfur
  and z.IDTkan=t.IDTcan
  and z.IDZacazchik={fAutoriz.ばかじゃない.ばか}", true);
            LstHis.Clear();
            while (fAutoriz.rd.Read())
            {
                His his = new His();
                his.NameT = fAutoriz.rd["namet"].ToString();
                his.IDT = fAutoriz.rd["idt"].ToString();
                byte[] ByteImage = (byte[])fAutoriz.rd["pt"];
                his.PhotoT = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                ByteImage = (byte[])fAutoriz.rd["pf"];
                his.PhotoF = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                his.CntF = fAutoriz.rd["cntf"].ToString();
                his.CntI = fAutoriz.rd["cnti"].ToString();
                his.NameFm = fAutoriz.rd["namef"].ToString();
                his.NameI = fAutoriz.rd["namei"].ToString();
                his.IDF = fAutoriz.rd["idf"].ToString();
                his.IDI = fAutoriz.rd["idi"].ToString();
                his.Man = fAutoriz.rd["manager"].ToString();
                his.Zak = fAutoriz.rd["zakazchik"].ToString();

                LstHis.Add(his);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }

        void GetDateHisFromDBKlad()
        {
            fAutoriz.SqlConn($@"select (select fam+' '+Name+' '+Otch from Users where IDUser=z.IDZacazchik) as 'zakazchik'
      ,(select fam+' '+Name+' '+Otch from Users where IDUser=z.IDManager) as 'manager'
	  ,f.countfur as 'cntf' ,f.namefur as 'namef' ,f.photo as 'pf',f.idfur as 'idf'
	  ,i.NameIzd as 'namei' ,i.Length as 'cnti',i.IDIzd as 'idi'
	  ,t.Photo as 'pt' ,t.NameTcan as 'namet',t.IDTcan as 'idt'

from Furnitura f
    ,Izdelie i
	,Tcan t
	,Zakazi z

where z.IDIzd=i.IDIzd 
  and z.IDFurn=f.idfur
  and z.IDTkan=t.IDTcan", true);
            LstHis.Clear();
            while (fAutoriz.rd.Read())
            {
                His his = new His();
                his.NameT = fAutoriz.rd["namet"].ToString();
                his.IDT = fAutoriz.rd["idt"].ToString();
                byte[] ByteImage = (byte[])fAutoriz.rd["pt"];
                his.PhotoT = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                ByteImage = (byte[])fAutoriz.rd["pf"];
                his.PhotoF = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                his.CntF = fAutoriz.rd["cntf"].ToString();
                his.CntI = fAutoriz.rd["cnti"].ToString();
                his.NameFm = fAutoriz.rd["namef"].ToString();
                his.NameI = fAutoriz.rd["namei"].ToString();
                his.IDF = fAutoriz.rd["idf"].ToString();
                his.IDI = fAutoriz.rd["idi"].ToString();
                his.Man = fAutoriz.rd["manager"].ToString();
                his.Zak = fAutoriz.rd["zakazchik"].ToString();

                LstHis.Add(his);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }

        void GetDateHisFromDBMan()
        {
            fAutoriz.SqlConn($@"select (select fam+' '+Name+' '+Otch from Users where IDUser=z.IDZacazchik) as 'zakazchik'
      ,(select fam+' '+Name+' '+Otch from Users where IDUser=z.IDManager) as 'manager'
	  ,f.countfur as 'cntf' ,f.namefur as 'namef' ,f.photo as 'pf',f.idfur as 'idf'
	  ,i.NameIzd as 'namei' ,i.Length as 'cnti',i.IDIzd as 'idi'
	  ,t.Photo as 'pt' ,t.NameTcan as 'namet',t.IDTcan as 'idt'

from Furnitura f
    ,Izdelie i
	,Tcan t
	,Zakazi z

where z.IDIzd=i.IDIzd 
  and z.IDFurn=f.idfur
  and z.IDTkan=t.IDTcan
  and z.IDManager={fAutoriz.ばかじゃない.ばか}", true);
            LstHis.Clear();
            while (fAutoriz.rd.Read())
            {
                His his = new His();
                his.NameT = fAutoriz.rd["namet"].ToString();
                his.IDT = fAutoriz.rd["idt"].ToString();
                byte[] ByteImage = (byte[])fAutoriz.rd["pt"];
                his.PhotoT = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                ByteImage = (byte[])fAutoriz.rd["pf"];
                his.PhotoF = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                his.CntF = fAutoriz.rd["cntf"].ToString();
                his.CntI = fAutoriz.rd["cnti"].ToString();
                his.NameFm = fAutoriz.rd["namef"].ToString();
                his.NameI = fAutoriz.rd["namei"].ToString();
                his.IDF = fAutoriz.rd["idf"].ToString();
                his.IDI = fAutoriz.rd["idi"].ToString();
                his.Man = fAutoriz.rd["manager"].ToString();
                his.Zak = fAutoriz.rd["zakazchik"].ToString();

                LstHis.Add(his);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }

        void GetDateTcanFromDB()
        {
            fAutoriz.SqlConn(@"select Whidth,IDTcan,Length,Photo,NameTcan,NameColor,Primech from Tcan,Color where Tcan.IDColor=Color.IDColor", true);
            LstTcan.Clear();
            while (fAutoriz.rd.Read())
            {
                Tcan tcan = new Tcan();
                tcan.Name = "Название: " + fAutoriz.rd["NameTcan"].ToString();
                tcan.Color = "Цвет: " + fAutoriz.rd["NameColor"].ToString();
                tcan.Desk = "Описание: " + fAutoriz.rd["Primech"].ToString();
                tcan.W = "Ширина: " + fAutoriz.rd["Whidth"].ToString();
                tcan.H = "Высота: " + fAutoriz.rd["Length"].ToString();
                tcan.ID = fAutoriz.rd["IDTcan"].ToString();
                byte[] ByteImage = (byte[])fAutoriz.rd["Photo"];
                tcan.PhotoTcan = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                LstTcan.Add(tcan);
            }
            fAutoriz.rd.Close();
            fAutoriz.con.Close();
        }
        #endregion

        #region FillPanel

        void livins()
        {
            pTcan.Controls.Clear();

            foreach (Tcan tcan in LstTcan)
            {
                if (tbFindTcan.Text.Trim() == "")
                {
                    ItemPanelTcan ItemPanelTcan = new ItemPanelTcan();
                    ItemPanelTcan.lColor.Text = tcan.Color;
                    ItemPanelTcan.lDesc.Text = tcan.Desk;
                    ItemPanelTcan.lHeigth.Text = tcan.H;
                    ItemPanelTcan.lWidth.Text = tcan.W;
                    ItemPanelTcan.lName.Text = tcan.Name;
                    ItemPanelTcan.IDTcan = tcan.ID;

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
                    ItemPanelTcan.lDesc.Click += Object_Click;
                    ItemPanelTcan.lHeigth.Click += Object_Click;
                    ItemPanelTcan.lWidth.Click += Object_Click;
                    ItemPanelTcan.lName.Click += Object_Click;

                    if (pTcan.Controls.Count == 1)
                    {
                        CurrentItemTcan = ItemPanelTcan;
                        CurrentItemTcan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                    }
                }
                else
                {
                    if (EditDistance(tbFindTcan.Text.Trim(), tcan.Name.Split(' ')[1]) <= 3)
                    {
                        ItemPanelTcan ItemPanelTcan = new ItemPanelTcan();
                        ItemPanelTcan.lColor.Text = tcan.Color;
                        ItemPanelTcan.lDesc.Text = tcan.Desk;
                        ItemPanelTcan.lHeigth.Text = tcan.H;
                        ItemPanelTcan.lWidth.Text = tcan.W;
                        ItemPanelTcan.lName.Text = tcan.Name;
                        ItemPanelTcan.IDTcan = tcan.ID;

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
                        ItemPanelTcan.lDesc.Click += Object_Click;
                        ItemPanelTcan.lHeigth.Click += Object_Click;
                        ItemPanelTcan.lWidth.Click += Object_Click;
                        ItemPanelTcan.lName.Click += Object_Click;

                        if (pTcan.Controls.Count == 1)
                        {
                            CurrentItemTcan = ItemPanelTcan;
                            CurrentItemTcan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                        }
                    }
                }
            }
        }
        
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
                    ItemPanelTcan.IDTcan = tcan.ID;

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
                    ItemPanelTcan.lDesc.Click += Object_Click;
                    ItemPanelTcan.lHeigth.Click += Object_Click;
                    ItemPanelTcan.lWidth.Click += Object_Click;
                    ItemPanelTcan.lName.Click += Object_Click;

                    if (pTcan.Controls.Count == 1)
                    {
                        CurrentItemTcan = ItemPanelTcan;
                        CurrentItemTcan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                    }
                }

            pFurn.Controls.Clear();

            foreach (Furn furn in LstFurn)
            {
                ItemPanelFr ItemPanelf = new ItemPanelFr();
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
                pFurn.Controls.Add(ItemPanelf);

                ItemPanelf.Click += itemFur;
                ItemPanelf.pbFur.Click += ObjectFur;
                ItemPanelf.lCntFur.Click += ObjectFur;
                ItemPanelf.lNazvFur.Click += ObjectFur;


                if (pFurn.Controls.Count == 1)
                {
                    CurrentItemFur = ItemPanelf;
                    CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                }
            }

            pHistoryZ.Controls.Clear();

            foreach (His his in LstHis)
            {
                ItemPanelHis1 ItemPanelh = new ItemPanelHis1();
                ItemPanelh.lCntF.Text = his.CntF;
                ItemPanelh.lCntIzd.Text = his.CntI;
                ItemPanelh.lF.Text = his.NameFm;
                ItemPanelh.lI.Text = his.NameI;
                ItemPanelh.lT.Text = his.NameT;
                ItemPanelh.lM.Text = his.Man;
                ItemPanelh.lZ.Text = his.Zak;
                ItemPanelh.IDT = his.IDT;
                ItemPanelh.IDF = his.IDF;
                ItemPanelh.IDI = his.IDI;
                try
                {
                    ItemPanelh.PbF.Image = his.PhotoF;
                    ItemPanelh.PbT.Image = his.PhotoT;
                }
                catch { }

                pHistoryZ.Controls.Add(ItemPanelh);

                ItemPanelh.Click += ItemPanelh_Click;
                ItemPanelh.lT.Click += objecth_Click;
                ItemPanelh.lI.Click += objecth_Click;
                ItemPanelh.lCntF.Click += objecth_Click;
                ItemPanelh.lCntIzd.Click += objecth_Click;
                ItemPanelh.lM.Click += objecth_Click;
                ItemPanelh.lZ.Click += objecth_Click;
                ItemPanelh.PbF.Click += objecth_Click;
                ItemPanelh.PbT.Click += objecth_Click;
                ItemPanelh.lF.Click += objecth_Click;


                if (pHistoryZ.Controls.Count == 1)
                {
                    CurrentItemHis = ItemPanelh;
                    CurrentItemHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                }
            }
        }

        #endregion


        private void objecth_Click(object sender, EventArgs e)
        {
            CurrentItemHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            CurrentItemHis = (sender as Control).Parent as ItemPanelHis1;
            CurrentItemHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }

        private void ItemPanelh_Click(object sender, EventArgs e)
        {
            CurrentItemHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            CurrentItemHis = sender as ItemPanelHis1;
            CurrentItemHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }
        

        private void ObjectFur(object sender, EventArgs e)
        {
            CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            CurrentItemFur = (sender as Control).Parent as ItemPanelFr;
            CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }
        
        private void itemFur(object sender, EventArgs e)
        {
            CurrentItemFur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            CurrentItemFur = sender as ItemPanelFr;
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

        struct His
        {
            public string Man, Zak, CntF, CntI, NameT, NameFm, NameI,IDT,IDF,IDI;
            public Image PhotoT,PhotoF;
        }

        struct newzak
        {
            public string ID;
            public string Name;
        }


        private void bProfil_Click(object sender, EventArgs e)
        {
            fProfil fp=new fProfil();
            fp.ShowDialog();

        }

        private void bAddIzd_Click(object sender, EventArgs e)
        {
            fManager fm = new fManager();
            fm.ShowDialog();
        }
        public static int row=-1;

        public void izdelieDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row=LstIzd[e.RowIndex]-1;
            KladMen km=new KladMen();
            km.ShowDialog();
        }

        private void bNewZak_Click(object sender, EventArgs e)
        {
            if(tbCntFur.Text!=""&&tbCntIzd.Text!="")
            fAutoriz.SqlConn($@"insert into Zakazi values({LstZak2[nameIzdComboBox.SelectedIndex]},{fAutoriz.ばかじゃない.ばか},(select top 1 Fam, Name,Otch from Users group by Role,Fam,Name,Otch having Role=2 order by count(*) ),{LstZak1[nameTcanComboBox.SelectedIndex]},{LstZak[namefurComboBox.SelectedIndex]},{tbCntFur},{tbCntIzd})", false);
            MessageBox.Show("Заказ добавлен");
            GetDateHisFromDB();
        }

        private void tbFindTcan_TextChanged(object sender, EventArgs e)
        {
            livins();
        }

        private void namefurComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChanPhoto();
        }

        private void nameTcanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChanPhoto();
        }

        private void bCsv_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(ofd.FileName, false, Encoding.Unicode);
                ManagerExport();

                foreach (His item in LstHisM)
                {
                    sw.WriteLine($"{item.NameI};{item.Zak};{item.Man};{item.NameT};{item.NameFm};{item.CntF};{item.CntI}");
                }
                sw.Close();
                MessageBox.Show(@"Успешно сохранено ");
            }
        }

        private void ManagerExport()
        {
            fAutoriz.SqlConn($@"select (select fam+' '+Name+' '+Otch from Users where IDUser=z.IDZacazchik) as 'zakazchik'
      ,(select fam+' '+Name+' '+Otch from Users where IDUser=z.IDManager) as 'manager'
	  ,f.countfur as 'cntf' ,f.namefur as 'namef' ,f.photo as 'pf',f.idfur as 'idf'
	  ,i.NameIzd as 'namei' ,i.Length as 'cnti',i.IDIzd as 'idi'
	  ,t.Photo as 'pt' ,t.NameTcan as 'namet',t.IDTcan as 'idt'

from Furnitura f
    ,Izdelie i
	,Tcan t
	,Zakazi z

where z.IDIzd=i.IDIzd 
  and z.IDFurn=f.idfur
  and z.IDTkan=t.IDTcan
  and z.IDManager={fAutoriz.ばかじゃない.ばか}", true);
            LstHis.Clear();
            while (fAutoriz.rd.Read())
            {
                His his = new His();
                his.NameT = fAutoriz.rd["namet"].ToString();
                his.IDT = fAutoriz.rd["idt"].ToString();
                byte[] ByteImage = (byte[])fAutoriz.rd["pt"];
                his.PhotoT = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                ByteImage = (byte[])fAutoriz.rd["pf"];
                his.PhotoF = (Bitmap)(new ImageConverter().ConvertFrom(ByteImage));
                his.CntF = fAutoriz.rd["cntf"].ToString();
                his.CntI = fAutoriz.rd["cnti"].ToString();
                his.NameFm = fAutoriz.rd["namef"].ToString();
                his.NameI = fAutoriz.rd["namei"].ToString();
                his.IDF = fAutoriz.rd["idf"].ToString();
                his.IDI = fAutoriz.rd["idi"].ToString();
                his.Man = fAutoriz.rd["manager"].ToString();
                his.Zak = fAutoriz.rd["zakazchik"].ToString();


                LstHisM.Add(his);
            }
        }

        private void bWord_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DocX dox = DocX.Create(fbd.SelectedPath + @"\Заказы.docx");
                dox.InsertParagraph($"{LstHisM[0].Man}");
                dox.InsertParagraph("");
                dox.InsertParagraph("Список заказов:");

                var table = dox.AddTable(LstHisM.Count + 1, 6);
                table.Alignment = Alignment.center;
                table.Design = TableDesign.TableGrid;

                table.Rows[0].Cells[0].Paragraphs.First().Append("Изделие");
                table.Rows[0].Cells[1].Paragraphs.First().Append("Кол-во изделий");
                table.Rows[0].Cells[2].Paragraphs.First().Append("Ткань");
                table.Rows[0].Cells[3].Paragraphs.First().Append("Фурнитура");
                table.Rows[0].Cells[4].Paragraphs.First().Append("Кол-во фурнитуры");
                table.Rows[0].Cells[5].Paragraphs.First().Append("Заказчик");

                for (int i = 1; i < table.RowCount; i++)
                {
                    table.Rows[0].Cells[0].Paragraphs.First().Append(LstHisM[i - 1].NameI);
                    table.Rows[0].Cells[0].Paragraphs.First().Append(LstHisM[i - 1].CntI.ToString());
                    table.Rows[0].Cells[0].Paragraphs.First().Append(LstHisM[i - 1].NameT.Split()[1]);
                    table.Rows[0].Cells[0].Paragraphs.First().Append(LstHisM[i - 1].NameFm);
                    table.Rows[0].Cells[0].Paragraphs.First().Append(LstHisM[i - 1].CntF.ToString());
                    table.Rows[0].Cells[0].Paragraphs.First().Append(LstHisM[i - 1].Zak);
                }

                table.AutoFit = AutoFit.Window;

                dox.InsertTable(table);
                dox.Save();
                Process.Start("winword.exe", fbd.SelectedPath + @"\Заказы.docx");
            }
        }

        private void bSpFT_Click(object sender, EventArgs e)
        {

            foreach (Furn f in LstFurn)
            {
                if (CurrentItemFur.isSelected)
                {

                    fAutoriz.SqlConn($@"delete from Furnitura where idfur ={f.ID}", false);
                }
            }


        }

        private void bAddFT_Click(object sender, EventArgs e)
        {
            fSpis fs = new fSpis();
            fs.ShowDialog();
        }

        private void bSPT_Click(object sender, EventArgs e)
        {
            foreach (Tcan t in LstTcan)
            {
                if (CurrentItemTcan.isSelected)
                {
                    
                    fAutoriz.SqlConn($@"delete from Tcan where IDTcan ={t.ID}", false);
                }
            }
        }
    }
}
