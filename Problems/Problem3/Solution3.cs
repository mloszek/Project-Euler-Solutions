using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    //unfinished
    class Solution3
    {
        static List<long> GetFactors(long number) {

            List<long> result = new List<long>();
            result.Add(number);

            for (long i = 1; i <= number / 2; i++)
            {
                if (number % i == 0) {
                    result.Add(i);
                    Console.WriteLine(i);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            List<long> list = GetFactors(600851475143);
            //Console.WriteLine(list.Count());
            Console.ReadKey();
        }
    }
}
