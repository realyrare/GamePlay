using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IService
{
   public interface IVCodeService:IBaseService<VerificationCode>
    {
        bool CheckMobileCode(string mobile, string code);
    }
}
