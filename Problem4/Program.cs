using System;
using Methods;
/* 3 basamaklı 2 saayının çarpımından oluşan en büyük palindrome sayıyı bulunuz */
namespace Problem4
{
    class Program
    {
        //Girilen sayının palindrome olup olmadığını doğru kontrol edersen sorun çözülür
        static void Main(string[] args)
        {
            int biggestPalindrome = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if (Methods.Palindrome.IsPalindrome(i*j) && biggestPalindrome<i*j)
                    {
                        biggestPalindrome = i * j;
                    }
                }
            }
            Console.WriteLine(biggestPalindrome);
        }
    }
}
