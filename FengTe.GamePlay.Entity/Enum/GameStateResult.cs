using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity.Enum
{
    /// <summary>
    /// 游戏认证状态
    /// </summary>
    public enum GameStateResult
    {      
        /// <summary>
        /// 已提交
        /// </summary>
        Commit=0,
        /// <summary>
        /// 初审通过
        /// </summary>
        Pass=1,
        /// <summary>
        /// 未通过初审
        /// </summary>
        NoPass=2,
        /// <summary>
        /// 复审未通过
        /// </summary>
        AgainNoPass=3,
        /// <summary>
        /// 复审通过
        /// </summary>
        AgainPass=4


    }
}
