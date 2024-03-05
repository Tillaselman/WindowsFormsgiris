namespace datagridviewnesnesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxkayit = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelisim = new System.Windows.Forms.Label();
            this.labelsoyisim = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxisim = new System.Windows.Forms.TextBox();
            this.textBoxsoyisim = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttongoster = new System.Windows.Forms.Button();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttongüncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsoyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxkayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxkayit
            // 
            this.groupBoxkayit.Controls.Add(this.buttongüncelle);
            this.groupBoxkayit.Controls.Add(this.buttonsil);
            this.groupBoxkayit.Controls.Add(this.buttonekle);
            this.groupBoxkayit.Controls.Add(this.buttongoster);
            this.groupBoxkayit.Controls.Add(this.textBoxid);
            this.groupBoxkayit.Controls.Add(this.textBoxsoyisim);
            this.groupBoxkayit.Controls.Add(this.textBoxisim);
            this.groupBoxkayit.Controls.Add(this.labelid);
            this.groupBoxkayit.Controls.Add(this.labelsoyisim);
            this.groupBoxkayit.Controls.Add(this.labelisim);
            this.groupBoxkayit.Location = new System.Drawing.Point(12, 12);
            this.groupBoxkayit.Name = "groupBoxkayit";
            this.groupBoxkayit.Size = new System.Drawing.Size(402, 555);
            this.groupBoxkayit.TabIndex = 0;
            this.groupBoxkayit.TabStop = false;
            this.groupBoxkayit.Text = "kayıt işlemleri";
            // 
            // labelisim
            // 
            this.labelisim.AutoSize = true;
            this.labelisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelisim.Location = new System.Drawing.Point(41, 32);
            this.labelisim.Name = "labelisim";
            this.labelisim.Size = new System.Drawing.Size(72, 20);
            this.labelisim.TabIndex = 0;
            this.labelisim.Text = "İsism : ";
            // 
            // labelsoyisim
            // 
            this.labelsoyisim.AutoSize = true;
            this.labelsoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyisim.Location = new System.Drawing.Point(20, 66);
            this.labelsoyisim.Name = "labelsoyisim";
            this.labelsoyisim.Size = new System.Drawing.Size(93, 20);
            this.labelsoyisim.TabIndex = 0;
            this.labelsoyisim.Text = "Soyisim : ";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelid.Location = new System.Drawing.Point(67, 103);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(36, 20);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "İd :";
            // 
            // textBoxisim
            // 
            this.textBoxisim.Location = new System.Drawing.Point(134, 32);
            this.textBoxisim.Name = "textBoxisim";
            this.textBoxisim.Size = new System.Drawing.Size(231, 22);
            this.textBoxisim.TabIndex = 1;
            // 
            // textBoxsoyisim
            // 
            this.textBoxsoyisim.Location = new System.Drawing.Point(134, 66);
            this.textBoxsoyisim.Name = "textBoxsoyisim";
            this.textBoxsoyisim.Size = new System.Drawing.Size(231, 22);
            this.textBoxsoyisim.TabIndex = 1;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(134, 103);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(231, 22);
            this.textBoxid.TabIndex = 1;
            // 
            // buttongoster
            // 
            this.buttongoster.Location = new System.Drawing.Point(134, 202);
            this.buttongoster.Name = "buttongoster";
            this.buttongoster.Size = new System.Drawing.Size(221, 35);
            this.buttongoster.TabIndex = 2;
            this.buttongoster.Text = "göster";
            this.buttongoster.UseVisualStyleBackColor = true;
            this.buttongoster.Click += new System.EventHandler(this.buttongoster_Click);
            // 
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(134, 243);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(221, 35);
            this.buttonekle.TabIndex = 2;
            this.buttonekle.Text = "ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(134, 284);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(221, 35);
            this.buttonsil.TabIndex = 2;
            this.buttonsil.Text = "sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.Location = new System.Drawing.Point(134, 325);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(221, 35);
            this.buttongüncelle.TabIndex = 2;
            this.buttongüncelle.Text = "güncelle";
            this.buttongüncelle.UseVisualStyleBackColor = true;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnid,
            this.columnisim,
            this.columnsoyisim});
            this.dataGridView1.Location = new System.Drawing.Point(466, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(556, 205);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // columnid
            // 
            this.columnid.HeaderText = "İD";
            this.columnid.MinimumWidth = 6;
            this.columnid.Name = "columnid";
            this.columnid.Width = 125;
            // 
            // columnisim
            // 
            this.columnisim.HeaderText = "İSİM";
            this.columnisim.MinimumWidth = 6;
            this.columnisim.Name = "columnisim";
            this.columnisim.Width = 150;
            // 
            // columnsoyisim
            // 
            this.columnsoyisim.HeaderText = "SOYİSİM";
            this.columnsoyisim.MinimumWidth = 6;
            this.columnsoyisim.Name = "columnsoyisim";
            this.columnsoyisim.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxkayit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxkayit.ResumeLayout(false);
            this.groupBoxkayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxkayit;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelsoyisim;
        private System.Windows.Forms.Label labelisim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttongüncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttongoster;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxsoyisim;
        private System.Windows.Forms.TextBox textBoxisim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsoyisim;
    }
}

