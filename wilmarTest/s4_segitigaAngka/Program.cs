using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace s4_segitigaAngka
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.WriteLine("Invalid Input");
                }
                Console.Write("\nPress any key to repeat, press T to exit : ");
            } while (Console.ReadKey(true).Key != ConsoleKey.T);
        }
    }
}
