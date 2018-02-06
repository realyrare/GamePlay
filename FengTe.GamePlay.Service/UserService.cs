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
            return  IocUtils.Resolve<IUserRepository>().GetModel(where: where);
        }     
        public int Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<User>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public User Login(string str, string password, out string msg)
        {         
          var user= IocUtils.Resolve<IUserRepository>().GetModel(where: str);
            if (user != null)
            {
                if (user.State == true)
                {
                    if (user.Password == password)
                    {
                        //登录成功了,写其他业务；
                        user.Last_Login_IP = "";
                        user.Last_Login_Time = DateTime.Now;
                        IocUtils.Resolve<IUserRepository>().Update(user);
                        msg = "恭喜：登录成功！";
                        return user;
                    }
                    else
                    {                   
                        msg = "提示：密码错误！";
                        return user;
                    }
                }
                else {               
                    msg = "账户被系统锁定,请联系管理员！";
                    return user;
                }
            }
            else {         
                msg = "账户不存在，请重新输入！";
                return user;
            }                      
        }
        public bool Update(User entity)
        {
           return IocUtils.Resolve<IUserRepository>().Update(entity);
        }
    }
}
