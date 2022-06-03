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
    public partial class AddCustomer : Form
    {
        //Access bağlantı ve atamalar
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=yemekhane.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
            public AddCustomer()
            {
                InitializeComponent();
            }

   

        private void button1_Click(object sender, EventArgs e)
        {
        if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
             {
                //Access kullanıcı verilerini tabloya yazdırma
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into user_table(kullanici_adi,sifre,sirket_adi,adres,telefon) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Yeni Müşteri Başarıyla Eklendi");
                ds.Clear();

             }
         else
             {
                MessageBox.Show("Boş alanları doldurunuz");
             }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Geri tuşu ataması
            AdminPanel ap2 = new AdminPanel();
            ap2.Show();
            this.Hide();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
