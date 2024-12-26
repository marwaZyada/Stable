using System.ComponentModel.DataAnnotations;
using webApplication.Cars.Helpers;

namespace Stable.Models
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public List<Photo> Photos { get; set; }=new List<Photo>();

        public void AddImage(IFormFile file)
        {
            var image = "https://localhost:7251/Images/" + DocumentSettings.UploadFile(file,"Images");
            var photo = new Photo
            {
                Name = image,
            };
            Photos.Add(photo);
        }

        public void DeleteImage(string Image)
        {
            var ImageName = Image.Split('/') ;
            DocumentSettings.DeleteFile(ImageName[ImageName.Length - 1], "Images"); ;
        }
    }
}
