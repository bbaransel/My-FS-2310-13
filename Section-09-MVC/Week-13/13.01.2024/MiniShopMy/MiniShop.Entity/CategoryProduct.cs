﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Entity
{
    public class CategoryProduct
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Navigation Property
        public int ProductId { get; set; }
        public Product Product { get; set; } // Navigation Property
    }
}
