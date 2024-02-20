using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class LoginViewModel
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="Boş bırakılamaz")]
        public string UserName { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage ="Boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
