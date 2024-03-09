using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class LoginViewModel
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string UserName { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Beni hatırla")]
        public bool RememberMe { get; set; }
    }
}
