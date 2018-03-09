using FengTe.GamePlay.Entity;
using FengTe.GamePlay.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity.Params;
using Dapper;
using System.Data;

namespace FengTe.GamePlay.Repository.MSSQLDB
{
    public class UserRepository : IUserRepository
    {
        public bool Delete(User entity)
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

        public User GetModel(int id = 1, string name = null)
        {
            using (var conn = ConnectionFactory.Connection())
            {
                string sql = "select  UserId,UserName,Password,Tel ,State,CurrentCity,Last_Login_Time,Last_Login_IP from  [dbo].[User]  where UserName=@name or Tel=@name ";           
                return conn.Query<User>(sql,new  {name=name}).SingleOrDefault();
            }
        }
        public int Insert(User entity)
        {
            using (var conn=ConnectionFactory.Connection())
            {
                string sql = "	insert  into  [dbo].[User](UserName,Password,Tel,QQ) values(@UserName,@Password,@Tel,@QQ)";
                return conn.Execute(sql, entity);
            }                      
        }
    
        public Tuple<IEnumerable<User>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public string OutCode(string mobile, string vcode, string ip)
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("@mobile", mobile);
            dp.Add("@code", vcode);
            dp.Add("@ip", ip);
            dp.Add("@outCode", "", DbType.String, ParameterDirection.Output);
            using (var conn=ConnectionFactory.Connection())
            {
                conn.Execute("SendVCode", dp, null, null, CommandType.StoredProcedure);
                string outCode = dp.Get<string>("@outCode");
                return outCode;
            }
        }

        public bool Update(User entity)
        {
            using (var conn = ConnectionFactory.Connection())
            {
                string sql = "update [dbo].[User] set Last_Login_IP=@Last_Login_IP,Last_Login_Time=@Last_Login_Time where UserId=@Id";
               int i= conn.Execute(sql, new { Id = entity.UserId, Last_Login_IP = entity.Last_Login_IP, Last_Login_Time = entity.Last_Login_Time });
                return i > 0 ? true : false;
            }
        }     
    }
}
