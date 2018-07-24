using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace s1_bilanganPrima
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.WriteLine("Invalid Input");
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
    }
}
