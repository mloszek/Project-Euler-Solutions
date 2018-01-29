using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Solution5
    {
        static bool IsDivisible(int number)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int SmallestEvenlyDivisibleNumber()
        {
            var i = 1;

            while (!IsDivisible(i))
            {
                i++;
            }

            return i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SmallestEvenlyDivisibleNumber());
            Console.ReadKey();
        }
    }
}
