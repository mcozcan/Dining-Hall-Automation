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
    public partial class UserOrder : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;



        public UserOrder()
        {
            InitializeComponent();
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            string c = GlobalClass.KullaniciAdi;

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            da = new OleDbDataAdapter("SElect *from siparisler_table where musteri_kadi like '" + c + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "siparisler_table");
            dataGridView1.DataSource = ds.Tables["siparisler_table"];
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            CancelOrder co = new CancelOrder();
            co.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
