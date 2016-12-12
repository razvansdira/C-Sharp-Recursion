using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise08
    {
        static void Main(string[] args)
        {
            string s;
            bool tf;

            Console.Write(" Input a string: ");
            s = Console.ReadLine();
            tf = palindrom(s);

            if (tf == true)
                Console.WriteLine("The string is palindrome.");
            else
                Console.WriteLine("The string is not a palindrome.");
            Console.ReadLine();
        }

        static bool palindrom(string txt)
        {
            if (txt.Length <= 1)
                return true;
            else
            {
                if (txt[0] != txt[txt.Length - 1])
                    return false;
                else
                    return palindrom(txt.Substring(1, txt.Length - 2));
            }
        }
    }
}
