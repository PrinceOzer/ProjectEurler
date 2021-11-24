using System;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 0; i < 2000000; i++)
            {
                if (Methods.Prime.IsPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
