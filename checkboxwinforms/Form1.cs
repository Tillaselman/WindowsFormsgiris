using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkboxwinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hesapla_btn_Click(object sender, EventArgs e)
        {
            int tutar = 0;

            if(çaychackbox.Checked ) 
            {
                tutar +=2;
            }
            if(kahvecheckBox.Checked ) 
            {
                tutar +=4;
            }

            string toplam=Convert.ToString(tutar);
            toptutlabel.Text = toplam;
        }

        
    }
}
