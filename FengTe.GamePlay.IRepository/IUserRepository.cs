using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IRepository
{
  public  interface IUserRepository:IBaseRepository<User>
    {
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="vcode"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        string OutCode(string mobile, string vcode, string ip);
        int UserInfoUpdate(User user);
      
    }
}
