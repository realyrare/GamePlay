using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 游戏价格
    /// </summary>
  public  class GamePrice
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string GradeName { get; set; }
        /// <summary>
        /// 可接段位
        /// </summary>
        public string OrderRange { get; set; }
        public int Price { get; set; }
        public string RatingName { get; set; }
        public int Type { get; set; }
        public DateTime InTime { get; set; }
    }
}
