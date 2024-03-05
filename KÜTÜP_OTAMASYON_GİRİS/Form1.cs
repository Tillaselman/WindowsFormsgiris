using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜP_OTAMASYON_GİRİS
{
    public partial class Kullanici_giris_form : Form
    {
        public Kullanici_giris_form()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string kullanici = textBox_Kullanici.Text;
            kullanici = "selman".ToLower();

            string sifre = textBox_Sifre.Text;
            sifre = "1234";



            if(textBox_Kullanici.Text.ToLower()==kullanici && textBox_Sifre.Text==sifre)
            {
                arayüz form2arayüz = new arayüz(); 
                form2arayüz.Show();

                this.Hide();
                       
            }
            else
            {
                MessageBox.Show("Hatalı giriş tekrar deneyin", "HATA");
            }
        }

        private void Kullanici_giris_form_Load(object sender, EventArgs e)
        {
            arayüz arayüz = new arayüz();
           
            this.Hide();
            arayüz.Show();
        }
    }
}
