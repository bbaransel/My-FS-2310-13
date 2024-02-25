using MiniShop.Entity.Concrete;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IOrderService
    {
        Task CreateAsync(Order order);
        Task<List<AdminOrderViewModel>> GetOrdersAsync();
        Task<List<AdminOrderViewModel>> GetOrdersAsync(string userId);
        Task<List<AdminOrderViewModel>> GetOrdersAsync(int productId);
        Task<AdminOrderViewModel> GetOrderAsync(int orderId);
        Task CancelOrder(int orderId);
    }
}
