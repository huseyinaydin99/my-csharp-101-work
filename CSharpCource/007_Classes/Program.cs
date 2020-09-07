using _007_Classes.Model;
using _007_Classes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Hüseyin","Aydın");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Update(customer);
            customerManager.Delete(customer);
            customerManager.Get(customer);

            Customer customer1 = new Customer
            {
                Id = 2,
                Name = "Hasan",
                LastName = "Fefer"
            };
            Console.ReadKey();
        }
    }
}
