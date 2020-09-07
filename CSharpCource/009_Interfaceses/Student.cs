using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Interfaceses
{
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {get; set; }

        public string Kalem { get; set; }
    }
}
