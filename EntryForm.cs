using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_of_Pixeland
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }
        private void yukle_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                Image image = Image.FromFile(selectedImagePath);
                MainForm mainForm = new MainForm(image);
                mainForm.Show();
                this.Hide();
            }
        }
        private void sec_btn_Click(object sender, EventArgs e)
        {
            string hazirGorselDizini = Path.Combine(Application.StartupPath, "HazirGorseller");
            if (!Directory.Exists(hazirGorselDizini) || Directory.GetFiles(hazirGorselDizini).Length == 0)
            {
                MessageBox.Show("Hazır görseller bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = hazirGorselDizini;
            openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                Image image = Image.FromFile(selectedImagePath);
                MainForm mainForm = new MainForm(image);
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
