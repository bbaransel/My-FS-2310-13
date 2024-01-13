using MiniShop.Data.Abstract;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete
{
    public class ProductRepository:GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext _appDbContext):base(_appDbContext)
        {
            
        }
        AppDbContext AppContext {
            get { 
            return _dbContext as AppDbContext;
            }
        }

        public List<Product> GetHomePageProducts(bool? isHome)
        {
            var products = AppContext
                .Products
                .Where(p=>p.IsHome==isHome && p.IsActive && !p.IsDelete)
                .ToList();  //LINQ Sorguları tekniği (Language Interface Query)
            return products;
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            
            throw new NotImplementedException();
        }
    }
}
