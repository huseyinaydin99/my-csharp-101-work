using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
            DoWhileLoop();
            ForEachLoop();
            PrimeNumber();
            Console.ReadKey();
        }

        private static void PrimeNumber()
        {
            if (IsPrimeNumber(6))
                Console.WriteLine("This is a prime number");
            else
                Console.WriteLine("This is a not prime number");
        }

        public static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if(number % i == 0)
                {
                    result = true;
                    i = number;
                    break;
                }
            }
            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = { "Hüseyin", "Rümeysa", "Yasin", "Ömer" };
            foreach (var student in students)
            {
                //student = "Abc"; //student read only olduğu için değer atayamadık.
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 0;
            do
            {
                Console.WriteLine(number);
                ++number;
            }
            while (number < 10);
        }

        private static void WhileLoop()
        {
            int number = 0;
            while (number < 10)
            {
                Console.WriteLine(number);
                ++number;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("İ nin değeri {0}", i);
            }
        }
    }
}
