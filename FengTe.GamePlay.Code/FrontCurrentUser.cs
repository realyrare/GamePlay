using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Code
{
    /// <summary>
    /// 前台个人中心当前操作的用户
    /// </summary>
  public  class FrontCurrentUser
    {
        public int UserId { get; set; }
        public string UserAccount { get; set; }
        public string RealName { get; set; }
        public string UserPwd { get; set; }
        public string Last_Login_IP { get; set; }
        public DateTime Last_Login_Time { get; set; }
        /// <summary>
        /// 个人介绍
        /// </summary>
        public string Intro { get; set; }
        /// <summary>
        /// 个人主页照片
        /// </summary>
        public string HomePage_Img { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string HeadImg { get; set; }
        public string CurrentCity { get; set; }
        public string LoginToken { get; set; }       
    }
}
