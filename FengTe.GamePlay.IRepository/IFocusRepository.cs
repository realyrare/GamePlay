using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IRepository
{
    public interface IFocusRepository:IBaseRepository<Focus>
    {
        /// <summary>
        /// 当前用户关注与粉丝数
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="sign"> true为关注，false为粉丝</param>
        /// <returns></returns>
        IList<Focus> GetFocusList(int userId ,bool sign);
    }
}
