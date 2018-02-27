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
        public ActionResult UserReg()
        {
            User user = new User() { };
           int i= IocUtils.Resolve<IUserService>().Insert(user);
            if (i > 0)
            {
                return Content("恭喜：注册成功！");
            }
            else {
                return Content("提示：注册失败！");
            }
        }
        public ActionResult IsUserWhere(string where)
        {
            if (IocUtils.Resolve<IUserService>().IsExistUserWhere(where))
            {
                return Content("exist");
            }
            else {
                return Content("noExist");
            }            
        }
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