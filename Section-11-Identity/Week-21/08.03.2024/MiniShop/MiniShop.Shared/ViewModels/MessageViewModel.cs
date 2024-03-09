using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

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
