using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap originalBmp, resultBmp;

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.bmp)|*.jpg; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBefore.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            int rValue, gValue, bValue;
            originalBmp = (Bitmap)pictureBoxBefore.Image;
            int row = originalBmp.Width;
            int column = originalBmp.Height;
            resultBmp = new Bitmap(row, column);
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rValue = 255 - originalBmp.GetPixel(i, j).R;
                    gValue = 255 - originalBmp.GetPixel(i, j).G;
                    bValue = 255 - originalBmp.GetPixel(i, j).B;

                    resultBmp.SetPixel(i, j, Color.FromArgb(rValue, gValue, bValue));
                }
            }
            pictureBoxAfter.Image = resultBmp;
            Cursor = Cursors.Default;
        }

        private void brightnessButton_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt16(textBoxBrightness.Text);
            //int i, j;
            int rValue, gValue, bValue;
            originalBmp = (Bitmap)pictureBoxBefore.Image;
            int row = originalBmp.Width;
            int column = originalBmp.Height;
            resultBmp = new Bitmap(row, column);
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rValue = originalBmp.GetPixel(i, j).R + k;
                    gValue = originalBmp.GetPixel(i, j).G + k;
                    bValue = originalBmp.GetPixel(i, j).B + k;

                    if (rValue > 255) rValue = 255;
                    if (gValue > 255) gValue = 255;
                    if (bValue > 255) bValue = 255;

                    if (rValue < 0) rValue = 0;
                    if (gValue < 0) gValue = 0;
                    if (bValue < 0) bValue = 0;

                    resultBmp.SetPixel(i, j, Color.FromArgb(rValue, gValue, bValue));
                }
            }
            pictureBoxAfter.Image = resultBmp;
            Cursor = Cursors.Default;
        }

        private void gHumanEyeButton_Click(object sender, EventArgs e)
        {
            int rValue, gValue, bValue, grValue;
            double temp;
            originalBmp = (Bitmap)pictureBoxBefore.Image;
            int row = originalBmp.Width;
            int column = originalBmp.Height;
            resultBmp = new Bitmap(row, column);
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rValue = originalBmp.GetPixel(i, j).R;
                    gValue = originalBmp.GetPixel(i, j).G;
                    bValue = originalBmp.GetPixel(i, j).B;
                    temp = (0.3 * rValue) + (0.59 * gValue) + (0.11 * bValue);
                    grValue = (int)temp;
                    resultBmp.SetPixel(i, j, Color.FromArgb(grValue, grValue, grValue));
                }
            }
            pictureBoxAfter.Image = resultBmp;
            Cursor = Cursors.Default;
        }

        private void gLumaButton_Click(object sender, EventArgs e)
        {
            int rValue, gValue, bValue, grValue;
            double temp;
            originalBmp = (Bitmap)pictureBoxBefore.Image;
            int row = originalBmp.Width;
            int column = originalBmp.Height;
            resultBmp = new Bitmap(row, column);
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rValue = originalBmp.GetPixel(i, j).R;
                    gValue = originalBmp.GetPixel(i, j).G;
                    bValue = originalBmp.GetPixel(i, j).B;
                    temp = (0.2126 * rValue) + (0.7152 * gValue) + (0.0722 * bValue);
                    grValue = (int)temp;
                    resultBmp.SetPixel(i, j, Color.FromArgb(grValue, grValue, grValue));
                }
            }
            pictureBoxAfter.Image = resultBmp;
            Cursor = Cursors.Default;
        }

        private void gBtButton_Click(object sender, EventArgs e)
        {
            int rValue, gValue, bValue, grValue;
            double temp;
            originalBmp = (Bitmap)pictureBoxBefore.Image;
            int row = originalBmp.Width;
            int column = originalBmp.Height;
            resultBmp = new Bitmap(row, column);
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rValue = originalBmp.GetPixel(i, j).R;
                    gValue = originalBmp.GetPixel(i, j).G;
                    bValue = originalBmp.GetPixel(i, j).B;
                    temp = (0.299 * rValue) + (0.587 * gValue) + (0.114 * bValue);
                    grValue = (int)temp;
                    resultBmp.SetPixel(i, j, Color.FromArgb(grValue, grValue, grValue));
                }
            }
            pictureBoxAfter.Image = resultBmp;
            Cursor = Cursors.Default;
        }

        private void ThresholdButton_Click(object sender, EventArgs e)
        {
            int rValue, gValue, bValue, grValue;
            int t = Convert.ToInt16(textBoxThreshold.Text);
            originalBmp = (Bitmap)pictureBoxBefore.Image;
            int row = originalBmp.Width;
            int column = originalBmp.Height;
            resultBmp = new Bitmap(row, column);
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rValue = originalBmp.GetPixel(i, j).R;
                    gValue = originalBmp.GetPixel(i, j).G;
                    bValue = originalBmp.GetPixel(i, j).B;
                    grValue = (rValue + gValue + bValue) / 3;

                    if (grValue > t) grValue = 255;
                    else grValue = 0;

                    resultBmp.SetPixel(i, j, Color.FromArgb(grValue, grValue, grValue));
                }
            }
            pictureBoxAfter.Image = resultBmp;
            Cursor = Cursors.Default;
        }

        private void hEqualizeButton_Click(object sender, EventArgs e)
        {
            originalBmp = (Bitmap)pictureBoxBefore.Image;
            int row = originalBmp.Width;
            int column = originalBmp.Height;
            BitmapData sd = originalBmp.LockBits(new Rectangle(0, 0, row, column),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = sd.Stride * sd.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(sd.Scan0, buffer, 0, bytes);
            originalBmp.UnlockBits(sd);
            int current = 0;
            double[] pn = new double[256];
            for (int p = 0; p < bytes; p += 4)
            {
                pn[buffer[p]]++;
            }
            for (int prob = 0; prob < pn.Length; prob++)
            {
                pn[prob] /= (row * column);
            }
            for (int y = 0; y < column; y++)
            {
                for (int x = 0; x < row; x++)
                {
                    current = y * sd.Stride + x * 4;
                    double sum = 0;
                    for (int i = 0; i < buffer[current]; i++)
                    {
                        sum += pn[i];
                    }
                    for (int c = 0; c < 3; c++)
                    {
                        result[current + c] = (byte)Math.Floor(255 * sum);
                    }
                    result[current + 3] = 255;
                }
            }
            Bitmap res = new Bitmap(row, column);
            BitmapData rd = res.LockBits(new Rectangle(0, 0, row, column),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, rd.Scan0, bytes);
            res.UnlockBits(rd);

            pictureBoxAfter.Image = res;
        }

        private void stretchContrastButton_Click(object sender, EventArgs e)
        {
            //originalBmp = (Bitmap)pictureBoxBefore.Image;
            //int row = originalBmp.Width;
            //int column = originalBmp.Height;

            ////Lock bits for your source image into system memory
            //Rectangle rect = new Rectangle(0, 0, originalBmp.Width, originalBmp.Height);
            //BitmapData srcData = originalBmp.LockBits(rect, ImageLockMode.ReadOnly,
            //    PixelFormat.Format32bppArgb);

            ////Create a bitmap to which you will write new pixel data
            //Bitmap destImage = new Bitmap(row, column);

            ////Lock bits for your writable bitmap into system memory
            //Rectangle rect2 = new Rectangle(0, 0, destImage.Width, destImage.Height);
            //BitmapData destData = destImage.LockBits(rect2, ImageLockMode.WriteOnly,
            //    PixelFormat.Format32bppArgb);

            ////Get the width of a single row of pixels in the bitmap
            //int stride = srcData.Stride;

            ////Scan for the first pixel data in bitmaps
            //IntPtr srcScan0 = srcData.Scan0;
            //IntPtr destScan0 = destData.Scan0;

            //var freq = new int[256];

            //unsafe
            //{
            //    //Create an array of pixel data from source image
            //    byte* src = (byte*)srcScan0;

            //    //Get the number of pixels for each intensity value
            //    for (int y = 0; y < srcImage.Height; ++y)
            //    {
            //        for (int x = 0; x < srcImage.Width; ++x)
            //        {
            //            freq[src[y * stride + x * 4]]++;
            //        }
            //    }

            //    //Get the total number of pixels in the image
            //    int numPixels = srcImage.Width * srcImage.Height;

            //    //Set the minimum intensity value of an image (0 = black)
            //    int minI = 0;

            //    //Get the total number of black pixels
            //    var blackPixels = numPixels * blackPointPercent;

            //    //Set a variable for summing up the pixels that will turn black
            //    int accum = 0;

            //    //Sum up the darkest shades until you reach the total of black pixels
            //    while (minI < 255)
            //    {
            //        accum += freq[minI];
            //        if (accum > blackPixels) break;
            //        minI++;
            //    }

            //    //Set the maximum intensity of an image (255 = white)
            //    int maxI = 255;

            //    //Set the total number of white pixels
            //    var whitePixels = numPixels * whitePointPercent;

            //    //Reset the summing variable back to 0
            //    accum = 0;

            //    //Sum up the pixels that are the lightest which will turn white
            //    while (maxI > 0)
            //    {
            //        accum += freq[maxI];
            //        if (accum > whitePixels) break;
            //        maxI--;
            //    }

            //    //Part of a normalization equation that doesn't vary with each pixel
            //    double spread = 255d / (maxI - minI);

            //    //Create an array of pixel data from created image
            //    byte* dst = (byte*)destScan0;

            //    //Write new pixel data to the image
            //    for (int y = 0; y < srcImage.Height; ++y)
            //    {
            //        for (int x = 0; x < srcImage.Width; ++x)
            //        {
            //            int i = y * stride + x * 4;

            //            //Part of equation that varies with each pixel
            //            double value = Math.Round((src[i] - minI) * spread);

            //            byte val = (byte)(Math.Min(Math.Max(value, 0), 255));
            //            dst[i] = val;
            //            dst[i + 1] = val;
            //            dst[i + 2] = val;
            //            dst[i + 3] = 255;
            //        }
            //    }
            //}

            ////Unlock bits from system memory
            //srcImage.UnlockBits(srcData);
            //destImage.UnlockBits(destData);

            //return destImage;
        }

        private void pictureBoxBefore_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            base.OnMouseHover(me);
            int x, y;
            x = me.X;
            y = me.Y;

            textBoxX.Text = x.ToString();
            textBoxY.Text = y.ToString();
        }

        private void pictureBoxAfter_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            base.OnMouseHover(me);
            int x, y;
            x = me.X;
            y = me.Y;

            textBoxX.Text = x.ToString();
            textBoxY.Text = y.ToString();
        }

        private void gLevelingButton_Click(object sender, EventArgs e)
        {
            int rValue, gValue, bValue, grValue;
            originalBmp = (Bitmap)pictureBoxBefore.Image;
            int row = originalBmp.Width;
            int column = originalBmp.Height;
            resultBmp = new Bitmap(row, column);
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rValue = originalBmp.GetPixel(i, j).R;
                    gValue = originalBmp.GetPixel(i, j).G;
                    bValue = originalBmp.GetPixel(i, j).B;
                    grValue = (rValue + gValue + bValue) / 3;

                    resultBmp.SetPixel(i, j, Color.FromArgb(grValue, grValue, grValue));
                }
            }
            pictureBoxAfter.Image = resultBmp;
            Cursor = Cursors.Default;
        }
    }
}
