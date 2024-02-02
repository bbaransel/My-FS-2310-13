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
        [DisplayName("�r�n")]
        [Required(ErrorMessage ="{0} alan� bo� b�rak�lamaz")]
        [MinLength(1, ErrorMessage = "{0} alan�na uzunlu�u {1} karakterden az de�er girilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alan�na uzunlu�u {1} karakterden fazla de�er girilemez.")]
        public string Name { get; set; }


        [JsonPropertyName("Description")]
        [DisplayName("�r�n �zellikleri")]
        //[Required(ErrorMessage = "{0} alan� bo� b�rak�lamaz")]
        //[MinLength(5, ErrorMessage = "{0} alan�na uzunlu�u {1} karakterden az de�er girilemez.")]
        public string Description { get; set; }


        [JsonPropertyName("Url")]
        public string Url { get; set; }


        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif �r�n")]
        public bool IsActive { get; set; }

    }
}