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



        private void KladMen_Load(object sender, EventArgs e)
        {
            fAutoriz.SqlConn($@"select NameIzd,Whidth,Length from Izdelie where IDIzd={fZakazchiki.row}", true);
            tbW.Text= fAutoriz.rd["Length"].ToString();
            tbH.Text = fAutoriz.rd["Whidth"].ToString();
            tbNaz.Text = fAutoriz.rd["NameIzd"].ToString();
        }

        private void bSaveIzd_Click(object sender, EventArgs e)
        { 
            fAutoriz.SqlConn($@"update Izdelie set NameIzd='{tbNaz.Text}',Length={tbH.Text},Whidth={tbW.Text} where IDIzd={fZakazchiki.row}", false);
            this.Close();
        }
    }
}
