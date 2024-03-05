using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matematikDLL;

namespace dllolustirma
{
    public partial class Form1 : Form
    {
        Matematik_dll mat=new Matematik_dll();
        public Form1()
        {
            InitializeComponent();
        }

        //dll nedir dinamik link liabery dinamik kütüphanler
        //bizler bir tane dll oluştururruz ve içlerine bir sürü metotlar yazarız sonra o dll leri projelerimizde
        //aktif edip o metotları tekrar yazmaya kalkışmadan kullanabiliriz
        // dll nasıl oluşturulur? nasıl kullanılır?
        // *yeni proje açıyoruz class libary  diye aratıp Class Libary(.NET Framework) c# dilinde seçiyoruz.
        // *winforms projeme geldim referance kısmına sağtık yaptık add referance dedik ve açılan pencerede Projects
        //   kısmından oluşturduğumuz dll clasının tikini işaretledik ok dedik ve kullanacağımız calss a using ettik -üst tarafta görünüyor- 

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        private void toplabtn_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayı1textbox.Text);
            int sayi2 = Convert.ToInt32(sayı2textbox.Text);

            int islem=mat.topla(sayi1,sayi2);
            
            sonucdegerlabel.Text=islem.ToString();

        }

        private void cıkarbtn_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayı1textbox.Text);
            int sayi2 = Convert.ToInt32(sayı2textbox.Text);

            int islem=mat.cıkar(sayi1 ,sayi2);
            
            sonucdegerlabel.Text = islem.ToString();
        }

        private void carpbtn_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayı1textbox.Text);
            int sayi2 = Convert.ToInt32(sayı2textbox.Text); 
            
            int islem=mat.carpma(sayi1 ,sayi2); 
            sonucdegerlabel.Text = islem.ToString();

        }

        private void bolbtn_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToInt32(sayı1textbox.Text);
            double sayi2 = Convert.ToInt32(sayı2textbox.Text);

           double islem= mat.bolme(sayi1 ,sayi2);

            sonucdegerlabel.Text=islem.ToString();


        }
    }
}
