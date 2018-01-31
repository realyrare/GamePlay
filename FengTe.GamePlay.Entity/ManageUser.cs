using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 总后台管理用户表
    /// </summary>
   public class ManageUser
    {
        public int Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealyName { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 当前时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 是否禁用、默认为未禁用
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 是否删除、默认为伪删除（false）
        /// </summary>
        public bool IsDel { get; set; }
        /// <summary>
        /// 当前的登录Ip
        /// </summary>
        public string LoginIp { get; set; }
        /// <summary>
        /// 登录的次数
        /// </summary>
        public int LoginNum { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public int Last_LoginTime { get; set; }
    }
}
