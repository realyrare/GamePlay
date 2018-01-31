using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 游戏结果表
    /// </summary>
  public  class GameResult
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 系统当前的时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 游戏结果（输或赢）
        /// </summary>
        public bool Result { get; set; }
        /// <summary>
        /// 吃鸡游戏的详细结果
        /// </summary>
        public int EatChook_GameResultId { get; set; }
        /// <summary>
        /// 当前用户
        /// </summary>
        public int User_UserId { get; set; }
       /// <summary>
       /// 当前的游戏
       /// </summary>
        public int Games_GameId { get; set; }
    }
}
