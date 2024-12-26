using Microsoft.AspNetCore.Http.HttpResults;

namespace webApplication.Cars.Helpers
{
    public class DocumentSettings
    {
        public static string UploadFile(IFormFile file ,string folderName)
        {
            if (file == null)
                return "";
            else
            {

                string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName);
                var fileName = $"{file.FileName}";
                string filePath = Path.Combine(FolderPath, fileName);
                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fs);
                }

                return fileName;
            }
            }
        public static void DeleteFile(string filename, string foldername)
        {
            if (filename != null && foldername != null)
            {
                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", foldername, filename);
                if (File.Exists(filepath)) {
                File.Delete(filepath);
                }
            }
        }

    }
}
