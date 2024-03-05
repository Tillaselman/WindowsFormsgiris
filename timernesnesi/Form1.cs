using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timernesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int değer = 20;
        private void startbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(değer >= 0) 
            {
                labelgerisayim.Text=değer.ToString();
                değer--;
            
            }
            else
            {
                timer1.Enabled=false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saatlabel  .Text=DateTime.Now.Hour.ToString();
            dakikalabel.Text=DateTime.Now.Minute.ToString();
            saniyelabel.Text=DateTime.Now.Second.ToString();
        }
    }
}
