using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfTheSquares = 0;
            double squareOfTheSum = 0;
            for (int i = 1; i < 101; i++)
            {
                sumOfTheSquares += Math.Pow(i, 2);
            }
            for (int i = 1; i < 101; i++)
            {
                squareOfTheSum += i;
            }
            Console.WriteLine(Math.Pow(squareOfTheSum,2)-sumOfTheSquares);
        }
    }
}
