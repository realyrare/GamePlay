using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IRepository
{
  public  interface IGameRatingRepository:IBaseRepository<GameRating>
    {
        IList<GameRating> GetList(int gameId);
    }
}
