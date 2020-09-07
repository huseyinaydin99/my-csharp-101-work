using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Interfaceses
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
}
