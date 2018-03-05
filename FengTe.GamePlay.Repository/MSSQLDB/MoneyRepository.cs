using FengTe.GamePlay.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity.Params;
using FengTe.GamePlay.Entity;
using Dapper;

namespace FengTe.GamePlay.Repository.MSSQLDB
{
    public class MoneyRepository : IMoneyRepository
    {
        public bool Delete(Money entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Money> GetList()
        {
            throw new NotImplementedException();
        }

        public Money GetModel(int id = 1, string name = null)
        {
            throw new NotImplementedException();
        }

        public int Insert(Money entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<Money>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Money entity)
        {
            throw new NotImplementedException();
        }

        public int UserMoney(int userId, bool state)
        {
            string sql = @"SELECT COALESCE(SUM(rmb),0) FROM  Money where Money.User_UserId=@UserId and RMBState=@State";
            using (var conn=ConnectionFactory.Connection())
            {
                if (state==false)
                {
                    return conn.Query<int>(sql, new {UserId=userId,State=0 }).SingleOrDefault();
                }
                else {
                    return conn.Query<int>(sql, new { UserId = userId, State =1 }).SingleOrDefault();
                }
               
            }
        }
    }
}
