using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IService
{
  public  interface IMoneyService:IBaseService<Money>
    {
        /// <summary>
        /// 用户可用及冻结余额
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        int UserMoney(int userId, bool state);
    }
}
