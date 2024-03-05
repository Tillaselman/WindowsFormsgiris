using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PİCTUREBOXANDBİRDENFAZLAFORMİLEÇALIŞMA
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

        private void button_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre;

            kullaniciadi=textBox_kullaniciadi.Text;
            sifre=textBox_sifre.Text;

            //tolower girilen karakterlerin hepsini küçük yap demek...
            if(kullaniciadi.ToLower()=="selman" && sifre=="1")
            {
                Form2 digersayfa= new Form2();
                //diğer formdaki labelin modifariesini public yaptık ve kullanıcı adı texte girmiş olduğumuz değerin harflerini büyüterek içine yazdırdık
                digersayfa.label_deger.Text = kullaniciadi.ToUpper();

                //öteki formu gösterecek
                digersayfa.Show();

                //öteki forma geçince bu formu gizleyecek
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı giriş", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
