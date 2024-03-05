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
    public partial class arayüz : Form
    {
        public arayüz()
        {
            InitializeComponent();
        }
        private void arayüz_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(0001, "Muhammed Selman", "Yozoğlu");
            dataGridView1.Rows.Add(0002, "Bayram Furkan", "İrioğlu");
            dataGridView1.Rows.Add(0003, "Enes", "Çatalkaya");
            dataGridView1.Rows.Add(0004, "Mustafa Anıl", "Özkapıcı");
        }
        private void cıkıs_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button_kuli_goster_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell0 = dataGridView1.SelectedCells[0];
            DataGridViewCell cell1 = dataGridView1.SelectedCells[1];
            DataGridViewCell cell2 = dataGridView1.SelectedCells[2];

            textBox_kuli_kütüpno.Text= cell0.Value.ToString();
            textBox_kuli_isim.Text= cell1.Value.ToString();
            textBox_kuli_soyisim.Text= cell2.Value.ToString();

        }

        private void button_kuli_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_kuli_kütüpno.Text);
            string isim= textBox_kuli_isim.Text;
            string soyisim=textBox_kuli_soyisim.Text;

            dataGridView1.Rows.Add(id , isim, soyisim);

            MessageBox.Show("Kullanıcı eklendi", "KAYIT");

            for(int i = 0;i<groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox)
                {
                    groupBox1.Controls[i].Text=string.Empty;
                }
            }

        }

        private void button_kuli_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            MessageBox.Show("Kayıt Silindi", "UYARI");
        }

        private void button_kuli_Guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_kuli_kütüpno.Text);
            string isim = textBox_kuli_isim.Text;
            string soyisim = textBox_kuli_soyisim.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim);

            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
        }
    }
}
