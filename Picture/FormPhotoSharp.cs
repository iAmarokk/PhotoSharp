using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class PhotoSharp : Form
    {
        Bitmap bmp;
        string text_brightness;
        string text_contrast;
        string text_gamma;
        public PhotoSharp()
        {
            InitializeComponent();
            LoadPicture("aperture-25.jpg");
            text_brightness = labelBrightness.Text;
            text_contrast = labelContrast.Text;
            text_gamma = labelGamma.Text;
            TextChanges();
            comboBoxCorrection.SelectedIndex = 0;
        }

        private void buttonOpenPicture_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            DialogResult result = ofd.ShowDialog();
            LoadPicture(ofd.FileName);
        }

        public void LoadPicture(string filename)
        {

            try
            {
                bmp = new Bitmap(Image.FromFile(filename));
                textBoxFileName.Text = filename;
                picture.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxFileName.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (checkBoxGray.Checked)
                ChangePicture();
        }

        public void ChangePicture()
        {
            Bitmap res = new Bitmap(bmp);
            bool isGray = checkBoxGray.Checked;
            int brightness = trackBarBrightness.Value;
            int contrast = trackBarContrast.Value;
            int correction = comboBoxCorrection.SelectedIndex;
            int gamma = trackBarGamma.Value;
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    if (isGray)
                    { 
                    pixel = ChangeGrayScale(pixel);
                    }

                    if (brightness != 0)
                    {
                        pixel = ChangeBrightness(pixel, brightness);
                    }

                    if (contrast != 0)
                    {
                        pixel = ChangeContrast(pixel, contrast);
                    }
                    switch (correction)
                    {
                        case 0: break;
                        case 1: // sinus
                            pixel = ChangeCorrestion(pixel, CorrBySinus);
                            break;
                        case 2: // exp
                            pixel = ChangeCorrestion(pixel, CorrByExp);
                            break;
                        case 3: //log
                            pixel = ChangeCorrestion(pixel, CorrByLog);
                            break;
                    }
                    if (gamma != 100)
                    {
                        pixel = ChangeGamma(pixel, gamma);
                    }
                    res.SetPixel(x, y, pixel);
                }
            picture.Image = res;
        }

        private Color ChangeGamma(Color pixel, int gamma)
        {
            double g = gamma / 100d;
            return Color.FromArgb(
                ChangeGamma(pixel.R, g),
                ChangeGamma(pixel.G, g),
                ChangeGamma(pixel.B,g));
        }
        private int ChangeGamma(int color, double gamma)
        {
            double result = Math.Pow(color / 255d, gamma) * 255;
            if (result > 255) result = 255;
            return Convert.ToInt16(result);
        }

        delegate int CorrFunction(int color);
        double CorrK = 8 * Math.Log(2) / 255d;
        private Color ChangeCorrestion(Color pixel, CorrFunction fn)
        {
            return
                Color.FromArgb(fn(pixel.R), fn(pixel.G), fn(pixel.B));
        }

        int CorrBySinus(int color)
        {
            //if (color < 0) color = 0;
            //if (color > 255) color = 255;
            double result = (255 / 2d) * Math.Sin(Math.PI / 255 * color - Math.PI / 2) + (255 / 2d);
            if (result < 0) result = 0;
            if (result > 255) result = 255;
            return Convert.ToInt16(result);
        }
        int CorrByExp (int color)
        {
            //if (color < 0) color = 0;
            //if (color > 255) color = 255;
            double result = Math.Exp(CorrK * color) - 1;
            if (result < 0) result = 0;
            if (result > 255) result = 255;
            return Convert.ToInt16(result);
        }
        int CorrByLog(int color)
        {
            double result = Math.Log(color + 1) / CorrK;
            if (result < 0) result = 0;
            if (result > 255) result = 255;
            return Convert.ToInt16(result);
        }

        private Color ChangeContrast(Color pixel, int procent)
        {
            float p = procent / 100f;
            return Color.FromArgb(
                ChangeContrast(pixel.R, p),
                ChangeContrast(pixel.G, p),
                ChangeContrast(pixel.B, p));
        }

        private Color ChangeBrightness(Color pixel, int procent)
        {
            float p = procent /100f;
            return Color.FromArgb(
                ChangeBrightness(pixel.R, p),
                ChangeBrightness(pixel.G, p),
                ChangeBrightness(pixel.B, p));
        }

        private int ChangeBrightness(int color, float p)
        {
            int result = Convert.ToInt16(color + p * 128);
            if (result > 255) result = 255;
            if (result < 0) result = 0;
            return result;
        }

        private int ChangeContrast(int color, float p)
        {
            int result;
            if (p < 0)
                result = Convert.ToInt16(color + p * (color - 128));
            else
                result = Convert.ToInt16(128 + (color - 128) / (1 - p));
            if (result > 255) result = 255;
            if (result < 0) result = 0;
            return result;
        }

        private Color ChangeGrayScale(Color pixel)
        {
            int avg = (pixel.R + pixel.G + pixel.B + 1) / 3;
            return Color.FromArgb(avg, avg, avg);
        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            TextChanges();
        }

        private void TextChanges()
        {
            labelBrightness.Text = text_brightness + " " + trackBarBrightness.Value + "%";
            labelContrast.Text = text_contrast + " " + trackBarContrast.Value + "%";
            labelGamma.Text = text_gamma + " " + trackBarGamma.Value + "%";
        }

        private void trackBarContrast_ValueChanged(object sender, EventArgs e)
        {
            TextChanges();
        }

        private void trackBarGamma_ValueChanged(object sender, EventArgs e)
        {
            TextChanges();
        }

        private void trackBarGamma_Scroll(object sender, EventArgs e)
        {
            TextChanges();
        }
    }
}
