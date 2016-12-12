using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            long n, m, z, lcm;

            Console.Write("  Input the first number: ");
            n = Convert.ToInt64(Console.ReadLine());

            Console.Write(" Input the second number: ");
            m = Convert.ToInt64(Console.ReadLine());

            z = gcd(n, m);
            lcm = (n * m) / z;

            Console.WriteLine("The GCD of {0} and {1} = {2} ", n, m, z);
            Console.WriteLine("The LCM of {0} and {1} = {2}\n", n, m, lcm);

            Console.ReadLine();
        }

        static long gcd(long x, long y)
        {
            if (y == 0)
                return x;
            else
                return gcd(y, x % y);
        }
    }
}
