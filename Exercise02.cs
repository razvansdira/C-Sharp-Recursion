using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("  How many numbers to print: ");
            x = Convert.ToInt32(Console.ReadLine());
            print(x, 1);
            Console.ReadLine();
        }

        static int print(int a, int b)
        {
            if (a < 0)
                return b;
            Console.Write(" {0}", a);
            a--;
            return print(a, b);
        }
    }
}
