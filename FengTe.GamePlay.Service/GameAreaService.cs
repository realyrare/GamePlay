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
    public class GameAreaService : IGameAreaService
    {
        public bool Delete(Entity.GameAreaService entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity.GameAreaService> GetList()
        {
            throw new NotImplementedException();
        }

        public IList<Entity.GameAreaService> GetList(int gameId)
        {
            return IocUtils.Resolve<IGameAreaServiceRepository>().GetList(gameId);
        }

        public Entity.GameAreaService GetModel(int id = 1, string where = null)
        {
            throw new NotImplementedException();
        }

        public int Insert(Entity.GameAreaService entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<Entity.GameAreaService>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Entity.GameAreaService entity)
        {
            throw new NotImplementedException();
        }
    }
}
