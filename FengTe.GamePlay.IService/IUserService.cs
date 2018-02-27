using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity.Params;
using FengTe.GamePlay.Entity.Enum;

namespace FengTe.GamePlay.IService
{
    public interface IUserService : IBaseService<User>
    {
       bool Login(string str, string password,out string msg,out  User userInfo);
        /// <summary>
        /// 根据用户传入的字段判断是否存在该记录
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        bool IsExistUserWhere(string where);
    }
}
