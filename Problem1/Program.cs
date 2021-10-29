using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1000 den küçük 3 veya 5 in katlarının toplamını bulunuz */
namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            // 3den 1000 e kadar 3 veya 5 katlarını toplayacak 15 katlarını çıkartacak
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    toplam += i;
                }
                else if (i % 15 == 0)
                {
                    toplam -= i;
                }

            }
            Console.WriteLine(toplam);
        }
    }
}
