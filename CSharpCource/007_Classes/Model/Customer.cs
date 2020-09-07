using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Classes.Model
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Customer()
        {

        }
        public Customer(int ıd, string name, string lastName)
        {
            Id = ıd;
            Name = name;
            LastName = lastName;
        }
    }
}
