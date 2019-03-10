using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
