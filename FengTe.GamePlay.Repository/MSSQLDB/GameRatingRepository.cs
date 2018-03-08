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
    public class GameRatingRepository : IGameRatingRepository
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
            string sql = "select Id,  RatingName from GameRating where  Games_GameId=@GameId";
            using (var conn = ConnectionFactory.Connection())
            {
                return conn.Query<GameRating>(sql, new { GameId = gameId }).ToList();
            }
        }

        public GameRating GetModel(int id = 1, string name = null)
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
