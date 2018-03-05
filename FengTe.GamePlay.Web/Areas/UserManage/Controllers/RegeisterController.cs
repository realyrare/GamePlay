using FengTe.GamePlay.Entity;
using FengTe.GamePlay.IService;
using FengTe.GamePlay.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FengTe.GamePlay.Web.Areas.UserManage.Controllers
{
    public class RegeisterController : Controller
    {
        // GET: UserManage/Regeister
     
        /// <summary>
        /// 前台注册
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        #region 用户注册
        public ActionResult UserReg(string uname, string phone, string pwd, int qq)
        {
            User user = new User()
            {
                UserName = uname,
                Tel = phone,
                Password =DESEncrypt.Encrypt(pwd),
                QQ = qq
            };
            int i = IocUtils.Resolve<IUserService>().Insert(user);
            if (i > 0)
            {
                return Content("ok,恭喜：注册成功！");
            }
            else
            {
                return Content("no,提示：注册失败！");
            }
        } 
        #endregion
        #region 校验手机号，用户名是否已存在
        public ActionResult IsUserWhere(string where)
        {
            if (IocUtils.Resolve<IUserService>().IsExistUserWhere(where))
            {
                return Content("exist");
            }
            else
            {
                return Content("noExist");
            }
        } 
        #endregion
        #region 用户注册验证码发送
        public ActionResult SendVcode(string phone, string vcode)
        {
            var validatecode = Session["user_vcode"].ToString() == null ? "" : Session["user_vcode"].ToString();
            if (string.IsNullOrEmpty(vcode))
            {
                return Content("提示：验证码错误！");
            }
            if (!validatecode.Equals(vcode, StringComparison.CurrentCultureIgnoreCase))
            {
                return Content("提示：验证码错误！");
            }
            if (phone.Length != 11 && phone.ToString() == null)
            {
                return Content("提示：手机号码不正确");
            }
            Random r = new Random();
            string code2 = r.Next(100000, 999999).ToString();
            string ip = Net.Ip;
            string outCode = IocUtils.Resolve<IUserService>().OutCode(phone, code2, ip);
            if (outCode != null)
            {
                string msg = VCode.SendVCode(phone, outCode);
                return Content(msg);
            }
            else
            {
                return Content("您的验证码短信仍在30分钟有效期内");
            }
        }
        #endregion
        #region 校验验证码是否匹配
        public ActionResult CheckMobileCode(string mobile, string code)
        {
            if (IocUtils.Resolve<IVCodeService>().CheckMobileCode(mobile, code))
            {
                return Content("ok");
            }
            else {
                return Content("no");
            }            
        }
        #endregion
        /// <summary>
        /// 第三方注册
        /// </summary>
        /// <returns></returns>
        public ActionResult RegisterOther()

        {
            return View();
        }
        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <returns></returns>
        public ActionResult ForgetPwd()
        {
            return View();
        }
    }
}