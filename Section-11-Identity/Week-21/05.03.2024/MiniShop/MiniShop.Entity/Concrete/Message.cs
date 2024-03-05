﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Entity.Concrete
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime SendingDate { get; set; } = DateTime.Now;
        public string Text { get; set; }
        public string ToId { get; set; }
        public string FromId { get; set; }
        public bool IsRead { get; set; }
    }
}
