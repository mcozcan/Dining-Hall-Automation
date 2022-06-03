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
    public partial class CancelOrderAdmin : Form
    {
        public CancelOrderAdmin()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        private void CancelOrderAdmin_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            da = new OleDbDataAdapter("SElect *from iptal_table'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "iptal_table");
            dataGridView1.DataSource = ds.Tables["iptal_table"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerOrders co = new CustomerOrders();
            co.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
