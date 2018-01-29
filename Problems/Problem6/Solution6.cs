using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Solution6
    {
        static long Difference(int n)
        {
            long sumOfTheSquares = 0;
            long squareOfTheSum = 0;

            for (int i = 1; i <= n; i++)
            {
                sumOfTheSquares += Convert.ToInt64(Math.Pow(i, 2));
                squareOfTheSum += i;
            }

            return Convert.ToInt64(Math.Pow(squareOfTheSum, 2) - sumOfTheSquares);
        }

        static void Main(string[] args)
        {
            int n = 100;
            Console.WriteLine(Difference(n));
            Console.ReadKey();
        }
    }
}
