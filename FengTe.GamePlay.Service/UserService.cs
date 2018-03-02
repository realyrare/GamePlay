using FengTe.GamePlay.Entity;
using FengTe.GamePlay.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity.Params;
using FengTe.GamePlay.Utility;
using FengTe.GamePlay.IRepository;
using FengTe.GamePlay.Entity.Enum;

namespace FengTe.GamePlay.Service
{
    public class UserService : IUserService
    {
        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetList()
        {
            throw new NotImplementedException();
        }

        public User GetModel(int id = 1, string where = null)
        {
            return  IocUtils.Resolve<IUserRepository>().GetModel(name: where);
        }     
        public int Insert(User entity)
        {
           return IocUtils.Resolve<IUserRepository>().Insert(entity);
        }

        public bool IsExistUserWhere(string where)
        {
           User  userInfo= IocUtils.Resolve<IUserRepository>().GetModel(name: where);
            if (userInfo != null)
            {
                return true;
            }
            else {
                return false;
            }
        }
        public Tuple<IEnumerable<User>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Login(string str, string password, out string msg,out  User  userInfo)
        {         
          userInfo= IocUtils.Resolve<IUserRepository>().GetModel(name: str);
            if (userInfo != null)
            {
                if (userInfo.State == true)
                {
                    if (userInfo.Password == DESEncrypt.Encrypt(password))
                    {
                        //登录成功了,写其他业务；
                        userInfo.Last_Login_IP = Net.Ip;
                        userInfo.Last_Login_Time = DateTime.Now;                      
                        IocUtils.Resolve<IUserRepository>().Update(userInfo);
                        msg = "ok,恭喜：登录成功！";
                        return true;
                    }
                    else
                    {                   
                        msg = "no,提示：密码错误！";
                        return false;
                    }
                }
                else {               
                    msg = "no,账户被系统锁定,请联系管理员！";
                    return false;
                }
            }
            else {         
                msg = "no,账户不存在，请重新输入！";
                return false;
            }                      
        }

        public string OutCode(string mobile, string vcode, string ip)
        {
          return  IocUtils.Resolve<IUserRepository>().OutCode(mobile, vcode, ip);
        }

        public bool Update(User entity)
        {
           return IocUtils.Resolve<IUserRepository>().Update(entity);
        }
    }
}
