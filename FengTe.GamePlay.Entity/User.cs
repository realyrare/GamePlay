using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
  public  class User
    {
        /// <summary>
        /// 自身Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RelyName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string HeadImg { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
        public int QQ { get; set; }
        /// <summary>
        /// 微信
        /// </summary>
        public string WeChat { get; set; }
        /// <summary>
        /// 最终登录的ip
        /// </summary>
        public string Last_Login_IP { get; set; }
        /// <summary>
        /// 最终的登录时间
        /// </summary>
        public DateTime Last_Login_Time { get; set; }
        /// <summary>
        /// 系统当前时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdentityCard { get; set; }
        /// <summary>
        /// 身份证照
        /// </summary>
        public string CardPhoto { get; set; }
        /// <summary>
        /// 是否审核通过
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 当前城市
        /// </summary>
        public string CurrentCity { get; set; }
        /// <summary>
        /// 个人介绍
        /// </summary>
        public string Intro { get; set; }
        /// <summary>
        /// 在线状态
        /// </summary>
        public string OnLine_State { get; set; }
        /// <summary>
        /// 个人风采照
        /// </summary>
        public string PersonalPhoto { get; set; }
        /// <summary>
        /// 个人音频
        /// </summary>
        public string PersonalAudio { get; set; }
        /// <summary>
        /// 个人主页照片
        /// </summary>
        public string HomePage_Img { get; set; }
    }
}
