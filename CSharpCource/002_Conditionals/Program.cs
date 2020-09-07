using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayi1 = 10;
            if (sayi1 > 5)
                Console.WriteLine("Sayı 5 den büyüktür");

            Console.WriteLine(sayi1 == 10 ? "Sayı 10" : "sayı 10 değil");

            switch (sayi1)
            {
                case 1:
                    Console.WriteLine("Sayı 1");
                    break;
                case 5:
                    Console.WriteLine("Sayı 5");
                    break;
                case 10:
                    Console.WriteLine("Sayı 10");
                    break;
                default:
                    Console.WriteLine("Hiç biri");
                    break;
            }

            if(sayi1 >= 0 && sayi1 <= 100)
            {
                Console.WriteLine("Sayı 0 ile 100 arasındadır");
            }
            else if (sayi1 > 100 && sayi1 <= 200)
            {
                Console.WriteLine("Sayı 100 ile 200 arasındadır");
            }
            else if (sayi1 >= 200 && sayi1 < 0)
            {
                Console.WriteLine("Sayı 0 ile 1000 arasındadır");
            }

            if(sayi1 < 100)
            {
                if(sayi1 < 90)
                {
                    if(sayi1 < 80)
                    {
                        Console.WriteLine("Sayi1 80 den küçük");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
