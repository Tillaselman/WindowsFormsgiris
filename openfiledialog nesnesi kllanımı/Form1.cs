using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openfiledialog_nesnesi_kllanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {

            //openfiledialog nesnesini projemize sürekliyip bıraktık


            //butona basınca dosyalarada arama çıkacak
            openFileDialog1.ShowDialog();

            //seçmiş olduğumuz dosyanın yolunu bize string olarak yakalayacak 
            string resimyolu=openFileDialog1.FileName;

            //yakalamış olduğumuz yolu picturebox nesnesinin image yolumna attık
            pictureBox1.Image=Image.FromFile(resimyolu);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
