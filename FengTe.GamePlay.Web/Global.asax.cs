using FengTe.GamePlay.Utility;
using System;
using System.Collections.Generic;
using System.IO;
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
            FileInfo configFile = new FileInfo(HttpContext.Current.Server.MapPath("/Config/log4net.config"));
            log4net.Config.XmlConfigurator.Configure(configFile);
        }
        public void Application_Error(object send, EventArgs e)
        {
             //记录日志
            Exception ex = Server.GetLastError();               
            LogHelper.WriteLog(ex.ToString());          
            // Response.Redirect("/Home/Error");
        }
    }
}
