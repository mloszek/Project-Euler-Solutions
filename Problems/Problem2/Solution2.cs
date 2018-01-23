using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Solution2
    {
        static long SumOfFibonacciTermsLesserThanThreshold(long threshold)
        {

            long result = 0;
            long a = 1;
            long b = 2;
            long c = 0;

            result += b;

            while (b <= threshold)
            {
                c = b;
                b = a + b;
                a = c;

                if (b % 2 == 0)
                {
                    result += b;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumOfFibonacciTermsLesserThanThreshold(4000000));

            Console.ReadKey();
        }
    }
}
