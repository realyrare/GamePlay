using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
    /// <summary>
    /// （绝地求生）吃鸡游戏的结果表
    /// </summary>
  public  class EatChook_GameResult
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 局数
        /// </summary>
        public string Ju { get; set; }
        /// <summary>
        /// 人头数
        /// </summary>
        public int RenTou { get; set; }
        /// <summary>
        /// 当前时间
        /// </summary>
        public DateTime InTime { get; set; }
    }
}
