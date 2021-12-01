using System;

namespace Problem013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = System.IO.File.ReadAllLines(@"C:\Users\okkes\source\repos\ProjectEurler\Problem013\numbers\numbers.txt");
            string firstTen = "";
            int sum_ = 0;
            for (int i = 49; i >= 0; i--)
            {
                int subSum = 0;
                for (int j = 0; j < 100; j ++)
                {
                    subSum += int.Parse(str[j][i].ToString()); 
                }
                subSum += sum_;
                firstTen = firstTen.Insert(0, (subSum % 10).ToString()) ;
                sum_ = (subSum - (subSum % 10)) / 10;
            }
            firstTen = firstTen.Insert(0, sum_.ToString());
            Console.WriteLine(firstTen.Substring(0,10));
        }
    }
}
