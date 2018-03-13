using FengTe.GamePlay.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity;
using FengTe.GamePlay.Entity.Params;
using FengTe.GamePlay.Utility;
using FengTe.GamePlay.IRepository;

namespace FengTe.GamePlay.Service
{
    public class R_Game_User_PlayService : IR_Game_User_PlayService
    {
        public bool Delete(R_Game_User_Play entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<R_Game_User_Play> GetList()
        {
            throw new NotImplementedException();
        }

        public R_Game_User_Play GetModel(int id = 1, string where = null)
        {
            return IocUtils.Resolve<IR_Game_User_PlayRepository>().GetModel(id);
        }

        public int Insert(R_Game_User_Play entity)
        {
            return IocUtils.Resolve<IR_Game_User_PlayRepository>().Insert(entity);
        }

        public bool InsertFunPlay(R_Game_User_Play entity, User user)
        {
            return IocUtils.Resolve<IR_Game_User_PlayRepository>().InsertFunPlay(entity,  user) >0?true:false;
        }

        public Tuple<IEnumerable<R_Game_User_Play>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(R_Game_User_Play entity)
        {
            throw new NotImplementedException();
        }
    }
}
