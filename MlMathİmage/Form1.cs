using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MlMathİmage
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            

        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int gri = (c.R + c.G + c.B) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(gri, gri, gri));
                }
            }

            pictureBox1.Image = bmp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);

            int w = bmp.Width;
            int h = bmp.Height;

            int[,] matris = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int px = j * w / 5;
                    int py = i * h / 5;

                    Color c = bmp.GetPixel(px, py);
                    int gri = (c.R + c.G + c.B) / 3;

                    matris[i, j] = gri;
                }
            }

            txtMatrixResult.Text = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    txtMatrixResult.Text += matris[i, j].ToString().PadLeft(3) + " ";
                }
                txtMatrixResult.Text += Environment.NewLine;
            }
        }

        private void btnML_Click(object sender, EventArgs e)
        {
            string input = txtMLİnput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Lütfen ML girdisini yaz.");
                return;
            }

            // Basit sahte tahmin (model olmadığı için)
            txtMLOutput.Text = "Tahmin: " + input.Length;
        }
    }
}
