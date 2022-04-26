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
    public partial class fProfil : Form
    {
        public fProfil()
        {
            InitializeComponent();
        }
        string oldpass;
        private void fProfil_Load(object sender, EventArgs e)
        {
            fAutoriz.SqlConn($"select Login,Passw,Fam,Name,Otch,Tel from Users='{fAutoriz.ばかじゃない.ばか}'", true);
            tbFam.Text = fAutoriz.rd["Fam"].ToString();
            tbLogin.Text = fAutoriz.rd["Login"].ToString();
            oldpass = fAutoriz.rd["Passw"].ToString();
            tbName.Text = fAutoriz.rd["Name"].ToString();
            tbOtch.Text = fAutoriz.rd["Otch"].ToString();
            mtbTel.Text = fAutoriz.rd["Tel"].ToString();
        }

        private void btnSaveIzm_Click(object sender, EventArgs e)
        {
            if (tbPass.Text != oldpass)
            {
                MessageBox.Show("Введите свой старый пароль");
                return;
            }
            try
            {
                fAutoriz.SqlConn($"update Users set Login='{tbLogin.Text}', Passw='{tbPass.Text}',Fam='{tbFam.Text}',Name='{tbName.Text}',Otch='{tbOtch.Text}',Tel='{mtbTel.Text}' where IDUser={fAutoriz.ばかじゃない.ばか}", false);
            }
            catch { }
            MessageBox.Show("Успешно изменено");
        }
    }
}
