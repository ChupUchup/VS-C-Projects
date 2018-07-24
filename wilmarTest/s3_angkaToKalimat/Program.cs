using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace s3_angkaToKalimat
{
    class Program
    {
        enum toKalimat
        {
            satu = 1, 
            dua = 2, 
            tiga = 3, 
            empat = 4, 
            lima = 5, 
            enam = 6, 
            tujuh = 7, 
            delapan = 8, 
            sembilan = 9
        };

        static void Main(string[] args)
        {
            UInt64 input;
            Console.Title = "Soal 3 : Angka Menjadi Kalimat";
            do
            {
                Console.Clear();
                input = 0;
                Console.Write("Input User : ");
                try
                {
                    input = Convert.ToUInt64(Console.ReadLine());
                    printLine("Konversi   : " + ubah(input), ConsoleColor.Green);
                }
                catch
                {
                    printLine("Invalid Input", ConsoleColor.Red);
                }
                Console.Write("\nPress any key to repeat, press T to exit : ");
            } while (Console.ReadKey(true).Key != ConsoleKey.T);
        }

        static string ubah(UInt64 input)
        {
            string hsl = "", t = input.ToString();
            t = t.PadLeft(t.Length + ((3 - (t.Length % 3)) % 3), '0');
            byte count = (byte)t.Length;
            for (int i = 0; i < t.Length;)
            {
                for (int j = 0; j < 3; j++)
                {
                    byte b = Convert.ToByte(t.Substring(i + j, 1));
                    if (b != 0)
                    {
                        if (j == 0)
                        {
                            if (b == 1) hsl += "se";
                            else hsl += (toKalimat)b + " ";
                            hsl += "ratus ";
                        }
                        else if (j == 1)
                        {
                            byte b2 = Convert.ToByte(t.Substring(i + j + 1, 1));
                            if (b == 1)
                            {
                                if (b2 == 0) hsl += "sepuluh ";
                                else if (b2 == 1) hsl += "sebelas ";
                                else hsl += (toKalimat)b2 + " belas ";
                                j += 1;
                            }
                            else hsl += (toKalimat)b + " puluh "; 

                        }
                        else if (j == 2)
                        {
                            if (count > 3 && count < 7)
                            {
                                Int16 b3 = Convert.ToInt16(t.Substring(t.Length - count, 3));
                                if (b3 == 1) hsl += "se";
                                else hsl += (toKalimat)b + " ";
                            }
                            else hsl += (toKalimat)b + " ";
                        }
                    }
                }
                Int16 b4 = Convert.ToInt16(t.Substring(i, 3));
                if (b4 != 0)
                {
                    if (count > 15) hsl += "bilyun ";
                    else if (count > 12) hsl += "trilyun ";
                    else if (count > 9) hsl += "milyar ";
                    else if (count > 6) hsl += "juta ";
                    else if (count > 3) hsl += "ribu ";
                }
                count -= 3;
                i += 3;
            }
            return hsl;
        }

        static void printLine(string text, ConsoleColor clr)
        {
            Console.ForegroundColor = clr;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
