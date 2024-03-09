using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(MiniShopDbContext _context) : base(_context)
        {

        }
        MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
    }
}
