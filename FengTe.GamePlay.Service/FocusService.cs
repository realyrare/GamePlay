using FengTe.GamePlay.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity;
using FengTe.GamePlay.Entity.Params;
using FengTe.GamePlay.Utility;
using FengTe.GamePlay.IRepository;

namespace FengTe.GamePlay.Service
{
    public class FocusService : IFocusService
    {
        public bool Delete(Focus entity)
        {
            throw new NotImplementedException();
        }    
        public IList<Focus> GetFocusList(int userId, bool sign)
        {
         return   IocUtils.Resolve<IFocusRepository>().GetFocusList(userId, sign);
        }

        public IEnumerable<Focus> GetList()
        {
            throw new NotImplementedException();
        }
        public Focus GetModel(int id = 1, string where = null)
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
