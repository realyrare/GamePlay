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
    public class FocusRepository : IFocusRepository
    {
        public bool Delete(Focus entity)
        {
            throw new NotImplementedException();
        }

        public IList<Focus> GetFocusList(int userId,bool  sign)
        {
            string sql = "select  User_UserId   from  Focus  where  User_UserId=@UserId";//关注的用户
            using (var conn = ConnectionFactory.Connection())
            {
                if (sign)
                {                  
                    return conn.Query<Focus>(sql, new { UserId = userId }).ToList();
                }
                else {
                    sql = "select  Self_UserId  from  Focus  where  Self_UserId=@Self_UserId";//粉丝数
                    return conn.Query<Focus>(sql, new { Self_UserId = userId }).ToList();
                }              
            }           
        }
        public IEnumerable<Focus> GetList()
        {
            throw new NotImplementedException();
        }

        public Focus GetModel(int id = 1, string name = null)
        {
            throw new NotImplementedException();
        }

        public int Insert(Focus entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<Focus>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Focus entity)
        {
            throw new NotImplementedException();
        }
    }
}
