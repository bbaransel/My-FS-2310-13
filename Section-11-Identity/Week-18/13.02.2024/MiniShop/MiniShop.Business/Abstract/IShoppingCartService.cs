﻿using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IShoppingCartService
    {
        Task<Response<NoContent>> InitializeShoppingCartAsync(string userId);
        Task<Response<ShoppingCartViewModel>> GetShoppingCartByUserIdAsync(string userId);
        Task<Response<NoContent>> AddToCartAsync(string userId, string cartId);
        Task<Response<NoContent>> DeleteFromCartAsync(int shoppingCartId, int productId);
        Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId);
    }
}
