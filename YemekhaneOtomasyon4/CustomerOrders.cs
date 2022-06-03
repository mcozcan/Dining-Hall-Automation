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
    public partial class CustomerOrders : Form
    {


        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public CustomerOrders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel ap2 = new AdminPanel();
            ap2.Show();
            this.Hide();
        }

        private void CustomerOrders_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            da = new OleDbDataAdapter("SElect *from siparisler_table'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "siparisler_table");
            dataGridView1.DataSource = ds.Tables["siparisler_table"];
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CancelOrderAdmin coa = new CancelOrderAdmin();
            coa.Show();
            this.Hide();
        }
    }
}
