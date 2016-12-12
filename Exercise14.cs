using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise14
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("  Input a string: ");
            str = Console.ReadLine();

            str = reverse(str);
            Console.Write("The reverse of the string is: ");

            Console.Write(str);
            Console.ReadLine();
        }

        public static string reverse(string s)
        {
            if (s.Length > 0)
                return s[s.Length - 1] + reverse(s.Substring(0, s.Length - 1));
            else
                return s;
        }
    }
}
