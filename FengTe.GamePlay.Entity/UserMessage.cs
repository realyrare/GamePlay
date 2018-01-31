using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 前台用户消息表
    /// </summary>
   public class UserMessage
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int UserMessageId { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 系统当前的时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 所属用户
        /// </summary>
        public int User_UserId { get; set; }
    }
}
