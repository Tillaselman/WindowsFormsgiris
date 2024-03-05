using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüp_otamasyon2.model
{
    public class kisi
    {
        public int id { get; set; }
        public  string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmatarihi { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }

        public kisi()
        {
            
        }

        public kisi(int id, string isim, string soyisim, DateTime olusturmatarihi, string kullaniciadi, string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmatarihi = olusturmatarihi;
            this.kullaniciadi = kullaniciadi;
            this.sifre = sifre; 
            this.yetki = yetki;

        }

        public void setId (int id)
        {
            this.id=id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setIsim() 
        {
            this.isim=isim;
        }
        public string getIsim() 
        {
            return isim;
            
        }
        public void setsoyisim()
        {
            this.soyisim=soyisim;
        }
        public string getsoyisim()
        {
            return soyisim; 
        }
        public void setolusturmatarihi()
        {
            this.olusturmatarihi=olusturmatarihi;
        }
        public DateTime getolusturmatarihi() 
        {
            return this.olusturmatarihi;
        }
        public void setkullaniciadi()
        {
            this.kullaniciadi=kullaniciadi;
        }
        public string getkullaniciadi()
        {
            return kullaniciadi;
        }
        public void setsifre()
        {
            this.sifre=sifre;
        }
        public string getsifre()
        {
            return this.sifre;
        }
        public void setyetki()
        {
            this.yetki=yetki;
        }
        public string getyetki()
        {
            return this.yetki;
        }

        public override string ToString()
        {
            return "isim -  soyisim : " + this.isim + "  " + this.soyisim;
        }



    }
}
