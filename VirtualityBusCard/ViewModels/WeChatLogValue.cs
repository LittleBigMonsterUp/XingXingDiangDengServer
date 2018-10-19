using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualityBusCard.ViewModels
{
    public class WeChatLogValue
    {
        /// <summary>
        /// Cord用户登录凭证（有效期五分钟）。开发者需要在开发者服务器后台调用 api，使用 code 换取 openid 和 session_key 等信息
        /// </summary>


        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string Openid { get; set; }

        /// <summary>
        ///  会话密钥
        /// </summary>
        public string Session_key { get; set; }
        /// <summary>
        /// 用户在开放平台的唯一标识符，在满足 UnionID 下发条件的情况下会返回
        /// </summary>
        public string Unionid { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        public int Errcode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg { get; set; }

    }
}