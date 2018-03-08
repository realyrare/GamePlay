using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
namespace FengTe.GamePlay.Utility
{
 public  class ImgUploadHelper
    {
        /// <summary>
        /// 公共的图片上传方法
        /// </summary>
        /// <param name="file"></param>
        /// <param name="msg"></param>
        ///  /// <param name="filePath">存放的文件路径</param>
        /// <returns></returns>
        ///  HttpPostedFileBase
        public static string CommonUploadImg(HttpPostedFileBase file, out string msg, string filePath)
        {
            string[] imgType = { ".jpg", ".png", ".jpeg", ".bmp" };
            string fullDir=null;
            if (file == null)
            {
                return msg = "empty,您懂上传吗？";
            }
            string fileExt = Path.GetExtension(file.FileName);//得到文件的后缀名
            if (imgType.Contains(fileExt))
            {
                if (file.ContentLength>1024*1024*3)
                {
                    return msg = "size,上传图片不能超过3M";
                }
                //拿到文件MD5值+文件扩展名
                string fileName = WebHelper.GetStreamMd5(file.InputStream) + fileExt;
                if (IsCreateFolder(filePath))
                {
                    //转换为相对路径             
                    fullDir = System.Web.HttpContext.Current.Server.MapPath(filePath + fileName);
                    file.SaveAs(fullDir);
                  
                }
                return msg = filePath + fileName;
            }
            else
            {
                return msg = "typeError,请选择正确的图片类型,目前仅支持:jpg/png/jpeg";
            }
        }
        /// <summary>
        /// 根据文件名删除图片
        /// </summary>     
        public static bool DeleteFileByName(string name)
        {
            File.Delete(name);
            return true;
        }
        //根据相对路径在项目根路径下创建文件夹
        private static bool IsCreateFolder(string path)
        {
            bool result = true;
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }

    }
}
