using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 反馈表
    /// </summary>
  public  class ComplainInfo
    {
        /// <summary>
        /// 自身id
        /// </summary>
        public int ComplainInfoId { get; set; }
        /// <summary>
        /// 当前用户
        /// </summary>
        public int User_UserId { get; set; }
        /// <summary>
        /// 反馈信息
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 当前时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 提交的截图
        /// </summary>
        public string Img { get; set; }
        /// <summary>
        /// 审核通过状态、默认为待审核（false）
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 是否删除、默认为未删除（false）
        /// </summary>
        public bool IsDel { get; set; }
    }
}
