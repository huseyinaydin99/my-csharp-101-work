using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_TypesAndVariabled
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = -2147483648; //int 32 bitlik yer kaplarken
            long sayi2 = 9223372036854775807; //long 64 bitlik yer kaplar
            short sayi3 = -32768;
            byte sayi4 = 255; //bellekte 8 bitlik yer kaplar yani 1 byte lık
            bool sart = sayi4 > 254;
            char karakter = 'A';
            double ondalikliSayi = 10.4; //bellekte 64 bitlik yer kaplar
            decimal uzunOndalikliSayi = 10.4444444444444444444444444444444444M;
            var deger = 10;
            //deger = "Selam"; //hata!

            Color color = Color.black;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);
            Console.WriteLine((int)karakter);
            Console.WriteLine(ondalikliSayi);
            Console.WriteLine(uzunOndalikliSayi);
            Console.WriteLine(color);
            Console.WriteLine((int)color);
            Console.ReadLine();
        }
    }
    enum Color
    {
        red=1,blue,black,yellow,green,gray
    }
}
