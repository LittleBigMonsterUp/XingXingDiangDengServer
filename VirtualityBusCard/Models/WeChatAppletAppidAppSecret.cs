using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualityBusCard.Models
{     

  /// <summary>
  /// 微信登录
  /// </summary>
    public class WeChatAppletAppidAppSecret
    {    
        public int id { get; set; }
        public string Appid { get; set; }
        
        public string AppSecret { get; set; }

    }
}