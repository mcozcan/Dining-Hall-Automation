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
    public partial class Customers : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
      
        DataSet ds;
        OleDbCommand komut = new OleDbCommand();
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerNoOrders cno = new CustomerNoOrders();
            cno.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel ap2 = new AdminPanel();
            ap2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
                DataSet ds = new DataSet();
                con.Open();
                komut.Connection = con;
                //Database'den müşteriyi silme
                komut.CommandText = ("DELETE *from user_table WHERE kullanici_adi like '" + textBox11.Text + "'");
                
                komut.ExecuteNonQuery();
                komut.Dispose();
                con.Close();
                ds.Clear();
            }
    }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            da = new OleDbDataAdapter("SElect *from user_table'", con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds, "user_table");
            dataGridView1.DataSource = ds.Tables["user_table"];
            con.Close();
        }
    }
}
