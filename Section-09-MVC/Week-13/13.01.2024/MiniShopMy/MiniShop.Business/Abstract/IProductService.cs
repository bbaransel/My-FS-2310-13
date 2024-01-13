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
        List<ProductViewModel> GetAll(bool? isHome, bool? isActive, bool? isDelete);
    }
}
