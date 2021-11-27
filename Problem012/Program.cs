using System;
using System.Linq;

namespace Problem012
{//Find first triangle number to have over five hundred divisors
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDivisors = 1;
            int triangleNumber = 1;
            int counter = 2;
            for (int i = 2; i < counter + 1; i++)
            {
                numberOfDivisors = 1;
                var divisors = Methods.Prime.PrimeDivisorsAll(triangleNumber).GroupBy(x => x)
                                                               .Where(g => g.Count() > 0)
                                                               .Select(y => new { Element = y.Key, Counter = y.Count() })
                                                               .ToList(); ;
                foreach (var item in divisors)
                {
                    numberOfDivisors *= item.Counter + 1;
                }
                if (numberOfDivisors > 500)
                {
                    Console.WriteLine(triangleNumber);
                    break;
                }
                triangleNumber += i;
                counter += 1;
            }
        }
    }
}
