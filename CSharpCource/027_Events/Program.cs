using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hdd = new Product(50);
            hdd.ProductName = "Harddisk";
            hdd.StockControlEvent += Hdd_StockControlEvent;

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 4; i++)
            {
                hdd.Sell(10);
                gsm.Sell(10);
                Console.ReadKey();
            }

        }

        private static void Hdd_StockControlEvent()
        {
            Console.WriteLine("HDD about to finish");
        }

        private static void Gsm_StockControlEvent()
        {
            //throw new NotImplementedException();
            Console.WriteLine("GSM about to finish");
        }
    }
}
