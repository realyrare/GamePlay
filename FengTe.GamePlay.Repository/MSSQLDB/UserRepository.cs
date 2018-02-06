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
        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteList(IList<User> list)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetList()
        {
            using (var conn=ConnectionFactory.Connection())
            {
                //string sql = @"select * from user ";
              return  conn.Query<User>("select username,password  from user");                
            }
        }

        public User GetModel(int id = 1, string where = null)
        {
            using (var conn = ConnectionFactory.Connection())
            {
                string sql = "select id,UserName,Password,Tel ,State from  [dbo].[User]where UserName=@where or tel=@where";           
                return conn.Query<User>(sql,new  {UserName=where,Tel=where }).FirstOrDefault();
            }
        }

        public IList<User> GetQueryMultiple()
        {
            throw new NotImplementedException();
        }

        public int Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public int InsertList(IList<User> list)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<User>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }
        public bool Update(User entity)
        {
            using (var conn = ConnectionFactory.Connection())
            {
                string sql = "update user set Last_Login_IP=@Last_Login_IP,Last_Login_Time=@Last_Login_Time where id=@Id";
               int i= conn.Execute(sql, new { Id = entity.UserId, Last_Login_IP = entity.Last_Login_IP, Last_Login_Time = entity.Last_Login_Time });
                return i > 0 ? true : false;
            }
        }

        public bool UpdateList(IList<User> list)
        {
            throw new NotImplementedException();
        }
    }
}
