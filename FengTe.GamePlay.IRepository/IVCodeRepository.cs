using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IRepository
{
   public interface IVCodeRepository: IBaseRepository<VerificationCode>
    {
        /// <summary>
        /// 验证码与库中手机号，验证码是否匹配+
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        int CheckMobileCode(string mobile, string code);
    }
}
