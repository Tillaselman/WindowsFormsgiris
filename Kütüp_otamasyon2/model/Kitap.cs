using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüp_otamasyon2.model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapisim { get; set; }
        public string kitapyazar { get; set; }
        public string kitapdili { get; set; }
        public string kitapyayinevi { get; set; }
        public  string kitaptur { get; set; }
        public int kitapadet { get; set; }
        public  int kitapsayfasayisi { get; set; }
        public int kitapbasimyili { get; set; }
        
        public Kitap()
        {
            
        }
        
        public Kitap(int _kitapid, string _kitapisism, string _kitapyazar, string _kitapdili, string _kitapyayinevi, string _kitaptür, int _kitapadet, int _kitapsayfasayisi, int _kitapbasimyili)
        {
            this.kitapid = _kitapid;    
            this.kitapisim = _kitapisism;
            this.kitapyazar = _kitapyazar;
            this.kitapdili = _kitapdili;
            this.kitapyayinevi= _kitapyayinevi;
            this.kitaptur = _kitaptür;
            this.kitapadet = _kitapadet;
            this.kitapsayfasayisi = _kitapsayfasayisi;
            this.kitapbasimyili = _kitapbasimyili;

        }

        public int getkitapid()
        {
            return this.kitapid;    
        }
        public string getkitapisim()
        { 
            return this.kitapisim;
        }
        public string getkitapyazar() 
        {
            return this.kitapyazar; 
        }
        public string getkitapdili()
        {
            return this.kitapdili;
        }
        public string getkitapyayinevi() 
        { 
            return this.kitapyayinevi;
        }
        public string getkitaptür()
        {
            return this.kitaptur;
        }
        public int getkitapadet()
        {
            return this.kitapadet;
        }
        public int getkitapsayfasayisi()
        {
            return this.kitapsayfasayisi;
        }
        public int getkitapbasimyili()
        {
            return this.kitapbasimyili;
        }













    }
}
