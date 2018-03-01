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
    public class VCodeService : IVCodeService
    {
        public bool CheckMobileCode(string mobile, string code)
        {
            int i = IocUtils.Resolve<IVCodeRepository>().CheckMobileCode(mobile, code);
            if (i > 0)
            {
                return true;
            }
            else {
                return false;
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

        public VerificationCode GetModel(int id = 1, string where = null)
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
