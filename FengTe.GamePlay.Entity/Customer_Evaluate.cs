using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 用户评价表
    /// </summary>
   public class Customer_Evaluate
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int Customer_EvaluateId { get; set; }
        /// <summary>
        /// 评价几颗星
        /// </summary>
        public int Star_Level { get; set; }
        /// <summary>
        /// 评价信息
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 评价时间
        /// </summary>
        public DateTime? InTime { get; set; }
        /// <summary>
        /// 评价用户
        /// </summary>
        public int User_UserId { get; set; }
        /// <summary>
        /// 当前游戏
        /// </summary>
        public int Games_GameId { get; set; }
    }
}
