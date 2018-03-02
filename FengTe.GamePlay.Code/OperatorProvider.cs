using FengTe.GamePlay.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Code
{
  public  class OperatorProvider<T> where T:class,new()
    { 
    //  public static T Provider
    //{
    //    get { return new T(); }
    //}
    private string LoginUserKey = "current_user";
    private string LoginProvider = Configs.GetValue("LoginProvider");

    public  T GetCurrent()
    {
        T operatorModel = new T();
        if (LoginProvider == "Cookie")
        {
            operatorModel = DESEncrypt.Decrypt(CookieHelper.GetCookieValue(LoginUserKey).ToString()).ToObject<T>();
        }
        else
        {
            operatorModel = DESEncrypt.Decrypt(WebHelper.GetSession(LoginUserKey).ToString()).ToObject<T>();
        }
        return operatorModel;
    }
    public void AddCurrent(T operatorModel)
    {
        if (LoginProvider == "Cookie")
        {
          CookieHelper.SetCookie(LoginUserKey, DESEncrypt.Encrypt(operatorModel.ToJson()), DateTime.Now.AddMinutes(60)); 
        }
        else
        {
            WebHelper.WriteSession(LoginUserKey, DESEncrypt.Encrypt(operatorModel.ToJson()));
        }
        //WebHelper.WriteCookie("nfine_mac", Md5.md5(Net.GetMacByNetworkInterface().ToJson(), 32));
        //WebHelper.WriteCookie("nfine_licence", Licence.GetLicence());
    }
    public void RemoveCurrent()
    {
        if (LoginProvider == "Cookie")
        {
                CookieHelper.ClearCookie(LoginUserKey.Trim());        
        }
        else
        {
            WebHelper.RemoveSession(LoginUserKey.Trim());
        }
    }
}
}
