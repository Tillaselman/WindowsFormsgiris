using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linklabelwinforms
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

        private void link_lab_gog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

                 //bir kütüphane //buda bir sınıf //buda bir metot   //burayada gitmek istediğimiz linkimizi verdik
            System.Diagnostics.    Process.         Start              ("https://www.udemy.com/course/c-sharp-programlama-dili-her-seviyeye-hitap-eden-egitim-seti/learn/lecture/24327124#overview");
        }
    }
}
