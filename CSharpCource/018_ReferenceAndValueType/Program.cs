using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 22;
            Console.WriteLine(sayi2);

            string[] dizi1 = {"Ankara","Adana","Amasya" };
            string[] dizi2 = {"Bolu","Balıkesir","Bursa" };

            dizi2 = dizi1;
            dizi1[0] = "Niğde";
            Console.WriteLine(dizi2[0]);

            Console.ReadKey();
        }
    }
}
