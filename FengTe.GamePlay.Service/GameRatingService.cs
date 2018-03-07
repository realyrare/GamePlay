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
    public class GameRatingService : IGameRatingService
    {
        public bool Delete(GameRating entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameRating> GetList()
        {
            throw new NotImplementedException();
        }

        public IList<GameRating> GetList(int gameId)
        {
            return IocUtils.Resolve<IGameRatingRepository>().GetList(gameId);
         
        }

        public GameRating GetModel(int id = 1, string where = null)
        {
            throw new NotImplementedException();
        }

        public int Insert(GameRating entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<GameRating>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(GameRating entity)
        {
            throw new NotImplementedException();
        }
    }
}
