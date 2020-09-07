using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Hüseyin","Rümeysa","Yasin","Ömer" };
            string[] students2 = new string[] { "Hüseyin", "Rümeysa", "Yasin", "Ömer" };
            string[] students3 = new string[4] { "Hüseyin", "Rümeysa", "Yasin", "Ömer" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("********");

            string[,] regions = new string[3, 2];
            regions[0,0] = "Ankara";
            regions[0, 1] = "Konya";

            regions[1, 0] = "Niğde";
            regions[1, 1] = "Nevşehir";

            regions[2, 0] = "Trabzon";
            regions[2, 1] = "Giresun";

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }

            Console.ReadKey();
        }
    }
}
