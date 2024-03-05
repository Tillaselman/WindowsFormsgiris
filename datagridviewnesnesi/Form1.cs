using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridviewnesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttongoster_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, "selman", "yozoğlu");
            dataGridView1.Rows.Add(2, "enes", "bayram");
            dataGridView1.Rows.Add(3, "memati", "baş");

        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(textBoxid.Text);
            string isim=textBoxisim.Text;
            string soyisim=textBoxsoyisim.Text;

            dataGridView1.Rows.Add(id, isim, soyisim);

            MessageBox.Show("kayıt eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string isim= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soyisim= dataGridView1.CurrentRow.Cells[2].Value.ToString();

            textBoxid.Text = id;
            textBoxisim.Text = isim;
            textBoxsoyisim.Text= soyisim;

        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
           dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            MessageBox.Show("kayıt silindi");
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(textBoxid.Text);
            string isim=textBoxisim.Text;
            string soyisim = textBoxsoyisim.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim);


        }
    }
}
