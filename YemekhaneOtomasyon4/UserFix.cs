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
    public partial class UserFix : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=yemekhane.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public UserFix()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }



        private void UserFix_Load(object sender, EventArgs e)
        {
            string c = GlobalClass.KullaniciAdi;
            textBox3.Text = c;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandText = "Insert Into iptal_table(siparis_id,musteri_kadi,iptal_nedeni,tarih) Values ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "')";
            baglanti.Open();
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            MessageBox.Show("Siparişinizin iptal talebi alınmıştır işleme alınmamış ise iptali sağlanacaktır.");
        }
    }
}
