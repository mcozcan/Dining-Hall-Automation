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
    public partial class CustomerNoOrders : Form
    {

        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public CustomerNoOrders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //access girilen veri ile tablodan veri çekme
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            da = new OleDbDataAdapter("SELECT *from user_table where kullanici_adi like '" + textBox1.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "user_table");
            dataGridView1.DataSource = ds.Tables["user_table"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers ap2 = new Customers();
            ap2.Show();
            this.Hide();
        }

        private void CustomerNoOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
