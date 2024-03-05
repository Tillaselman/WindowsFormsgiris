namespace KÜTÜP_OTAMASYON_GİRİS
{
    partial class arayüz
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
            this.cıkıs_button = new System.Windows.Forms.Button();
            this.tabControl1_arayüz = new System.Windows.Forms.TabControl();
            this.tabPage1_kitap_islemleri = new System.Windows.Forms.TabPage();
            this.tabPage2_kullanici_islemleri = new System.Windows.Forms.TabPage();
            this.label_kuli_isim = new System.Windows.Forms.Label();
            this.label_kuli_soyisim = new System.Windows.Forms.Label();
            this.label_kuli_kütüphane_No = new System.Windows.Forms.Label();
            this.textBox_kuli_isim = new System.Windows.Forms.TextBox();
            this.textBox_kuli_soyisim = new System.Windows.Forms.TextBox();
            this.textBox_kuli_kütüpno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_kuli_goster = new System.Windows.Forms.Button();
            this.button_kuli_ekle = new System.Windows.Forms.Button();
            this.button_kuli_sil = new System.Windows.Forms.Button();
            this.button_kuli_Guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KÜTÜPNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1_arayüz.SuspendLayout();
            this.tabPage2_kullanici_islemleri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cıkıs_button
            // 
            this.cıkıs_button.BackColor = System.Drawing.Color.Red;
            this.cıkıs_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkıs_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cıkıs_button.Location = new System.Drawing.Point(961, 717);
            this.cıkıs_button.Name = "cıkıs_button";
            this.cıkıs_button.Size = new System.Drawing.Size(151, 52);
            this.cıkıs_button.TabIndex = 0;
            this.cıkıs_button.Text = "çıkış";
            this.cıkıs_button.UseVisualStyleBackColor = false;
            this.cıkıs_button.Click += new System.EventHandler(this.cıkıs_button_Click);
            // 
            // tabControl1_arayüz
            // 
            this.tabControl1_arayüz.Controls.Add(this.tabPage1_kitap_islemleri);
            this.tabControl1_arayüz.Controls.Add(this.tabPage2_kullanici_islemleri);
            this.tabControl1_arayüz.Location = new System.Drawing.Point(3, 4);
            this.tabControl1_arayüz.Name = "tabControl1_arayüz";
            this.tabControl1_arayüz.SelectedIndex = 0;
            this.tabControl1_arayüz.Size = new System.Drawing.Size(1124, 702);
            this.tabControl1_arayüz.TabIndex = 1;
            // 
            // tabPage1_kitap_islemleri
            // 
            this.tabPage1_kitap_islemleri.Location = new System.Drawing.Point(4, 25);
            this.tabPage1_kitap_islemleri.Name = "tabPage1_kitap_islemleri";
            this.tabPage1_kitap_islemleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_kitap_islemleri.Size = new System.Drawing.Size(1116, 673);
            this.tabPage1_kitap_islemleri.TabIndex = 0;
            this.tabPage1_kitap_islemleri.Text = "Kitap İşlemleri";
            this.tabPage1_kitap_islemleri.UseVisualStyleBackColor = true;
            // 
            // tabPage2_kullanici_islemleri
            // 
            this.tabPage2_kullanici_islemleri.Controls.Add(this.groupBox1);
            this.tabPage2_kullanici_islemleri.Location = new System.Drawing.Point(4, 25);
            this.tabPage2_kullanici_islemleri.Name = "tabPage2_kullanici_islemleri";
            this.tabPage2_kullanici_islemleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_kullanici_islemleri.Size = new System.Drawing.Size(1116, 673);
            this.tabPage2_kullanici_islemleri.TabIndex = 1;
            this.tabPage2_kullanici_islemleri.Text = "Kullanıcı İslemleri";
            this.tabPage2_kullanici_islemleri.UseVisualStyleBackColor = true;
            // 
            // label_kuli_isim
            // 
            this.label_kuli_isim.AutoSize = true;
            this.label_kuli_isim.BackColor = System.Drawing.Color.Transparent;
            this.label_kuli_isim.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kuli_isim.Location = new System.Drawing.Point(20, 28);
            this.label_kuli_isim.Name = "label_kuli_isim";
            this.label_kuli_isim.Size = new System.Drawing.Size(67, 27);
            this.label_kuli_isim.TabIndex = 1;
            this.label_kuli_isim.Text = "İsim :";
            // 
            // label_kuli_soyisim
            // 
            this.label_kuli_soyisim.AutoSize = true;
            this.label_kuli_soyisim.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kuli_soyisim.Location = new System.Drawing.Point(20, 71);
            this.label_kuli_soyisim.Name = "label_kuli_soyisim";
            this.label_kuli_soyisim.Size = new System.Drawing.Size(102, 27);
            this.label_kuli_soyisim.TabIndex = 1;
            this.label_kuli_soyisim.Text = "Soyisim :";
            // 
            // label_kuli_kütüphane_No
            // 
            this.label_kuli_kütüphane_No.AutoSize = true;
            this.label_kuli_kütüphane_No.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kuli_kütüphane_No.Location = new System.Drawing.Point(20, 118);
            this.label_kuli_kütüphane_No.Name = "label_kuli_kütüphane_No";
            this.label_kuli_kütüphane_No.Size = new System.Drawing.Size(171, 27);
            this.label_kuli_kütüphane_No.TabIndex = 1;
            this.label_kuli_kütüphane_No.Text = "Kütüphane No :";
            // 
            // textBox_kuli_isim
            // 
            this.textBox_kuli_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_kuli_isim.Location = new System.Drawing.Point(209, 32);
            this.textBox_kuli_isim.Multiline = true;
            this.textBox_kuli_isim.Name = "textBox_kuli_isim";
            this.textBox_kuli_isim.Size = new System.Drawing.Size(189, 23);
            this.textBox_kuli_isim.TabIndex = 0;
            // 
            // textBox_kuli_soyisim
            // 
            this.textBox_kuli_soyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_kuli_soyisim.Location = new System.Drawing.Point(209, 75);
            this.textBox_kuli_soyisim.Multiline = true;
            this.textBox_kuli_soyisim.Name = "textBox_kuli_soyisim";
            this.textBox_kuli_soyisim.Size = new System.Drawing.Size(189, 23);
            this.textBox_kuli_soyisim.TabIndex = 1;
            // 
            // textBox_kuli_kütüpno
            // 
            this.textBox_kuli_kütüpno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_kuli_kütüpno.Location = new System.Drawing.Point(209, 118);
            this.textBox_kuli_kütüpno.Multiline = true;
            this.textBox_kuli_kütüpno.Name = "textBox_kuli_kütüpno";
            this.textBox_kuli_kütüpno.Size = new System.Drawing.Size(189, 27);
            this.textBox_kuli_kütüpno.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_kuli_Guncelle);
            this.groupBox1.Controls.Add(this.button_kuli_sil);
            this.groupBox1.Controls.Add(this.button_kuli_ekle);
            this.groupBox1.Controls.Add(this.button_kuli_goster);
            this.groupBox1.Controls.Add(this.textBox_kuli_isim);
            this.groupBox1.Controls.Add(this.textBox_kuli_kütüpno);
            this.groupBox1.Controls.Add(this.label_kuli_isim);
            this.groupBox1.Controls.Add(this.textBox_kuli_soyisim);
            this.groupBox1.Controls.Add(this.label_kuli_soyisim);
            this.groupBox1.Controls.Add(this.label_kuli_kütüphane_No);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 661);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Kayıt İşlemleri";
            // 
            // button_kuli_goster
            // 
            this.button_kuli_goster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_kuli_goster.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kuli_goster.Location = new System.Drawing.Point(209, 158);
            this.button_kuli_goster.Name = "button_kuli_goster";
            this.button_kuli_goster.Size = new System.Drawing.Size(193, 44);
            this.button_kuli_goster.TabIndex = 3;
            this.button_kuli_goster.Text = "Göster";
            this.button_kuli_goster.UseVisualStyleBackColor = false;
            this.button_kuli_goster.Click += new System.EventHandler(this.button_kuli_goster_Click);
            // 
            // button_kuli_ekle
            // 
            this.button_kuli_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_kuli_ekle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kuli_ekle.Location = new System.Drawing.Point(209, 208);
            this.button_kuli_ekle.Name = "button_kuli_ekle";
            this.button_kuli_ekle.Size = new System.Drawing.Size(193, 44);
            this.button_kuli_ekle.TabIndex = 4;
            this.button_kuli_ekle.Text = "Ekle";
            this.button_kuli_ekle.UseVisualStyleBackColor = false;
            this.button_kuli_ekle.Click += new System.EventHandler(this.button_kuli_ekle_Click);
            // 
            // button_kuli_sil
            // 
            this.button_kuli_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_kuli_sil.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kuli_sil.Location = new System.Drawing.Point(209, 258);
            this.button_kuli_sil.Name = "button_kuli_sil";
            this.button_kuli_sil.Size = new System.Drawing.Size(193, 44);
            this.button_kuli_sil.TabIndex = 5;
            this.button_kuli_sil.Text = "Sil";
            this.button_kuli_sil.UseVisualStyleBackColor = false;
            this.button_kuli_sil.Click += new System.EventHandler(this.button_kuli_sil_Click);
            // 
            // button_kuli_Guncelle
            // 
            this.button_kuli_Guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_kuli_Guncelle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kuli_Guncelle.Location = new System.Drawing.Point(209, 308);
            this.button_kuli_Guncelle.Name = "button_kuli_Guncelle";
            this.button_kuli_Guncelle.Size = new System.Drawing.Size(193, 44);
            this.button_kuli_Guncelle.TabIndex = 6;
            this.button_kuli_Guncelle.Text = "Güncelle";
            this.button_kuli_Guncelle.UseVisualStyleBackColor = false;
            this.button_kuli_Guncelle.Click += new System.EventHandler(this.button_kuli_Guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KÜTÜPNO,
            this.isim,
            this.Soyisim});
            this.dataGridView1.Location = new System.Drawing.Point(25, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(476, 251);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KÜTÜPNO
            // 
            this.KÜTÜPNO.HeaderText = "Kütüphane NO";
            this.KÜTÜPNO.MinimumWidth = 6;
            this.KÜTÜPNO.Name = "KÜTÜPNO";
            this.KÜTÜPNO.Width = 125;
            // 
            // isim
            // 
            this.isim.HeaderText = "İsim";
            this.isim.MinimumWidth = 6;
            this.isim.Name = "isim";
            this.isim.Width = 125;
            // 
            // Soyisim
            // 
            this.Soyisim.HeaderText = "Soyisim";
            this.Soyisim.MinimumWidth = 6;
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Width = 125;
            // 
            // arayüz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 781);
            this.Controls.Add(this.cıkıs_button);
            this.Controls.Add(this.tabControl1_arayüz);
            this.MaximumSize = new System.Drawing.Size(1142, 828);
            this.MinimumSize = new System.Drawing.Size(1142, 828);
            this.Name = "arayüz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arayüz";
            this.Load += new System.EventHandler(this.arayüz_Load);
            this.tabControl1_arayüz.ResumeLayout(false);
            this.tabPage2_kullanici_islemleri.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cıkıs_button;
        private System.Windows.Forms.TabControl tabControl1_arayüz;
        private System.Windows.Forms.TabPage tabPage1_kitap_islemleri;
        private System.Windows.Forms.TabPage tabPage2_kullanici_islemleri;
        private System.Windows.Forms.Label label_kuli_kütüphane_No;
        private System.Windows.Forms.Label label_kuli_soyisim;
        private System.Windows.Forms.Label label_kuli_isim;
        private System.Windows.Forms.TextBox textBox_kuli_kütüpno;
        private System.Windows.Forms.TextBox textBox_kuli_soyisim;
        private System.Windows.Forms.TextBox textBox_kuli_isim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_kuli_Guncelle;
        private System.Windows.Forms.Button button_kuli_sil;
        private System.Windows.Forms.Button button_kuli_ekle;
        private System.Windows.Forms.Button button_kuli_goster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KÜTÜPNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyisim;
    }
}