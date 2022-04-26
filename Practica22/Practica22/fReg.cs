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

        public void btnReg_Click(object sender, EventArgs e)
        {
            if(tbFam.Text ==""|| tbName.Text == ""|| tbLogin.Text == ""|| tbPass.Text == ""|| tbPass2.Text == ""|| tbOtch.Text == ""|| mtbTel.Text.Contains('_'))
            {
                MessageBox.Show("くそ, Не все поля заполнены");
                return;
            }
            


                fAutoriz.SqlConn($"select Login from Users where Login='{tbLogin.Text}'", true);
                if (fAutoriz.rd.HasRows)
                {
                    MessageBox.Show("Данный логин занят");
                    return;
                }
                fAutoriz.con.Close();
                fAutoriz.rd.Close();

                bool s = Pasword.Check(tbPass.Text);
                bool s1 = tbPass.Text == tbPass2.Text;

                if (s && s1)
                {
                    fAutoriz.SqlConn($"insert into Users(Login,Passw,Role,Fam,Name,Otch,Tel) values('{tbLogin.Text.Trim()}','{tbPass.Text.Trim()}',1,'{tbFam.Text}','{tbName.Text}','{tbOtch.Text}','{mtbTel.Text}')", false);

                    fAutoriz fa = new fAutoriz();
                    fa.tbLogin.Text = tbLogin.Text;
                    fa.tbPass.Text = tbPass.Text;
                    fReg fr = new fReg();
                    fr.Close();
                    fr.Dispose();
                }
                else return;
            
        }

     
    }
}
