using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MiniShop.Shared.ViewModels
{
    public class AddCategoryViewModel
    {
        [JsonPropertyName("Name")]
        [DisplayName("Ürün")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        [MinLength(5, ErrorMessage = "{0} alanına uzunluğu {1} karakterden küçük değer girilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alanına uzunluğu {1} karakterden büyük değer girilemez.")]
        public string Name { get; set; }

        [JsonPropertyName("Description")]
        [DisplayName("Kategori Açıklaması")]
        public string Description { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif Kategori")]
        public bool IsActive { get; set; }
    }
}
