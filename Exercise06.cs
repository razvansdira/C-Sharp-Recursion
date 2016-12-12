using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise06
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("  Input the range: 1 - ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("   All even numbers are: ");
            eo(2, x);

            Console.WriteLine("\n   All odd numbers are: ");
            eo(1, x);

            Console.ReadLine();
            return;            
        }

        static void eo(int val, int x)
        {
            if (val > x)
                return;
            Console.Write(" {0}", val);
            eo(val + 2, x);
        }
    }
}
