namespace KÜTÜP_OTAMASYON_GİRİS
{
    partial class Kullanici_giris_form
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
            this.Kullanici_label = new System.Windows.Forms.Label();
            this.Şifre_label = new System.Windows.Forms.Label();
            this.button_giris = new System.Windows.Forms.Button();
            this.textBox_Kullanici = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KÜTÜP_OTAMASYON_GİRİS.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(21, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Kullanici_label
            // 
            this.Kullanici_label.AutoSize = true;
            this.Kullanici_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_label.Location = new System.Drawing.Point(341, 66);
            this.Kullanici_label.Name = "Kullanici_label";
            this.Kullanici_label.Size = new System.Drawing.Size(107, 25);
            this.Kullanici_label.TabIndex = 1;
            this.Kullanici_label.Text = "Kullanıcı :";
            // 
            // Şifre_label
            // 
            this.Şifre_label.AutoSize = true;
            this.Şifre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Şifre_label.Location = new System.Drawing.Point(378, 144);
            this.Şifre_label.Name = "Şifre_label";
            this.Şifre_label.Size = new System.Drawing.Size(70, 25);
            this.Şifre_label.TabIndex = 1;
            this.Şifre_label.Text = "Şifre :";
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.Location = new System.Drawing.Point(454, 209);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(156, 36);
            this.button_giris.TabIndex = 2;
            this.button_giris.Text = "Giris";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // textBox_Kullanici
            // 
            this.textBox_Kullanici.Location = new System.Drawing.Point(454, 70);
            this.textBox_Kullanici.Multiline = true;
            this.textBox_Kullanici.Name = "textBox_Kullanici";
            this.textBox_Kullanici.Size = new System.Drawing.Size(156, 40);
            this.textBox_Kullanici.TabIndex = 0;
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(454, 144);
            this.textBox_Sifre.Multiline = true;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(156, 40);
            this.textBox_Sifre.TabIndex = 1;
            // 
            // Kullanici_giris_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 326);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_Kullanici);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.Şifre_label);
            this.Controls.Add(this.Kullanici_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kullanici_giris_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Kullanici_giris_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Kullanici_label;
        private System.Windows.Forms.Label Şifre_label;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.TextBox textBox_Kullanici;
        private System.Windows.Forms.TextBox textBox_Sifre;
    }
}

