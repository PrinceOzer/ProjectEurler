using System;
using System.Numerics;
namespace Problem016
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger x = 1;
            int sum = 0;
            for (int i = 1; i < 1001; i++)
            {
                x *= 2;
            }
            string a = x.ToString();
            foreach (char i in a)
            {
                sum += int.Parse(i.ToString());
            }
            Console.Write(sum);
        }
    }
}
