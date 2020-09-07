using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings();
            Strings2();
            Console.ReadKey();
        }

        private static void Strings2()
        {
            string isim = "Benim adım Hüseyin Aydın";
            var result = isim.Length;
            var result2 = isim.Clone();
            isim = "Benim adım Hüseyin Aydın 2";
            bool result3 = isim.EndsWith("n");
            bool result4 = isim.StartsWith("B");
            var result5 = isim.IndexOf(" ");
            var result6 = isim.LastIndexOf(" ");
            var result7 = isim.Insert(5, "Abc");
            var result8 = isim.Substring(5, 4);
            var result9 = isim.ToLower();
            var result10 = isim.ToUpper();
            var result11 = isim.Replace(" ", "-");
            var result12 = isim.Remove(5, 2);
        }

        private static void Strings()
        {
            string city = "Niğde";
            foreach (var c in city)
            {
                Console.WriteLine(c);
            }
            string city2 = "Nevşehir";
            Console.WriteLine(String.Format("{0},{1}", city, city2));
        }
    }
}
