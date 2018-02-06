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
       User Login(string str, string password,out string msg);
    }
}
