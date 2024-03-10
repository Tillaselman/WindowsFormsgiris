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
    public partial class admin : Form
    {
        uyeler uye=new uyeler();
        uyelerEntities db=new uyelerEntities();

        kitaplarim kitap1= new kitaplarim();
        kitaplarimdbEntities dbk=new kitaplarimdbEntities();

        
        //List<kisi> kisilerim;
       // List<Kitap> kitaplarim;
       
        public admin(List<uyeler> uyelerim     /*List<kisi> kisilerim,List<Kitap> kitaplarim*/)
        {
            InitializeComponent();

           /* this.kisilerim = kisilerim;*/
           // this.kitaplarim = kitaplarim;
            
        }

        private void admin_Load(object sender, EventArgs e)
        {
            /*
            foreach(kisi kisi in kisilerim) 
            {
               // dataGridView1.Rows.Add(kisi.getId(),kisi.getIsim(),kisi.getsoyisim(),kisi.getolusturmatarihi(),kisi.getkullaniciadi(),kisi.getsifre(),kisi.getyetki());

                
            }
            */

            dataGridView1.DataSource = db.uyeler.ToList();
            dataGridView2.DataSource=dbk.kitaplarim.ToList();
             /*
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getkitapyayinevi(), kitap.getkitaptür(), kitap.getkitapadet(), kitap.getkitapsayfasayisi(), kitap.getkitapbasimyili());
            }
             */
        }

        // üye işlemleri kısmı..............................................................................

        //ekle btn düzenlendi...
        private void button_ekle_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(Convert.ToInt32(textBox_id.Text), textBox_isim.Text, textBox_soyisim.Text, maskedTextBox_olusturmatarihi.Text, textBox_kullaniciadi.Text, textBox_sifre.Text, textBox_yetki.Text);
            
            uye.uye_isim=textBox_isim.Text;
            uye.uye_soyisim=textBox_soyisim.Text;
            uye.uye_olusturmatarihi = DateTime.Parse(maskedTextBox_olusturmatarihi.Text);
            uye.uye_kullaniciadi=textBox_kullaniciadi.Text;
            uye.uye_yetki=textBox_yetki.Text;
            uye.uye_sifre=textBox_sifre.Text;

            db.uyeler.Add(uye);
            db.SaveChanges();
            dataGridView1.DataSource=db.uyeler.ToList();

            




        }

        //sil btn düzenlendi...
        private void button_sil_Click(object sender, EventArgs e)
        {
            /*
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            */
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            uyeler uye=db.uyeler.FirstOrDefault(x => x.uye_id==id);
            MessageBox.Show("Data Silinsinmi?..","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            db.uyeler.Remove(uye);
            db.SaveChanges();
            dataGridView1.DataSource = db.uyeler.ToList();

            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {

                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }



        }
        public void textleridoldur()
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_isim.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_soyisim.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_olusturmatarihi.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_kullaniciadi.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_sifre.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_yetki.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();


        }

        //guncelle btn düzenlendi...
        private void button_guncelle_Click(object sender, EventArgs e)
        {
            /*
            string id = textBox_id.Text;
            string isism = textBox_isim.Text;
            string soyisism= textBox_soyisim.Text;
            string tarih = maskedTextBox_olusturmatarihi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sifre = textBox_sifre.Text;
            string yetki = textBox_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isism, soyisism, tarih, kullaniciadi, sifre,yetki);


            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {

                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
            */

            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            uyeler uye = db.uyeler.FirstOrDefault(x => x.uye_id == id);

            uye.uye_isim = textBox_isim.Text;
            uye.uye_soyisim = textBox_soyisim.Text;
            uye.uye_olusturmatarihi = DateTime.Parse(maskedTextBox_olusturmatarihi.Text);
            uye.uye_kullaniciadi = textBox_kullaniciadi.Text;
            uye.uye_yetki = textBox_yetki.Text;
            uye.uye_sifre = textBox_sifre.Text;

            db.SaveChanges();
            dataGridView1.DataSource=db.uyeler.ToList();

        }
        private void button_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {

                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_uyeler_Click(object sender, EventArgs e)
        {

        }

        //btn ara ve btn yenile güncellenmedi güncellenecek*********
        private void button_ara_Click(object sender, EventArgs e)
        {

            int id;
            if (int.TryParse(textBox_ara.Text, out id))
            {
                using (var db = new uyelerEntities())
                {
                    var result = db.uyeler.FirstOrDefault(a => a.uye_id == id);
                    if (result != null)
                    {
                        
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["uye_id"].Value) == id)
                            {
                                row.Selected = true;
                                dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID ile eşleşen veri bulunamadı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz ID formatı. Lütfen sayısal bir değer girin.");
            }











            /*
            kisi hedefkisi = null;

            int secilenkisiID=Convert.ToInt32(textBox_ara.Text);

            foreach(kisi kisi in kisilerim)
            {
                if(kisi.getId()==secilenkisiID)
                {
                    hedefkisi=kisi;

                    break;

                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getsoyisim(), hedefkisi.getsoyisim(), hedefkisi.getolusturmatarihi(), hedefkisi.getkullaniciadi(), hedefkisi.getsifre(),hedefkisi.getyetki()); 
            */





        }
        private void button_yenile_Click(object sender, EventArgs e)
        {
            /*
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach(kisi hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getsoyisim(), hedefkisi.getsoyisim(), hedefkisi.getolusturmatarihi(), hedefkisi.getkullaniciadi(), hedefkisi.getsifre(), hedefkisi.getyetki());
            }

            */




        }


        //**************************************************************************************************

       
        //kitap işlemleri kısmı.............................................................................
        
        //kitap ekle btn hazır*******
        private void button_kitapekle_Click(object sender, EventArgs e)
        {
            kitap1.kitapisim=textBox_kitapisim.Text;
            kitap1.kitapyazar=textBox_kitapyazar.Text;
            kitap1.kitapdili=textBox_kitapdili.Text;
            kitap1.kitapyayinevi=textBox_yayınevi.Text;
            kitap1.kitaptür=textBox_kitaptürü.Text;
            kitap1.kitapadet=textBox_kitapadet.Text;
            kitap1.kitapsayfasayisi=textBox_kitapsayfasayisi.Text;
            kitap1.kitapbasimyili=textBox_kitapbasimyili.Text;

            dbk.kitaplarim.Add(kitap1);
            dbk.SaveChanges();

            dataGridView2.DataSource = dbk.kitaplarim.ToList();


            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {

                if (groupBox2.Controls[i] is TextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }







            // dataGridView2.Rows.Add(textBox_kitapid.Text, textBox_kitapisim.Text  , textBox_kitapyazar.Text , textBox_kitapdili.Text , textBox_yayınevi.Text , textBox_kitaptürü.Text , textBox_kitapadet.Text , textBox_kitapsayfasayisi.Text , textBox_kitapbasimyili.Text);

            /*
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {

                if (groupBox2.Controls[i] is TextBox || groupBox2.Controls[i] is MaskedTextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }
            */
        }
        //sil btn hazır*****
        private void button_kitapsil_Click(object sender, EventArgs e)
        {
             int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            kitaplarim kitap = dbk.kitaplarim.FirstOrDefault(x => x.kitapid == id);

            MessageBox.Show("Data Silinsinmi?..", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            dbk.kitaplarim.Remove(kitap);
            dbk.SaveChanges();
            dataGridView2.DataSource = dbk.kitaplarim.ToList();


            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {

                if (groupBox2.Controls[i] is TextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }

            /*
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);


            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {

                if (groupBox2.Controls[i] is TextBox || groupBox2.Controls[i] is MaskedTextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }
            */
        }


        //güncelle btn hazır*******************
    private void button_güncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            kitaplarim kitap = dbk.kitaplarim.FirstOrDefault(x => x.kitapid == id);

            kitap.kitapisim = textBox_kitapisim.Text;
            kitap.kitapyazar = textBox_kitapyazar.Text;
            kitap.kitapdili = textBox_kitapdili.Text;
            kitap.kitapyayinevi = textBox_yayınevi.Text;
            kitap.kitaptür = textBox_kitaptürü.Text;
            kitap.kitapadet = textBox_kitapadet.Text;
            kitap.kitapsayfasayisi = textBox_kitapsayfasayisi.Text;
            kitap.kitapbasimyili = textBox_kitapbasimyili.Text;

            dbk.SaveChanges();
            dataGridView2.DataSource = dbk.kitaplarim.ToList();



            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {

                if (groupBox2.Controls[i] is TextBox )
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }








            /*
            string id = textBox_kitapid.Text;
            string isim = textBox_kitapisim.Text;
            string yazar = textBox_kitapyazar.Text;
            string kitapdili=textBox_kitapdili.Text;
            string yayinevi = textBox_yayınevi.Text;
            string türü = textBox_kitaptürü.Text;
            string adet=textBox_kitapadet.Text;
            string sayfasayısı=textBox_kitapsayfasayisi.Text;
            string basimyili=textBox_kitapbasimyili.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(id, isim, yazar, kitapdili,yayinevi,türü,adet,sayfasayısı,basimyili);


            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {

                if (groupBox2.Controls[i] is TextBox || groupBox2.Controls[i] is MaskedTextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }

            */
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldurkitap();
        }

        public void textleridoldurkitap()
        {
            textBox_kitapid.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox_kitapisim.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox_kitapdili.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox_yayınevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox_kitaptürü.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox_kitapadet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBox_kitapsayfasayisi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBox_kitapbasimyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();


        }

        private void button_Kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {

                if (groupBox2.Controls[i] is TextBox || groupBox2.Controls[i] is MaskedTextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }
        }

        private void button_kitapara_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox_kitapara.Text, out id))
            {
                using (var db = new kitaplarimdbEntities())
                {
                    var result = db.kitaplarim.FirstOrDefault(a => a.kitapid == id);
                    if (result != null)
                    {
                        
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["kitapid"].Value) == id)
                            {
                                row.Selected = true;
                                dataGridView2.FirstDisplayedScrollingRowIndex = row.Index;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID ile eşleşen veri bulunamadı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz ID formatı. Lütfen sayısal bir değer girin.");
            }










            /*
            Kitap hedefkitap = null;

            int secilenkitapID=Convert.ToInt32(textBox_kitapara.Text);

            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getkitapid() == secilenkitapID)
                {
                    hedefkitap = kitap;

                    break;

                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getkitapyayinevi(), hedefkitap.getkitaptür(),hedefkitap.getkitapadet(),hedefkitap.getkitapsayfasayisi(),hedefkitap.getkitapbasimyili());
            */

        }

        private void button_kitapyenile_Click(object sender, EventArgs e)
        {
            /*
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            foreach(Kitap hedefkitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getkitapyayinevi(), hedefkitap.getkitaptür(), hedefkitap.getkitapadet(), hedefkitap.getkitapsayfasayisi(), hedefkitap.getkitapbasimyili());

            }


            */
        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }





        //**************************************************************************************************

    }

}
