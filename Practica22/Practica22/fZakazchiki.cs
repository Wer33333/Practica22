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

        private void fZakazchiki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet.Zakazi". При необходимости она может быть перемещена или удалена.
            this.zakaziTableAdapter.Fill(this.fabricaDataSet.Zakazi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet.Tcan". При необходимости она может быть перемещена или удалена.
            this.tcanTableAdapter.Fill(this.fabricaDataSet.Tcan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet.Izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter.Fill(this.fabricaDataSet.Izdelie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet.Furnitura". При необходимости она может быть перемещена или удалена.
            this.furnituraTableAdapter.Fill(this.fabricaDataSet.Furnitura);
            lZag.Text = fAutoriz.ばかじゃない.FIO;
        }

        private void bProfil_Click(object sender, EventArgs e)
        {
            fProfil fp=new fProfil();
            fp.ShowDialog();

        }
    }
}
