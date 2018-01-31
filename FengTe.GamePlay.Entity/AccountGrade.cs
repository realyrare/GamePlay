using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 用户账号等级表
    /// </summary>
   public class AccountGrade
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 等级名称
        /// </summary>
        public string GradeName { get; set; }
        /// <summary>
        /// 当前游戏
        /// </summary>
        public int Games_GameId { get; set; }
        /// <summary>
        /// 当前用户
        /// </summary>
        public int User_UserId { get; set; }
    }
}
