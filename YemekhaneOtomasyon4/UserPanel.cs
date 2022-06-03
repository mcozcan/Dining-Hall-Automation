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
    public partial class UserPanel : Form
    {
       
       
        public UserPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserToOrder uto = new UserToOrder();
            uto.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserOrder uo = new UserOrder();
            uo.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerAccount ca = new CustomerAccount();
            ca.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserFix uf = new UserFix();
            uf.Show();
            this.Hide();
        }
        

        private void UserPanel_Load(object sender, EventArgs e)
        {
            string c = GlobalClass.KullaniciAdi;
            
            label2.Text = c;


            timer1.Start();
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label5.Text = DateTime.Now.ToShortTimeString();
            label6.Text = DateTime.Now.ToLongDateString();

        }

   
    }
}
