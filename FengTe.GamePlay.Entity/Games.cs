using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 游戏仓储表
    /// </summary>
   public class Games
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int GameId { get; set; }
        /// <summary>
        /// 游戏名称
        /// </summary>
        public string GameName { get; set; }
        /// <summary>
        /// 游戏区服
        /// </summary>
        public string AreaService { get; set; }
        /// <summary>
        /// 游戏入库时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 游戏段位
        /// </summary>
        public string Rating { get; set; }
        /// <summary>
        /// 游戏Logo图
        /// </summary>
        public string LogoImg { get; set; }
        /// <summary>
        /// 游戏线上单价
        /// </summary>
        public int OnLine_OnePrice { get; set; }
        /// <summary>
        /// 游戏线下陪玩单价
        /// </summary>
        public int OffLine_OnePrice { get; set; }
    }
}
