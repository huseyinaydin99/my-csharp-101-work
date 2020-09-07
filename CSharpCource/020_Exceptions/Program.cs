using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatch();
            try
            {
                Find();
            }
            catch (RecordNotFoundExcepiton excepiton)
            {
                Console.WriteLine(excepiton.Message);
            }
            finally
            {
                Console.WriteLine("Ben her halükarda çalışırım!");
            }

            HandleExceptions(() =>
            {
                Find();
            });
            
            Console.ReadKey();
        }

        private static void HandleExceptions(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (RecordNotFoundExcepiton excepiton)
            {
                Console.WriteLine(excepiton.Message);
            }
            finally
            {
                Console.WriteLine("Ben her halükarda çalışırım!");
            }
        }

        private static void Find()
        {
            List<string> names = new List<string>()
            {
                "Hüseyin","Yasin","Rümeysa","Ömer Faruk"
            };
            if (!names.Contains("Ahmet"))
            {
                throw new RecordNotFoundExcepiton("Record not found!");
            }
            else
            {
                Console.WriteLine("Record found!");
            }
        }

        private static void TryCatch()
        {
            string[] cities = new string[3] { "Niğde", "Mersin", "Trabzon" };
            try
            {
                cities[3] = "Muğla";
                int number1 = 10;
                int number2 = 0;
                int result = number1 / number2;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Her halükarda çalışırım!");
            }
        }
    }
}
