using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Solution10
    {
        static bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static long FindSumOfPrimes()
        {
            long result = 2;

            for (int i = 3; i < 2000000; i += 2)
            {
                if (IsPrime(i))
                {
                    result += i;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindSumOfPrimes());
            Console.ReadKey();
        }
    }
}
