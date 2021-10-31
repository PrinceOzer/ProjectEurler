using System;
using System.Collections.Generic;
/*Problemleri çözerken sık kullanılan methodlar*/
namespace Methods
{
    public class Prime
    {
        /// <summary>
        /// Returns the given number isPrime(true) or Not(False)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(long number)
        {
            if (number < 4)
            {
                return true;
            }
            else if (Math.Sqrt(number) == Math.Ceiling(Math.Sqrt(number)))
            {
                return false;
            }
            for (long i = 2; i < Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Returns a List of Divisors of Given number. Use it in foreachLoop
        /// </summary>
        /// <param name="number"></param>
        /// <returns>System.Collections.Generic.List`1[System.Int64]</returns>
        public static List<long> PrimeDivisors(long number)
        {
            List<long> PrimeDivisors_ = new List<long>(1);
            for (long i = 2; i < Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number%i==0 && IsPrime(i))
                {
                    PrimeDivisors_.Add(i);
                }

            }
            return PrimeDivisors_;
        }
    }
    public class Palindrome
    {
        public static bool IsPalindrome(int number)
        {
            for (int i = 0; i < number.ToString().Length / 2; i++)
            {
                if (number.ToString()[i] != number.ToString()[number.ToString().Length - (i + 1)])
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
}
