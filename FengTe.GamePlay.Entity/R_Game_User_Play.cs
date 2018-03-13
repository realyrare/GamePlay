using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 大神，娱乐陪玩中间表
    /// </summary>
   public class R_Game_User_Play
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 所属用户
        /// </summary>
        public int User_UserId { get; set; }
        /// <summary>
        /// 所属游戏
        /// </summary>
        public int Games_GameId { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        public string TagName { get; set; }
        /// <summary>
        /// 系统的当前时间
        /// </summary>
        public DateTime InTime { get; set; }
       /// <summary>
       /// 服务条约
       /// </summary>
        public string ServiceNote { get; set; }
        /// <summary>
        /// 战绩截图
        /// </summary>
        public string GameScore_CutImg { get; set; }
        /// <summary>
        /// 段位截图
        /// </summary>
        public string GameRating_CutImg { get; set; }
        /// <summary>
        /// 认证状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 认证类型：1、陪玩2、大神
        /// </summary>
        public int Type { get; set; }
        public int GameRatingId { get; set; }
        public int GameAreaId { get; set; }
        /// <summary>
        /// 线下价格
        /// </summary>
        public int OfflinePrice { get; set; }
        /// <summary>
        /// 线上价格
        /// </summary>
        public int OnlinePrice { get; set; }
    }
}
