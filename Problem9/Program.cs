using System;

namespace Problem9
{
    //Pythagorean triplet a+b+c==1000 a*b*c=?
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int b = 2; b < 500; b++)
            {
                for (int a = 1; a < b; a++)
                {
                    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c,2)) && (a + b + c == 1000.0))
                    {
                        Console.WriteLine(a*b*c);
                        break;
                    }
                }
            }
            



        }
    }
}
