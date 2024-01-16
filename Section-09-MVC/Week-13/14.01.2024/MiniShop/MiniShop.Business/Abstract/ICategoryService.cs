using MiniShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface ICategoryService
    {
        void Create(CategoryViewModel model);                                    // (C)reate
        List<CategoryViewModel> GetAll(bool? isDelete = null);  // (R)ead
        CategoryViewModel GetById(int id);
        void Update(CategoryViewModel model);                                     // (U)pdate
        void HardDelete(int id);                                                  // (D)elete
        void SoftDelete(int id);
    }
}
