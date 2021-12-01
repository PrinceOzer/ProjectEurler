using System;

namespace Problem014
{
    class Program
    {
        static long EvenOdd(long number)
        {
            if (number%2==0)
            {
                return number / 2;
            }
            else
            {
                return (number*3)+1;
            }
           
        }
        static int Count(long number)
        {
            int count = 1;
            while (number != 1)
            {
                number=EvenOdd(number);
                count += 1;
            }
            
            return count;
        }
        static void Main(string[] args)
        {
            int maxChain =0;
            int number = 0;
            for (int i = 1; i < 1000000; i++)
            {
                if (Count(i)>maxChain)
                {
                    maxChain = Count(i);
                    number = i;
                }
            }
            Console.WriteLine(number +"  "+ maxChain);
        }
    }
}
