using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsgirisapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {







            /*
            //comboboxsa item ekleme 
            comboBox1.Items.Add("per");
            comboBox1.Items.Add("cum");


            //proje çalıştırınca bir uyarı kutusu çıkar
            MessageBox.Show("anama babam");

            //index numarasına göre item siler comboboxdan
            comboBox1.Items.RemoveAt(1);
            */

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboboxdan seçtiğimiz günü yakaladı obje olarak döndü ama biz string istediğimiz için tostring yaptık
            string gün=comboBox1.SelectedItem.ToString();

            //seçtiğimiz değeri index numarası ile yakalama
            int gunindex=comboBox1.SelectedIndex;

            //messagebox sada seçilen günü yazdırdık.
            MessageBox.Show("seçtiğin gün  :  " + gün+" "+"index"+gunindex);
        }
    }
}
