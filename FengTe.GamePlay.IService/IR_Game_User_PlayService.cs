using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IService
{
  public  interface IR_Game_User_PlayService:IBaseService<R_Game_User_Play>
    {
        /// <summary>
        /// 大神申请>娱乐陪玩
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool InsertFunPlay(R_Game_User_Play entity, User user);

    }
}
