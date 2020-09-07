using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = { new Worker(), new Manager(), new Robot() };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eaters = { new Worker(), new Manager() };
            foreach (var eater in eaters)
            {
                eater.Eat();
            }

            ISalary[] salarys = { new Worker(), new Manager() };
            foreach (var salary in salarys)
            {
                salary.GetSalary();
            }

            Console.ReadKey();
        }
    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
           
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            
        }
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            
        }
    }
}
