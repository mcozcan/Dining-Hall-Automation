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
    public partial class AdminAccouting : Form
    {

        

        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;

        public AdminAccouting()
        {
            InitializeComponent();
        }

        private void AdminAccouting_Load(object sender, EventArgs e)
        {

            
            //Access bağlantı ve atamalar
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=yemekhane.mdb");
            da = new OleDbDataAdapter("SElect *from siparisler_table'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "siparisler_table");
            dataGridView1.DataSource = ds.Tables["siparisler_table"];
            
            //tablo atama ve değerlerin hesaplanması
            double toplam = 0.0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam = toplam + Convert.ToDouble(dataGridView1.Rows[i].Cells["fiyat"].Value);
            }
            label4.Text = toplam.ToString();
            double lbl4 = toplam;
            double total = toplam;
            double lbl5 = (total * 0.59);
            double lbl6 = (total * 0.41);
            label5.Text = lbl5.ToString();
            label6.Text = lbl6.ToString();



            con.Close();
                 foreach (var series in chart1.Series)
                 {
                     series.Points.Clear();
                 }
            chart1.Series["GRAP"].Points.AddXY("Ciro", lbl4);
            chart1.Series["GRAP"].Points.AddXY("Kar", lbl5);
            chart1.Series["GRAP"].Points.AddXY("Gider", lbl6);

                 foreach (var series in chart2.Series)
                  {
                    series.Points.Clear();
                  }
            chart2.Series["GRAP2"].Points.AddXY("Ciro", lbl4);
            chart2.Series["GRAP2"].Points.AddXY("Kar", lbl5);
            chart2.Series["GRAP2"].Points.AddXY("Gider", lbl6);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AdminPanel ap2 = new AdminPanel();
            ap2.Show();
            this.Hide();
        }
    }
}