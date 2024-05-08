namespace Project_of_Pixeland
{
    partial class Form_HistogramIslemleri
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sifirla_btn = new System.Windows.Forms.Button();
            this.indir_btn = new System.Windows.Forms.Button();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.iptal_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ger_btn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yeniGorsel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // sifirla_btn
            // 
            this.sifirla_btn.BackColor = System.Drawing.Color.Moccasin;
            this.sifirla_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifirla_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sifirla_btn.Location = new System.Drawing.Point(12, 656);
            this.sifirla_btn.Name = "sifirla_btn";
            this.sifirla_btn.Size = new System.Drawing.Size(206, 38);
            this.sifirla_btn.TabIndex = 27;
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
            this.indir_btn.TabIndex = 23;
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
            this.kaydet_btn.TabIndex = 24;
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
            this.iptal_btn.TabIndex = 25;
            this.iptal_btn.Text = "Iptal";
            this.iptal_btn.UseVisualStyleBackColor = false;
            this.iptal_btn.Click += new System.EventHandler(this.iptal_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ger_btn
            // 
            this.ger_btn.BackColor = System.Drawing.Color.LightCyan;
            this.ger_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ger_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ger_btn.Location = new System.Drawing.Point(332, 455);
            this.ger_btn.Name = "ger_btn";
            this.ger_btn.Size = new System.Drawing.Size(206, 38);
            this.ger_btn.TabIndex = 24;
            this.ger_btn.Text = "Histogramı Ger";
            this.ger_btn.UseVisualStyleBackColor = false;
            this.ger_btn.Click += new System.EventHandler(this.ger_btn_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(438, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(418, 379);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // yeniGorsel_btn
            // 
            this.yeniGorsel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.yeniGorsel_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniGorsel_btn.ForeColor = System.Drawing.Color.Purple;
            this.yeniGorsel_btn.Location = new System.Drawing.Point(332, 656);
            this.yeniGorsel_btn.Name = "yeniGorsel_btn";
            this.yeniGorsel_btn.Size = new System.Drawing.Size(206, 38);
            this.yeniGorsel_btn.TabIndex = 29;
            this.yeniGorsel_btn.Text = "Yeni Görsel";
            this.yeniGorsel_btn.UseVisualStyleBackColor = false;
            this.yeniGorsel_btn.Click += new System.EventHandler(this.yeniGorsel_btn_Click);
            // 
            // Form_HistogramIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(868, 706);
            this.Controls.Add(this.yeniGorsel_btn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.sifirla_btn);
            this.Controls.Add(this.indir_btn);
            this.Controls.Add(this.ger_btn);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.iptal_btn);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form_HistogramIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sifirla_btn;
        private System.Windows.Forms.Button indir_btn;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button iptal_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ger_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button yeniGorsel_btn;
    }
}