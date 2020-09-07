using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Entity_Framework_Demo.Data
{
    class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext()) //using ifadesi içinde tanımlanan nesneyi metot bitmeden bellekten atmaya yarar. kullanmaz isek metot bitince garbage collector onu bellekten atar.
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext()) //using ifadesi içinde tanımlanan nesneyi metot bitmeden bellekten atmaya yarar. kullanmaz isek metot bitince garbage collector onu bellekten atar.
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext()) //using ifadesi içinde tanımlanan nesneyi metot bitmeden bellekten atmaya yarar. kullanmaz isek metot bitince garbage collector onu bellekten atar.
            {
                return context.Products.Where(p => p.UnitPrice > price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext()) //using ifadesi içinde tanımlanan nesneyi metot bitmeden bellekten atmaya yarar. kullanmaz isek metot bitince garbage collector onu bellekten atar.
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <=max).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext()) //using ifadesi içinde tanımlanan nesneyi metot bitmeden bellekten atmaya yarar. kullanmaz isek metot bitince garbage collector onu bellekten atar.
            {
                //var result = context.Products.FirstOrDefault(p => p.Id == id);//bu id ye ait birden fazla kayıt varsa ilkini alır
                var result = context.Products.SingleOrDefault(p => p.Id == id);//bu id ye ait birden fazla kayıt varsa o zaman hata fırlatır
                return result;
            }
        }

        public bool Add(Product product)
        {
            using (ETradeContext context = new ETradeContext()) //using ifadesi içinde tanımlanan nesneyi metot bitmeden bellekten atmaya yarar. kullanmaz isek metot bitince garbage collector onu bellekten atar.
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            return true;
        }

        public bool Update(Product product)
        {
            using (ETradeContext context = new ETradeContext()) //using ifadesi içinde tanımlanan nesneyi metot bitmeden bellekten atmaya yarar. kullanmaz isek metot bitince garbage collector onu bellekten atar.
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return true;
        }

        public bool Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext()) //using ifadesi içinde tanımlanan nesneyi metot bitmeden bellekten atmaya yarar. kullanmaz isek metot bitince garbage collector onu bellekten atar.
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
            return true;
        }
    }
}
