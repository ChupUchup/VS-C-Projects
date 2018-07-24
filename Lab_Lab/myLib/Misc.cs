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
    public static class Misc
    {
        private static BitArray ListPrima;

        public static int GetPrima(int Seed)
        {
            int xPrima = 0, xSeed = Seed;
            try
            {
                if (xSeed % 2 == 0) xSeed = xSeed - 1;
                for (int i = xSeed; i > 1; i -= 2)
                {
                    if (Misc.isPrima(i)) { xPrima = i; break; }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(
                    "Error Type : " + err.GetType().ToString() + "\n\n" +
                    "Error Message : " + err.Message.ToString(),
                    "Error Information");
            }
            return xPrima;
        }

        public static int GetGemod(int xP, int Mode = 4)
        {
            int xGemod = 0;
            try
            {
                if (Misc.isPrima(xP))
                {
                    int Pos = 0;
                    if (Mode == 1)
                    {
                        for (int i = 1; i < xP; i += 2)
                        {
                            if (Misc.isGemod(i, xP)) { xGemod = i; break; }
                        }
                    }
                    else if (Mode == 2)
                    {
                        Pos = xP / 2;
                        if (Pos % 2 == 0) Pos -= 1;
                        for (int i = Pos; i > 2; i -= 2)
                        {
                            if (Misc.isGemod(i, xP)) { xGemod = i; break; }
                        }
                    }
                    else if (Mode == 3)
                    {
                        Pos = xP / 2;
                        if (Pos % 2 == 0) Pos += 1;
                        for (int i = Pos; i < xP; i += 2)
                        {
                            if (Misc.isGemod(i, xP)) { xGemod = i; break; }
                        }
                    }
                    else if (Mode == 4)
                    {
                        for (int i = xP; i > 1; i -= 2)
                        {
                            if (Misc.isGemod(i, xP)) { xGemod = i; break; }
                        }
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
            return xGemod;
        }

        public static int GF_8(int num1, int num2)
        {
            int res = 0;
            while (num2 > 0)
            {
                if ((num2 & 1) == 1)
                {
                    res ^= num1;
                }
                num1 <<= 1;
                if ((num1 & 1 << 8) == 1 << 8)
                    num1 ^= 0x00011B;
                num2 >>= 1;
            }
            return res;
        }

        public static int FastExp(int num, int power, int divisor)
        {
            return (int)FastExp((long)num, (long)power, (long)divisor);
        }

        public static long FastExp(long num, long power, long divisor)
        {
            long res = 1;
            long y = num;
            while (power > 0)
            {
                if ((power & 1) == 1)
                {
                    //res = (res * y) % div;
                    res = KaliMod(res, y, divisor);
                }
                //y = (y * y) % div;
                y = KaliMod(y, y, divisor);
                power >>= 1;
            }
            return res % divisor;
        }

        private static long KaliMod(long num1, long num2, long divisor)
        {
            long res = 0;
            long y = num1 % divisor;
            while (num2 > 0)
            {
                if ((num2 & 1) == 1)
                {
                    res = (res + y) % divisor;
                }
                y = (y * 2) % divisor;
                num2 >>= 1;
            }
            return res;
        }

        private static bool isPrima(long pnP, long pnA = 1662803)
        {
            if ((pnP % 2 == 0 && pnP != 2) || pnP < 2)
            {
                return false;
            }
            else
            {
                return isRabin(pnP, pnA);
            }
        }

        private static bool isGemod(int number, int divisor)
        {
            //if (!PrimaListed)
            //{
            Sieve(divisor);
            //    PrimaListed = true;
            //}
            List<int> faktorPrima = new List<int>();
            int p = number - 1;
            int sq = (int)Math.Sqrt(p);
            for (int i = 2; i <= sq && p > 1; i++)
            {
                if (ListPrima[i] && p % i == 0)
                {
                    faktorPrima.Add(i);
                    while (p % i == 0)
                    {
                        p /= i;
                    }
                }
            }
            if (p > 1)
            {
                faktorPrima.Add(p);
            }
            p = number - 1;
            bool res = true;
            foreach (int prima in faktorPrima)
            {
                int mod = FastExp(number, p / prima, divisor);
                res &= (mod > 1);
            }
            return res;
        }

        private static bool isRabin(long pnP, long pnA)
        {
            int nTemp;
            long pnC;
            int pnB;
            long pnM;
            long pnJ;
            long pnZ;
            if (pnP == 2)
                return true;
            pnC = pnP - 1;
            nTemp = 0;
            while (pnC % (1 << nTemp) == 0 && (1 << nTemp) < pnP)
            {
                nTemp = nTemp + 1;
            }
            pnB = nTemp - 1;
            pnM = pnC / (1 << pnB);
            pnJ = 0;
            pnZ = FastExp(pnA, pnM, pnP);
            if (pnZ == 1 || pnZ == (pnP - 1))
                return true;
            while (true)
            {
                if (pnJ > 0 && pnZ == 1)
                    return false;
                pnJ = pnJ + 1;
                if (pnJ < pnB && pnZ != pnP - 1)
                {
                    pnZ = FastExp(pnZ, (long)2, pnP);
                    continue;
                }
                else
                {
                    break;
                }
            }
            if (pnZ == pnP - 1)
                return true;
            if (pnJ == pnB && pnZ != pnP - 1)
                return false;
            return true;
        }

        private static void Sieve(int Limit)
        {
            ListPrima = new BitArray(Limit, false);
            int n = Limit - 1;
            ListPrima[2] = true;
            for (int i = 3; i <= n; i += 2)
            {
                ListPrima[i] = true;
            }
            int sq = (int)Math.Sqrt(n + 1e-6);
            for (int i = 3; i <= sq; i += 2)
            {
                if (ListPrima[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        ListPrima[i] = false;
                    }
                }
            }
        }

        public static string IntToHex(this int number)
        {
            return number.ToString("X2");
        }

        public static string IntToBin(this int number)
        {
            return Convert.ToString(number, 2);
        }

        public static int BinToInt(this string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        public static int HexToInt(this string hexa)
        {
            return int.Parse(hexa, System.Globalization.NumberStyles.HexNumber);
        }

        public static string BinToHex(this string binary)
        {
            return binary.BinToInt().IntToHex();
        }

        public static string HexToBin(this string hexa)
        {
            return hexa.HexToInt().IntToBin();
        }

        ///// <summary>
        ///// Fungsi Mencari generator modulo dar internet
        ///// http://www.bluetulip.org/2014/programs/primitive.html
        ///// </summary>
        ///// <param name="theNum"></param>
        ///// <returns></returns>
        //private static int IsRoot(int theNum)
        //{
        //    int ooo = 1;
        //    double k = 0;
        //    List<int> roots = new List<int>();
        //    //var z = 0;

        //    for (var r = 3; r < theNum; r += 2)
        //    {
        //        if (IsPrima(r))
        //        {
        //            k = Math.Pow(r, ooo);
        //            k %= theNum;
        //            while (k > 1)
        //            {
        //                ooo++;
        //                k *= r;
        //                k %= theNum;
        //            }
        //            if (ooo == (theNum - 1))
        //            {
        //                roots.Add(r);
        //            }
        //            ooo = 1;
        //        }
        //    }
        //    return roots.Count;
        //}
    }
}
