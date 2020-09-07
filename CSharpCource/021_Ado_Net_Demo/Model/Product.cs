using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Ado_Net_Demo.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }

        public Product(string name, decimal unitPrice, int stockAmount)
        {
            Name = name;
            UnitPrice = unitPrice;
            StockAmount = stockAmount;
        }

        public Product()
        {

        }
    }
}
