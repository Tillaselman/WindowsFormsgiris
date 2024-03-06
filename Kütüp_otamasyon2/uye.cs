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
    public partial class uye : Form
    {

        List<Kitap> kitaplarim;

       
        public uye(List<Kitap>kitaplarim)
        {

            InitializeComponent();

            this.kitaplarim = kitaplarim;
            
        }

        private void uye_Load(object sender, EventArgs e)
        {
            foreach(Kitap hedefkitap in kitaplarim)
            {
                dataGridView1.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getkitapyayinevi(), hedefkitap.getkitaptür(), hedefkitap.getkitapadet(), hedefkitap.getkitapsayfasayisi(), hedefkitap.getkitapbasimyili());
            }
        }

        private void button_uye_ara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;

            int secilenkitapID = Convert.ToInt32(textBox_uye_kitap_ara.Text);

            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getkitapid() == secilenkitapID)
                {
                    hedefkitap = kitap;

                    break;

                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getkitapyayinevi(), hedefkitap.getkitaptür(), hedefkitap.getkitapadet(), hedefkitap.getkitapsayfasayisi(), hedefkitap.getkitapbasimyili());

        }

        private void button_uye_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach (Kitap hedefkitap in kitaplarim)
            {
                dataGridView1.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getkitapyayinevi(), hedefkitap.getkitaptür(), hedefkitap.getkitapadet(), hedefkitap.getkitapsayfasayisi(), hedefkitap.getkitapbasimyili());

            }

        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }
    }
}
