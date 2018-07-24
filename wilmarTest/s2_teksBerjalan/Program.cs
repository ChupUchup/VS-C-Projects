using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace s2_teksBerjalan
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.WriteLine("Invalid Input");
                }
                Console.Write("\nPress any key to repeat, press T to exit : ");
            } while (Console.ReadKey(true).Key != ConsoleKey.T);
        }
    }
}
