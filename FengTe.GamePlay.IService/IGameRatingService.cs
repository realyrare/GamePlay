using FengTe.GamePlay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IService
{
    public  interface IGameRatingService:IBaseService<GameRating>
    {
        IList<GameRating> GetList(int gameId);
    }
}
