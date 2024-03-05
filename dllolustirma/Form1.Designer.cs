namespace dllolustirma
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
            this.sayı1label = new System.Windows.Forms.Label();
            this.sayi2label = new System.Windows.Forms.Label();
            this.sayı1textbox = new System.Windows.Forms.TextBox();
            this.sayı2textbox = new System.Windows.Forms.TextBox();
            this.toplabtn = new System.Windows.Forms.Button();
            this.cıkarbtn = new System.Windows.Forms.Button();
            this.carpbtn = new System.Windows.Forms.Button();
            this.bolbtn = new System.Windows.Forms.Button();
            this.sonuclabel = new System.Windows.Forms.Label();
            this.sonucdegerlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sayı1label
            // 
            this.sayı1label.AutoSize = true;
            this.sayı1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı1label.Location = new System.Drawing.Point(27, 38);
            this.sayı1label.Name = "sayı1label";
            this.sayı1label.Size = new System.Drawing.Size(86, 25);
            this.sayı1label.TabIndex = 0;
            this.sayı1label.Text = "Sayı 1 :";
            // 
            // sayi2label
            // 
            this.sayi2label.AutoSize = true;
            this.sayi2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi2label.Location = new System.Drawing.Point(27, 97);
            this.sayi2label.Name = "sayi2label";
            this.sayi2label.Size = new System.Drawing.Size(86, 25);
            this.sayi2label.TabIndex = 1;
            this.sayi2label.Text = "Sayı 2 :";
            // 
            // sayı1textbox
            // 
            this.sayı1textbox.Location = new System.Drawing.Point(119, 42);
            this.sayı1textbox.Name = "sayı1textbox";
            this.sayı1textbox.Size = new System.Drawing.Size(100, 22);
            this.sayı1textbox.TabIndex = 2;
            // 
            // sayı2textbox
            // 
            this.sayı2textbox.Location = new System.Drawing.Point(119, 97);
            this.sayı2textbox.Name = "sayı2textbox";
            this.sayı2textbox.Size = new System.Drawing.Size(100, 22);
            this.sayı2textbox.TabIndex = 2;
            // 
            // toplabtn
            // 
            this.toplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplabtn.Location = new System.Drawing.Point(26, 165);
            this.toplabtn.Name = "toplabtn";
            this.toplabtn.Size = new System.Drawing.Size(71, 31);
            this.toplabtn.TabIndex = 3;
            this.toplabtn.Text = "+";
            this.toplabtn.UseVisualStyleBackColor = true;
            this.toplabtn.Click += new System.EventHandler(this.toplabtn_Click);
            // 
            // cıkarbtn
            // 
            this.cıkarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkarbtn.Location = new System.Drawing.Point(103, 165);
            this.cıkarbtn.Name = "cıkarbtn";
            this.cıkarbtn.Size = new System.Drawing.Size(71, 31);
            this.cıkarbtn.TabIndex = 3;
            this.cıkarbtn.Text = "-";
            this.cıkarbtn.UseVisualStyleBackColor = true;
            this.cıkarbtn.Click += new System.EventHandler(this.cıkarbtn_Click);
            // 
            // carpbtn
            // 
            this.carpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpbtn.Location = new System.Drawing.Point(180, 165);
            this.carpbtn.Name = "carpbtn";
            this.carpbtn.Size = new System.Drawing.Size(71, 31);
            this.carpbtn.TabIndex = 3;
            this.carpbtn.Text = "X";
            this.carpbtn.UseVisualStyleBackColor = true;
            this.carpbtn.Click += new System.EventHandler(this.carpbtn_Click);
            // 
            // bolbtn
            // 
            this.bolbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolbtn.Location = new System.Drawing.Point(257, 165);
            this.bolbtn.Name = "bolbtn";
            this.bolbtn.Size = new System.Drawing.Size(71, 31);
            this.bolbtn.TabIndex = 3;
            this.bolbtn.Text = "/";
            this.bolbtn.UseVisualStyleBackColor = true;
            this.bolbtn.Click += new System.EventHandler(this.bolbtn_Click);
            // 
            // sonuclabel
            // 
            this.sonuclabel.AutoSize = true;
            this.sonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclabel.Location = new System.Drawing.Point(34, 132);
            this.sonuclabel.Name = "sonuclabel";
            this.sonuclabel.Size = new System.Drawing.Size(79, 20);
            this.sonuclabel.TabIndex = 5;
            this.sonuclabel.Text = "Sonuç : ";
            // 
            // sonucdegerlabel
            // 
            this.sonucdegerlabel.AutoSize = true;
            this.sonucdegerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucdegerlabel.Location = new System.Drawing.Point(153, 132);
            this.sonucdegerlabel.Name = "sonucdegerlabel";
            this.sonucdegerlabel.Size = new System.Drawing.Size(21, 22);
            this.sonucdegerlabel.TabIndex = 6;
            this.sonucdegerlabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 239);
            this.Controls.Add(this.sonucdegerlabel);
            this.Controls.Add(this.sonuclabel);
            this.Controls.Add(this.bolbtn);
            this.Controls.Add(this.carpbtn);
            this.Controls.Add(this.cıkarbtn);
            this.Controls.Add(this.toplabtn);
            this.Controls.Add(this.sayı2textbox);
            this.Controls.Add(this.sayı1textbox);
            this.Controls.Add(this.sayi2label);
            this.Controls.Add(this.sayı1label);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayı1label;
        private System.Windows.Forms.Label sayi2label;
        private System.Windows.Forms.TextBox sayı1textbox;
        private System.Windows.Forms.TextBox sayı2textbox;
        private System.Windows.Forms.Button toplabtn;
        private System.Windows.Forms.Button cıkarbtn;
        private System.Windows.Forms.Button carpbtn;
        private System.Windows.Forms.Button bolbtn;
        private System.Windows.Forms.Label sonuclabel;
        private System.Windows.Forms.Label sonucdegerlabel;
    }
}

