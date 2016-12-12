using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise09
    {
        static void Main(string[] args)
        {
            Console.Write(" Input a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long f = factorial(n);

            Console.Write("The factorial is: {0}.", f);
            Console.ReadLine();
        }

        static long factorial(int x)
        {
            if (x == 0)
                return 1;
            return x * factorial(x - 1);
        }
    }
}
