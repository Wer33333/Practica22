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
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }

        private void bSaveIzd_Click(object sender, EventArgs e)
        {
            if (tbH.Text != "" && tbNaz.Text != "" && tbW.Text != "")
            {
                foreach (char item in tbH.Text)
                {
                    if (char.IsDigit(item) == false)
                    {
                        MessageBox.Show("Без лишних символов");
                        return;
                    }
                }

                foreach (char item in tbW.Text)
                {
                    if (char.IsDigit(item) == false)
                    {
                        MessageBox.Show("Без лишних символов");
                        return;
                    }
                }

                fAutoriz.SqlConn($@"insert into Izdelie(NameIzd,Length,Whidth) values('{tbNaz.Text}',{tbH.Text},{tbW.Text})", false);
                this.Close();
            }
            MessageBox.Show("Заполните все поля");
        }
    }
}
