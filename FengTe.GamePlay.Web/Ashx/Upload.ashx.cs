using FengTe.GamePlay.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FengTe.GamePlay.Web.Ashx
{
    public class Upload : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            try
            {
                HttpPostedFile file;
                string msg = string.Empty;
                string filePath = "/Content/GameImg/";
                for (int i = 0; i < context.Request.Files.Count; ++i)
                {
                    file = context.Request.Files[i];
                    string[] imgType = { ".jpg", ".png", ".jpeg", ".bmp" };
                    string fullDir = null;
                    if (file == null || file.ContentLength == 0 || string.IsNullOrEmpty(file.FileName))
                    {
                        msg = "empty,您懂上传吗？";
                    }
                    string fileExt = Path.GetExtension(file.FileName);//得到文件的后缀名
                    if (imgType.Contains(fileExt))
                    {
                        if (file.ContentLength > 1024 * 1024 * 3)
                        {
                            msg = "size,上传图片不能超过3M";
                        }
                        //拿到文件MD5值+文件扩展名
                        string fileName = WebHelper.GetStreamMd5(file.InputStream) + fileExt;
                        if (IsCreateFolder(filePath))
                        {
                            //转换为相对路径             
                            fullDir = System.Web.HttpContext.Current.Server.MapPath(filePath + fileName);
                            file.SaveAs(fullDir);
                        }
                        msg = filePath + fileName;
                    }
                    else
                    {
                        msg = "typeError,请选择正确的图片类型、目前仅支持:jpg/png/jpeg";
                    }
                    context.Response.Write(JsonConvert.SerializeObject(msg));//输出上传地址以用于前台js获取                

                }
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                context.Response.Write(ex.Message);
                context.Response.End();
            }
            finally
            {
                context.Response.End();
            }
        }
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
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}