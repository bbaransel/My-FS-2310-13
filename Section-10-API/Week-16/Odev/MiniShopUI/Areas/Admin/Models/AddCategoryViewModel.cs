using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.MVC.Areas.Admin.Models
{
    public class AddCategoryViewModel
    {

        [JsonPropertyName("Name")]
        [DisplayName("Ürün")]
        [Required(ErrorMessage ="{0} alaný boþ býrakýlamaz")]
        [MinLength(1, ErrorMessage = "{0} alanýna uzunluðu {1} karakterden az deðer girilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alanýna uzunluðu {1} karakterden fazla deðer girilemez.")]
        public string Name { get; set; }


        [JsonPropertyName("Description")]
        [DisplayName("Ürün Özellikleri")]
        //[Required(ErrorMessage = "{0} alaný boþ býrakýlamaz")]
        //[MinLength(5, ErrorMessage = "{0} alanýna uzunluðu {1} karakterden az deðer girilemez.")]
        public string Description { get; set; }


        [JsonPropertyName("Url")]
        public string Url { get; set; }


        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif Ürün")]
        public bool IsActive { get; set; }

    }
}