using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MiniShopDbContext _context) : base(_context)
        {
            
        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }

        public async Task<List<Category>> GetAllCategoriesActiveDeletedAsync(bool? isActive = null, bool? isDeleted = null)
        {
            if (isActive != null && isDeleted==null)
            {
                var categories = await MiniShopDbContext.Categories.Where(c => c.IsActive==isActive).ToListAsync();
                return categories;
            }else if (isDeleted != null && isActive==null) 
            {
                var categories = await MiniShopDbContext.Categories.Where(c => c.IsDeleted == isDeleted).ToListAsync();
                return categories;
            }else if(isActive != null && isDeleted!=null)
            {
                var categories = await MiniShopDbContext.Categories.Where(c=>c.IsActive==isActive && c.IsDeleted==isDeleted).ToListAsync();
                return categories;
            }
            return await MiniShopDbContext.Categories.ToListAsync();

        }

        public async Task<List<Category>> GetAllCategoriesWithProductsAsync()
        {
            List<Category> categories = await MiniShopDbContext.Categories.Include(c=>c.ProductCategories).ThenInclude(pc => pc.Product).ToListAsync();
            return categories;
        }

        public Task<Category> GetCategoryWithProductsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
