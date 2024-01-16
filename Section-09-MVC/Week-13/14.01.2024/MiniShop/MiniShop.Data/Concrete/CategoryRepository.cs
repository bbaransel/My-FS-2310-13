using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }

        //public CategoryRepository(DbContext _appDbContext) : base(_appDbContext)
        //{
        //}
        AppDbContext AppContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }
        public List<Category> GetDeletedCategories(bool? isDeleted)
        {
            var categories = AppContext.Categories.Where(c => c.IsDelete == isDeleted).ToList();
            return categories;
        }
    }
}
