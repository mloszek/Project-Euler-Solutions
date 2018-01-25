using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Solution3
    {
        public static Stopwatch stopwatch;

        static bool IsPrime(long number)
        {
            if (number == 1)
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

        static long GetLargestEvenPrimeFactor(long number)
        {
            if (IsPrime(number))
            {
                return number;
            }
            Console.WriteLine("Number itself is not a prime.");

            for (long i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    if (IsPrime(number / i))
                    {
                        return number / i;
                    }
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Largest prime factor is: " + GetLargestEvenPrimeFactor(600851475143));
            Console.WriteLine(stopwatch.Elapsed.Milliseconds);
            stopwatch.Stop();
            Console.ReadKey();
        }
    }
}
