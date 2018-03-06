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
    public class GamesService : IGamesService
    {
        public bool Delete(Games entity)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Games> GetList()
        {
            return IocUtils.Resolve<IGamesRepository>().GetList();
        }
        public Games GetModel(int id = 1, string where = null)
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
