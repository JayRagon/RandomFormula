using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFormula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("What will be the length of the formula\n> ");
            Int32 length = Int32.Parse(Console.ReadLine());

            Int64 x = 123543123;
            Int64 y = 123543123;

            Int64[] addBy = new Int64[length];

            for (int i = 0; i < 1000000000; i++)
            {
                x = 123543123;
                for (int a = 0; a < length; a++)
                {
                    addBy[a] = (Int64)rnd.Next(-10, 10);
                    x += addBy[a];
                }

                if (x == y)
                {
                    for (int e = 0; e < length; e++)
                    {
                        Console.WriteLine(addBy[e]);
                    }

                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
