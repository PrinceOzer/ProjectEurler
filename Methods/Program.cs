using System;
using System.Collections.Generic;
/*Usefull methods*/
namespace Methods
{
    public class Numbers
    {
        public static long Factorial(int number)
        {
            if (number==0)
            {
                return 1;
            }
            long result = 1;
            for (int i = 2; i < number + 1; i++)
            {
                result *= i;
            }
            return result;
        }
        /// <summary>
        /// Combination 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double Combination(double num1,double num2)
        {
            if (num2==0 || num1==num2)
            {
                return 1;
            }
            else if (num2>num1)
            {
                return 0;
            }
            double result = 1;
            for (int i = 0; i < num2; i++)
            {
                result *= (num1-i)/(i+1);
            }
            return result ;
        }
        
    }
    public class Prime
    {
        /// <summary>
        /// Returns the given number isPrime(true) or Not(False)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(long number)
        {
            if (number < 4 && number > 1)
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
        /// Returns a List of Not Repeated Prime Divisors of Given number.Not repeated.Use it in foreachLoop
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
        /// <summary>
        /// Returns a List of All Prime Divisors of Given number.Use it in foreachLoop
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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
    {/// <summary>
     /// Returns the given number is Palindrome true/false
     /// </summary>
     /// <param name="number"></param>
     /// <returns></returns>
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
    {/// <summary>
     /// Return the Greatest Common Divisor of two number
     /// </summary>
     /// <param name="num1"></param>
     /// <param name="num2"></param>
     /// <returns></returns>
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
    {/// <summary>
     /// Returns Least Common Multiplier of given two number
     /// </summary>
     /// <param name="num1"></param>
     /// <param name="num2"></param>
     /// <returns></returns>
        public static int GetLcm(int a, int b)
        {
            return a * (b / Gcd.GetGcd(a, b));
        }
        /// <summary>
        /// Return Least Common Multiplier of given integer List
        /// </summary>
        /// <param name="numberList"></param>
        /// <returns></returns>
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
    public class NumbersInWord {
        /// <summary>
        /// Returns given number between 1-1000 in words with non space
        /// </summary>
        /// <param name="number"></param>
        /// <returns>NumberInWord</returns>
        public static string NumbersInWords(int number)

        {

            string numbersInWords = "";

            Dictionary<int, string> numbers = new Dictionary<int, string>();

            numbers = NumbersFillMethod();

            if (number == 100)

            { numbersInWords = numbers[1] + numbers[number]; }

            else if (numbers.ContainsKey(number))

            { numbersInWords = numbers[number]; }

            else

            {



                if (number < 100)

                { numbersInWords = numbers[((number) - (number % 10))] + numbers[number % 10]; }

                else

                {

                    if (number % 100 == 0) { numbersInWords = numbers[(number / 100)] + numbers[100]; return numbersInWords; }

                    numbersInWords = numbers[(number / 100)] + numbers[100] + "and";

                    if (numbers.ContainsKey(number % 100))

                    { numbersInWords += numbers[(number) % 100]; }

                    else { numbersInWords += numbers[((number % 100) - (number % 10))] + numbers[number % 10]; }

                }

            }

            return numbersInWords;

        }

        public static Dictionary<int, string> NumbersFillMethod()

        {

            Dictionary<int, string> _numbers = new Dictionary<int, string>();



            _numbers.Add(1, "one");

            _numbers.Add(2, "two");

            _numbers.Add(3, "three");

            _numbers.Add(4, "four");

            _numbers.Add(5, "five");

            _numbers.Add(6, "six");

            _numbers.Add(7, "seven");

            _numbers.Add(8, "eight");

            _numbers.Add(9, "nine");

            _numbers.Add(10, "ten");

            _numbers.Add(11, "eleven");

            _numbers.Add(12, "twelve");

            _numbers.Add(13, "thirteen");

            _numbers.Add(14, "fourteen");

            _numbers.Add(15, "fifteen");

            _numbers.Add(16, "sixteen");

            _numbers.Add(17, "seventeen");

            _numbers.Add(18, "eighteen");

            _numbers.Add(19, "nineteen");

            _numbers.Add(20, "twenty");

            _numbers.Add(30, "thirty");

            _numbers.Add(40, "forty");

            _numbers.Add(50, "fifty");

            _numbers.Add(60, "sixty");

            _numbers.Add(70, "seventy");

            _numbers.Add(80, "eighty");

            _numbers.Add(90, "ninety");

            _numbers.Add(100, "hundred");

            _numbers.Add(1000, "onethousand");

            return _numbers;

        }
    }
    class Program
    {
        static void Main(string[] args) { }
    }
}
