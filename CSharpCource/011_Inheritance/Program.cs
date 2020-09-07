using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Adem[] adems = {new Adem(),new Habil(),new Kabil() };
            foreach (var insan in adems)
            {
                insan.NefesAlmak();
            }
            Console.ReadKey();
        }
    }
    interface Ruh
    {
        int Yasamak { get; set; }
    }

    class Adem : Ruh //işk insan
    {
        public int Yasamak { get; set; }
        public void Yurumek()
        {
            Console.WriteLine("Yürüyorum");
        }

        public void NefesAlmak()
        {
            Console.WriteLine("Nefes alıyorum");
        }
    }

    class Kabil:Adem
    {
        public void NefesAlmak()
        {
            Console.WriteLine("Kabil nefes alıyor");
        }
        public void Oldurme()
        {
            Console.WriteLine("Geber");
        }
    }

    class Habil : Adem
    {
        public void NefesAlmak()
        {
            Console.WriteLine("Habil nefes alıyor");
        }
        public void IyılikYapmak()
        {
            Console.WriteLine("İyilik yapıyorum");
        }
    }
}
