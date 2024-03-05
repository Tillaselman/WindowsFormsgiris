namespace timernesnesi
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
            this.components = new System.ComponentModel.Container();
            this.startbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelgerisayim = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saatlabel = new System.Windows.Forms.Label();
            this.dakikalabel = new System.Windows.Forms.Label();
            this.saniyelabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(70, 105);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(114, 52);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "başla";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "gerisayım :";
            // 
            // labelgerisayim
            // 
            this.labelgerisayim.AutoSize = true;
            this.labelgerisayim.Location = new System.Drawing.Point(140, 42);
            this.labelgerisayim.Name = "labelgerisayim";
            this.labelgerisayim.Size = new System.Drawing.Size(21, 16);
            this.labelgerisayim.TabIndex = 2;
            this.labelgerisayim.Text = "20";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saatlabel
            // 
            this.saatlabel.AutoSize = true;
            this.saatlabel.Location = new System.Drawing.Point(17, 206);
            this.saatlabel.Name = "saatlabel";
            this.saatlabel.Size = new System.Drawing.Size(44, 16);
            this.saatlabel.TabIndex = 3;
            this.saatlabel.Text = "label2";
            // 
            // dakikalabel
            // 
            this.dakikalabel.AutoSize = true;
            this.dakikalabel.Location = new System.Drawing.Point(67, 206);
            this.dakikalabel.Name = "dakikalabel";
            this.dakikalabel.Size = new System.Drawing.Size(44, 16);
            this.dakikalabel.TabIndex = 3;
            this.dakikalabel.Text = "label2";
            // 
            // saniyelabel
            // 
            this.saniyelabel.AutoSize = true;
            this.saniyelabel.Location = new System.Drawing.Point(117, 206);
            this.saniyelabel.Name = "saniyelabel";
            this.saniyelabel.Size = new System.Drawing.Size(44, 16);
            this.saniyelabel.TabIndex = 3;
            this.saniyelabel.Text = "label2";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "saat timer2 ile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saniyelabel);
            this.Controls.Add(this.dakikalabel);
            this.Controls.Add(this.saatlabel);
            this.Controls.Add(this.labelgerisayim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelgerisayim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saatlabel;
        private System.Windows.Forms.Label dakikalabel;
        private System.Windows.Forms.Label saniyelabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
    }
}

