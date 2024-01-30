using AutoMapper;
using MiniShop.MVC.Areas.Admin.Models;

namespace MiniShop.MVC.Mappings.Admin
{
    public class GeneralMappingProfile: Profile
    {
        GeneralMappingProfile() 
        { 
          CreateMap<ProductViewModel, EditProductViewModel>()
                .ForMember(p=>p.CategoryIds, options => options.MapFrom(x=>x.Categories.Select(c=>c.Id)))
                .ReverseMap();
        }
    }
}
