using FengTe.GamePlay.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity;
using FengTe.GamePlay.Entity.Params;
using Dapper;

namespace FengTe.GamePlay.Repository.MSSQLDB
{
    public class GameAreaServiceRepository : IGameAreaServiceRepository
    {
        public bool Delete(GameAreaService entity)
        {
            throw new NotImplementedException();
        }

        public IList<GameAreaService> GetList(int gameId)
        {
            string sql = "select Id,  AreaName  from GameAreaService where  Games_GameId=@GameId";
            using (var conn=ConnectionFactory.Connection())
            {
               return  conn.Query<GameAreaService>(sql, new { GameId = gameId }).ToList();
            }
        }

        public IEnumerable<GameAreaService> GetList()
        {
            throw new NotImplementedException();
        }

        public GameAreaService GetModel(int id = 1, string name = null)
        {
            throw new NotImplementedException();
        }

        public int Insert(GameAreaService entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<GameAreaService>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(GameAreaService entity)
        {
            throw new NotImplementedException();
        }
    }
}
