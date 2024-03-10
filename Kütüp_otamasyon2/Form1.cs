using Kütüp_otamasyon2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüp_otamasyon2
{
    public partial class Form1 : Form
    {
        List<kisi> kisilerim=new List<kisi>();
        List<Kitap> kitaplarım=new List<Kitap>();
        List<uyeler> uyelerim=new List<uyeler>();


        uyeler uye = new uyeler();
        uyelerEntities db = new uyelerEntities();


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Kullanici.Text=string.Empty;
            textBox_sfr.Text=string.Empty;
        }

        private void button_giris_Click(object sender, EventArgs e)
        {

            string username = textBox_Kullanici.Text;
            string password = textBox_sfr.Text;

            using (var db = new uyelerEntities())
            {

                var admin = db.uyeler.FirstOrDefault(a => a.uye_kullaniciadi.ToLower() == username && a.uye_sifre == password && a.uye_yetki.ToLower() == "admin");
                var uye   = db.uyeler.FirstOrDefault(a => a.uye_kullaniciadi.ToLower() == username && a.uye_sifre == password && a.uye_yetki.ToLower() == "üye");
                if (admin != null)
                {
                  
                   admin adminsayfası = new admin(uyelerim);
                    adminsayfası.Show();
                    this.Hide();
                }
                else if(uye != null)
                {
                    uye uyesayfası = new uye(kitaplarım);
                    uyesayfası.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş. Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }









            /*
            string kullanici,sifre= "";

            kullanici = textBox_Kullanici.Text;
            sifre = textBox_sfr.Text;


            bool kontrol = false;

            foreach(uyeler uyeler in uyelerim)
            {
                if (/*(kullanici.ToLower()==kisi.getkullaniciadi() && sifre.ToLower()==kisi.getsifre()&& kisi.getyetki()=="admin")||*/ // kullanici.ToLower() == uye.uye_kullaniciadi && sifre.ToLower() == uye.uye_sifre && uye.uye_yetki == "admin")
            {
                /*
                    admin adminsayfası = new admin(uyelerim);
                    adminsayfası.Show();
                    this.Hide();

                    kontrol = true;
                    break;
                */
                }
                /*
                else if(kullanici.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getsifre() && kisi.getyetki() == "uye")
                {
                    uye uyesayfası = new uye(kitaplarım);
                    uyesayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
               



            }

            if(!kontrol)
            {
                MessageBox.Show("hatalı giris", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            //üye ve adminlerin listesi
            kisilerim.Add(new kisi(1,"selman", "yozoğlu",DateTime.Now,"tilla","12","admin"));
            kisilerim.Add(new kisi(2, "mustafa", "özkapıcı", DateTime.Now, "anıl", "123", "uye"));
            kisilerim.Add(new kisi(3, "enes", "çatalkaya", DateTime.Now, "enes", "12", "uye"));
            kisilerim.Add(new kisi(4, "bayram", "irioğlu", DateTime.Now, "furkan", "1234", "uye"));


            // kitapların listesi
            kitaplarım.Add(new Kitap(1, "içimizdeki şeytan", "sabahattin ali", "türkçe", "yapıkredi yayınları", "roman", 100, 250, 2016));
            kitaplarım.Add(new Kitap(2, "tutunamayanlar", "oğuz atay", "Türkçe", "iletişim yayıncılık", "roman", 50, 760, 2016));
            kitaplarım.Add(new Kitap(3, "uçurtma avcısı", "khaled hosseini", "ingilizce", "everest yayıcılık", "roman", 100, 350, 2010));
            kitaplarım.Add(new Kitap(4, "küçük prens", "antoine de saint_exupery", "ingilizce", "can çocuk yayınları", "roman", 100, 60, 2018));
            kitaplarım.Add(new Kitap(5, "kürk mantolu madonna", "sabahattin ali", "türkçe", "yapıkredi yayınları", "roman", 150 ,220, 2015));
            */





        }

        private void button_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
