using System;

namespace Problem017
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 0;
            for (int i = 1; i < 1001; i++)
            {
                //Console.WriteLine(Methods.NumbersInWord.NumbersInWords(i)); //Numbers Writing
                len += Methods.NumbersInWord.NumbersInWords(i).Length;
            }
            Console.WriteLine(len);
        }
    }
}
