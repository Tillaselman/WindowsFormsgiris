namespace Kütüp_otamasyon2
{
    partial class uye
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
            this.groupBox_kitap_uye_islemleri = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_uye_ara = new System.Windows.Forms.Button();
            this.textBox_uye_kitap_ara = new System.Windows.Forms.TextBox();
            this.button_uye_yenile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaptürü = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kitapadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapsayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapbasimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_cikis = new System.Windows.Forms.Button();
            this.groupBox_kitap_uye_islemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_kitap_uye_islemleri
            // 
            this.groupBox_kitap_uye_islemleri.Controls.Add(this.button_cikis);
            this.groupBox_kitap_uye_islemleri.Controls.Add(this.dataGridView1);
            this.groupBox_kitap_uye_islemleri.Controls.Add(this.button_uye_yenile);
            this.groupBox_kitap_uye_islemleri.Controls.Add(this.textBox_uye_kitap_ara);
            this.groupBox_kitap_uye_islemleri.Controls.Add(this.button_uye_ara);
            this.groupBox_kitap_uye_islemleri.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_kitap_uye_islemleri.Location = new System.Drawing.Point(12, 12);
            this.groupBox_kitap_uye_islemleri.Name = "groupBox_kitap_uye_islemleri";
            this.groupBox_kitap_uye_islemleri.Size = new System.Drawing.Size(1159, 638);
            this.groupBox_kitap_uye_islemleri.TabIndex = 0;
            this.groupBox_kitap_uye_islemleri.TabStop = false;
            this.groupBox_kitap_uye_islemleri.Text = "kitap uye islemleri:";
            // 
            // button_uye_ara
            // 
            this.button_uye_ara.Location = new System.Drawing.Point(302, 39);
            this.button_uye_ara.Name = "button_uye_ara";
            this.button_uye_ara.Size = new System.Drawing.Size(116, 34);
            this.button_uye_ara.TabIndex = 0;
            this.button_uye_ara.Text = "Kitap Ara :";
            this.button_uye_ara.UseVisualStyleBackColor = true;
            this.button_uye_ara.Click += new System.EventHandler(this.button_uye_ara_Click);
            // 
            // textBox_uye_kitap_ara
            // 
            this.textBox_uye_kitap_ara.Location = new System.Drawing.Point(424, 43);
            this.textBox_uye_kitap_ara.Name = "textBox_uye_kitap_ara";
            this.textBox_uye_kitap_ara.Size = new System.Drawing.Size(285, 30);
            this.textBox_uye_kitap_ara.TabIndex = 1;
            // 
            // button_uye_yenile
            // 
            this.button_uye_yenile.Location = new System.Drawing.Point(715, 39);
            this.button_uye_yenile.Name = "button_uye_yenile";
            this.button_uye_yenile.Size = new System.Drawing.Size(116, 34);
            this.button_uye_yenile.TabIndex = 2;
            this.button_uye_yenile.Text = "Yenile";
            this.button_uye_yenile.UseVisualStyleBackColor = true;
            this.button_uye_yenile.Click += new System.EventHandler(this.button_uye_yenile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.kitapyayinevi,
            this.kitaptürü,
            this.Kitapadet,
            this.kitapsayfasayisi,
            this.kitapbasimyili});
            this.dataGridView1.Location = new System.Drawing.Point(6, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 489);
            this.dataGridView1.TabIndex = 3;
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "Kitap Id :";
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
            this.kitapyazar.HeaderText = "Kitap Yazar : ";
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
            // kitapyayinevi
            // 
            this.kitapyayinevi.HeaderText = "kitap Yayınevi :";
            this.kitapyayinevi.MinimumWidth = 6;
            this.kitapyayinevi.Name = "kitapyayinevi";
            this.kitapyayinevi.Width = 125;
            // 
            // kitaptürü
            // 
            this.kitaptürü.HeaderText = "Kitap Türü :";
            this.kitaptürü.MinimumWidth = 6;
            this.kitaptürü.Name = "kitaptürü";
            this.kitaptürü.Width = 125;
            // 
            // Kitapadet
            // 
            this.Kitapadet.HeaderText = "kitap Adet :";
            this.Kitapadet.MinimumWidth = 6;
            this.Kitapadet.Name = "Kitapadet";
            this.Kitapadet.Width = 125;
            // 
            // kitapsayfasayisi
            // 
            this.kitapsayfasayisi.HeaderText = "kitap Sayfa Sayısı : ";
            this.kitapsayfasayisi.MinimumWidth = 6;
            this.kitapsayfasayisi.Name = "kitapsayfasayisi";
            this.kitapsayfasayisi.Width = 125;
            // 
            // kitapbasimyili
            // 
            this.kitapbasimyili.HeaderText = "Kitap Basım Yılı :";
            this.kitapbasimyili.MinimumWidth = 6;
            this.kitapbasimyili.Name = "kitapbasimyili";
            this.kitapbasimyili.Width = 125;
            // 
            // button_cikis
            // 
            this.button_cikis.Location = new System.Drawing.Point(6, 587);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(173, 45);
            this.button_cikis.TabIndex = 4;
            this.button_cikis.Text = "Çıkış";
            this.button_cikis.UseVisualStyleBackColor = true;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // uye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 662);
            this.Controls.Add(this.groupBox_kitap_uye_islemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "uye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uye";
            this.Load += new System.EventHandler(this.uye_Load);
            this.groupBox_kitap_uye_islemleri.ResumeLayout(false);
            this.groupBox_kitap_uye_islemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_kitap_uye_islemleri;
        private System.Windows.Forms.Button button_uye_ara;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_uye_yenile;
        private System.Windows.Forms.TextBox textBox_uye_kitap_ara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitaptürü;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapadet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapsayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapbasimyili;
        private System.Windows.Forms.Button button_cikis;
    }
}