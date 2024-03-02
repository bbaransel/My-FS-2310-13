﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class ResetPasswordViewModel
    {
        public string UserId { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage ="{0} alanı boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrar")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "İki şifre birbiri ile uyuşmuyor.")]
        public string RePassword { get; set; }
        public string TokenCode { get; set; }
    }
}
