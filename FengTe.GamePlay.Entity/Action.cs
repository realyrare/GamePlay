using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 后台权限表
    /// </summary>
   public class Action
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string ActionName { get; set; }
        /// <summary>
        /// 权限路径
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 是否删除默认为伪删除（false）
        /// </summary>
        public bool IsDel { get; set; }
        /// <summary>
        /// 权限父Id
        /// </summary>
        public int Action_ParentId { get; set; }
        /// <summary>
        /// 系统当前时间
        /// </summary>
        public DateTime InTime { get; set; }
    }
}
