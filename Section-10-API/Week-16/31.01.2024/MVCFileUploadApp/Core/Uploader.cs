namespace MVCFileUploadApp.Core
{
    public static class Uploader
    {
        public static string UploadImage(IFormFile image)
        {
            //dosyaismi.uzantı
            //Örnek image ismi : ipjone12.png

            //.png
            var extension = "." + image.FileName.Split('.')[image.FileName.Split('.').Length-1];

            //localhost:7700/wwwroot/images
            var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","images");
            if(!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            //asfga2G4S12FD31SG.png
            var fileName = $"{Guid.NewGuid()}{extension}";
            //localhost:7700/wwwroot/images/asfga2G4S12FD31SG.png
            var path = Path.Combine(filePath,fileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return fileName;
        }
    }
}
