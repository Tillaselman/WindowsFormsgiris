using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageboxkullanim
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

        private void button1_Click(object sender, EventArgs e)
        {
            //message box bir calss dır 

          //enum dönüyor                      //bu kısım mesajımız,  //bu kısım başlık,  //buda mesajımıza evet hayır butonu ekledik, //buda soru işareti iconu koydu
          DialogResult sonuc=  MessageBox.Show("çıkılsınmı?",         "bilgilendirme",    MessageBoxButtons.YesNo,                     MessageBoxIcon.Question         );
           if(sonuc==DialogResult.Yes)
            {
                label1.Text=("cıkılıyor");
                Application.Exit();
            }
           else
            {
                label1.Text = "cıkışyapılamadı";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
