using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace myLib
{
    public class Draw
    {
        public static Bitmap GetImg()
        {
            Bitmap img = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Gambar Bmp (*.bmp;*.BMP)|*.bmp;*.BMP";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!ofd.FileName.Equals(""))
                    {
                        img = new Bitmap(ofd.FileName);
                        ofd.Dispose();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(
                    "Error Type : " + err.GetType().ToString() + "\n\n" +
                    "Error Message : " + err.Message.ToString(),
                    "Error Information");
            }
            GC.Collect();
            return img;
        }

        public static void SaveImg(Bitmap img)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Gambar Bmp (*.bmp;*.BMP)|*.bmp;*.BMP";
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!sfd.FileName.Equals(""))
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                        img.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        fs.Dispose(); sfd.Dispose();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(
                    "Error Type : " + err.GetType().ToString() + "\n\n" +
                    "Error Message : " + err.Message.ToString(),
                    "Error Information");
            }
        }

        public static string GetText()
        {
            string Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File (*.txt;*.TXT)|*.txt;*.TXT";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!ofd.FileName.Equals(""))
                    {
                        FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        Text = sr.ReadToEnd();
                        sr.Dispose(); fs.Dispose(); ofd.Dispose();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(
                    "Error Type : " + err.GetType().ToString() + "\n\n" +
                    "Error Message : " + err.Message.ToString(),
                    "Error Information");
            }
            GC.Collect();
            return Text;
        }

        public static void SaveText(string Text)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File (*.txt;*.TXT)|*.txt;*.TXT";
            sfd.AddExtension = true;
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!sfd.FileName.Equals(""))
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(Text);
                        sw.Dispose(); sfd.Dispose();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(
                    "Error Type : " + err.GetType().ToString() + "\n\n" +
                    "Error Message : " + err.Message.ToString(),
                    "Error Information");
            }
        }

        public static Bitmap GetScaledImage(Bitmap img, int maxWidth, int maxHeight)
        {
            Bitmap newImage = null;
            try
            {
                var ratioX = (double)maxWidth / img.Width;
                var ratioY = (double)maxHeight / img.Height;
                var ratio = Math.Min(ratioX, ratioY);
                var newWidth = (int)(img.Width * ratio);
                var newHeight = (int)(img.Height * ratio);
                newImage = new Bitmap(newWidth, newHeight);
                using (Graphics g = Graphics.FromImage(newImage))
                {
                    g.Clear(Color.Transparent);
                    g.DrawImage(img, 0, 0, newWidth, newHeight);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(
                    "Error Type : " + err.GetType().ToString() + "\n\n" +
                    "Error Message : " + err.Message.ToString(),
                    "Error Information");
            }
            return newImage;
        }

        public static void DrawScaledImg(PictureBox KanvasTarget, Bitmap img)
        {
            try
            {
                if (img != null)
                {
                    Bitmap imgNew = new Bitmap(GetScaledImage(img, KanvasTarget.Width, KanvasTarget.Height));
                    Graphics g = Graphics.FromImage(KanvasTarget.Image);
                    g.Clear(Color.Transparent);
                    g.DrawImage(imgNew,
                        new Rectangle(0, 0, imgNew.Width, imgNew.Height),
                        new Rectangle(0, 0, imgNew.Width, imgNew.Height),
                        GraphicsUnit.Pixel);
                    KanvasTarget.Invalidate();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(
                    "Error Type : " + err.GetType().ToString() + "\n\n" +
                    "Error Message : " + err.Message.ToString(),
                    "Error Information");
            }
        }

        public static int[] GetHistogram(Bitmap img)
        {
            int[] Histo = new int[256];
            if (img != null)
            {
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        Color pixel = img.GetPixel(j, i);
                        Histo[pixel.R]++;
                        Histo[pixel.G]++;
                        Histo[pixel.B]++;
                    }
                }
            }
            return Histo;
        }
    }
}
