using FengTe.GamePlay.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FengTe.GamePlay.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           
            IocUtils.Init();
            //让log4net配置节点起作用
            log4net.Config.XmlConfigurator.Configure();
        }

        public void Application_Error(object send, EventArgs e)
        {
             //记录日志
            Exception ex = Server.GetLastError();
            string errorMsg = ex.ToString();         
            LogHelper.WriteLog(errorMsg);
            //   //转到错误页或者跳转。
            // Response.Redirect("/Home/Error");
        }
    }
}
