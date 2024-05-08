using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_of_Pixeland
{
    public partial class Form_Dondurme : Form
    {
        Bitmap originImage;
        public Form_Dondurme(Bitmap image)
        {
            InitializeComponent();
            originImage = image;
            pictureBox1.Image = originImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void aciDegeri_trbar_ValueChanged(object sender, EventArgs e)
        {
            aciDegeri_lbl.Text = Convert.ToString(aciDegeri_trbar.Value);
            Bitmap newImage = new Bitmap(originImage);
            dondur(newImage);
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
                dondur(newImage);
            }
        }
        private void iptal_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(originImage);
            mainForm.Show();
            this.Close();
        }
        private void dondur(Bitmap img)
        {
            int aci = aciDegeri_trbar.Value;
            Bitmap newImage = new Bitmap(img.Width, img.Height);
            Graphics grafik = Graphics.FromImage(newImage);
            grafik.TranslateTransform(img.Width / 2, img.Height / 2);
            grafik.RotateTransform(aci);
            grafik.TranslateTransform(-img.Width / 2, -img.Height / 2);
            grafik.DrawImage(img, new Point(0, 0));
            pictureBox1.Image = newImage;
            grafik.Dispose();
        }
        private void sifirla_btn_Click(object sender, EventArgs e)
        {
            aciDegeri_trbar.Value = 0;
            pictureBox1.Image = originImage;
        }
    }
}