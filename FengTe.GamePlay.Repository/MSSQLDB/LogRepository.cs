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
    public class LogRepository : ILogRepository
    {
        public bool Delete(Log entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> GetList()
        {
            throw new NotImplementedException();
        }

        public Log GetModel(int id = 1, string name = null)
        {
            throw new NotImplementedException();
        }

        public int Insert(Log entity)
        {
            string sql = "insert  into log(Title,Msg,IP)values(@Title,@Msg,@IP)";
            using (var conn =ConnectionFactory.Connection())
            {
                return conn.Execute(sql, entity);
            }
        }

        public Tuple<IEnumerable<Log>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Log entity)
        {
            throw new NotImplementedException();
        }
    }
}
