using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            int n, pow;
            int result;

            Console.Write(" Input the base value: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("   Input the exponent: ");
            pow = Convert.ToInt32(Console.ReadLine());

            result = calcul(n, pow);

            Console.Write("  {0} ^ {1} = {2}", n, pow, result);
            Console.ReadLine();
        }

        public static int calcul(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * calcul(x, y - 1);
        }
    }
}
