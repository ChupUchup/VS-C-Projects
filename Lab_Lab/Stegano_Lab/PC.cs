using myLib;
using System;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Stegano_Lab
{
    public static class Stego
    {
        public enum Mode { PCA, PCS, LSBA, LSBS };
        public enum Enkrip { NoEnkrip, AES128, AES256 };
    }
    public static class PC
    {
        #region Variable
        
        private static Bitmap img_ori, img_hsl;
        private static List<Color> Pixel;
        private static int nP, Pr, G, nM, inM, N, Y; //nK tidak dipakai, static 32
        private static string M, K, bM, bK, bnM, eM, M_1, Rotasi = "R";
        #endregion Variable

        #region Sisip
        public static Bitmap Sisip(string myPesan, string myKunci, Bitmap myBmp, Stego.Mode myMode, Stego.Enkrip myEnkrip)
        {
            if (isBmpCukup(myPesan, myKunci, myBmp, myMode, myEnkrip))
            {
                isiPixel();
                SubSisip(myMode);
                img_hsl = JadiBmp();
            }
            return img_hsl;
        }
        public static bool isBmpCukup(string myPesan, string myKunci, Bitmap myBmp, Stego.Mode myMode, Stego.Enkrip myEnkrip)
        {
            bool res = false;

            M = myPesan;
            K = myKunci;

            img_ori = myBmp;
            nP = img_ori.Width * img_ori.Height;

            
            if(myEnkrip==Stego.Enkrip.AES128)
            {
                bK = JadiBit(PadChar(K, 16), 8);
                eM = AES.Enkrip(PadChar(M, 16), PadChar(K, 16));
            }
            else if (myEnkrip == Stego.Enkrip.AES256) { MessageBox.Show("Maaf Fitur AES256 Belum Ada", "Informasi"); }
            else if (myEnkrip == Stego.Enkrip.NoEnkrip) { K = ""; bK = ""; eM = M; }

            bM = JadiBit(eM);

            inM = Misc.IntToBin(nP).Length;
            bnM = Misc.IntToBin(bM.Length).PadLeft(inM, '0');

            M_1 = bnM + bK + bM;
            N = M_1.Length;

            if (myMode == Stego.Mode.PCA)
            {
                Pr = Misc.GetPrima(nP);
                G = Misc.GetGemod(Pr);
                if (Pr > N) res = true;
                else res = false;
            }
            else if (myMode == Stego.Mode.PCS)
            {
                if (nP > N) res = true;
                else res = false;
            }
            return res;
        }
        private static void SubSisip(Stego.Mode myMode)
        {
            if (myMode == Stego.Mode.PCA)
            {
                Rotasi = "R";
                for (int i = 1; i < Pr; i++)
                {
                    Y = Misc.FastExp(G, i, Pr);
                    if (i - 1 < N)
                    {
                        if (isGanjil(Pixel[Y].R + Pixel[Y].G + Pixel[Y].B + Convert.ToInt32(M_1[i - 1].ToString())))
                        {
                            Pixel[Y] = newPixel(Pixel[Y]);
                        }
                    }
                    else break;
                }
            }
            else if (myMode == Stego.Mode.PCS)
            {
                Rotasi = "R";
                for (int i = 0; i < N; i++)
                {
                    if (isGanjil(Pixel[i].R + Pixel[i].G + Pixel[i].B + Convert.ToInt32(M_1[i].ToString())))
                    {
                        Pixel[i] = newPixel(Pixel[i]);
                    }
                }
            }
        }
        #endregion Ekstrak

        #region Ekstrak
        public static string Ekstrak(Bitmap myBmp, string myKunci, Stego.Mode myMode, Stego.Enkrip myEnkrip)
        {
            if (isKunciSama(myBmp, myKunci, myMode, myEnkrip))
            {

                if (myEnkrip == Stego.Enkrip.AES128)
                {
                    bM = SubEkstrak(myMode, (inM + 128), nM);
                    eM = JadiText(bM);
                    M = AES.Dekrip(eM, K, 4);
                }
                else if (myEnkrip == Stego.Enkrip.AES256) { M = "Maaf Fitur AES256 Belum Ada"; }
                else if (myEnkrip == Stego.Enkrip.NoEnkrip)
                {
                    bM = SubEkstrak(myMode, inM, nM);
                    eM = JadiText(bM);
                    M = eM;
                }
            }
            return M;
        }
        public static bool isKunciSama(Bitmap myBmp, string myKunci, Stego.Mode myMode, Stego.Enkrip myEnkrip)
        {
            img_ori = myBmp; isiPixel();

            nP = img_ori.Width * img_ori.Height;
            inM = Misc.IntToBin(nP).Length;

            if (myMode == Stego.Mode.PCA)
            {
                Pr = Misc.GetPrima(nP);
                G = Misc.GetGemod(Pr);
            }

            bnM = SubEkstrak(myMode, 0, inM);
            nM = Misc.BinToInt(bnM);
            //MessageBox.Show(myEnkrip.ToString(), "Informasi");
            if (myEnkrip == Stego.Enkrip.AES128)
            {
                bK = SubEkstrak(myMode, inM, 128);
                K = JadiText(bK).Trim(); 
            }
            else if (myEnkrip == Stego.Enkrip.AES256) { MessageBox.Show("Maaf Fitur AES256 Belum Ada", "Informasi"); }
            else if (myEnkrip == Stego.Enkrip.NoEnkrip) { bK = ""; K = ""; }
            
            //MessageBox.Show(K);

            if (K == myKunci) return true;
            else return false;
        }
        private static string SubEkstrak(Stego.Mode myMode, int Start, int Panjang)
        {
            string res = "";
            if (myMode == Stego.Mode.PCA)
            {
                for (int i = 1 + Start; i <= (Start + Panjang); i++)
                {
                    int Y = Misc.FastExp(G, i, Pr);
                    if (isGanjil(Pixel[Y].R + Pixel[Y].G + Pixel[Y].B)) res += "1";
                    else res += "0";
                }
            }
            else if (myMode == Stego.Mode.PCS)
            {
                for (int i = Start; i < (Start + Panjang); i++)
                {
                    if (isGanjil(Pixel[i].R + Pixel[i].G + Pixel[i].B)) res += "1";
                    else res += "0";
                }
            }
            return res;
        }
        #endregion Ekstrak

        #region Fungsi Umum
        private static string PadChar(string Text, int Block = 16)
        {
            if (Text.Length == 0) return Text.PadRight(Block, (char)32);
            else return Text.PadRight(Text.Length + ((Block - (Text.Length % Block)) % Block), (char)32);
        }
        private static Color newPixel(Color col)
        {
            if (Rotasi == "R") { Rotasi = "G"; return Color.FromArgb(col.A, ReverseColor(col.R), col.G, col.B); }
            else if (Rotasi == "G") { Rotasi = "B"; return Color.FromArgb(col.A, col.R, ReverseColor(col.G), col.B); }
            else { Rotasi = "R"; return Color.FromArgb(col.A, col.R, col.G, ReverseColor(col.B)); }
        }
        private static Bitmap JadiBmp()
        {
            Bitmap temp = new Bitmap(img_ori.Width, img_ori.Height);
            for (int i = 0; i < temp.Height; i++)
            {
                for (int j = 0; j < temp.Width; j++)
                {
                    temp.SetPixel(j, i, Pixel[(i * temp.Width) + j]);
                }
            }
            return temp;
        }
        private static string JadiText(string bitbit)
        {
            string res = "";
            for (int i = 0; i < bitbit.Length; i += 8)
            {
                res += ((char)Misc.BinToInt(bitbit.Substring(i, 8)));
            }
            return res;
        }
        private static string JadiBit(string Text, int Block = 8)
        {
            string res = "";
            foreach (char i in Text)
            {
                string bit = Misc.IntToBin((int)i);
                res += (bit.PadLeft(bit.Length + ((Block - (bit.Length % Block)) % Block), '0'));
            }
            return res;
        }
        private static int ReverseColor(int num)
        {
            if (isGanjil(num)) return num - 1;
            else return num + 1;
        }
        private static bool isGanjil(int num)
        {
            if (num % 2 != 0) return true;
            else return false;
        }
        private static void isiPixel()
        {
            Pixel = new List<Color>();
            for (int i = 0; i < img_ori.Height; i++)
            {
                for (int j = 0; j < img_ori.Width; j++)
                {
                    Pixel.Add(img_ori.GetPixel(j, i));
                }
            }
        }
        #endregion Fungsi Umum
    }
}
