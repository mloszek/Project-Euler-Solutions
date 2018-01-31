using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Solution9
    {
        static int a;
        static int b;
        static int c;

        static void FindTriple()
        {

            a = 0;
            b = 0;
            c = 0;

            for (int n = 1; n < 40; n++)
            {
                for (int m = n + 1; m < 40; m++)
                {
                    a = Convert.ToInt32(Math.Pow(m, 2) - Math.Pow(n, 2));
                    b = 2 * m * n;
                    c = Convert.ToInt32(Math.Pow(m, 2) + Math.Pow(n, 2));
                    if (a + b + c == 1000)
                    {
                        Console.WriteLine(a * b * c);
                    }

                }
            }
        }

        static void Main(string[] args)
        {
            FindTriple();
            Console.ReadKey();
        }
    }
}
