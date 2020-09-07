using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _025_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(10, 5);
            Console.WriteLine(dortIslem.Topla());
            Console.WriteLine(dortIslem.Bol(10, 2));

            var tip = typeof(DortIslem);
            DortIslem dortIslem1 = (DortIslem)Activator.CreateInstance(tip,10,5);
            Console.WriteLine(dortIslem1.Topla());
            Console.WriteLine(dortIslem1.Bol(10, 2));

            var instance = Activator.CreateInstance(typeof(DortIslem),10,2);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            //Console.WriteLine(instance.GetType().GetMethod("Topla").Invoke(instance, null));

            var methods = tip.GetMethods();
            foreach (var mInfo in methods)
            {
                Console.WriteLine(mInfo.Name);
                foreach (var parameter in mInfo.GetParameters())
                {
                    Console.WriteLine(parameter.Name);
                }

                foreach (var attribute in mInfo.GetCustomAttributes())
                {
                    Console.WriteLine(attribute.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }

    class DortIslem
    {
        public int _Sayi1 { get; set; }
        public int _Sayi2 { get; set; }

        public DortIslem(int sayi1, int sayi2)
        {
            _Sayi1 = sayi1;
            _Sayi2 = sayi2;
        }

        public int Topla()
        {
            return this._Sayi1 + this._Sayi2;
        }

        public int Cikar()
        {
            return this._Sayi1 - this._Sayi2;
        }

        public int Bol()
        {
            return this._Sayi1 / this._Sayi2;
        }

        public int Carp()
        {
            return this._Sayi1 * this._Sayi2;
        }

        public int Bol(int sayi1,int sayi2)
        {
            return sayi1 / sayi2;
        }

        [MethodName("Bilgi")]
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }

    [AttributeUsage(AttributeTargets.Method,AllowMultiple = false)]
    public class MethodNameAttribute : Attribute
    {
        public string Info { get; set; }
        public MethodNameAttribute(string ınfo)
        {
            Info = ınfo;
        }
    }
}
