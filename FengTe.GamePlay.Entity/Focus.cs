using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 粉丝表
    /// </summary>
  public  class Focus
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int FocusId { get; set; }
        /// <summary>
        /// 系统当前的时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 当前用户
        /// </summary>
        public int Self_UserId { get; set; }
        /// <summary>
        /// 被关注用户
        /// </summary>
        public int User_UserId { get; set; }
    }
}
