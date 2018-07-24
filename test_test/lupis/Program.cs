using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lupis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "lupis";
            do
            {
                Console.Clear();
                int max = 0;
                Console.Write("input max : "); max = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
                for (int i = 1; i <= max + 1; i++)
                {
                    for (int j = 1; j < i; j++) Console.Write(j);
                    Console.WriteLine();
                }
                for (int i = max - 1; i > 0; i--)
                {
                    for (int j = 1; j <= i; j++) Console.Write(j);
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.Write("ulangi ? Y/T : ");
            } while (char.ToUpper(Console.ReadKey().KeyChar) != 'T');
        }
    }
}
