using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Providers
{
    public class ImageProvider
    {
        private string LogoPath;
        private string CategoryPath;
        private string ProductPath;

        private static ImageProvider _instance;
        public static ImageProvider Instance
        {
            get { return _instance ?? (_instance = new ImageProvider()); }
        }

        public ImageProvider()
        {
            string root = string.Format("{0}/{1}", ConfigurationProvider.Instance.ImageRootPath, SessionProvider.Instance.CurrentShop.Id);
            LogoPath = string.Format("{0}/Logo", root);
            CategoryPath = string.Format("{0}/categories", root);
            ProductPath = string.Format("{0}/products", root);
        }
        public void SaveCategory(HttpPostedFileBase file, string category, string desFileName)
        {
            try
            {
                if (file != null && file.ContentLength > 0)
                {
                    desFileName = string.IsNullOrWhiteSpace(desFileName) ? Guid.NewGuid().ToString() : string.Format("{0}{1}", System.IO.Path.GetFileNameWithoutExtension(desFileName), System.IO.Path.GetExtension(file.FileName));
                    string path = string.Format("{0}/{1}", CategoryPath, category);
                    if (!System.IO.Directory.Exists(path))
                        System.IO.Directory.CreateDirectory(path);

                    file.SaveAs(string.Format("{0}/{1}", path, desFileName));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<string> GetCategory(int categoryId)
        {
            try
            {
                List<string> images = new List<string>();



                return images;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ReCategoryPathName(string oldName, string newName)
        {
            try
            {
                string oldPath = string.Format("{0}/{1}", CategoryPath, oldName);
                if (System.IO.Directory.Exists(oldPath))
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(oldPath, newName);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void SaveLogo(HttpPostedFileBase file)
        {
            try
            {
                if (file != null && file.ContentLength > 0)
                {
                    string desFileName = string.Format("logo{0}", System.IO.Path.GetExtension(file.FileName));
                    if (!System.IO.Directory.Exists(LogoPath))
                        System.IO.Directory.CreateDirectory(LogoPath);

                    string existingLogo = GetLogo();
                    if (!string.IsNullOrWhiteSpace(existingLogo))
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(string.Format("{0}/{1}", LogoPath,existingLogo), string.Format("{0}_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), existingLogo));

                    file.SaveAs(string.Format("{0}/{1}", LogoPath, desFileName));
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public string GetLogo()
        {
            try
            {
                string logo = string.Empty;

                string file= System.IO.Directory.GetFiles(LogoPath, "logo.*").FirstOrDefault();
                if (file != string.Empty)
                    logo = System.IO.Path.GetFileName(file);

                return logo;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}