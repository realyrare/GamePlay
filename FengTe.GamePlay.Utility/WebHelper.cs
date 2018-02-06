using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Utility
{
   public class WebHelper
    {
        /// <summary>
        /// 计算文件的MD5值
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static String GetStreamMd5(Stream stream)
        {
          
            string strHashData = "";
            var oMd5Hasher =
                new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] arrbytHashValue = oMd5Hasher.ComputeHash(stream);
            //由以连字符分隔的十六进制对构成的String，其中每一对表示value 中对应的元素；例如“F-2C-4A”
            strHashData = System.BitConverter.ToString(arrbytHashValue);
            //替换-
            strHashData = strHashData.Replace("-", "");
            
            return strHashData;
        }
    }
}
