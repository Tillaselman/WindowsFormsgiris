namespace checkboxwinforms
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
            this.çaychackbox = new System.Windows.Forms.CheckBox();
            this.kahvecheckBox = new System.Windows.Forms.CheckBox();
            this.hesapla_btn = new System.Windows.Forms.Button();
            this.tutar_label = new System.Windows.Forms.Label();
            this.toptutlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // çaychackbox
            // 
            this.çaychackbox.AutoSize = true;
            this.çaychackbox.Location = new System.Drawing.Point(46, 42);
            this.çaychackbox.Name = "çaychackbox";
            this.çaychackbox.Size = new System.Drawing.Size(73, 20);
            this.çaychackbox.TabIndex = 0;
            this.çaychackbox.Text = "çay : 2tl";
            this.çaychackbox.UseVisualStyleBackColor = true;
            this.çaychackbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // kahvecheckBox
            // 
            this.kahvecheckBox.AutoSize = true;
            this.kahvecheckBox.Location = new System.Drawing.Point(46, 68);
            this.kahvecheckBox.Name = "kahvecheckBox";
            this.kahvecheckBox.Size = new System.Drawing.Size(88, 20);
            this.kahvecheckBox.TabIndex = 0;
            this.kahvecheckBox.Text = "kahve : 4tl";
            this.kahvecheckBox.UseVisualStyleBackColor = true;
            // 
            // hesapla_btn
            // 
            this.hesapla_btn.Location = new System.Drawing.Point(46, 112);
            this.hesapla_btn.Name = "hesapla_btn";
            this.hesapla_btn.Size = new System.Drawing.Size(75, 23);
            this.hesapla_btn.TabIndex = 1;
            this.hesapla_btn.Text = "hesapla";
            this.hesapla_btn.UseVisualStyleBackColor = true;
            this.hesapla_btn.Click += new System.EventHandler(this.hesapla_btn_Click);
            // 
            // tutar_label
            // 
            this.tutar_label.AutoSize = true;
            this.tutar_label.Location = new System.Drawing.Point(194, 42);
            this.tutar_label.Name = "tutar_label";
            this.tutar_label.Size = new System.Drawing.Size(41, 16);
            this.tutar_label.TabIndex = 3;
            this.tutar_label.Text = "tutar : ";
            // 
            // toptutlabel
            // 
            this.toptutlabel.AutoSize = true;
            this.toptutlabel.Location = new System.Drawing.Point(241, 42);
            this.toptutlabel.Name = "toptutlabel";
            this.toptutlabel.Size = new System.Drawing.Size(14, 16);
            this.toptutlabel.TabIndex = 4;
            this.toptutlabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 228);
            this.Controls.Add(this.toptutlabel);
            this.Controls.Add(this.tutar_label);
            this.Controls.Add(this.hesapla_btn);
            this.Controls.Add(this.kahvecheckBox);
            this.Controls.Add(this.çaychackbox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox çaychackbox;
        private System.Windows.Forms.CheckBox kahvecheckBox;
        private System.Windows.Forms.Button hesapla_btn;
        private System.Windows.Forms.Label tutar_label;
        private System.Windows.Forms.Label toptutlabel;
    }
}

