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
    public class LogService : ILogService
    {
        public bool Delete(Log entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> GetList()
        {
            throw new NotImplementedException();
        }

        public Log GetModel(int id = 1, string where = null)
        {
            throw new NotImplementedException();
        }

        public int Insert(Log entity)
        {
            return IocUtils.Resolve<ILogRepository>().Insert(entity);
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
