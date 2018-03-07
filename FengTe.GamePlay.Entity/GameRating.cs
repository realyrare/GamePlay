using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 游戏段位表
    /// </summary>
  public  class GameRating
    {
        public int Id { get; set; }
        public string RatingName { get; set; }
        public int Price { get; set; }
        public DateTime InTime { get; set; }
        public int Games_GameId { get; set; }
    }
}
