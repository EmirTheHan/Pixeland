namespace Project_of_Pixeland
{
    partial class Form_Bulaniklastir
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
            this.parlaklikDegeri_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bulaniklik_tbar = new System.Windows.Forms.TrackBar();
            this.sifirla_btn = new System.Windows.Forms.Button();
            this.indir_btn = new System.Windows.Forms.Button();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.iptal_btn = new System.Windows.Forms.Button();
            this.yeniGorsel_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bulaniklik_tbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parlaklikDegeri_lbl
            // 
            this.parlaklikDegeri_lbl.AutoSize = true;
            this.parlaklikDegeri_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parlaklikDegeri_lbl.ForeColor = System.Drawing.Color.LightCyan;
            this.parlaklikDegeri_lbl.Location = new System.Drawing.Point(468, 447);
            this.parlaklikDegeri_lbl.Name = "parlaklikDegeri_lbl";
            this.parlaklikDegeri_lbl.Size = new System.Drawing.Size(18, 18);
            this.parlaklikDegeri_lbl.TabIndex = 47;
            this.parlaklikDegeri_lbl.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(378, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Bulanıklık :";
            // 
            // bulaniklik_tbar
            // 
            this.bulaniklik_tbar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.bulaniklik_tbar.LargeChange = 0;
            this.bulaniklik_tbar.Location = new System.Drawing.Point(12, 468);
            this.bulaniklik_tbar.Minimum = 1;
            this.bulaniklik_tbar.Name = "bulaniklik_tbar";
            this.bulaniklik_tbar.Size = new System.Drawing.Size(844, 45);
            this.bulaniklik_tbar.SmallChange = 0;
            this.bulaniklik_tbar.TabIndex = 45;
            this.bulaniklik_tbar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.bulaniklik_tbar.Value = 1;
            this.bulaniklik_tbar.ValueChanged += new System.EventHandler(this.bulaniklik_tbar_ValueChanged);
            // 
            // sifirla_btn
            // 
            this.sifirla_btn.BackColor = System.Drawing.Color.Moccasin;
            this.sifirla_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifirla_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sifirla_btn.Location = new System.Drawing.Point(12, 656);
            this.sifirla_btn.Name = "sifirla_btn";
            this.sifirla_btn.Size = new System.Drawing.Size(206, 38);
            this.sifirla_btn.TabIndex = 44;
            this.sifirla_btn.Text = "Sıfırla";
            this.sifirla_btn.UseVisualStyleBackColor = false;
            this.sifirla_btn.Click += new System.EventHandler(this.sifirla_btn_Click);
            // 
            // indir_btn
            // 
            this.indir_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.indir_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indir_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.indir_btn.Location = new System.Drawing.Point(332, 602);
            this.indir_btn.Name = "indir_btn";
            this.indir_btn.Size = new System.Drawing.Size(206, 38);
            this.indir_btn.TabIndex = 40;
            this.indir_btn.Text = "Indir";
            this.indir_btn.UseVisualStyleBackColor = false;
            this.indir_btn.Click += new System.EventHandler(this.indir_btn_Click);
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.BackColor = System.Drawing.Color.LightGreen;
            this.kaydet_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydet_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.kaydet_btn.Location = new System.Drawing.Point(332, 548);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(206, 38);
            this.kaydet_btn.TabIndex = 41;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = false;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // iptal_btn
            // 
            this.iptal_btn.BackColor = System.Drawing.Color.LightPink;
            this.iptal_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptal_btn.ForeColor = System.Drawing.Color.Maroon;
            this.iptal_btn.Location = new System.Drawing.Point(650, 656);
            this.iptal_btn.Name = "iptal_btn";
            this.iptal_btn.Size = new System.Drawing.Size(206, 38);
            this.iptal_btn.TabIndex = 42;
            this.iptal_btn.Text = "Iptal";
            this.iptal_btn.UseVisualStyleBackColor = false;
            this.iptal_btn.Click += new System.EventHandler(this.iptal_btn_Click);
            // 
            // yeniGorsel_btn
            // 
            this.yeniGorsel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.yeniGorsel_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniGorsel_btn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.yeniGorsel_btn.Location = new System.Drawing.Point(332, 656);
            this.yeniGorsel_btn.Name = "yeniGorsel_btn";
            this.yeniGorsel_btn.Size = new System.Drawing.Size(206, 38);
            this.yeniGorsel_btn.TabIndex = 43;
            this.yeniGorsel_btn.Text = "Yeni Görsel";
            this.yeniGorsel_btn.UseVisualStyleBackColor = false;
            this.yeniGorsel_btn.Click += new System.EventHandler(this.yeniGorsel_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Bulaniklastir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(868, 706);
            this.Controls.Add(this.parlaklikDegeri_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bulaniklik_tbar);
            this.Controls.Add(this.sifirla_btn);
            this.Controls.Add(this.indir_btn);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.iptal_btn);
            this.Controls.Add(this.yeniGorsel_btn);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form_Bulaniklastir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulanıklaştır";
            ((System.ComponentModel.ISupportInitialize)(this.bulaniklik_tbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label parlaklikDegeri_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar bulaniklik_tbar;
        private System.Windows.Forms.Button sifirla_btn;
        private System.Windows.Forms.Button indir_btn;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button iptal_btn;
        private System.Windows.Forms.Button yeniGorsel_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}