using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = Utilities.BuildList<string>("Niğde", "Nevşehir", "Trabzon");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Product> products = Utilities.BuildList<Product>(new Product {Name="Telefon" }, new Product {Name="Laptop" });
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadKey();
        }
    }

    static class Utilities
    {
        public static List<T> BuildList<T>(params T[] t)
        {
            return new List<T>(t);
        }
    }

    interface IEntity
    {

    }

    class Product:IEntity
    {
        public string Name { get; set; }
    }

    interface IProductDal:IRepository<Product>
    {
        
    }

    class Customer:IEntity
    {

    }

    interface ICustomerDal:IRepository<Customer>
    {
        
    }

    interface IRepository<T> where T:class,IEntity,new() // struct yazsaydık değer tiplere karşılık gelirdi //T class tip olabilir ve new lene bilir olmalıdır!
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
