﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
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
    public class MessageManager : IMessageService
    {
        private readonly IMapper _mapper;
        private readonly IMessageRepository _repository;

        public MessageManager(IMapper mapper, IMessageRepository messageRepository)
        {
            _mapper = mapper;
            _repository = messageRepository;
        }

        public async Task<Response<MessageViewModel>> CreateAsync(MessageViewModel messageViewModel)
        {
            var message = _mapper.Map<Message>(messageViewModel);
            message.SendingDate = DateTime.Now;
            var createdMessage = await _repository.CreateAsync(message);
            if (createdMessage == null)
            {
                return Response<MessageViewModel>.Fail("Mesaj gönderilemedi.");
            }
            var createdMessageViewModel = _mapper.Map<MessageViewModel>(createdMessage);
            return Response<MessageViewModel>.Success(createdMessageViewModel);
        }

        public async Task<Response<List<MessageViewModel>>> GetAllRecivedMessageAsync(string toUserId, bool isRead = false)
        {
            var messageList = await _repository.GetAllAsync(x => x.ToId == toUserId && x.IsRead==isRead);
            if (messageList.Count == 0)
            {
                var infoText = isRead ? "Okunmuş" : "Okunmamış";
                return Response<List<MessageViewModel>>.Fail($"{infoText} mesajınız bulunmamaktadır.");
            }
            var messageViewModelList = _mapper.Map<List<MessageViewModel>>(messageList);
            return Response<List<MessageViewModel>>.Success(messageViewModelList);
        }

        public async Task<Response<List<MessageViewModel>>> GetAllSentMessageAsync(string fromUserId)
        {
            var messageList = await _repository.GetAllAsync(x=>x.FromId== fromUserId);
            if (messageList.Count == 0)
            {
                return Response<List<MessageViewModel>>.Fail("Giden kutusu boş");
            }
            var messageViewModelList = _mapper.Map<List<MessageViewModel>>(messageList);
            return Response<List<MessageViewModel>>.Success(messageViewModelList);
        }

        public async Task<Response<MessageViewModel>> GetByIdAsync(int id)
        {
            var message = await _repository.GetByIdAsync(x => x.Id == id);
            if (message == null)
            {
                return Response<MessageViewModel>.Fail("Mesaj açılamadı");
            }
            var messageViewModel = _mapper.Map<MessageViewModel>(message);
            return Response<MessageViewModel>.Success(messageViewModel);
        }

        public async Task<Response<int>> GetMessageCountAsync(string userId, bool isRead = false)
        {
            var count = await _repository.GetCount(x => x.FromId==userId && x.IsRead==isRead);
            return Response<int>.Success(count);
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            var message = await _repository.GetByIdAsync(x => x.Id == id);
            if (message == null)
            {
                return Response<NoContent>.Fail("Silinecek mesaj bulunamadı");
            }
            await _repository.HardDeleteAsync(message);
            return Response<NoContent>.Success();
        }

        public async Task<Response<NoContent>> MakeReadAsync(int id)
        {
            var message = await _repository.GetByIdAsync(x=>x.Id == id);
            message.IsRead = true;
            await _repository.UpdateAsync(message);
            return Response<NoContent>.Success();
        }
    }
}
