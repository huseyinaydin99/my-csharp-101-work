using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _024_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = new CustomerDal();
            customerDal.Delete();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Abdulcabbar",
                LastName = "Andiregandi"
            };
            customerDal.Add(customer);
            Console.ReadKey();
        }
    }

    [ToTable("Customer")]
    class Customer
    {
        [RequiredPropertyAttribute]
        public int Id { get; set; }

        [RequiredPropertyAttribute]
        public string FirstName { get; set; }

        [RequiredPropertyAttribute]
        public string LastName { get; set; }
    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2}",customer.Id,customer.FirstName,customer.LastName);
        }
        [Obsolete("Gardaş bu metot eski bir metotdur. Bunu kullanmanı tavsiye etmiyorum ok?")]
        public void Delete()
        {

        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] //ikili kullanıma pipe deniyor hacı
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]//allow mutiple true olduğu zaman birden fazla yerde kullanılabilir. ard arda iki tanw aynı yerde kullanıla bilir.
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
