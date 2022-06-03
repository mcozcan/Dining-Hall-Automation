using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace YemekhaneOtomasyon4
{
    public partial class UserToOrder : Form
    {

        public int hesaplaTutar(int a , int b)
        {
            return a * b;
        }

        public double hesaplaIndirim(int a,int b)
        {

            return a * b * 0.05;
        }
        

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=yemekhane.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();


        public UserToOrder()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == "")
            {

                MessageBox.Show("Lütfen Fiyat Hesaplayınız");
            }

            else { 
        

            if (textBox1.Text != "" && comboBox1.Text != "" && textBox3.Text != "")
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd:MM:yyyy hh:mm:ss";
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into siparisler_table(m_isim,m_soyisim,m_tc,m_tel,alis_tarihi,yemek_zamani) Values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text+ "','" + textBox4.Text + "','" + comboBox2.Text + "')";
            
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                    MessageBox.Show("Siparişiniz alındı ödeme ekranına yönlendiriliyorsunuz");
                    ds.Clear();
                    UserAccounting ua = new UserAccounting();
                    ua.Show();
                    this.Hide();

                }


            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }




            }


        }



        public void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || comboBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");

            }

            else
            {
                if(textBox1.Text == "" || comboBox1.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
                }
                else
                {

                
            int sayi1 = Convert.ToInt32(comboBox1.Text);
            int sayi2 = Convert.ToInt32(textBox3.Text);
            if(sayi2>99)
            {

                textBox4.Text = Convert.ToString(hesaplaTutar(sayi1,sayi2)-hesaplaIndirim(sayi1,sayi2));
                textBox2.Text = Convert.ToString(hesaplaIndirim(sayi1,sayi2));
            }
                
            else
            {
                textBox4.Text = Convert.ToString(hesaplaTutar(sayi1,sayi2));
                textBox2.Text = Convert.ToString(sayi1 * sayi2 * 0);
            }
            }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuPanel mp = new MenuPanel();
            mp.Show();
           
        }


        private void UserToOrder_Load(object sender, EventArgs e)
        {
            string c = GlobalClass.KullaniciAdi;
            textBox1.Text = c;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
