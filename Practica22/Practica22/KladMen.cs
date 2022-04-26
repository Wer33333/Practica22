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
    public partial class KladMen : Form
    {
        public KladMen()
        {
            InitializeComponent();
        }

        private void bProfil_Click(object sender, EventArgs e)
        {
            fProfil fp = new fProfil();
            fp.ShowDialog();
        }

        private void KladMen_Load(object sender, EventArgs e)
        {
            lZag.Text = fAutoriz.ばかじゃない.FIO;
        }
    }
}
