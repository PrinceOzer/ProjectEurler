using System;
/* 4 milyonun altındaki ttüm çift fibonacci sayılarının toplamını bulunuz*/
namespace Problem2
{
    class Program
    {
        /*1,1,2,3,5,8,13,21,.... 
         ilksayı ile ikinci sayının toplamı ikinci sayıya ikinci sayının ilk değeri ilk sayıya eşit olucak
         */
        static void Main(string[] args)
        {
            int sayi1 = 1;//1.sayi
            int sayi2 = 1;//2.sayi
            int sayi2_ = sayi1 + sayi2;//3.sayi
            int toplam = 0;//toplam
            while (sayi1 + sayi2 < 4000000)
            {
                sayi2_ = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = sayi2_;
                if (sayi2_ % 2 == 0)
                {
                    toplam += sayi2_;
                }

            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
