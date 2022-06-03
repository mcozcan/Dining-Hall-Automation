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
    public partial class UserAccounting : Form
    {






        public UserAccounting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");

            }

            else
            {

            
            MessageBox.Show("Borcunuz bankadan tahsil ediliyor tamam tuşuna basıp bekleyiniz");
            System.Threading.Thread.Sleep(1000);
            MessageBox.Show("Borcunuz ödenmiştir teşekkür ederiz...");
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
            }
        }

        private void UserAccounting_Load(object sender, EventArgs e)
        {

        }
    }
}
