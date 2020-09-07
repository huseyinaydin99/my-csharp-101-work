using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            MySQL mySQL = new MySQL();
            mySQL.Add();
            mySQL.Delete();

            Console.ReadKey();
        }
    }

    abstract class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Data added");
        }

        public abstract void Delete();
    }

    class MySQL : Database
    {
        public override void Add()
        {
            base.Add();
            Console.WriteLine("MySQL Date Added");
        }
        public override void Delete()
        {
            Console.WriteLine("MySQL Date Deleted");
        }
    }
}
