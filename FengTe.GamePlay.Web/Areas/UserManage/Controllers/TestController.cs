using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FengTe.GamePlay.Utility;
using FengTe.GamePlay.IRepository;
using FengTe.GamePlay.Entity;
using FengTe.GamePlay.IService;

namespace FengTe.GamePlay.Web.Areas.UserManage.Controllers
{
    public class TestController : Controller
    {
        // GET: UserManage/Test
        public ActionResult Index()
        {
          var data=  IocUtils.Resolve<IUserService>().GetList();
            return View(data);
        }
    }
}