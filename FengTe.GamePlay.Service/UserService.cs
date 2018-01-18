using FengTe.GamePlay.Entity;
using FengTe.GamePlay.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity.Params;
using FengTe.GamePlay.Utility;
using FengTe.GamePlay.IRepository;

namespace FengTe.GamePlay.Service
{
    public class UserService : IUserService
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
          return IocUtils.Resolve<IUserRepository>().GetList();
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
