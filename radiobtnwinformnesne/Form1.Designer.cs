namespace radiobtnwinformnesne
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.radioButtonerkek = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonkadın = new System.Windows.Forms.RadioButton();
            this.devambtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(87, 48);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(220, 22);
            this.textad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadınız : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 22);
            this.textBox3.TabIndex = 1;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(87, 76);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(220, 22);
            this.textsoyad.TabIndex = 1;
            // 
            // radioButtonerkek
            // 
            this.radioButtonerkek.AutoSize = true;
            this.radioButtonerkek.Location = new System.Drawing.Point(87, 143);
            this.radioButtonerkek.Name = "radioButtonerkek";
            this.radioButtonerkek.Size = new System.Drawing.Size(63, 20);
            this.radioButtonerkek.TabIndex = 2;
            this.radioButtonerkek.TabStop = true;
            this.radioButtonerkek.Text = "Erkek";
            this.radioButtonerkek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(123, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "cinsiyetiniz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButtonkadın
            // 
            this.radioButtonkadın.AutoSize = true;
            this.radioButtonkadın.Location = new System.Drawing.Point(244, 143);
            this.radioButtonkadın.Name = "radioButtonkadın";
            this.radioButtonkadın.Size = new System.Drawing.Size(61, 20);
            this.radioButtonkadın.TabIndex = 3;
            this.radioButtonkadın.TabStop = true;
            this.radioButtonkadın.Text = "kadın";
            this.radioButtonkadın.UseVisualStyleBackColor = true;
            this.radioButtonkadın.CheckedChanged += new System.EventHandler(this.radioButtonkadın_CheckedChanged);
            // 
            // devambtn
            // 
            this.devambtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devambtn.Location = new System.Drawing.Point(101, 183);
            this.devambtn.Name = "devambtn";
            this.devambtn.Size = new System.Drawing.Size(183, 41);
            this.devambtn.TabIndex = 4;
            this.devambtn.Text = "DEVAM";
            this.devambtn.UseVisualStyleBackColor = true;
            this.devambtn.Click += new System.EventHandler(this.devambtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 297);
            this.Controls.Add(this.devambtn);
            this.Controls.Add(this.radioButtonkadın);
            this.Controls.Add(this.radioButtonerkek);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.RadioButton radioButtonerkek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonkadın;
        private System.Windows.Forms.Button devambtn;
    }
}

