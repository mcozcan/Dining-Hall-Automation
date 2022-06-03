using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YemekhaneOtomasyon4
{
    public partial class AdminPanel : Form
    {
       



        public AdminPanel()
        {
           
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerOrders co = new CustomerOrders();
            co.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAccouting aac = new AdminAccouting();
            aac.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCustomer addc = new AddCustomer();
            addc.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToShortTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
