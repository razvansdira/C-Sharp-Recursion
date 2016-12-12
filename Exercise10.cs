using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            Console.Write("  Input number of terms for the Fibonacci series: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Fibonacci series of {0} terms is: ", a);
            for (int i = 0; i < a; i++)
                Console.Write("{0} ", fibo(i));
            Console.ReadLine();
        }

        public static int fibo(int x)
        {
            int m = 0;
            int n = 1;
            for (int i = 0; i < x; i++)
            {
                int temp = m;
                m = n;
                n = temp + n;
            }
            return m;
        }
    }
}
