using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Interfaceses
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Demo2();
            Console.ReadKey();
        }

        private static void Demo2()
        {
            ICustomerDal[] customerDals = { new SQLServerCustomerDal(), new MySQLCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            ICustomerDal customerDal = new SQLServerCustomerDal();
            CustomerManager customerManager = new CustomerManager(customerDal);
            customerManager.Add();
        }
    }


}
