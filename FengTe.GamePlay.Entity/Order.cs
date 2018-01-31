using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// 订单表
    /// </summary>
  public  class Order
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 所属用户
        /// </summary>
        public int User_UserId { get; set; }
        /// <summary>
        /// 所属游戏
        /// </summary>
        public int Games_GameId { get; set; }
        /// <summary>
        /// 系统当前时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public int OrderType { get; set; }
        /// <summary>
        /// 当前订单的状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime NextOrder_Time { get; set; }
        /// <summary>
        /// 接单时间
        /// </summary>
        public DateTime ReceiveOrder_Time { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get; set; }
    }
}
