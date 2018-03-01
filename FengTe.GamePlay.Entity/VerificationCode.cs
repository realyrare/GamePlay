using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Entity
{
   public class VerificationCode
    {
        public string Mobile { get; set; }
        public string Code { get; set; }
        public DateTime InTime { get; set; }
        public string IP { get; set; }
    }
}
