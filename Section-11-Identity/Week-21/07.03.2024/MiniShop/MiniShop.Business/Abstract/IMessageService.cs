using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IMessageService
    {
        Task<Response<MessageViewModel>> CreateAsync(MessageViewModel messageViewModel);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<List<MessageViewModel>>> GetAllSentMessageAsync(string fromUserId);
        Task<Response<List<MessageViewModel>>> GetAllRecivedMessageAsync(string toUserId);
        Task<Response<List<MessageViewModel>>> GetAllRecivedMessageAsync(string toUserId, bool isRead);
        Task<Response<MessageViewModel>> GetByIdAsync(int id);
        Task<Response<int>> GetMessageCountAsync(string userId,bool isRead=false);
        Task<Response<NoContent>> MakeReadAsync(int id);
    }
}
