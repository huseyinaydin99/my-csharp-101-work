using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Entity_Framework_Demo.Data
{
    public class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
