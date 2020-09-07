using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            decimal result = Add(10, 10.2M);
            int result2 = Add(100);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            int sayi1 = 10;
            int sayi2;
            Console.WriteLine(Add2(ref sayi1, out sayi2));
            Console.WriteLine("Sayı1 " + sayi1);
            Console.WriteLine("Sayı2 " + sayi2);

            Console.WriteLine(Multiply(10, 12.0M));
            Console.WriteLine(Add3(10,20,30,40,50));

            Console.ReadKey();
        }

        static void Add()
        {
            Console.WriteLine("Kayıt yapıldı");
        }

        static decimal Add(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi1;
        }

        static int Add(int sayi1,int sayi2 = 10)
        {
            return sayi1 + sayi2;
        }

        static int Add2(ref int sayi1, out int sayi2)
        {
            sayi1 = 30;
            sayi2 = 22;
            return sayi1 + sayi2;
        }
        static decimal Multiply(decimal sayi1, decimal sayi2)
        {
            return (sayi1 * sayi2);
        }

        static decimal Multiply(decimal sayi1, decimal sayi2, decimal sayi3)
        {
            return (sayi1 * sayi2 * sayi3);
        }

        static int Add3(int s, params int[] dizi)//params son parametre olmak zorunda
        {
            return dizi.Sum();
        }
    }
}
