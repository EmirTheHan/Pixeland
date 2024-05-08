using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_of_Pixeland
{
    public partial class Form_SiyahBeyaz : Form
    {
        Bitmap originImage;
        public Form_SiyahBeyaz(Bitmap image)
        {
            InitializeComponent();
            originImage = image;
            pictureBox1.Image = originImage;
            esikDegeri_trbar.Value = 128;
            Bitmap newImage = new Bitmap(originImage);
            siyahBeyazYap(newImage);
        }
        private void esikDegeri_trbar_ValueChanged(object sender, EventArgs e)
        {
            esikDegeri_lbl.Text = Convert.ToString(esikDegeri_trbar.Value);
        }
        private void esikDegeri_trbar_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap newImage = new Bitmap(originImage);
            siyahBeyazYap(newImage);
        }
        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(pictureBox1.Image);
            mainForm.Show();
            this.Close();
        }
        private void indir_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaAdi = saveFileDialog.FileName;
                pictureBox1.Image.Save(dosyaAdi);
                MessageBox.Show("Görsel başarıyla indirildi! Elinize Sağlık", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void yeniGorsel_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                System.Drawing.Image image = System.Drawing.Image.FromFile(selectedImagePath);
                originImage = (Bitmap)image;
                Bitmap newImage = new Bitmap(originImage);
                siyahBeyazYap(newImage);
            }
        } 
        private void iptal_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(originImage);
            mainForm.Show();
            this.Close();
        }
        private void siyahBeyazYap(Bitmap img)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixelColor = originImage.GetPixel(x, y);
                    int griTon = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    Color yeniRenk = (griTon < esikDegeri_trbar.Value) ? Color.Black : Color.White;
                    img.SetPixel(x, y, yeniRenk);
                }
            }
            pictureBox1.Image = img;
        }
        private void sifirla_btn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originImage;
        }
    }
}
