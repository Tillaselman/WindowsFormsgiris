using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobtnwinformnesne
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void devambtn_Click(object sender, EventArgs e)
        {
            string isism, soyisim, cinsiyet = null;

            if(radioButtonerkek.Checked)
            {
                cinsiyet = "erkek";
            }
            else if(radioButtonkadın.Checked) 
            {
                cinsiyet = "kadın";
            }
            else
            {
                cinsiyet = "";
            }

            isism = textad.Text;
            soyisim = textsoyad.Text;
                                                                              
            MessageBox.Show("adınız ve soyadınız :  " + isism + " " + soyisim + "\n " /*bir satır aşağıya*/  + "cinsiyetiniz : " + cinsiyet);
        }

        private void radioButtonkadın_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
