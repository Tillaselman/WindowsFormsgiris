using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webbrowserwinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aramatext=textBox1.Text;

            webBrowser1.Navigate(aramatext);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
