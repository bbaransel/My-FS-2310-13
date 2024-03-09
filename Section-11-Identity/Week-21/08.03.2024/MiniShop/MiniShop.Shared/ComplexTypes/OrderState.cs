using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ComplexTypes
{
    public enum OrderState
    {
        [Display(Name = "Sipariş alındı.")]
        Recieved = 0,

        [Display(Name = "Sipariş hazırlanıyor.")]
        Preparing = 1,

        [Display(Name = "Sipariş yola çıktı.")]
        Sent = 2,

        [Display(Name = "Sipariş teslim edildi.")]
        Delivered = 3,
    }
}
