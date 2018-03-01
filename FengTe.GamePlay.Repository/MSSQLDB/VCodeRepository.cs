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
    public class VCodeRepository : IVCodeRepository
    {
        public int CheckMobileCode(string mobile, string code)
        {
            
            using (var conn=ConnectionFactory.Connection())
            {
                string sql = "select 1 from  VerificationCode  where mobile=@Mobile and code=@Code  and DATEDIFF(MINUTE,intime,getdate())<300";
                return  conn.Query<int>(sql, new { Mobile = mobile, Code = code }).FirstOrDefault();
            }
        }
        public bool Delete(VerificationCode entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VerificationCode> GetList()
        {
            throw new NotImplementedException();
        }

        public VerificationCode GetModel(int id = 1, string name = null)
        {
            throw new NotImplementedException();
        }

        public int Insert(VerificationCode entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<VerificationCode>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(VerificationCode entity)
        {
            throw new NotImplementedException();
        }
    }
}
