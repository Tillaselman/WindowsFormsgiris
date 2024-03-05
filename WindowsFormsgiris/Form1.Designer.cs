namespace WindowsFormsgiris
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
            this.not1 = new System.Windows.Forms.Label();
            this.not2 = new System.Windows.Forms.Label();
            this.textboxnot1 = new System.Windows.Forms.TextBox();
            this.textBoxnot2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hesaplananort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // not1
            // 
            this.not1.AutoSize = true;
            this.not1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not1.Location = new System.Drawing.Point(12, 9);
            this.not1.Name = "not1";
            this.not1.Size = new System.Drawing.Size(112, 32);
            this.not1.TabIndex = 0;
            this.not1.Text = "1. Not :";
            // 
            // not2
            // 
            this.not2.AutoSize = true;
            this.not2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not2.Location = new System.Drawing.Point(11, 59);
            this.not2.Name = "not2";
            this.not2.Size = new System.Drawing.Size(112, 32);
            this.not2.TabIndex = 0;
            this.not2.Text = "2. Not :";
            this.not2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxnot1
            // 
            this.textboxnot1.Location = new System.Drawing.Point(130, 9);
            this.textboxnot1.Multiline = true;
            this.textboxnot1.Name = "textboxnot1";
            this.textboxnot1.Size = new System.Drawing.Size(115, 37);
            this.textboxnot1.TabIndex = 1;
            // 
            // textBoxnot2
            // 
            this.textBoxnot2.Location = new System.Drawing.Point(130, 59);
            this.textBoxnot2.Multiline = true;
            this.textBoxnot2.Name = "textBoxnot2";
            this.textBoxnot2.Size = new System.Drawing.Size(115, 37);
            this.textBoxnot2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "ort hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hesaplananort
            // 
            this.hesaplananort.AutoSize = true;
            this.hesaplananort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplananort.Location = new System.Drawing.Point(263, 128);
            this.hesaplananort.Name = "hesaplananort";
            this.hesaplananort.Size = new System.Drawing.Size(27, 29);
            this.hesaplananort.TabIndex = 3;
            this.hesaplananort.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 295);
            this.Controls.Add(this.hesaplananort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxnot2);
            this.Controls.Add(this.textboxnot1);
            this.Controls.Add(this.not2);
            this.Controls.Add(this.not1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label not1;
        private System.Windows.Forms.Label not2;
        private System.Windows.Forms.TextBox textboxnot1;
        private System.Windows.Forms.TextBox textBoxnot2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hesaplananort;
    }
}

