using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise07
    {
        static int Main(string[] args)
        {
            int n, p;
            Console.Write("  Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            p = check(n, n / 2);

            if (p == 1)
                Console.Write("The number {0} is prime.", n);
            else
                Console.Write("The number {0} is not prime.", n);

            Console.ReadLine();
            return 0;
        }

        static int check(int l, int m)
        {
            if (m == 1)
                return 1;
            else
            {
                if (l % m == 0)
                    return 0;
                else
                    return check(l, m - 1);
            }
        }
    }
}
