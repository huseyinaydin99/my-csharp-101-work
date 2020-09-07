using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Interfaceses
{
    class SQLServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Kayıt eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
