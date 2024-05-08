namespace Project_of_Pixeland
{
    partial class Form_SiyahBeyaz
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
            this.esikDegeri_trbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.esikDegeri_lbl = new System.Windows.Forms.Label();
            this.indir_btn = new System.Windows.Forms.Button();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.yeniGorsel_btn = new System.Windows.Forms.Button();
            this.iptal_btn = new System.Windows.Forms.Button();
            this.sifirla_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esikDegeri_trbar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // esikDegeri_trbar
            // 
            this.esikDegeri_trbar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.esikDegeri_trbar.Location = new System.Drawing.Point(21, 443);
            this.esikDegeri_trbar.Maximum = 255;
            this.esikDegeri_trbar.Name = "esikDegeri_trbar";
            this.esikDegeri_trbar.Size = new System.Drawing.Size(820, 45);
            this.esikDegeri_trbar.TabIndex = 2;
            this.esikDegeri_trbar.TickFrequency = 4;
            this.esikDegeri_trbar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.esikDegeri_trbar.ValueChanged += new System.EventHandler(this.esikDegeri_trbar_ValueChanged);
            this.esikDegeri_trbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.esikDegeri_trbar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(9, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Beyaz\r\n  - 0 -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(800, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = " Siyah\r\n- 255 -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(363, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Esik Degeri :";
            // 
            // esikDegeri_lbl
            // 
            this.esikDegeri_lbl.AutoSize = true;
            this.esikDegeri_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esikDegeri_lbl.ForeColor = System.Drawing.Color.LightCyan;
            this.esikDegeri_lbl.Location = new System.Drawing.Point(467, 415);
            this.esikDegeri_lbl.Name = "esikDegeri_lbl";
            this.esikDegeri_lbl.Size = new System.Drawing.Size(38, 18);
            this.esikDegeri_lbl.TabIndex = 3;
            this.esikDegeri_lbl.Text = "100";
            // 
            // indir_btn
            // 
            this.indir_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.indir_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indir_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.indir_btn.Location = new System.Drawing.Point(331, 602);
            this.indir_btn.Name = "indir_btn";
            this.indir_btn.Size = new System.Drawing.Size(206, 38);
            this.indir_btn.TabIndex = 4;
            this.indir_btn.Text = "Indir";
            this.indir_btn.UseVisualStyleBackColor = false;
            this.indir_btn.Click += new System.EventHandler(this.indir_btn_Click);
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.BackColor = System.Drawing.Color.LightGreen;
            this.kaydet_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydet_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.kaydet_btn.Location = new System.Drawing.Point(331, 548);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(206, 38);
            this.kaydet_btn.TabIndex = 5;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = false;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // yeniGorsel_btn
            // 
            this.yeniGorsel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.yeniGorsel_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniGorsel_btn.ForeColor = System.Drawing.Color.Purple;
            this.yeniGorsel_btn.Location = new System.Drawing.Point(331, 656);
            this.yeniGorsel_btn.Name = "yeniGorsel_btn";
            this.yeniGorsel_btn.Size = new System.Drawing.Size(206, 38);
            this.yeniGorsel_btn.TabIndex = 6;
            this.yeniGorsel_btn.Text = "Yeni Görsel";
            this.yeniGorsel_btn.UseVisualStyleBackColor = false;
            this.yeniGorsel_btn.Click += new System.EventHandler(this.yeniGorsel_btn_Click);
            // 
            // iptal_btn
            // 
            this.iptal_btn.BackColor = System.Drawing.Color.LightPink;
            this.iptal_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptal_btn.ForeColor = System.Drawing.Color.Maroon;
            this.iptal_btn.Location = new System.Drawing.Point(650, 656);
            this.iptal_btn.Name = "iptal_btn";
            this.iptal_btn.Size = new System.Drawing.Size(206, 38);
            this.iptal_btn.TabIndex = 6;
            this.iptal_btn.Text = "Iptal";
            this.iptal_btn.UseVisualStyleBackColor = false;
            this.iptal_btn.Click += new System.EventHandler(this.iptal_btn_Click);
            // 
            // sifirla_btn
            // 
            this.sifirla_btn.BackColor = System.Drawing.Color.Moccasin;
            this.sifirla_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifirla_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sifirla_btn.Location = new System.Drawing.Point(12, 656);
            this.sifirla_btn.Name = "sifirla_btn";
            this.sifirla_btn.Size = new System.Drawing.Size(206, 38);
            this.sifirla_btn.TabIndex = 7;
            this.sifirla_btn.Text = "Sıfırla";
            this.sifirla_btn.UseVisualStyleBackColor = false;
            this.sifirla_btn.Click += new System.EventHandler(this.sifirla_btn_Click);
            // 
            // Form_SiyahBeyaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(868, 706);
            this.Controls.Add(this.sifirla_btn);
            this.Controls.Add(this.indir_btn);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.iptal_btn);
            this.Controls.Add(this.yeniGorsel_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.esikDegeri_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esikDegeri_trbar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_SiyahBeyaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SiyahBeyaz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esikDegeri_trbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar esikDegeri_trbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label esikDegeri_lbl;
        private System.Windows.Forms.Button indir_btn;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button yeniGorsel_btn;
        private System.Windows.Forms.Button iptal_btn;
        private System.Windows.Forms.Button sifirla_btn;
    }
}