using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise05
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("   Input any big number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(" The number {0} contains {1} digits.", n, d(n, 0));
            Console.ReadLine();
        }

        public static int d(int n1, int n2)
        {
            if (n1 == 0)
                return n2;
            return d(n1 / 10, ++n2);
        }
    }
}
