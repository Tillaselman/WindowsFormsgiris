using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupboxnesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //groupbox bir conteyner görevi görür içine eklediğimiz nesneler onun olur ve onla berabeer hareket eder 
            //basit bir kayıt tablosu oluşturduk


            MessageBox.Show("kayıt alındı", "uyarı");

            //burdaada kayıttan sonra textbox lar içindeki yazıları mantıken kayıt ekledikten tonra silmek lazım
            //bunuda tek tek değil groupbox ve for döngüsü sayetinde bütün textlerdeki yazıları sırayla silebiliyoruz 
            //öbür türlü şöyle uğraşcaktık
            /*textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            */

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            for (int i = 0;i< groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox)
                {
                    groupBox1.Controls[i].Text=string.Empty;
                }

            }
        }
    }
}
