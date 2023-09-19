
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace BusinessLayer.Utility;

public static class InsertPhoto
{
    public static string Insert(this IFormFile file, string path)
    {
        string ImageName = "";
        if (file != null && !path.IsNullOrEmpty())
        {
            ImageName = GenerateCodeClass.GenerateCode() + Path.GetExtension(file.FileName);
            var Fullpath = Path.Combine(Directory.GetCurrentDirectory(), path, ImageName);
            using (var filePhoto = new FileStream(Fullpath, FileMode.Create))
            {
                file.CopyTo(filePhoto);
            }

        }
        return ImageName;
    }

    public static string InsertRange(List<InsertPhotoListDto> photoLists)
    {
        string ImageName = "";
        foreach (var item in photoLists)
        {

            ImageName = GenerateCodeClass.GenerateCode() + Path.GetExtension(item.file.FileName);
            var Fullpath = Path.Combine(Directory.GetCurrentDirectory(), item.path, ImageName);
            using (var filePhoto = new FileStream(Fullpath, FileMode.Create))
            {
                item.file.CopyTo(filePhoto);
            }

        }

        return ImageName;
    }


    public class InsertPhotoListDto
    {
        public IFormFile file { get; set; }
        public string path { get; set; }
    }
}
