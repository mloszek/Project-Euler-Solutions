using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Solution1
    {
        static int SumAllNumbersDivisableBy3And5(int threshold)
        {
            var result = 0;

            for (int i = 1; i < threshold; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) {
                    result += i;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumAllNumbersDivisableBy3And5(1000));
            Console.ReadKey();
        }
    }
}
