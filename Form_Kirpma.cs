using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_of_Pixeland
{
    public partial class Form_Kirpma : Form
    {
        Bitmap originImage;
        private Bitmap croppedImage;
        private Point startPoint;
        private Rectangle selectionRectangle = new Rectangle();
        private bool isSelecting = false;
        Bitmap mask;
        private double scaleRate, refWidth, refHeight;

        public Form_Kirpma(Bitmap image)
        {
            InitializeComponent();
            originImage = image;
            scaleRate = (double)image.Width / image.Height;
            pictureBox_kirpma.Width = (int)(pictureBox_kirpma.Height * scaleRate);
            pictureBox_kirpma.Location = new Point((ClientSize.Width - pictureBox_kirpma.Width) / 2, ((ClientSize.Height - pictureBox_kirpma.Height) / 2) - 150);
            Bitmap refImage = new Bitmap(image, pictureBox_kirpma.Width, pictureBox_kirpma.Height);
            pictureBox_kirpma.Image = refImage;
        }

        private void pictureBox_kirpma_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            isSelecting = true;
        }

        private void pictureBox_kirpma_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                int x = Math.Min(startPoint.X, e.X);
                int y = Math.Min(startPoint.Y, e.Y);
                int width = Math.Abs(startPoint.X - e.X);
                int height = Math.Abs(startPoint.Y - e.Y);

                selectionRectangle = new Rectangle(x, y, width, height);

                pictureBox_kirpma.Invalidate();
            }
        }

        private void pictureBox_kirpma_MouseUp(object sender, MouseEventArgs e)
        {
            isSelecting = false;

            mask = new Bitmap(originImage.Width, originImage.Height);
            using (Graphics g = Graphics.FromImage(mask))
            {
                g.FillRectangle(Brushes.Red, new Rectangle(0, 0, mask.Width, mask.Height));
                g.FillRectangle(Brushes.Black, selectionRectangle);
            }
        }
        private void pictureBox_kirpma_Paint(object sender, PaintEventArgs e)
        {
            if (isSelecting)
            {
                using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Gray)))
                {
                    Rectangle imageRect = new Rectangle(Point.Empty, pictureBox_kirpma.Image.Size);
                    Region selectedRegion = new Region(selectionRectangle);
                    Region imageRegion = new Region(imageRect);
                    imageRegion.Exclude(selectedRegion);
                    e.Graphics.FillRegion(brush, imageRegion);
                }
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(pen, selectionRectangle);
                }
            }
        }

        private void kirp_btn_Click(object sender, EventArgs e)
        {
            if (!selectionRectangle.IsEmpty)
            {
                croppedImage = new Bitmap(selectionRectangle.Width, selectionRectangle.Height);
                using (Graphics g = Graphics.FromImage(croppedImage))
                {
                    g.DrawImage(originImage, new Rectangle(0, 0, croppedImage.Width, croppedImage.Height), selectionRectangle, GraphicsUnit.Pixel);
                }

                scaleRate = (double)croppedImage.Width / croppedImage.Height;
                pictureBox_kirpma.Width = (int)(pictureBox_kirpma.Height * scaleRate);
                pictureBox_kirpma.Location = new Point((ClientSize.Width - pictureBox_kirpma.Width) / 2, ((ClientSize.Height - pictureBox_kirpma.Height) / 2) - 150);

                pictureBox_kirpma.Image = croppedImage;
                pictureBox_kirpma.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Lütfen önce bir alan seçin.");
            }
        }
        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(pictureBox_kirpma.Image);
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
                pictureBox_kirpma.Image.Save(dosyaAdi);
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
                pictureBox_kirpma.Image = newImage;
            }
        }
        private void iptal_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(originImage);
            mainForm.Show();
            this.Close();
        }
        private void sifirla_btn_Click(object sender, EventArgs e)
        {
            scaleRate = (double)originImage.Width / originImage.Height;
            pictureBox_kirpma.Width = (int)(pictureBox_kirpma.Height * scaleRate);
            pictureBox_kirpma.Location = new Point((ClientSize.Width - pictureBox_kirpma.Width) / 2, ((ClientSize.Height - pictureBox_kirpma.Height) / 2) - 150);
            pictureBox_kirpma.Image = originImage;
            selectionRectangle = Rectangle.Empty;
        }
    }
}
