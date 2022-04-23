using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassCheck;

namespace Practica22
{
    public partial class fReg : Form
    {
        public fReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(tbFam.Text ==""|| tbName.Text == ""|| tbLogin.Text == ""|| tbPass.Text == ""|| tbPass2.Text == ""|| tbOtch.Text == ""|| mtbTel.Text.Contains('_'))
            {
                MessageBox.Show("くそ, Не все поля заполнены");
                return;
            }

            bool s = Pasword.Check(tbPass.Text);
            bool s1 = tbPass.Text == tbPass2.Text;

            if (s && s1)
            {
                fAutoriz.SqlConn("",false);
            }
            else return;
        }
    }
}
