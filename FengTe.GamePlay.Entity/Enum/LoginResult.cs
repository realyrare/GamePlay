using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity.Enum
{
    public enum LoginResult
    {
        用户名或手机号不存在 = 0,
        密码错误 = 1,
        用户已被冻结 = 2,
        登录成功 = 3
    }
}
