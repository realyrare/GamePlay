using FengTe.GamePlay.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity;
using FengTe.GamePlay.Entity.Params;
using Dapper;

namespace FengTe.GamePlay.Repository
{
    public class GamesRepository : IGamesRepository
    {
        public bool Delete(Games entity)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Games> GetList()
        {
            string sql = "select GameId,GameName,AreaService,Rating  from  Games ";
            using (var conn=ConnectionFactory.Connection())
            {
               return  conn.Query<Games>(sql);
            }
        }
        public Games GetModel(int id = 1, string name = null)
        {
            throw new NotImplementedException();
        }
        public int Insert(Games entity)
        {
            throw new NotImplementedException();
        }
        public Tuple<IEnumerable<Games>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }
        public bool Update(Games entity)
        {
            throw new NotImplementedException();
        }
    }
}
