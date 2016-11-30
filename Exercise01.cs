using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise01
    {
        static int print(int a, int b)
        {
            if (b < 1)
                return a;
            Console.Write(" {0}", a);
            b--;
            return print(a+1, b);
        }

        static void Main(string[] args)
        {
            int x;
            Console.Write("  How many numbers to print: ");
            x = Convert.ToInt32(Console.ReadLine());
            print(1,x);
            Console.ReadLine();
        }
    }
}
