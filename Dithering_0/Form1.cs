using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Dithering_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        Bitmap workingImage;
        Bitmap outputImage;
        int factor = 1;
        bool showEveryStep;
        bool dither;
        bool grayscale;
        long oldFileSize;
        long newFileSize;
        FileInfo info;
        string oldFileName;
        string newFileName;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            button_loadImage.Enabled = true;
            button_dither.Enabled = false;
            button_saveImage.Enabled = false;
            checkBox_dither.Enabled = false;
            checkBox_showEveryStep.Enabled = false;
            checkBox_grayscale.Enabled = false;
            numericUpDown_factor.Enabled = false;
            Clear();
        }

        private void button_loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.Filter = "Image Files | *.png; *.jpeg; *.jpg; *.bmp; *.tiff";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Clear();
                info = new FileInfo(ofd.FileName);
                oldFileSize = info.Length;
                oldFileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                pictureBox_display.Image = new Bitmap(ofd.FileName);
                button_loadImage.Enabled = true;
                button_dither.Enabled = true;
                button_saveImage.Enabled = true;
                checkBox_dither.Enabled = true;
                checkBox_showEveryStep.Enabled = true;
                checkBox_grayscale.Enabled = true;
                numericUpDown_factor.Enabled = true;
                StatusUpdate("Image loaded successfully.");
                StatusUpdate("Old file size: " + oldFileSize + " bytes.");
            }
        }

        private void button_dither_Click(object sender, EventArgs e)
        {
            workingImage = new Bitmap(pictureBox_display.Image);
            outputImage = new Bitmap(workingImage.Width, workingImage.Height, PixelFormat.Format16bppArgb1555);
            dither = checkBox_dither.Checked;
            showEveryStep = checkBox_showEveryStep.Checked;
            grayscale = checkBox_grayscale.Checked;
            factor = (int)numericUpDown_factor.Value;

            backgroundWorker_ditherer.RunWorkerAsync();

            button_loadImage.Enabled = false;
            button_dither.Enabled = false;
            button_saveImage.Enabled = false;
            checkBox_dither.Enabled = false;
            checkBox_showEveryStep.Enabled = false;
            checkBox_grayscale.Enabled = false;
            numericUpDown_factor.Enabled = false;
        }

        private void button_saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Image";
            sfd.Filter = "png(*.png) | *.png | jpeg(*.jpeg) | *.jpeg | jpg(*.jpg) | *.jpg | bmp(*.bmp) | *.bmp | tiff(*.tiff) | *.tiff";
            ImageFormat imgFormat;
            newFileName = oldFileName + "_compressed";
            if (dither)
            {
                newFileName += "_dithered_factor_" + factor;
            }
            if (grayscale)
            {
                newFileName += "_grayscale";
            }
            sfd.FileName = newFileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(sfd.FileName);
                switch (extension)
                {
                    case ".png":
                        imgFormat = ImageFormat.Png;
                        break;
                    case ".jpeg":
                        imgFormat = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        imgFormat = ImageFormat.Bmp;
                        break;
                    case ".tiff":
                        imgFormat = ImageFormat.Tiff;
                        break;
                    default:
                        imgFormat = ImageFormat.Png;
                        break;
                }
                pictureBox_display.Image.Save(sfd.FileName, imgFormat);
                info = new FileInfo(sfd.FileName);
                newFileSize = info.Length;
                StatusUpdate("Image saved successfully.");
                StatusUpdate("New file size: " + oldFileSize + " bytes.");
            }
        }

        private void backgroundWorker_ditherer_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int newR;
            int newG;
            int newB;
            int errorR;
            int errorG;
            int errorB;
            int r;
            int g;
            int b;

            Color c;
            Color tempColor;

            int gray;

            int[][] indexes;
            int[] factors = new int[] { 7, 3, 5, 1 };

            StatusUpdate("Started compressing.");

            for (int y = 0; y < workingImage.Height - 1; y++)
            {
                for (int x = 1; x < workingImage.Width - 1; x++)
                {

                    if (grayscale)
                    {
                        c = workingImage.GetPixel(x, y);
                        gray = (int)((c.R * 0.3) + (c.G * 0.59) + (c.B * 0.11)); //for the numbers check: https://en.wikipedia.org/wiki/Grayscale and https://stackoverflow.com/questions/2265910/convert-an-image-to-grayscale
                        workingImage.SetPixel(x, y, Color.FromArgb(c.A, gray, gray, gray));
                        outputImage.SetPixel(x, y, Color.FromArgb(c.A, gray, gray, gray));
                    }

                    c = workingImage.GetPixel(x, y);
                    newR = Convert.ToInt32(factor * (float)c.R / 255) * (255 / factor);
                    newG = Convert.ToInt32(factor * (float)c.G / 255) * (255 / factor);
                    newB = Convert.ToInt32(factor * (float)c.B / 255) * (255 / factor);
                    outputImage.SetPixel(x, y, Color.FromArgb(c.A, newR, newG, newB));
                    if (dither)
                    {
                        errorR = c.R - newR;
                        errorG = c.G - newG;
                        errorB = c.B - newB;
                        indexes = new int[][]{
                            new int[]{ x + 1, y    },
                            new int[]{ x - 1, y + 1},
                            new int[]{ x    , y + 1},
                            new int[]{ x + 1, y + 1},
                        };
                        for (int i = 0; i < 4; i++)
                        {
                            tempColor = workingImage.GetPixel(indexes[i][0], indexes[i][1]);
                            r = tempColor.R;
                            g = tempColor.G;
                            b = tempColor.B;
                            r += Convert.ToInt32((float)errorR * factors[i] / 16);
                            g += Convert.ToInt32((float)errorG * factors[i] / 16);
                            b += Convert.ToInt32((float)errorB * factors[i] / 16);

                            r = Clamp(r);
                            g = Clamp(g);
                            b = Clamp(b);

                            workingImage.SetPixel(indexes[i][0], indexes[i][1], Color.FromArgb(tempColor.A, r, g, b));
                            outputImage.SetPixel(indexes[i][0], indexes[i][1], Color.FromArgb(tempColor.A, r, g, b));
                        }
                    }
                }
                if (showEveryStep)
                {
                    pictureBox_display.Invoke((MethodInvoker)(() => pictureBox_display.Image.Dispose()));
                    pictureBox_display.Invoke((MethodInvoker)(() => pictureBox_display.Image = new Bitmap(outputImage)));
                }
            }

            StatusUpdate("Finished compressing.");
        }

        private void backgroundWorker_ditherer_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            pictureBox_display.Image.Dispose();
            pictureBox_display.Image = new Bitmap(outputImage);

            button_loadImage.Enabled = true;
            button_dither.Enabled = true;
            button_saveImage.Enabled = true;
            checkBox_dither.Enabled = true;
            checkBox_showEveryStep.Enabled = true;
            checkBox_grayscale.Enabled = true;
            numericUpDown_factor.Enabled = true;
        }

        void Clear()
        {
            pictureBox_display.Image = null;
            listBox_output.Items.Clear();
            oldFileName = "";
            newFileName = "";
        }

        int Clamp(int input)
        {
            if (input < 0)
            {
                return 0;
            }
            else if (input > 255)
            {
                return 255;
            }
            else
            {
                return input;
            }
        }

        void StatusUpdate(string message)
        {
            listBox_output.Invoke((MethodInvoker)(() => listBox_output.Items.Add(message)));
        }
    }
}
