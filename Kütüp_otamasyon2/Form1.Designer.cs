namespace Kütüp_otamasyon2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_kullanici = new System.Windows.Forms.Label();
            this.label_kullanici_sfr = new System.Windows.Forms.Label();
            this.textBox_Kullanici = new System.Windows.Forms.TextBox();
            this.textBox_sfr = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_kapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüp_otamasyon2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_kullanici
            // 
            this.label_kullanici.AutoSize = true;
            this.label_kullanici.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullanici.Location = new System.Drawing.Point(321, 31);
            this.label_kullanici.Name = "label_kullanici";
            this.label_kullanici.Size = new System.Drawing.Size(102, 25);
            this.label_kullanici.TabIndex = 1;
            this.label_kullanici.Text = "Kullanıcı : ";
            // 
            // label_kullanici_sfr
            // 
            this.label_kullanici_sfr.AutoSize = true;
            this.label_kullanici_sfr.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullanici_sfr.Location = new System.Drawing.Point(355, 86);
            this.label_kullanici_sfr.Name = "label_kullanici_sfr";
            this.label_kullanici_sfr.Size = new System.Drawing.Size(68, 25);
            this.label_kullanici_sfr.TabIndex = 1;
            this.label_kullanici_sfr.Text = "Şifre : ";
            // 
            // textBox_Kullanici
            // 
            this.textBox_Kullanici.Location = new System.Drawing.Point(437, 31);
            this.textBox_Kullanici.Multiline = true;
            this.textBox_Kullanici.Name = "textBox_Kullanici";
            this.textBox_Kullanici.Size = new System.Drawing.Size(241, 30);
            this.textBox_Kullanici.TabIndex = 0;
            this.textBox_Kullanici.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_sfr
            // 
            this.textBox_sfr.Location = new System.Drawing.Point(437, 86);
            this.textBox_sfr.Multiline = true;
            this.textBox_sfr.Name = "textBox_sfr";
            this.textBox_sfr.Size = new System.Drawing.Size(241, 32);
            this.textBox_sfr.TabIndex = 1;
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.Location = new System.Drawing.Point(438, 150);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(117, 40);
            this.button_giris.TabIndex = 2;
            this.button_giris.Text = "GİRİŞ";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // button_Temizle
            // 
            this.button_Temizle.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Temizle.Location = new System.Drawing.Point(561, 150);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(117, 40);
            this.button_Temizle.TabIndex = 3;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_kapat
            // 
            this.button_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_kapat.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kapat.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_kapat.Location = new System.Drawing.Point(471, 214);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(171, 40);
            this.button_kapat.TabIndex = 4;
            this.button_kapat.Text = "App\'i Kapa";
            this.button_kapat.UseVisualStyleBackColor = false;
            this.button_kapat.Click += new System.EventHandler(this.button_kapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 266);
            this.Controls.Add(this.button_kapat);
            this.Controls.Add(this.button_Temizle);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_sfr);
            this.Controls.Add(this.textBox_Kullanici);
            this.Controls.Add(this.label_kullanici_sfr);
            this.Controls.Add(this.label_kullanici);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_kullanici;
        private System.Windows.Forms.Label label_kullanici_sfr;
        private System.Windows.Forms.TextBox textBox_Kullanici;
        private System.Windows.Forms.TextBox textBox_sfr;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_kapat;
    }
}

