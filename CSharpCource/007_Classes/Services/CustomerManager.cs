using _007_Classes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Classes.Services
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.ToString());
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.ToString());
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.ToString());
        }
        public void Get(Customer customer)
        {
            Console.WriteLine(customer.ToString());
        }
    }
}
