using System;

namespace Problem9
{
    //Pythagorean triplet a+b+c==1000 a*b*c=?
    class Program
    {
        static void Main(string[] args)
        {

            for (int b = 2; b < 500; b++)    //500+500+100==1100 nearly 1000 so take b<500
            {
                for (int a = 1; a < b; a++)  //a<b<c
                {
                    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) && (a + b + c == 1000.0))
                    {
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                        Console.WriteLine(a * b * c);
                        break;
                    }
                }
            }




        }
    }
}
