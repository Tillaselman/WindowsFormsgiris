namespace Kütüp_otamasyon2
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_uyeler = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_isim = new System.Windows.Forms.Label();
            this.label_soyisim = new System.Windows.Forms.Label();
            this.label_olusturmatarihi = new System.Windows.Forms.Label();
            this.label_kullaniciadi = new System.Windows.Forms.Label();
            this.label_sifre = new System.Windows.Forms.Label();
            this.label_yetki = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.textBox_soyisim = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciadi = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_yetki = new System.Windows.Forms.TextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.maskedTextBox_olusturmatarihi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.İD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İSİM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOYİSİM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OLUŞTURMATARİHİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KULLANİCİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SİFRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YETKİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kitapyayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaptur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kitapsayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapbasimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_kitaplar = new System.Windows.Forms.Label();
            this.button_Kitaptemizle = new System.Windows.Forms.Button();
            this.button_güncelle = new System.Windows.Forms.Button();
            this.button_kitapsil = new System.Windows.Forms.Button();
            this.button_kitapekle = new System.Windows.Forms.Button();
            this.textBox_kitapid = new System.Windows.Forms.TextBox();
            this.maskedTextBox_kitapbasimyili = new System.Windows.Forms.MaskedTextBox();
            this.label_kitapbasimyili = new System.Windows.Forms.Label();
            this.label_kitapsayfasayisi = new System.Windows.Forms.Label();
            this.label_kitapadet = new System.Windows.Forms.Label();
            this.label_kitaptur = new System.Windows.Forms.Label();
            this.label_kitapyayinevi = new System.Windows.Forms.Label();
            this.label_kitapdili = new System.Windows.Forms.Label();
            this.label_kitapyazar = new System.Windows.Forms.Label();
            this.label_kitapisim = new System.Windows.Forms.Label();
            this.label_kitapid = new System.Windows.Forms.Label();
            this.textBox_kitapsayfasayisi = new System.Windows.Forms.TextBox();
            this.textBox_kitapadet = new System.Windows.Forms.TextBox();
            this.textBox_kitaptürü = new System.Windows.Forms.TextBox();
            this.textBox_kitapdili = new System.Windows.Forms.TextBox();
            this.textBox_yayınevi = new System.Windows.Forms.TextBox();
            this.textBox_kitapyazar = new System.Windows.Forms.TextBox();
            this.textBox_kitapisim = new System.Windows.Forms.TextBox();
            this.button_ara = new System.Windows.Forms.Button();
            this.button_yenile = new System.Windows.Forms.Button();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.button_kitapara = new System.Windows.Forms.Button();
            this.button_kitapyenile = new System.Windows.Forms.Button();
            this.textBox_kitapara = new System.Windows.Forms.TextBox();
            this.button_cikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_uyeler
            // 
            this.label_uyeler.AutoSize = true;
            this.label_uyeler.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_uyeler.Location = new System.Drawing.Point(6, 475);
            this.label_uyeler.Name = "label_uyeler";
            this.label_uyeler.Size = new System.Drawing.Size(102, 31);
            this.label_uyeler.TabIndex = 1;
            this.label_uyeler.Text = "Üyeler :";
            this.label_uyeler.Click += new System.EventHandler(this.label_uyeler_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(119, 29);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 24);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "İd : ";
            // 
            // label_isim
            // 
            this.label_isim.AutoSize = true;
            this.label_isim.Location = new System.Drawing.Point(100, 65);
            this.label_isim.Name = "label_isim";
            this.label_isim.Size = new System.Drawing.Size(61, 24);
            this.label_isim.TabIndex = 0;
            this.label_isim.Text = "İsim : ";
            // 
            // label_soyisim
            // 
            this.label_soyisim.AutoSize = true;
            this.label_soyisim.Location = new System.Drawing.Point(70, 99);
            this.label_soyisim.Name = "label_soyisim";
            this.label_soyisim.Size = new System.Drawing.Size(91, 24);
            this.label_soyisim.TabIndex = 0;
            this.label_soyisim.Text = "Soyisim : ";
            // 
            // label_olusturmatarihi
            // 
            this.label_olusturmatarihi.AutoSize = true;
            this.label_olusturmatarihi.Location = new System.Drawing.Point(1, 137);
            this.label_olusturmatarihi.Name = "label_olusturmatarihi";
            this.label_olusturmatarihi.Size = new System.Drawing.Size(160, 24);
            this.label_olusturmatarihi.TabIndex = 0;
            this.label_olusturmatarihi.Text = "Oluşturmatarihi : ";
            // 
            // label_kullaniciadi
            // 
            this.label_kullaniciadi.AutoSize = true;
            this.label_kullaniciadi.Location = new System.Drawing.Point(29, 173);
            this.label_kullaniciadi.Name = "label_kullaniciadi";
            this.label_kullaniciadi.Size = new System.Drawing.Size(132, 24);
            this.label_kullaniciadi.TabIndex = 0;
            this.label_kullaniciadi.Text = "Kullanıcı Adı : ";
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.Location = new System.Drawing.Point(97, 207);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(64, 24);
            this.label_sifre.TabIndex = 0;
            this.label_sifre.Text = "Şifre : ";
            // 
            // label_yetki
            // 
            this.label_yetki.AutoSize = true;
            this.label_yetki.Location = new System.Drawing.Point(93, 244);
            this.label_yetki.Name = "label_yetki";
            this.label_yetki.Size = new System.Drawing.Size(68, 24);
            this.label_yetki.TabIndex = 0;
            this.label_yetki.Text = "Yetki : ";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(167, 23);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(303, 30);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_isim
            // 
            this.textBox_isim.Location = new System.Drawing.Point(167, 65);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(303, 30);
            this.textBox_isim.TabIndex = 1;
            // 
            // textBox_soyisim
            // 
            this.textBox_soyisim.Location = new System.Drawing.Point(167, 101);
            this.textBox_soyisim.Name = "textBox_soyisim";
            this.textBox_soyisim.Size = new System.Drawing.Size(303, 30);
            this.textBox_soyisim.TabIndex = 1;
            // 
            // textBox_kullaniciadi
            // 
            this.textBox_kullaniciadi.Location = new System.Drawing.Point(167, 173);
            this.textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            this.textBox_kullaniciadi.Size = new System.Drawing.Size(303, 30);
            this.textBox_kullaniciadi.TabIndex = 1;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(167, 209);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(303, 30);
            this.textBox_sifre.TabIndex = 1;
            // 
            // textBox_yetki
            // 
            this.textBox_yetki.Location = new System.Drawing.Point(167, 245);
            this.textBox_yetki.Name = "textBox_yetki";
            this.textBox_yetki.Size = new System.Drawing.Size(303, 30);
            this.textBox_yetki.TabIndex = 1;
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(167, 302);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(303, 39);
            this.button_ekle.TabIndex = 2;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(167, 347);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(303, 39);
            this.button_sil.TabIndex = 2;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(167, 392);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(303, 39);
            this.button_guncelle.TabIndex = 2;
            this.button_guncelle.Text = "GÜNCELLE";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Location = new System.Drawing.Point(167, 437);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(303, 39);
            this.button_temizle.TabIndex = 2;
            this.button_temizle.Text = "TEMİZLE";
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // maskedTextBox_olusturmatarihi
            // 
            this.maskedTextBox_olusturmatarihi.Location = new System.Drawing.Point(167, 137);
            this.maskedTextBox_olusturmatarihi.Mask = "00/00/0000 90:00:00";
            this.maskedTextBox_olusturmatarihi.Name = "maskedTextBox_olusturmatarihi";
            this.maskedTextBox_olusturmatarihi.Size = new System.Drawing.Size(303, 30);
            this.maskedTextBox_olusturmatarihi.TabIndex = 3;
            this.maskedTextBox_olusturmatarihi.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ara);
            this.groupBox1.Controls.Add(this.button_yenile);
            this.groupBox1.Controls.Add(this.button_ara);
            this.groupBox1.Controls.Add(this.maskedTextBox_olusturmatarihi);
            this.groupBox1.Controls.Add(this.label_uyeler);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_temizle);
            this.groupBox1.Controls.Add(this.button_guncelle);
            this.groupBox1.Controls.Add(this.button_sil);
            this.groupBox1.Controls.Add(this.button_ekle);
            this.groupBox1.Controls.Add(this.textBox_yetki);
            this.groupBox1.Controls.Add(this.textBox_sifre);
            this.groupBox1.Controls.Add(this.textBox_kullaniciadi);
            this.groupBox1.Controls.Add(this.textBox_soyisim);
            this.groupBox1.Controls.Add(this.textBox_isim);
            this.groupBox1.Controls.Add(this.label_yetki);
            this.groupBox1.Controls.Add(this.label_sifre);
            this.groupBox1.Controls.Add(this.label_kullaniciadi);
            this.groupBox1.Controls.Add(this.label_olusturmatarihi);
            this.groupBox1.Controls.Add(this.label_soyisim);
            this.groupBox1.Controls.Add(this.label_isim);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 756);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.İD,
            this.İSİM,
            this.SOYİSİM,
            this.OLUŞTURMATARİHİ,
            this.KULLANİCİ,
            this.SİFRE,
            this.YETKİ});
            this.dataGridView1.Location = new System.Drawing.Point(6, 509);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 241);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // İD
            // 
            this.İD.HeaderText = "İD";
            this.İD.MinimumWidth = 6;
            this.İD.Name = "İD";
            this.İD.Width = 125;
            // 
            // İSİM
            // 
            this.İSİM.HeaderText = "İSİM";
            this.İSİM.MinimumWidth = 6;
            this.İSİM.Name = "İSİM";
            this.İSİM.Width = 125;
            // 
            // SOYİSİM
            // 
            this.SOYİSİM.HeaderText = "SOYİSİM";
            this.SOYİSİM.MinimumWidth = 6;
            this.SOYİSİM.Name = "SOYİSİM";
            this.SOYİSİM.Width = 125;
            // 
            // OLUŞTURMATARİHİ
            // 
            this.OLUŞTURMATARİHİ.HeaderText = "OLUŞTURMATARİHİ";
            this.OLUŞTURMATARİHİ.MinimumWidth = 6;
            this.OLUŞTURMATARİHİ.Name = "OLUŞTURMATARİHİ";
            this.OLUŞTURMATARİHİ.Width = 125;
            // 
            // KULLANİCİ
            // 
            this.KULLANİCİ.HeaderText = "KULLANICI";
            this.KULLANİCİ.MinimumWidth = 6;
            this.KULLANİCİ.Name = "KULLANİCİ";
            this.KULLANİCİ.Width = 125;
            // 
            // SİFRE
            // 
            this.SİFRE.HeaderText = "ŞİFRE";
            this.SİFRE.MinimumWidth = 6;
            this.SİFRE.Name = "SİFRE";
            this.SİFRE.Width = 125;
            // 
            // YETKİ
            // 
            this.YETKİ.HeaderText = "YETKİ";
            this.YETKİ.MinimumWidth = 6;
            this.YETKİ.Name = "YETKİ";
            this.YETKİ.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_cikis);
            this.groupBox2.Controls.Add(this.textBox_kitapara);
            this.groupBox2.Controls.Add(this.button_kitapyenile);
            this.groupBox2.Controls.Add(this.button_kitapara);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label_kitaplar);
            this.groupBox2.Controls.Add(this.button_Kitaptemizle);
            this.groupBox2.Controls.Add(this.button_güncelle);
            this.groupBox2.Controls.Add(this.button_kitapsil);
            this.groupBox2.Controls.Add(this.button_kitapekle);
            this.groupBox2.Controls.Add(this.textBox_kitapid);
            this.groupBox2.Controls.Add(this.maskedTextBox_kitapbasimyili);
            this.groupBox2.Controls.Add(this.label_kitapbasimyili);
            this.groupBox2.Controls.Add(this.label_kitapsayfasayisi);
            this.groupBox2.Controls.Add(this.label_kitapadet);
            this.groupBox2.Controls.Add(this.label_kitaptur);
            this.groupBox2.Controls.Add(this.label_kitapyayinevi);
            this.groupBox2.Controls.Add(this.label_kitapdili);
            this.groupBox2.Controls.Add(this.label_kitapyazar);
            this.groupBox2.Controls.Add(this.label_kitapisim);
            this.groupBox2.Controls.Add(this.label_kitapid);
            this.groupBox2.Controls.Add(this.textBox_kitapsayfasayisi);
            this.groupBox2.Controls.Add(this.textBox_kitapadet);
            this.groupBox2.Controls.Add(this.textBox_kitaptürü);
            this.groupBox2.Controls.Add(this.textBox_kitapdili);
            this.groupBox2.Controls.Add(this.textBox_yayınevi);
            this.groupBox2.Controls.Add(this.textBox_kitapyazar);
            this.groupBox2.Controls.Add(this.textBox_kitapisim);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(509, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 745);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.Kitapyayinevi,
            this.kitaptur,
            this.kitapadet,
            this.Kitapsayfasayisi,
            this.kitapbasimyili});
            this.dataGridView2.Location = new System.Drawing.Point(6, 498);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(642, 241);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "Kitap İd :";
            this.kitapid.MinimumWidth = 6;
            this.kitapid.Name = "kitapid";
            this.kitapid.Width = 125;
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "Kitap İsim :";
            this.kitapisim.MinimumWidth = 6;
            this.kitapisim.Name = "kitapisim";
            this.kitapisim.Width = 125;
            // 
            // kitapyazar
            // 
            this.kitapyazar.HeaderText = "Kitap Yazar :";
            this.kitapyazar.MinimumWidth = 6;
            this.kitapyazar.Name = "kitapyazar";
            this.kitapyazar.Width = 125;
            // 
            // kitapdili
            // 
            this.kitapdili.HeaderText = "Kitap Dili :";
            this.kitapdili.MinimumWidth = 6;
            this.kitapdili.Name = "kitapdili";
            this.kitapdili.Width = 125;
            // 
            // Kitapyayinevi
            // 
            this.Kitapyayinevi.HeaderText = "Kitap Yayınevi :";
            this.Kitapyayinevi.MinimumWidth = 6;
            this.Kitapyayinevi.Name = "Kitapyayinevi";
            this.Kitapyayinevi.Width = 125;
            // 
            // kitaptur
            // 
            this.kitaptur.HeaderText = "Kitap Tür :";
            this.kitaptur.MinimumWidth = 6;
            this.kitaptur.Name = "kitaptur";
            this.kitaptur.Width = 125;
            // 
            // kitapadet
            // 
            this.kitapadet.HeaderText = "Kitap Adet :";
            this.kitapadet.MinimumWidth = 6;
            this.kitapadet.Name = "kitapadet";
            this.kitapadet.Width = 125;
            // 
            // Kitapsayfasayisi
            // 
            this.Kitapsayfasayisi.HeaderText = "Kitap Sayfa Sayısı :";
            this.Kitapsayfasayisi.MinimumWidth = 6;
            this.Kitapsayfasayisi.Name = "Kitapsayfasayisi";
            this.Kitapsayfasayisi.Width = 125;
            // 
            // kitapbasimyili
            // 
            this.kitapbasimyili.HeaderText = "Kitap Basım Yılı :";
            this.kitapbasimyili.MinimumWidth = 6;
            this.kitapbasimyili.Name = "kitapbasimyili";
            this.kitapbasimyili.Width = 125;
            // 
            // label_kitaplar
            // 
            this.label_kitaplar.AutoSize = true;
            this.label_kitaplar.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kitaplar.Location = new System.Drawing.Point(11, 464);
            this.label_kitaplar.Name = "label_kitaplar";
            this.label_kitaplar.Size = new System.Drawing.Size(119, 31);
            this.label_kitaplar.TabIndex = 1;
            this.label_kitaplar.Text = "Kitaplar :";
            this.label_kitaplar.Click += new System.EventHandler(this.label_uyeler_Click);
            // 
            // button_Kitaptemizle
            // 
            this.button_Kitaptemizle.Location = new System.Drawing.Point(334, 401);
            this.button_Kitaptemizle.Name = "button_Kitaptemizle";
            this.button_Kitaptemizle.Size = new System.Drawing.Size(303, 39);
            this.button_Kitaptemizle.TabIndex = 5;
            this.button_Kitaptemizle.Text = "Temizle";
            this.button_Kitaptemizle.UseVisualStyleBackColor = true;
            this.button_Kitaptemizle.Click += new System.EventHandler(this.button_Kitaptemizle_Click);
            // 
            // button_güncelle
            // 
            this.button_güncelle.Location = new System.Drawing.Point(16, 401);
            this.button_güncelle.Name = "button_güncelle";
            this.button_güncelle.Size = new System.Drawing.Size(303, 39);
            this.button_güncelle.TabIndex = 5;
            this.button_güncelle.Text = "Güncelle";
            this.button_güncelle.UseVisualStyleBackColor = true;
            this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
            // 
            // button_kitapsil
            // 
            this.button_kitapsil.Location = new System.Drawing.Point(334, 356);
            this.button_kitapsil.Name = "button_kitapsil";
            this.button_kitapsil.Size = new System.Drawing.Size(303, 39);
            this.button_kitapsil.TabIndex = 5;
            this.button_kitapsil.Text = "Sil";
            this.button_kitapsil.UseVisualStyleBackColor = true;
            this.button_kitapsil.Click += new System.EventHandler(this.button_kitapsil_Click);
            // 
            // button_kitapekle
            // 
            this.button_kitapekle.Location = new System.Drawing.Point(16, 356);
            this.button_kitapekle.Name = "button_kitapekle";
            this.button_kitapekle.Size = new System.Drawing.Size(303, 39);
            this.button_kitapekle.TabIndex = 5;
            this.button_kitapekle.Text = "Ekle";
            this.button_kitapekle.UseVisualStyleBackColor = true;
            this.button_kitapekle.Click += new System.EventHandler(this.button_kitapekle_Click);
            // 
            // textBox_kitapid
            // 
            this.textBox_kitapid.Location = new System.Drawing.Point(206, 29);
            this.textBox_kitapid.Name = "textBox_kitapid";
            this.textBox_kitapid.Size = new System.Drawing.Size(303, 30);
            this.textBox_kitapid.TabIndex = 4;
            // 
            // maskedTextBox_kitapbasimyili
            // 
            this.maskedTextBox_kitapbasimyili.Location = new System.Drawing.Point(206, 317);
            this.maskedTextBox_kitapbasimyili.Mask = "0000";
            this.maskedTextBox_kitapbasimyili.Name = "maskedTextBox_kitapbasimyili";
            this.maskedTextBox_kitapbasimyili.Size = new System.Drawing.Size(303, 30);
            this.maskedTextBox_kitapbasimyili.TabIndex = 2;
            // 
            // label_kitapbasimyili
            // 
            this.label_kitapbasimyili.AutoSize = true;
            this.label_kitapbasimyili.Location = new System.Drawing.Point(30, 320);
            this.label_kitapbasimyili.Name = "label_kitapbasimyili";
            this.label_kitapbasimyili.Size = new System.Drawing.Size(158, 24);
            this.label_kitapbasimyili.TabIndex = 0;
            this.label_kitapbasimyili.Text = "Kitap Basim Yili : ";
            // 
            // label_kitapsayfasayisi
            // 
            this.label_kitapsayfasayisi.AutoSize = true;
            this.label_kitapsayfasayisi.Location = new System.Drawing.Point(13, 285);
            this.label_kitapsayfasayisi.Name = "label_kitapsayfasayisi";
            this.label_kitapsayfasayisi.Size = new System.Drawing.Size(175, 24);
            this.label_kitapsayfasayisi.TabIndex = 0;
            this.label_kitapsayfasayisi.Text = "Kitap Sayfa Sayısı : ";
            // 
            // label_kitapadet
            // 
            this.label_kitapadet.AutoSize = true;
            this.label_kitapadet.Location = new System.Drawing.Point(72, 248);
            this.label_kitapadet.Name = "label_kitapadet";
            this.label_kitapadet.Size = new System.Drawing.Size(116, 24);
            this.label_kitapadet.TabIndex = 0;
            this.label_kitapadet.Text = "Kitap Adet : ";
            // 
            // label_kitaptur
            // 
            this.label_kitaptur.AutoSize = true;
            this.label_kitaptur.Location = new System.Drawing.Point(73, 212);
            this.label_kitaptur.Name = "label_kitaptur";
            this.label_kitaptur.Size = new System.Drawing.Size(115, 24);
            this.label_kitaptur.TabIndex = 0;
            this.label_kitaptur.Text = "Kitap Türü : ";
            // 
            // label_kitapyayinevi
            // 
            this.label_kitapyayinevi.AutoSize = true;
            this.label_kitapyayinevi.Location = new System.Drawing.Point(41, 176);
            this.label_kitapyayinevi.Name = "label_kitapyayinevi";
            this.label_kitapyayinevi.Size = new System.Drawing.Size(147, 24);
            this.label_kitapyayinevi.TabIndex = 0;
            this.label_kitapyayinevi.Text = "Kitap Yayınevi : ";
            // 
            // label_kitapdili
            // 
            this.label_kitapdili.AutoSize = true;
            this.label_kitapdili.Location = new System.Drawing.Point(85, 135);
            this.label_kitapdili.Name = "label_kitapdili";
            this.label_kitapdili.Size = new System.Drawing.Size(103, 24);
            this.label_kitapdili.TabIndex = 0;
            this.label_kitapdili.Text = "Kitap Dili : ";
            // 
            // label_kitapyazar
            // 
            this.label_kitapyazar.AutoSize = true;
            this.label_kitapyazar.Location = new System.Drawing.Point(66, 99);
            this.label_kitapyazar.Name = "label_kitapyazar";
            this.label_kitapyazar.Size = new System.Drawing.Size(122, 24);
            this.label_kitapyazar.TabIndex = 0;
            this.label_kitapyazar.Text = "Kitap Yazar : ";
            // 
            // label_kitapisim
            // 
            this.label_kitapisim.AutoSize = true;
            this.label_kitapisim.Location = new System.Drawing.Point(77, 65);
            this.label_kitapisim.Name = "label_kitapisim";
            this.label_kitapisim.Size = new System.Drawing.Size(111, 24);
            this.label_kitapisim.TabIndex = 0;
            this.label_kitapisim.Text = "Kitap İsim : ";
            // 
            // label_kitapid
            // 
            this.label_kitapid.AutoSize = true;
            this.label_kitapid.Location = new System.Drawing.Point(96, 35);
            this.label_kitapid.Name = "label_kitapid";
            this.label_kitapid.Size = new System.Drawing.Size(92, 24);
            this.label_kitapid.TabIndex = 0;
            this.label_kitapid.Text = "Kitap İd : ";
            // 
            // textBox_kitapsayfasayisi
            // 
            this.textBox_kitapsayfasayisi.Location = new System.Drawing.Point(206, 281);
            this.textBox_kitapsayfasayisi.Name = "textBox_kitapsayfasayisi";
            this.textBox_kitapsayfasayisi.Size = new System.Drawing.Size(303, 30);
            this.textBox_kitapsayfasayisi.TabIndex = 1;
            // 
            // textBox_kitapadet
            // 
            this.textBox_kitapadet.Location = new System.Drawing.Point(206, 245);
            this.textBox_kitapadet.Name = "textBox_kitapadet";
            this.textBox_kitapadet.Size = new System.Drawing.Size(303, 30);
            this.textBox_kitapadet.TabIndex = 1;
            // 
            // textBox_kitaptürü
            // 
            this.textBox_kitaptürü.Location = new System.Drawing.Point(206, 209);
            this.textBox_kitaptürü.Name = "textBox_kitaptürü";
            this.textBox_kitaptürü.Size = new System.Drawing.Size(303, 30);
            this.textBox_kitaptürü.TabIndex = 1;
            // 
            // textBox_kitapdili
            // 
            this.textBox_kitapdili.Location = new System.Drawing.Point(206, 137);
            this.textBox_kitapdili.Name = "textBox_kitapdili";
            this.textBox_kitapdili.Size = new System.Drawing.Size(303, 30);
            this.textBox_kitapdili.TabIndex = 1;
            // 
            // textBox_yayınevi
            // 
            this.textBox_yayınevi.Location = new System.Drawing.Point(206, 173);
            this.textBox_yayınevi.Name = "textBox_yayınevi";
            this.textBox_yayınevi.Size = new System.Drawing.Size(303, 30);
            this.textBox_yayınevi.TabIndex = 1;
            // 
            // textBox_kitapyazar
            // 
            this.textBox_kitapyazar.Location = new System.Drawing.Point(206, 101);
            this.textBox_kitapyazar.Name = "textBox_kitapyazar";
            this.textBox_kitapyazar.Size = new System.Drawing.Size(303, 30);
            this.textBox_kitapyazar.TabIndex = 1;
            // 
            // textBox_kitapisim
            // 
            this.textBox_kitapisim.Location = new System.Drawing.Point(206, 65);
            this.textBox_kitapisim.Name = "textBox_kitapisim";
            this.textBox_kitapisim.Size = new System.Drawing.Size(303, 30);
            this.textBox_kitapisim.TabIndex = 1;
            // 
            // button_ara
            // 
            this.button_ara.Location = new System.Drawing.Point(6, 396);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(75, 39);
            this.button_ara.TabIndex = 4;
            this.button_ara.Text = "Ara";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // button_yenile
            // 
            this.button_yenile.Location = new System.Drawing.Point(85, 396);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(75, 39);
            this.button_yenile.TabIndex = 5;
            this.button_yenile.Text = "yenile";
            this.button_yenile.UseVisualStyleBackColor = true;
            this.button_yenile.Click += new System.EventHandler(this.button_yenile_Click);
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(6, 441);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(155, 30);
            this.textBox_ara.TabIndex = 6;
            // 
            // button_kitapara
            // 
            this.button_kitapara.Location = new System.Drawing.Point(136, 454);
            this.button_kitapara.Name = "button_kitapara";
            this.button_kitapara.Size = new System.Drawing.Size(89, 38);
            this.button_kitapara.TabIndex = 7;
            this.button_kitapara.Text = "ARA";
            this.button_kitapara.UseVisualStyleBackColor = true;
            this.button_kitapara.Click += new System.EventHandler(this.button_kitapara_Click);
            // 
            // button_kitapyenile
            // 
            this.button_kitapyenile.Location = new System.Drawing.Point(446, 457);
            this.button_kitapyenile.Name = "button_kitapyenile";
            this.button_kitapyenile.Size = new System.Drawing.Size(83, 35);
            this.button_kitapyenile.TabIndex = 7;
            this.button_kitapyenile.Text = "YENİLE";
            this.button_kitapyenile.UseVisualStyleBackColor = true;
            this.button_kitapyenile.Click += new System.EventHandler(this.button_kitapyenile_Click);
            // 
            // textBox_kitapara
            // 
            this.textBox_kitapara.Location = new System.Drawing.Point(231, 458);
            this.textBox_kitapara.Multiline = true;
            this.textBox_kitapara.Name = "textBox_kitapara";
            this.textBox_kitapara.Size = new System.Drawing.Size(209, 33);
            this.textBox_kitapara.TabIndex = 8;
            // 
            // button_cikis
            // 
            this.button_cikis.BackColor = System.Drawing.Color.Red;
            this.button_cikis.ForeColor = System.Drawing.SystemColors.Control;
            this.button_cikis.Location = new System.Drawing.Point(562, 27);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(75, 35);
            this.button_cikis.TabIndex = 9;
            this.button_cikis.Text = "Çıkış";
            this.button_cikis.UseVisualStyleBackColor = false;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 780);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_uyeler;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_isim;
        private System.Windows.Forms.Label label_soyisim;
        private System.Windows.Forms.Label label_olusturmatarihi;
        private System.Windows.Forms.Label label_kullaniciadi;
        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.Label label_yetki;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.TextBox textBox_soyisim;
        private System.Windows.Forms.TextBox textBox_kullaniciadi;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.TextBox textBox_yetki;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_olusturmatarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn İD;
        private System.Windows.Forms.DataGridViewTextBoxColumn İSİM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOYİSİM;
        private System.Windows.Forms.DataGridViewTextBoxColumn OLUŞTURMATARİHİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn KULLANİCİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SİFRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn YETKİ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_kitapid;
        private System.Windows.Forms.Label label_kitapbasimyili;
        private System.Windows.Forms.Label label_kitapsayfasayisi;
        private System.Windows.Forms.Label label_kitapadet;
        private System.Windows.Forms.Label label_kitaptur;
        private System.Windows.Forms.Label label_kitapyayinevi;
        private System.Windows.Forms.Label label_kitapdili;
        private System.Windows.Forms.Label label_kitapyazar;
        private System.Windows.Forms.Label label_kitapisim;
        private System.Windows.Forms.TextBox textBox_kitapsayfasayisi;
        private System.Windows.Forms.TextBox textBox_kitapadet;
        private System.Windows.Forms.TextBox textBox_kitaptürü;
        private System.Windows.Forms.TextBox textBox_kitapdili;
        private System.Windows.Forms.TextBox textBox_yayınevi;
        private System.Windows.Forms.TextBox textBox_kitapyazar;
        private System.Windows.Forms.TextBox textBox_kitapisim;
        private System.Windows.Forms.TextBox textBox_kitapid;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_kitapbasimyili;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_kitaplar;
        private System.Windows.Forms.Button button_Kitaptemizle;
        private System.Windows.Forms.Button button_güncelle;
        private System.Windows.Forms.Button button_kitapsil;
        private System.Windows.Forms.Button button_kitapekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapyayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitaptur;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapsayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapbasimyili;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.Button button_yenile;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.TextBox textBox_kitapara;
        private System.Windows.Forms.Button button_kitapyenile;
        private System.Windows.Forms.Button button_kitapara;
        private System.Windows.Forms.Button button_cikis;
    }
}