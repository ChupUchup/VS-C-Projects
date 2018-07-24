using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Steganography
{
    public class LSB
    {
        private static byte newColor(byte baseColor, string bitMessage, byte pos)
        {
            string bitColor = Change.toBin(baseColor).PadLeft(8, '0');
            bitColor = bitColor.Insert(pos, bitMessage);
            bitColor = bitColor.Remove(pos + 1, 1);
            return (byte)Change.toInt(bitColor, 2);
        }

        private static string getBit(int baseColor, int pos)
        {
            string hsl = Change.toBin(baseColor).PadLeft(8, '0');
            return hsl.Substring(pos, 1);
        }

        public static Bitmap Embed(Bitmap image, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new Exception("No embedding process happened"); ;
            }
            else if (image == null)
            {
                throw new Exception("Image can not be null");
            }
            else if ((message.Length * 8) + 32 > image.Width * image.Height * 3)
            {
                throw new Exception("Message over image capacity");
            }
            else
            {
                Color currentPixel;
                byte bitTarget = 7;
                string bitMessage = "";
                int loop = 0, mW = image.Width, mH = image.Height;

                var encodeUTF8 = Encoding.UTF8.GetBytes(message);
                var encodeW1252 = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(1252), encodeUTF8);
                foreach (byte b in encodeW1252)
                {
                    bitMessage += (Change.toBin(b).PadLeft(8, '0'));
                }
                bitMessage = bitMessage.Insert(0, Change.toBin(message.Length).PadLeft(32, '0'));

                for (int h = 0; h < mH; h++)
                {
                    for (int w = 0; w < mW; w++)
                    {
                        for (int p = 0; p < 3; p++)
                        {
                            loop = (h * mW * 3) + (w * 3) + p;
                            if (loop < bitMessage.Length)
                            {
                                currentPixel = image.GetPixel(w, h);
                                if (p == 0) //R
                                {
                                    image.SetPixel(w, h, Color.FromArgb(
                                        currentPixel.A,
                                        newColor(currentPixel.R, bitMessage.Substring(loop, 1), bitTarget),
                                        currentPixel.G,
                                        currentPixel.B));
                                }
                                else if (p == 1) //G
                                {
                                    image.SetPixel(w, h, Color.FromArgb(
                                        currentPixel.A,
                                        currentPixel.R,
                                        newColor(currentPixel.G, bitMessage.Substring(loop, 1), bitTarget),
                                        currentPixel.B));
                                }
                                else if (p == 2) //B
                                {
                                    image.SetPixel(w, h, Color.FromArgb(
                                        currentPixel.A,
                                        currentPixel.R,
                                        currentPixel.G,
                                        newColor(currentPixel.B, bitMessage.Substring(loop, 1), bitTarget)));
                                }
                            }
                            else break;
                        }
                    }
                }
            }
            return image;
        }

        public static string Extract(Bitmap image)
        {
            string hsl = "";
            if (image != null)
            {
                Color currentPixel;
                byte[] tmp;
                byte bitTarget = 7;
                string bitMessage = "";
                int mLength = 0, loop = 0, count = 0, mW = image.Width, mH = image.Height;

                for (int h = 0; h < mH; h++)
                {
                    for (int w = 0; w < mW; w++)
                    {
                        for (int p = 0; p < 3; p++)
                        {
                            loop = (h * mW * 3) + (w * 3) + p;
                            if (loop < 32 + (mLength * 8))
                            {
                                currentPixel = image.GetPixel(w, h);
                                if (p == 0) //R
                                {
                                    bitMessage += (getBit(currentPixel.R, bitTarget));
                                }
                                else if (p == 1) //G
                                {
                                    bitMessage += (getBit(currentPixel.G, bitTarget));
                                }
                                else if (p == 2) //B
                                {
                                    bitMessage += (getBit(currentPixel.B, bitTarget));
                                }
                            }
                            else
                            {
                                if (mLength == 0)
                                {
                                    mLength = Change.toInt(bitMessage, 2);
                                    bitMessage = "";
                                    p -= 1;
                                    continue;
                                }
                                else break;
                            }
                        }
                    }
                }

                tmp = new byte[mLength];
                for (int i = 0; i < bitMessage.Length; i += 8)
                {
                    tmp[count] = (byte)Change.toInt(bitMessage.Substring(i, 8), 2);
                    count++;
                    //hsl += Encoding.UTF8.GetString(Encoding.Convert(Encoding.GetEncoding(1252), Encoding.UTF8, new byte[] { (byte)Change.toInt(bitMessage.Substring(i, 8), 2) }));
                }
                hsl = Encoding.UTF8.GetString(Encoding.Convert(Encoding.GetEncoding(1252), Encoding.UTF8, tmp));
            }
            return hsl;
        }
    }
}

        //public static Bitmap Embed(Bitmap image, string message)
        //{
        //    Bitmap hsl = null; 
        //    if (string.IsNullOrEmpty(message)) hsl = image;
        //    else if (image == null) throw new Exception("Citra tidak boleh null");
        //    else if ((message.Length * 8) + 32 > image.Width * image.Height * 3) throw new Exception("Message melebihi kapasitas citra");
        //    else
        //    {
        //        string bitMessage = ""; byte pos = 7;
        //        foreach (char i in message) bitMessage += (Change.toBin(i).PadLeft(8, '0'));
        //        bitMessage = bitMessage.Insert(0, Change.toBin(message.Length).PadLeft(32, '0'));
        //        var pix = Pixel.PixelArray(image);
        //        char flag = 'R';
        //        for (int i = 0; i < bitMessage.Length; i++)
        //        {
        //            int x = i / 3;
        //            if (flag == 'R')
        //            {
        //                flag = 'G';
        //                pix[x].R = newColor(pix[x].R, bitMessage.Substring(i, 1), pos);
        //            }
        //            else if (flag == 'G')
        //            {
        //                flag = 'B';
        //                pix[x].G = newColor(pix[x].G, bitMessage.Substring(i, 1), pos);
        //            }
        //            else if (flag == 'B')
        //            {
        //                flag = 'R';
        //                pix[x].B = newColor(pix[x].B, bitMessage.Substring(i, 1), pos);
        //            }
        //        }
        //        hsl = Pixel.CreateBitmap(pix, image.Size);
        //    }
        //    return hsl;
        //}
