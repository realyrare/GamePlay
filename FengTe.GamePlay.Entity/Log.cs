using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 系统日志表
    /// </summary>
   public class Log
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int LogId { get; set; }
        public string  Title { get; set; }
        /// <summary>
        /// 系统当前时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 异常信息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 后台当前的管理用户
        /// </summary>
        public int ManageUser_Id { get; set; }
    }
}
