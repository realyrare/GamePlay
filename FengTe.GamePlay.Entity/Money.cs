using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
   public class Money
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int MoneyId { get; set; }
        /// <summary>
        /// 所属用户
        /// </summary>
        public int User_UserId { get; set; }
        /// <summary>
        /// 人民币是否冻结
        /// </summary>
        public int RMB { get; set; }
        /// <summary>
        /// 人民币状态
        /// </summary>
        public int RMBState { get; set; }
        /// <summary>
        /// 项目类型=========》1:陪玩，2:代练，3：租号
        /// </summary>
        public int ProjectType { get; set; }
        /// <summary>
        /// 资金来源类型:充值：提现：消费：收入
        /// </summary>
        public int Detail_Type { get; set; }
        /// <summary>
        /// 系统当前时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 充值方式
        /// </summary>
        public string Pay_Way { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string Order_No { get; set; }
       
    }
}
