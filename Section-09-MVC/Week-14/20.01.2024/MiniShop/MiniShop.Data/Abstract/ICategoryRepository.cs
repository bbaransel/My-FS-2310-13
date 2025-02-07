﻿using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Task<List<Category>> GetAllCategoriesWithProductsAsync();
        Task<Category> GetCategoryWithProductsAsync(int id);
        Task<List<Category>> GetAllCategoriesActiveDeletedAsync(bool? isActive=null, bool? isDeleted=null);

    }
}
