using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Infrastructure.Helper
{
    public static class Upload
    {
        public static List<string> imageUploads(IWebHostEnvironment env, List<IFormFile> files, out bool sonuc)
        {
            var errors = new List<string>();
            var filepaths = new List<string>();
            sonuc = false;
            var uploads = Path.Combine(env.WebRootPath, "uploads");

            if (files.Count <= 0 || files.Count > 3)
                errors.Add("Resim dosyası bulunamadı! veya Belirlenen sayıdan fazla yüklemeye çalışıyorsunuz.");

            foreach (var item in files)
            {
                if (!item.ContentType.Contains("image"))
                    errors.Add("Lütfen sadece resim yükleyiniz.");

                if (item.Length > 10485760)
                    errors.Add("Dosya Boyutu 10MB'den ve düşük olmalıdır.");
            }



            if (errors.Count == 0)
            {
                foreach (var item in files)
                {
                    string uniqueName =
                               $"{Guid.NewGuid().ToString().Replace("-", "_").ToLower()}.{item.ContentType.Split("/")[1]}";
                    var filePath = Path.Combine(uploads, uniqueName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        item.CopyTo(stream);
                        sonuc = true;
                        filepaths.Add(filePath.Substring(filePath.IndexOf("\\uploads\\")));
                    }
                }
                sonuc = true;
                return filepaths;
            }

            return errors;
        }

        public static string imageUpload(IWebHostEnvironment env, IFormFile file, out bool sonuc)
        {
            sonuc = false;
            var uploads = Path.Combine(env.WebRootPath, "uploads");
            if (file != null)
            {
                if (file.ContentType.Contains("image"))
                {
                    if (file.Length <= 10485760)
                    {
                        string uniqueName =
                            $"{Guid.NewGuid().ToString().Replace("-", "_").ToLower()}.{file.ContentType.Split("/")[1]}";
                        var filePath = Path.Combine(uploads, uniqueName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            sonuc = true;
                            return filePath.Substring(filePath.IndexOf("\\uploads\\"));
                        }
                    }
                    else
                        return "Dosya Boyutu 10MB'den ve düşük olmalıdır.";
                }
                else
                    return "Lütfen sadece resim yükleyiniz.";
            }
            return "Resim dosyası bulunamadı! veya Belirlenen sayıdan fazla yüklemeye çalışıyorsunuz.";
        }
    }
}
