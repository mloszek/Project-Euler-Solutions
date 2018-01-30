using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Solution7
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

        static int FindNthPrime(int n)
        {
            var index = 1;
            var number = 2;

            while (true)
            {
                if (IsPrime(number))
                {
                    if (index == n)
                    {
                        return number;
                    }
                    index++;
                }
                number++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindNthPrime(10001));
            Console.ReadKey();
        }
    }
}
