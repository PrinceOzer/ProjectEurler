using System;
namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int i = 1;
            do
            {
                if (Methods.Prime.IsPrime(i))
                {
                    count += 1;
                }
                i += 1;

            } while (count != 10001);
           
            Console.WriteLine(i-1);
        }
    }
}
