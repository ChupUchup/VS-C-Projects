using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s0_wilmarTest
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
            bool exitFlag = true;
            byte menu;
            do
            {
                Console.Clear();
                Console.Title = "Wilmar Test";
                Console.WriteLine("1. Bilangan Prima");
                Console.WriteLine("2. Teks Berjalan");
                Console.WriteLine("3. Angka Menjadi Kalimat");
                Console.WriteLine("4. Segitiga Angka");
                Console.WriteLine("5. Exit");
                Console.Write("\nPilih Menu : ");
                try
                {
                    menu = Convert.ToByte(Console.ReadLine());
                    if (menu == 1) s1();
                    else if (menu == 2) s2();
                    else if (menu == 3) s3();
                    else if (menu == 4) s4();
                    else if (menu == 5) exitFlag = false;
                    else throw new Exception();
                }
                catch
                {
                    printLine("\nInvalid Input", ConsoleColor.Red);
                    Console.ReadKey(true);
                }
            } while (exitFlag);
        }

        static void s1()
        {
            uint input;
            Console.Title = "Soal 1 : Bilangan Prima";
            do
            {
                Console.Clear();
                Console.Write("Input User : ");
                try
                {
                    input = Convert.ToUInt32(Console.ReadLine());
                    if (input > 1)
                    {
                        for (uint i = 2; i <= input; i++)
                        {
                            if (isPrima(i)) Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    else Console.WriteLine("Input Harus Lebih Dari 1");
                }
                catch
                {
                    printLine("Invalid Input", ConsoleColor.Red);
                }
                Console.Write("\nPress any key to repeat, press T to exit : ");
            } while (Console.ReadKey(true).Key != ConsoleKey.T);
        }

        static void s2()
        {
            string input;
            Console.Title = "Soal 2 : Teks Berjalan";
            do
            {
                Console.Clear();
                Console.Write("Input User : ");
                try
                {
                    input = Console.ReadLine() + " ";
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(input);
                        input = input + input.Substring(0, 1);
                        input = input.Remove(0, 1);
                        System.Threading.Thread.Sleep(200);
                    } while (true);
                }
                catch
                {
                    printLine("Invalid Input", ConsoleColor.Red);
                }
                Console.Write("\nPress any key to repeat, press T to exit : ");
            } while (Console.ReadKey(true).Key != ConsoleKey.T);
        }

        static void s3()
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

        static void s4()
        {
            uint input;
            Console.Title = "Soal 4 : Segitiga Angka";
            do
            {
                Console.Clear();
                input = 0;
                Console.Write("Input User : ");
                try
                {
                    input = Convert.ToUInt32(Console.ReadLine());
                    for (uint i = input; i > 0; i--)
                    {
                        for (uint j = 0; j < i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (uint k = input; k >= i; k--)
                        {
                            Console.Write(k);
                        }
                        Console.WriteLine();
                    }
                }
                catch
                {
                    printLine("Invalid Input", ConsoleColor.Red);
                }
                Console.Write("\nPress any key to repeat, press T to exit : ");
            } while (Console.ReadKey(true).Key != ConsoleKey.T);
        }

        static bool isPrima(uint angka)
        {
            byte count = 0;
            for (int i = 2; i <= angka / 2; i++)
            {
                if (angka % i == 0) count++;
            }
            if (count > 0) return false;
            else return true;
        }

        static string ubah(UInt64 input)
        {
            string hsl = "", t = input.ToString();
            t = t.PadLeft(t.Length + ((3 - (t.Length % 3)) % 3), '0');
            byte count = (byte)t.Length;
            for (int i = 0; i < t.Length; )
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
