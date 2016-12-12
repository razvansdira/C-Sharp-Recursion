using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            int x;
            DecToBinClass pg = new DecToBinClass();

            Console.Write(" Input a decimal number: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("The binary equivalent of {0} is: ", x);
            pg.binary(x);

            Console.ReadLine();
        }
    }

    public class DecToBinClass
    {
        public int binary(int n)
        {
            int bin;
            if (n != 0)
            {
                bin = (n % 2) + 10 * binary(n / 2);
                Console.Write(bin);
                return 0;
            }
            else
                return 0;
        }
    }
}
