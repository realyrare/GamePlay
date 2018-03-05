using FengTe.GamePlay.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FengTe.GamePlay.Web.App_Start.Filter
{
    public class CustomerAttribute:AuthorizeAttribute
    {
        public bool Ignore = true;
        public CustomerAttribute(bool ignore=true)
        {
            Ignore = ignore;
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (Ignore==false)
            {
                return;
            }
            if (new OperatorProvider<FrontCurrentUser>().GetCurrent()==null)
            {
                filterContext.HttpContext.Response.Redirect("/UserManage/Login/Index");
              //  filterContext.HttpContext.Response.Write("<script>top.location.href = '/Login/Index';</script>");
            }
           // base.OnAuthorization(filterContext);    
        }
    }
}