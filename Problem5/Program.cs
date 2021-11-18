using System;
using System.Collections.Generic;
using Methods;
namespace Problem5
{
    //LCM(0,21)
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < 21; i++)
            {
                numbers.Add(i);
            }
            
            Console.WriteLine(Lcm.GetLcms(numbers));
        }
    }
}
