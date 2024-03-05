namespace listbox
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
            this.label1 = new System.Windows.Forms.Label();
            this.texdegerbox = new System.Windows.Forms.TextBox();
            this.eklebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.elemansayi = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.indexbulbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "eklemek istediğiniz değeri girin :";
            // 
            // texdegerbox
            // 
            this.texdegerbox.Location = new System.Drawing.Point(346, 12);
            this.texdegerbox.Multiline = true;
            this.texdegerbox.Name = "texdegerbox";
            this.texdegerbox.Size = new System.Drawing.Size(267, 34);
            this.texdegerbox.TabIndex = 1;
            this.texdegerbox.TextChanged += new System.EventHandler(this.texdegerbox_TextChanged);
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(346, 52);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(267, 57);
            this.eklebtn.TabIndex = 2;
            this.eklebtn.Text = "ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(346, 115);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(267, 57);
            this.silbtn.TabIndex = 2;
            this.silbtn.Text = "Seçileni Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // elemansayi
            // 
            this.elemansayi.Location = new System.Drawing.Point(346, 241);
            this.elemansayi.Name = "elemansayi";
            this.elemansayi.Size = new System.Drawing.Size(267, 57);
            this.elemansayi.TabIndex = 2;
            this.elemansayi.Text = "eleman sayısı";
            this.elemansayi.UseVisualStyleBackColor = true;
            this.elemansayi.Click += new System.EventHandler(this.bulbtn_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(346, 178);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(267, 57);
            this.temizlebtn.TabIndex = 2;
            this.temizlebtn.Text = "Tümünü Temizle";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.temizlebtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 52);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(274, 324);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(346, 367);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(267, 57);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Çıkış";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // indexbulbtn
            // 
            this.indexbulbtn.Location = new System.Drawing.Point(346, 304);
            this.indexbulbtn.Name = "indexbulbtn";
            this.indexbulbtn.Size = new System.Drawing.Size(267, 57);
            this.indexbulbtn.TabIndex = 4;
            this.indexbulbtn.Text = "index bul";
            this.indexbulbtn.UseVisualStyleBackColor = true;
            this.indexbulbtn.Click += new System.EventHandler(this.indexbulbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(634, 465);
            this.Controls.Add(this.indexbulbtn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.temizlebtn);
            this.Controls.Add(this.elemansayi);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.texdegerbox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texdegerbox;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button elemansayi;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button indexbulbtn;
    }
}

