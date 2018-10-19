using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VirtualityBusCard.Models;

namespace VirtualityBusCard.DAL
{
    public class AccountInitializer :
         DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {

            var virtualityBusCardMessageUser = new List<VirtualityBusCardMessageUser>
            {
                new VirtualityBusCardMessageUser {Id=1,Age="8",Sex="男"  },
                new VirtualityBusCardMessageUser   {Id=2,Age="9",Sex="女"}
            };
            virtualityBusCardMessageUser.ForEach(s => context.VirtualityBusCardMessageUser.Add(s));
            context.SaveChanges();
            var virtualityBusCardUser = new List<VirtualityBusCardUser>
            {  
                new VirtualityBusCardUser { Id = 1, UserName = "小风谷", UserId = "133" },
                new VirtualityBusCardUser   { Id = 2, UserName = "风过无痕",UserId = "144"}
            };
            virtualityBusCardUser.ForEach(s => context.VirtualityBusCardUser.Add(s));
            context.SaveChanges();
            var weChatAppletAppidAppSecret = new List<WeChatAppletAppidAppSecret>
            {
                new WeChatAppletAppidAppSecret {Appid="wx5a3bc752f96c8f08",AppSecret="6c49a6e17c749da35ca8a007051dec45"}
            };
            weChatAppletAppidAppSecret.ForEach(s => context.WeChatAppletAppidAppSecret.Add(s));
            context.SaveChanges();
        }
    }
}