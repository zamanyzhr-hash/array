using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrey
{
    public partial class Form1 : Form
    {
        
        string[] days = { "sunday", "monday", "tuesday", "wendsday", "thersday", "friday", "saterday" };
        
        
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000;
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach(string m in days)
            {

                label1.Text = m;
                

            }
        }
    }
}
