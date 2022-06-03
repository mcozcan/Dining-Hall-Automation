using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Media;
using Timer = System.Timers.Timer;
using System.Timers;


namespace YemekhaneOtomasyon4
{


    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            timer4.Enabled = true;
            
            timer4.Interval = 1;
            timer5.Interval = 150;
         
            timer4.Start();
            timer5.Start();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            ul.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            label5.Text = DateTime.Now.ToShortTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //kayan yazı methodu
            label7.Text = label7.Text.Substring(1) + label7.Text.Substring(0, 1);
        }
    }
}
