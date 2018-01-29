using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Solution4
    {
        static bool IsPalidrome(int number)
        {
            string stringFromNumber = number.ToString();

            for (int i = 0; i < stringFromNumber.Length - 1 / 2; i++)
            {
                if (stringFromNumber[i] != stringFromNumber[stringFromNumber.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static int LargestPalidrome()
        {
            List<int> results = new List<int>();

            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    if (IsPalidrome(i * j))
                    {
                        results.Add(i * j);
                    }
                }
            }

            results.Sort();

            if (results.Count > 0)
            {
                return results[results.Count - 1];
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LargestPalidrome());
            Console.ReadKey();
        }
    }
}
