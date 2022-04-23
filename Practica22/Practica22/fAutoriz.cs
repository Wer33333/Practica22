using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica22
{
    public partial class fAutoriz : Form
    {

        public class ばかじゃない
        {
            public static string ばか;
            public static string ConString = @"Data Source=213.155.192.79,3002;Initial Catalog=Fabrica;Persist Security Info=True;User ID=u20lebed;Password=RT3E";
            public static string Role;
        }
        
        public fAutoriz()
        {
            InitializeComponent();
        }
        public static SqlDataReader rd;
        public static SqlConnection con;
        private void llReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fReg fr=new fReg();
            fr.ShowDialog();
        }
        
        private string Capcha = String.Empty;

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

        
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };


            Graphics g = Graphics.FromImage((Image)result);

            g.Clear(Color.Gray);

            Capcha = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                Capcha += ALF[rnd.Next(ALF.Length)];


            g.DrawString(Capcha,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));


            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }


        public static void SqlConn(string Zapr, bool type)
        {
             con = new SqlConnection(fAutoriz.ばかじゃない.ConString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(Zapr, con);
            if(type==false)
            {
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                rd= sqlCommand.ExecuteReader();
                rd.Read();
            }
        }

        private void BtnAutor_Click(object sender, EventArgs e)
        {
            if (tbCapcha.Text != this.Capcha)
            {
                tbCapcha.Text = "";
                lCapcha.Image = this.CreateImage(133, 67);
                return;
            }

            SqlConn($@"select Login,Passw,Role from Users where Login='{tbLogin.Text}' and Passw='{tbPass.Text}'", true);
            if (!rd.HasRows)
                MessageBox.Show("Неверный логин или пароль!");
            ばかじゃない.Role = rd["Role"].ToString();
            con.Close();

            if (ばかじゃない.Role == "1")
            {
                this.Hide();
                fZakazchiki fz = new fZakazchiki();
                fz.Show();
            }

        }

        private void pbUpC_Click(object sender, EventArgs e)
        {
            lCapcha.Image = this.CreateImage(133, 67);
        }

        private void fAutoriz_Load(object sender, EventArgs e)
        {
            lCapcha.Image = this.CreateImage(133, 67);
        }
    }
}
