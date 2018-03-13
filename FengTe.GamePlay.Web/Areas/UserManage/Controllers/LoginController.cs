using FengTe.GamePlay.Code;
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
                return Content("no,提示：请输入您的用户名或手机号！");
            }
            if (string.IsNullOrEmpty(pwd))
            {
                return Content("no,提示：请输入您的登录密码！");
            }
            // 校验验证码
            var session = Session["user_vcode"].ToString()==null?"": Session["user_vcode"].ToString();
            if (string.IsNullOrEmpty(vcode)||session!= vcode.ToString())
            {
                return Content("no,提示：验证码错误！");
            }          
            string msg = string.Empty;
            User userInfo = null;
            Log log = new Log();
            if (IocUtils.Resolve<IUserService>().Login(str, pwd, out msg,out userInfo))
            {
                //添加当前用户
                FrontCurrentUser currentUser = new FrontCurrentUser()
                {
                    UserId=userInfo.UserId,
                    UserAccount=userInfo.UserName,
                    UserPwd=userInfo.Password,
                   Last_Login_IP=userInfo.Last_Login_IP,
                   Last_Login_Time=userInfo.Last_Login_Time,
                   Intro=userInfo.Intro,
                   HomePage_Img=userInfo.HomePage_Img,
                   HeadImg=userInfo.HeadImg,
                   CurrentCity=userInfo.CurrentCity,
                   LoginToken=DESEncrypt.Encrypt(Guid.NewGuid().ToString())
                };
                OperatorProvider<FrontCurrentUser> provider = new OperatorProvider<FrontCurrentUser>();
                provider.AddCurrent(currentUser);
                //写日志
                log.Title = userInfo.UserName;
                log.Msg = "个人中心用户登录成功";
                log.IP = Net.Ip;             
                IocUtils.Resolve<ILogService>().Insert(log);
                // Session["current_user"] = userInfo;
                if (!string.IsNullOrEmpty(isCheck))
                {
                    CookieHelper.SetCookie("sb1", userInfo.UserName, DateTime.Now.AddDays(7));
                    CookieHelper.SetCookie("sb2", DESEncrypt.Encrypt(userInfo.Password), DateTime.Now.AddDays(7));
                }
                return Content(msg);
            }                         
            else {
                log.Title = userInfo.UserName;
                log.Msg = "个人中心用户登录失败" + msg;
                log.IP = Net.Ip;
                IocUtils.Resolve<ILogService>().Insert(log);
                return Content(msg);
            }          
        }
        [HttpGet]
        public ActionResult OutLogin()
        {
            string title = new OperatorProvider<FrontCurrentUser>().GetCurrent().UserAccount;
            if (string.IsNullOrEmpty(title))
            {
                return RedirectToAction("Index", "Login");
            }
            Log log = new Log() {
                Title= title,
                Msg = "个人中心用户安全退出系统",
                IP=Net.Ip
            };
            IocUtils.Resolve<ILogService>().Insert(log);
            Session.Abandon();
            Session.Clear();
            new OperatorProvider<FrontCurrentUser>().RemoveCurrent();
            return RedirectToAction("Index", "Login");
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