using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.Add();

            Product product = new Product(1, "Üssüğün");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            Test1 test1 = new Test1("Hüso");
            test1.Add();

            Teacher.Name = "Abdülmuttalip";
            Manager.Apply();
            Manager manager = new Manager();
            manager.Make();

            Utilities.Validate();

            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        public int Count { get; set; }

        public CustomerManager(int count)
        {
            Count = count;
        }

        public void Add()
        {
            Console.WriteLine("Eklendi {0}",Count);
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product(int id,string name)
        {
            Name = name;
            Id = id;
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Logged");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logged");
        }
    }

    class EmployeeManager
    {
        public ILogger logger { get; set; }
        public EmployeeManager(ILogger logger)
        {
            this.logger = logger;
        }

        public void Add()
        {
            this.logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        public string Name { get; set; }
        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class Test1 : BaseClass
    {
        public Test1(string name):base(name)
        {

        }

        public void Add()
        {
            Console.WriteLine(Name);
        }
    }

    static class Teacher
    {
        public static string Name { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {

        }

        public static void Validate()
        {

        }
    }

    class Manager
    {
        public static void Apply()
        {
            Console.WriteLine("Applying");
        }

        public void Make()
        {
            Console.WriteLine("Making");
        }
    }
}
