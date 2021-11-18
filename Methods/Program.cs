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
                if (number % i == 0 && IsPrime(i))
                {
                    PrimeDivisors_.Add(i);
                }

            }
            return PrimeDivisors_;
        }
        public static List<long> PrimeDivisorsAll(long number)
        {

            List<long> PrimeDivisorsAll_ = new List<long>();
            if (IsPrime(number))
            {
                PrimeDivisorsAll_.Add(number);
                return PrimeDivisorsAll_;
            }
            int divisor = 2;
            while (divisor <= number)
            {
                if (IsPrime(divisor) && number % divisor == 0)
                {
                    PrimeDivisorsAll_.Add(divisor);
                    number = number / divisor;
                    continue;
                }
                divisor += 1;
            }
            return PrimeDivisorsAll_;
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
    public class Gcd
    {
        public static int GetGcd(int a, int b)
        {

            while (a != 0 && b != 0)
            {
                int b_ = Math.Max(a, b) % Math.Min(a, b);
                int a_ = Math.Min(a, b);
                a = a_;
                b = b_;
            }
            return Math.Max(a, b);
        }

    }
    public class Lcm
    {
        public static int GetLcm(int a, int b)
        {
            return a * (b / Gcd.GetGcd(a, b));
        }
        public static int GetLcms(List<int> numbers)
        {
            if (numbers.Count < 2)
            {
                return numbers[0];
            }
            else if (numbers.Count == 2)
            {
                return GetLcm(numbers[0], numbers[1]);
            }
            else
            {
                int lcm = GetLcm(numbers[0], numbers[1]);
                for (int i = 2; i < numbers.Count; i++)
                {
                    lcm = Lcm.GetLcm(lcm, numbers[i]);

                }
                return lcm;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
}
