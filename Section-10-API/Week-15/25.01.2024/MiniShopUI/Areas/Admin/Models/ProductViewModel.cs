using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.MVC.Areas.Admin.Models
{
    public class ProductViewModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Properties")]
        public string Properties { get; set; }

        [JsonPropertyName("Price")]
        public decimal Price { get; set; }

        [JsonPropertyName("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
        [JsonPropertyName("IsHome")]
        public bool IsHome { get; set; }
        [JsonPropertyName("IsActive")]
        public bool IsActive { get; set; }

    }
}