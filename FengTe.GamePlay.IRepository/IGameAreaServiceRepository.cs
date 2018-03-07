using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IRepository
{
  public  interface IGameAreaServiceRepository:IBaseRepository<GameAreaService>
    {
        IList<GameAreaService> GetList(int gameId);
    }
}
