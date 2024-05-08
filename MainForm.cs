using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_of_Pixeland
{
    public partial class MainForm : Form
    {
        Image originImage;
        public MainForm(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            originImage = image;
        }

        private void griTonlama_btn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    int griTon = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    Color yeniRenk = Color.FromArgb(griTon, griTon, griTon);
                    bmp.SetPixel(x, y, yeniRenk);
                }
            }
            pictureBox1.Image = bmp;
            Cursor = Cursors.Default;
        }
        private void siyahbeyaz_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_SiyahBeyaz form_SiyahBeyaz = new Form_SiyahBeyaz(bmp);
            form_SiyahBeyaz.Show();
            Hide();
        }
        private void kirp_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_Kirpma form_Kirpma = new Form_Kirpma(bmp);
            form_Kirpma.Show();
            Hide();
        }
        private void dondur_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_Dondurme form_Dondur = new Form_Dondurme(bmp);
            form_Dondur.Show();
            Hide();
        }
        private void renkleriDonustur_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_RenkDonusumu form_renkDonusum = new Form_RenkDonusumu(bmp);
            form_renkDonusum.Show();
            Hide();
        }
        private void histogramIslemleri_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_HistogramIslemleri form_histogramIslemleri = new Form_HistogramIslemleri(bmp);
            form_histogramIslemleri.Show();
            Hide();
        }
        private void aritmetikIslemler_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_AritmetikIslemler form_AritmetikIslemler = new Form_AritmetikIslemler(bmp);
            form_AritmetikIslemler.Show();
            Hide();
        }
        private void parlaklikKontrast_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_ParlaklikKontrast form_ParlaklikKontrast = new Form_ParlaklikKontrast(bmp);
            form_ParlaklikKontrast.Show();
            Hide();
        }
        private void bulaniklastir_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_Bulaniklastir form_Bulaniklastir = new Form_Bulaniklastir(bmp);
            form_Bulaniklastir.Show();
            Hide();
        }
        private void kenarBulma_btn_Click(object sender, EventArgs e)
        {
            // form yok işlemler direkt buraya. pictureBox1.Image = sonImage;
        }
        private void gurultuEkleKaldir_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_GurultuEkleKaldir form_GurultuEkleKaldir = new Form_GurultuEkleKaldir(bmp);
            form_GurultuEkleKaldir.Show();
            Hide();
        }
        private void morfolojikIslemler_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Form_MorfolojikIslemler form_MorfolojikIslemler = new Form_MorfolojikIslemler(bmp);
            form_MorfolojikIslemler.Show();
            Hide();
        }
        private void yeniGorsel_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
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
        private void sifirla_btn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originImage;
        }
        private void iptal_btn_Click(object sender, EventArgs e)
        {
            Hide();
            EntryForm entryForm = new EntryForm();
            entryForm.Show();
        }
    }
}
