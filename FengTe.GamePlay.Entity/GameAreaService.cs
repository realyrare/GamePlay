using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 游戏区服表
    /// </summary>
  public  class GameAreaService

    {
        public int Id { get; set; }
        public DateTime InTime { get; set; }
        public string AreaName { get; set; }
        public int Games_GameId { get; set; }
    }
}
