using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Media;
namespace YemekhaneOtomasyon4
{
    public partial class UserLogin : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public UserLogin()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            

            string ad = textBox11.Text;
            string sifre = textBox22.Text;
            
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM user_table WHERE kullanici_adi='" + textBox11.Text + "' AND sifre='" + textBox22.Text + "'";
            dr = cmd.ExecuteReader();
           
            if (dr.Read())
            {

                GlobalClass.KullaniciAdi = ad;
                UserPanel up = new UserPanel();
                up.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış ya da boş bırakılamaz");
                textBox22.Clear();
                
            }
            
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        SoundPlayer player = new SoundPlayer();


        private void UserLogin_Load(object sender, EventArgs e)
        {
            player.Stop();
       
            timer1.Start();

          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label5.Text = DateTime.Now.ToShortTimeString();
            label6.Text = DateTime.Now.ToLongDateString();

        }


    }
}
