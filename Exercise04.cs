using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise04
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("  Input a big number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" The digits are: ");
            separ(n);
            Console.ReadLine();
        }

        static void separ(int x)
        {
            if (x < 10)
            {
                Console.Write("{0} ", x);
                return;
            }
            separ(x / 10);
            Console.Write(" {0} ", x % 10);
        }
    }
}
