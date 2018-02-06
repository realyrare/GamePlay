using FengTe.GamePlay.Entity;
using FengTe.GamePlay.Entity.Enum;
using FengTe.GamePlay.IService;
using FengTe.GamePlay.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FengTe.GamePlay.Web.Areas.UserManage.Controllers
{
    public class LoginController : Controller
    {
        // GET: UserManage/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserLogin(string str,string pwd,string isCheck,string vcode)
        {
            if (string.IsNullOrEmpty(str))
            {
                return Content("提示：请输入您的用户名或手机号！");
            }
            if (string.IsNullOrEmpty(pwd))
            {
                return Content("提示：请输入您的登录密码！");
            }
            // 校验验证码
            var session = Session["user_vcode"].ToString()==null?"": Session["user_vcode"].ToString();
            if (string.IsNullOrEmpty(vcode)||session!= vcode.ToString())
            {
                return Content("提示：验证码错误！");
            }
            string msg = string.Empty;        
            User user = IocUtils.Resolve<IUserService>().Login(str, pwd,out  msg);
            if (user != null)
            {
                if (msg == "恭喜：登录成功！")
                {
                    Session["current_user"] = user;
                    if (!string.IsNullOrEmpty(isCheck))
                    {
                        CookieHelper.SetCookie("sb1", user.UserName, DateTime.Now.AddDays(7));
                        CookieHelper.SetCookie("sb2", user.Password, DateTime.Now.AddDays(7));
                    }
                    return Content(msg);
                }
                else {
                    return Content(msg);
                }
            }
            else {
                return Content(msg);
            }
           
        }
        /// <summary>
        /// 验证码生成
        /// </summary>
        /// <returns></returns>
        public FileResult VCode()
        {
            var vcode = VerifyCode.CreateRandomCode(4);
            Session["user_vcode"] = vcode;
            var img = VerifyCode.DrawImage(vcode, 20, Color.White);
            return File(img, "image/gif");
        }
    }
}