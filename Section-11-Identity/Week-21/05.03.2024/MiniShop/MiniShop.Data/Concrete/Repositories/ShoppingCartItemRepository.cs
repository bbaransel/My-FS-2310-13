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
    public class ShoppingCartItemRepository : GenericRepository<ShoppingCartItem>, IShoppingCartItemRepository
    {
        public ShoppingCartItemRepository(MiniShopDbContext _context) : base(_context) { }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
        public async Task ChangeQuantityAsync(ShoppingCartItem shoppingCartItem, int quantity)
        {
            shoppingCartItem.Quantity = quantity;
            MiniShopDbContext.Update(shoppingCartItem);
            await MiniShopDbContext.SaveChangesAsync();
        }
    }
}
