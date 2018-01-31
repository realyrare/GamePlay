using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 总后台用户权限管理中间表
    /// </summary>
  public  class R_ManageUser_Action
    {
        public int Id { get; set; }
        /// <summary>
        /// 总后台所属用户
        /// </summary>
        public int ManageUserId { get; set; }
        /// <summary>
        /// 所属权限
        /// </summary>
        public int ActionId { get; set; }
        /// <summary>
        /// 是否通过、默认通过
        /// </summary>
        public bool IsPass { get; set; }
    }
}
