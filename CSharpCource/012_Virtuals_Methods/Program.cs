using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Virtuals_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MySQL mySQL = new MySQL();
            mySQL.Add();
            mySQL.Delete();

            Oracle oracle = new Oracle();
            oracle.Add();
            oracle.Delete();

            Console.ReadKey();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Data Added");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Data Deleted");
        }
    }

    class MySQL : Database
    {
        public override void Add()
        {
            base.Add();
            Console.WriteLine("MySQL Data Added");
        }

        public override void Delete()
        {
            base.Delete();
            Console.WriteLine("MySQL Data Deleted");
        }
    }

    class Oracle : Database
    {
        public override void Add()
        {
            base.Add();
            Console.WriteLine("Oracle Data Added");
        }

        public override void Delete()
        {
            base.Delete();
            Console.WriteLine("Oracle Data Deleted");
        }
    }
}
