using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Code
{
  public  class OperatorModel
    {
        public string UserId { get; set; }
        public string UserAccount { get; set; }
        public string RealName { get; set; }
        public string UserPwd { get; set; }      
        public string LoginIPAddress { get; set; }
        public string LoginIPAddressName { get; set; }
        public string LoginToken { get; set; }
        public DateTime LoginTime { get; set; }
        public bool IsSystem { get; set; }
    }
}
