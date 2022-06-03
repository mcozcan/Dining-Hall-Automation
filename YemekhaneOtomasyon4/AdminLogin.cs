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
    public partial class AdminLogin : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public AdminLogin()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM admin_table WHERE kullaniciadi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
   
            if (dr.Read())
            {
                AdminPanel ap = new AdminPanel();
                ap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış ya da boş bırakılamaz");
                textBox1.Clear();
                
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            //müzik başlatma ve anlık zaman değerlerini ekrana yazdırma
            player.Stop();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //saatin anlık günceleme için timer eklenmesi

            label5.Text = DateTime.Now.ToShortTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
        }

      
    }
}
