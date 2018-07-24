using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r05_cmdTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 257; i++)
            {
                Console.WriteLine(i.ToString().PadLeft(3) + " " + (char)i);
            }
            Console.ReadKey();
        }
    }

    /** test embed exxtract
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "test cmd";
            Console.SetWindowSize(160, 59);
            Console.SetBufferSize(1024, 1024);
            do
            {
                Console.Clear();


                int mW = 10, mH = 10;

                for (int h = 0; h < mH; h++)
                {
                    for (int w = 0; w < mW; w++)
                    {
                        for (int p = 0; p < 3; p++)
                        {
                            int x = (h * mW * 3) + (w * 3) + p;
                            Console.Write(x.ToString().PadLeft(4));
                        }
                        Console.Write(" =");
                    }
                    Console.WriteLine();
                }



            } while (Console.ReadKey().Key != ConsoleKey.T);
        }
    }
     */
}
