using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class ChangePasswordViewModel
    {
        [DisplayName("Eski Şifre")]
        [Required(ErrorMessage ="{0} alanı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DisplayName("Yeni Şifre")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DisplayName("Yeni Şifre Tekrar")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ReNewPassword { get; set; }
    }
}
