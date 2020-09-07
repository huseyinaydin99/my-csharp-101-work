using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        protected int Id { get; set; }
    }

    class Student : Person
    {
        public void Save()
        {
            Console.WriteLine(Id);
        }
    }

    internal class Test //internal iç demektir. sadece bu proje içinde tanımlanabilir.
    {
        private class Test2//private sadece tanımlandığı block içinde geçerlidir.
        {

        }
    }

    public class Abc
    {
    }

}
