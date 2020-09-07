using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Interfaceses
{
    class CustomerManager
    {
        public ICustomerDal customerDal { get; set; }

        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }

        public void Add()
        {
            Console.WriteLine("Kayıt eklendi");
            customerDal.Add();
        }
    }
}
