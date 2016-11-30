using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("   Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write(" The sum of first {1} number is {0}.", sum(1, x),x);
            Console.ReadLine();
        }

        static int calc(int m, int n)
        {
            if (n == m)
                return n;
            return n + calc(m, n - 1);
        }

        static int sum(int a, int b)
        {
            return calc(a, b);
        }
    }
}
