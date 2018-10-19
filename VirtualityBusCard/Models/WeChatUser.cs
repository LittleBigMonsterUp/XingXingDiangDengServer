using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualityBusCard.Models
{     
    /// <summary>
    /// 微信用户登录信息
    /// </summary>
    public class WeChatUser
    {
        public int id { get; set; }

        public string nickName { get; set; }

        public string city { get; set; }

        public  string gender { get; set; }

        public string language { get; set; }

        public string province { get; set; }

    }
}