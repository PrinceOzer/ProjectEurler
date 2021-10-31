using System;
using Methods;
/* 600851475143 sayısının en büyük asal bölenini bulunuz*/
namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last index of List is Biggest Prime Divisor
            Console.WriteLine(Prime.PrimeDivisors(600851475143)[Prime.PrimeDivisors(13195).Count - 1]);
        }
    }
}
