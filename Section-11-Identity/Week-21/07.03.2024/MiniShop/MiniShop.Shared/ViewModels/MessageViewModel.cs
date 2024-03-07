using Microsoft.AspNetCore.Mvc.Rendering;
using MiniShop.Shared.ViewModels.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        [DisplayName("Tarih/Saat:")]
        public DateTime SendingDate { get; set; } = DateTime.Now;

        [DisplayName("Mesaj:")]
        public string Text { get; set; }
        [DisplayName("Yanıt:")]
        public string ReplyText { get; set; }

        [DisplayName("Kime:")]
        public string ToId { get; set; }
        public string ToName { get; set; }
        public string FromId { get; set; }
        [DisplayName("Kimden:")]
        public string FromName { get; set; }
        public bool IsRead { get; set; }
        public int RelatedId { get; set; } = 0;
        public List<SelectListItem> UserList { get; set; }
    }
}
