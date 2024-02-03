using Microsoft.AspNetCore.Http;
using MiniShop.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile image, string folderName);
        bool ImageIsValid(string extension);
    }
}
