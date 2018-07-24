using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace char_to_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "char_to_int";
            char myinput = ' ';
            do
            {
                Console.Clear();

                Console.Write("masukkan karakter : "); myinput = Convert.ToChar(Console.ReadLine());
                Console.WriteLine((int)myinput);

                Console.Write("lagi ? y / t: ");
            } while (Console.ReadKey().KeyChar != 't');
        }
    }
}
