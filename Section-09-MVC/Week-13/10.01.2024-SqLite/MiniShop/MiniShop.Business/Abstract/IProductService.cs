using MiniShop.Core.ViewModels;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IProductService
    {
        // CRUD işlemlerini gerçekleştirecek metot imzalarımızı yazacağız.
        void Create(ProductViewModel model);       //   CREATE
        List<ProductViewModel> GetAll(bool? isHome, bool? isActive, bool? isDelete); //.....
        ProductViewModel GetById(int id);                                            // READ
        void Update(ProductViewModel model);            //UPDATE
        void HardDelete(int id);                    //.....
        void SoftDelete(int id);                    // DELETE
    }
}
