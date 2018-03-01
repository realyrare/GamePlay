using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace FengTe.GamePlay.Utility
{
   public class VCode
    {
        /// <summary>
        /// 阿里大鱼api验证码发送
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="outCode"></param>
        /// <returns></returns>
        public static string SendVCode(string mobile,string outCode)
        {
            try
            {
                ITopClient client = new DefaultTopClient("http://gw.api.taobao.com/router/rest", "23450194", "52b5a70bc10ba56ccfe6e50bdb9fa8d4");
                AlibabaAliqinFcSmsNumSendRequest req = new AlibabaAliqinFcSmsNumSendRequest();
                req.Extend = "";
                req.SmsType = "normal";
                req.SmsFreeSignName = "爽赞游戏网"; //签名,将来要改
                req.SmsParam = "{\"code\":\"" + outCode + "\",\"product\":\"爽赞游戏网(www.shuangzan.com)\"}";
              //  req.SmsFreeSignName = "躺鹰网"; //签名,将来要改
               // req.SmsParam = "{\"code\":\"" + outCode + "\",\"product\":\"躺鹰网(www.tangying.com)\"}";
                req.RecNum = mobile;
                req.SmsTemplateCode = "SMS_14720884"; //短信模板                                                
                AlibabaAliqinFcSmsNumSendResponse rsp = client.Execute(req);
                if (rsp.Result.Success)
                    return  "ok,验证码发送成功";
                else
                {
                    return  "no,验证码发送失败";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
