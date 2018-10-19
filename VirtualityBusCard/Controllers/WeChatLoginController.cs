using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VirtualityBusCard.Models;
using VirtualityBusCard.DAL;
using VirtualityBusCard.ViewModels;
namespace VirtualityBusCard.Controllers
{
    public class WeChatLoginController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        /// <summary>
        /// 微信登录请求授权
        /// </summary>
        /// <param name="weChatLogValue"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("WeChatLogin")]
        [Route("api/WeChatLogin")]
       public string WeChatLog (WeChatLogValue weChatLogValue)
        {

            var weChatAppletAppidAppSecrets = unitOfWork.WeChatAppletAppidAppSecretRepository.Get();
            var LogDataValue = (from u in weChatAppletAppidAppSecrets
                                select u
                               ).ToList();
            var LogDataValues = LogDataValue.FirstOrDefault();
            Message messages = new Message();
            WechatLogData wechatLogData = new WechatLogData();
            if (weChatLogValue.Errcode == -1)
            {
                messages.Messages = "系统繁忙，此时请开发者稍候再试";
            }
            else if (weChatLogValue.Errcode == 0)

            {
                wechatLogData.CodeAppidAppSecret = weChatLogValue.Openid+weChatLogValue.Session_key+weChatLogValue.Unionid+weChatLogValue.Errcode+weChatLogValue.ErrMsg
                    + LogDataValues.Appid + LogDataValues.AppSecret;
                return wechatLogData.CodeAppidAppSecret;
            }
            else if (weChatLogValue.Errcode == 40029)
            {
                messages.Messages = "Cord无效";
            }
            else if (weChatLogValue.Errcode==45011)
            {
                messages.Messages = "频率限制，每个用户每分钟100次";
            }

            return messages.Messages;
           
        }

    }
    
}
