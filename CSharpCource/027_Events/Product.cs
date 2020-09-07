using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Events
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;

        public string ProductName { get; set; }
        public int Stock 
        {
            get
            {
                return _stock;
            }
            set
            {
                this._stock = value;
                if(value <= 10 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            if (this.Stock >= 10)
                this.Stock -= amount;
            Console.WriteLine("Product Name: " + this.ProductName + " Stock {0}", this.Stock);
        }
    }
}
