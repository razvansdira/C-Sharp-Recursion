using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Recursion
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            int n, i;
            permutari test = new permutari();
            int[] arr = new int[5];

            Console.Write("  Input the number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("\n Element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe permutations with a combination of {0} digits are: ", n);
            test.permut(arr, 0, n - 1);

            Console.ReadLine();
        }
    }
}

class permutari
{
    public void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public void permut(int[] list, int k, int m)
    {
        int i;
        if (k == m)
        {
            for (i = 0; i <= m; i++)
                Console.Write("{0}", list[i]);
            Console.Write(" ");
        }
        else
            for (i = k; i <= m; i++)
            {
                swap(ref list[k], ref list[i]);
                permut(list, k + 1, m);
                swap(ref list[k], ref list[i]);
            }
    }
} 
