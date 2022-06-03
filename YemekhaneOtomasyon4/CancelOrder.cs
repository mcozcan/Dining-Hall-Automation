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
    public partial class CancelOrder : Form
    {

        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public CancelOrder()
        {
            InitializeComponent();
        }

        private void CancelOrder_Load(object sender, EventArgs e)
        {

            string c = GlobalClass.KullaniciAdi;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            da = new OleDbDataAdapter("SElect *from iptal_table where musteri_kadi like '" + c + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "iptal_table");
            dataGridView1.DataSource = ds.Tables["iptal_table"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserOrder uo = new UserOrder();
            uo.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
