using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_RecapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new FileLogger());
            customerManager.Add();

            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        public ILogger iLogger { get; set; }
        public CustomerManager(ILogger iLogger)
        {
            this.iLogger = iLogger;
        }
        public void Add()
        {
            Console.WriteLine("Data added");
            iLogger.Log();
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
            Console.WriteLine("Database logged!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File logged!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms logged!");
        }
    }
}
