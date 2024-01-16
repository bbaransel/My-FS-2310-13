using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        // Category'e özgü metotlar yazılacak
        List<Category> GetDeletedCategories(bool? isDeleted);
    }
}
