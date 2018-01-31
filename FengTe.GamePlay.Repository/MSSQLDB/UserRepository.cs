using FengTe.GamePlay.Entity;
using FengTe.GamePlay.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity.Params;
using Dapper;
namespace FengTe.GamePlay.Repository.MSSQLDB
{
    public class UserRepository : IUserRepository
    {
        public bool Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteList(IList<Users> list)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetList()
        {
            using (var conn=ConnectionFactory.Connection())
            {
                //string sql = @"select * from users ";
              return  conn.Query<Users>("select *  from users");                
            }
        }

        public Users GetModel(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Users> GetQueryMultiple()
        {
            throw new NotImplementedException();
        }

        public int Insert(Users entity)
        {
            throw new NotImplementedException();
        }

        public int InsertList(IList<Users> list)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<Users>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }
        public bool Update(Users entity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateList(IList<Users> list)
        {
            throw new NotImplementedException();
        }
    }
}
