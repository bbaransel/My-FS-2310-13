using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class ShoppingCartItemManager : IShoppingCartItemService
    {
        private readonly IShoppingCartItemRepository _shoppingCartItemRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartItemManager(IShoppingCartItemRepository shoppingCartItemRepository, IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartItemRepository = shoppingCartItemRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public async Task<Response<NoContent>> ChangeQuantityAsync(int shoppingCartItemId, int quantity)
        {
            var shoppingCartItem = await _shoppingCartItemRepository.GetByIdAsync(x => x.Id == shoppingCartItemId);
            await _shoppingCartItemRepository.ChangeQuantityAsync(shoppingCartItem, quantity);
            return Response<NoContent>.Success();
        }

        public async Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId)
        {
            // Aslında repository özerinde bu işe özel metot yazmıştık. Ama Burada alternatif bir yol kullandık. Çünkü daha performanslı.
            var cart = await _shoppingCartRepository.GetByIdAsync(x=>x.Id == shoppingCartId, source=>source.Include(x=>x.ShoppingCartItems));
            cart.ShoppingCartItems = new List<ShoppingCartItem>();
            await _shoppingCartRepository.UpdateAsync(cart);
            return Response<NoContent>.Success();
        }

        public async Task<int> CountAsync(int shoppingCartId)
        {
            return await _shoppingCartItemRepository.GetCount(x=>x.ShoppingCartId == shoppingCartId);
        }

        public async Task<Response<NoContent>> DeleteFromCartAsync(int shoppingCartItemId)
        {
            var deletedCart = await _shoppingCartItemRepository.GetByIdAsync(x=>x.Id == shoppingCartItemId);
            await _shoppingCartItemRepository.HardDeleteAsync(deletedCart);
            return Response<NoContent>.Success();
        }

        public async Task<ShoppingCartItemViewModel> GetShoppingCartItemAsync(int shoppingCartItemId)
        {
            var shoppingCarItem = await _shoppingCartItemRepository.GetByIdAsync(x=>x.Id == shoppingCartItemId,
                source=>source.Include(x=>x.Product));
            var shoppingCarItemViewModel = new ShoppingCartItemViewModel
            {
                Id = shoppingCarItem.Id,
                ProductId = shoppingCarItem.ProductId,
                ProductImageUrl = shoppingCarItem.Product.ImageUrl,
                ProductName = shoppingCarItem.Product.Name,
                ProductPrice = shoppingCarItem.Product.Price,
                Quantity = shoppingCarItem.Quantity,
            };
            return shoppingCarItemViewModel;
        }
    }
}
