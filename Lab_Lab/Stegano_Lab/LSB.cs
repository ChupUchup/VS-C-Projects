using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using myLib;

namespace Stegano_Lab
{
    public static class LSB
    {
        private static List<Color> Pixel = new List<Color>();
        private static Bitmap img_ori, img_hsl;
        private static int nP, nM, nK, P, G, inM, N;
        private static string M, K, bM, bK, bnM, M_1;
        //static Form myForm;
        //static ListBox LST;

        public static Bitmap Sisip(string myPesan, string myKunci, Bitmap myBmp)
        {
            //myForm = new Form(); LST = new ListBox();
            //myForm.Size = new Size(600, 600); LST.Size = new Size(580, 580);
            //LST.Location = new Point(0, 0);
            //myForm.Controls.Add(LST);
            //LST.Enabled = true;
            //myForm.Show(); 

            M = myPesan; K = myKunci; nM = M.Length;
            img_ori = myBmp; isiPixel();
            nP = img_ori.Width * img_ori.Height;

            bM = JadiBit(padChar(M));
            bM = padRight_3(bM); nM = bM.Length;

            bK = JadiBit(padChar(K));
            bK = padRight_3(bK); nK = bK.Length;

            inM = Misc.IntToBin(nP * 3).Length;
            bnM = padLeft_3(Misc.IntToBin(bM.Length).PadLeft(inM, '0'));

            M_1 = bnM + bK + bM;
            N = M_1.Length;

            SubSisip();
            img_hsl = JadiBmp();
            return img_hsl;
        }
        private static void SubSisip()
        {
            int count = 0; string flag = "R";
            for (int i = 0; i < nP; i++)
            {
                if (count < N)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (flag == "R")
                        {
                            if (count < N)
                            {
                                flag = "G";
                                Pixel[i] = Color.FromArgb(Pixel[i].A, banding(Pixel[i].R, Convert.ToInt32(M_1[count].ToString())), Pixel[i].G, Pixel[i].B);
                                count++;
                            }
                            else break;
                        }
                        else if (flag == "G")
                        {
                            if (count < N)
                            {
                                flag = "B";
                                Pixel[i] = Color.FromArgb(Pixel[i].A, Pixel[i].R, banding(Pixel[i].G, Convert.ToInt32(M_1[count].ToString())), Pixel[i].B);
                                count++;
                            }
                            else break;
                        }
                        else if (flag == "B")
                        {
                            if (count < N)
                            {
                                flag = "R";
                                Pixel[i] = Color.FromArgb(Pixel[i].A, Pixel[i].R, Pixel[i].G, banding(Pixel[i].B, Convert.ToInt32(M_1[count].ToString())));
                                count++;
                            }
                            else break;
                        }
                    }
                }
                else break;
            }
        }
        public static string Ekstrak(Bitmap myBmp, string myKunci)
        {
            //myForm = new Form(); LST = new ListBox();
            //myForm.Size = new Size(600, 600); LST.Size = new Size(580, 580);
            //LST.Location = new Point(0, 0);
            //myForm.Controls.Add(LST);
            //LST.Enabled = true;
            //myForm.Show();

            
            K = myKunci;
            img_ori = myBmp; isiPixel();
            nP = img_ori.Width * img_ori.Height;

            inM = padLeft_3(Misc.IntToBin(nP * 3)).Length;
            bnM = SubEkstrak(0, inM);
            nM = Misc.BinToInt(bnM);

            bK = SubEkstrak(inM, 129);
            K = JadiText(bK);

            bM = SubEkstrak(inM + 129, nM);
            M = JadiText(bM); nM = bM.Length;

            return M;
        }
        private static string SubEkstrak(int Start, int Panjang)
        {
            string res = ""; int count = 0; string flag = "R";
            for (int i = Start / 3; i < (Start + Panjang) / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (flag == "R")
                    {
                        if (count < Panjang)
                        {
                            flag = "G";
                            res += EkstrakBit(Pixel[i].R);
                            count++;
                        }
                        else break;
                    }
                    else if (flag == "G")
                    {
                        if (count < Panjang)
                        {
                            flag = "B";
                            res += EkstrakBit(Pixel[i].G);
                            count++;
                        }
                        else break;
                    }
                    else if (flag == "B")
                    {
                        if (count < Panjang)
                        {
                            flag = "R";
                            res += EkstrakBit(Pixel[i].B);
                            count++;
                        }
                        else break;
                    }
                }
            }
            return res;
        }
        
        private static Bitmap JadiBmp()
        {
            Bitmap tmp = new Bitmap(img_ori.Width, img_ori.Height);
            for (int i = 0; i < tmp.Height; i++)
            {
                for (int j = 0; j < tmp.Width; j++)
                {
                    tmp.SetPixel(j, i, Pixel[(i * tmp.Width) + j]);
                }
            }
            return tmp;
        }
        private static string JadiBit(string Text)
        {
            string res = "";
            foreach (char i in Text) { res = res + (Misc.IntToBin((int)i).PadLeft(8, '0')); }
            return res;
        }
        private static string JadiText(string Bit)
        {
            int limit = Bit.Length / 8;
            string res = "";
            for (int i = 0; i < limit; i++)
            {
                res += (char)(Misc.BinToInt(Bit.Substring(i * 8, 8)));
            }
            return res;
        }
        private static string padRight_3(string Bit)
        {
            return Bit.PadRight(Bit.Length + ((3 - (Bit.Length % 3)) % 3), '0');
        }
        private static string padLeft_3(string Bit)
        {
            return Bit.PadLeft(Bit.Length + ((3 - (Bit.Length % 3)) % 3), '0');
        }
        private static string padChar(string Text, int Panjang = 16)
        {
            if (Text.Length == 0) return Text.PadRight(Panjang, (char)32);
            else return Text.PadRight(Text.Length + ((Panjang - (Text.Length % Panjang)) % Panjang), (char)32);
        }
        private static bool isGanjil(int num)
        {
            if (num % 2 == 0) return false;
            return true;
        }
        private static void isiPixel()
        {
            for (int i = 0; i < img_ori.Height; i++)
            {
                for (int j = 0; j < img_ori.Width; j++)
                {
                    Pixel.Add(img_ori.GetPixel(j, i));
                }
            }
        }
        private static int banding(int pix, int bitM)
        {
            if (isGanjil(pix))
            {
                if (isGanjil(bitM)) return pix;
                else return pix - 1;
            }
            else
            {
                if (isGanjil(bitM)) return pix + 1;
                else return pix;
            }
        }
        private static char EkstrakBit(int num)
        {
            if (num % 2 == 0) return '0';
            return '1';
        }
        private static int newLenght(int Awal)
        {
            if (Awal % 3 != 0) return (Awal / 3) + 1;
            else return Awal / 3;
        }
    }
}
