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
    public class MoneyService : IMoneyService
    {
        public bool Delete(Money entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Money> GetList()
        {
            throw new NotImplementedException();
        }

        public Money GetModel(int id = 1, string where = null)
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
            return IocUtils.Resolve<IMoneyRepository>().UserMoney(userId, state);
        }
    }
}
