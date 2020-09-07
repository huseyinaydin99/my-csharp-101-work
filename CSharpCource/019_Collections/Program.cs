using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace _019_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add("book", "kitap");
            words.Add("computer", "bilgisayar");
            words.Add("table","tablo");

            Console.WriteLine(words["book"]);

            foreach (var word in words)
            {
                Console.WriteLine(word.Key + " - " + word.Value);
            }

            Console.WriteLine(words.ContainsKey("book"));
            Console.WriteLine(words.ContainsKey("glass"));

            List();
            Console.ReadKey();
        }

        private static void List()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Niğde");
            cities.Add("Nevşehir");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<string> list = new List<string>();
            list.Add("Selam");
            list.Add("Merhaba");

            foreach (var l in list)
            {
                Console.WriteLine(l);
            }

            List<Customer> customers = new List<Customer>()
            {
                new Customer{Id=1,Name="Hüseyin" },
                new Customer{Id=2,Name="Yasin" }
            };
            var customer = new Customer { Id = 1, Name = "Abdullah" };
            customers.Add(customer);
            customers.AddRange(new Customer[] { new Customer { Id = 3, Name = "Hasan" } });
            var count = customers.Count;
            Console.WriteLine(customers.Contains(customer));
            Console.WriteLine(customers.IndexOf(customer));
            Console.WriteLine(customers.LastIndexOf(customer));
            customers.Insert(2, customer);
            customers.Remove(customer);
            customers.RemoveAll(c => c.Id == 1);

            foreach (var item in customers)
            {
                Console.WriteLine(item.Name);
            }
            customers.Clear();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
