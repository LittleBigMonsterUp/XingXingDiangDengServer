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

            var adminUser = new List<VirtualityBusCardMessageUser>
            {
                new VirtualityBusCardMessageUser {Id=1,UserName="小风谷",UserId="133" },
                new VirtualityBusCardMessageUser   {Id=2,UserName="风过无痕",UserId="144"}
            };
            adminUser.ForEach(s => context.VirtualityBusCardMessageUser.Add(s));
            context.SaveChanges();
            var relationships = new List<VirtualityBusCardUser>
            {
                new VirtualityBusCardUser {Id=1,Age="8",Sex="男" },
                new VirtualityBusCardUser   {Id=2,Age="9",Sex="女"}
            };
            relationships.ForEach(s => context.VirtualityBusCardUser.Add(s));
            context.SaveChanges();

        }
    }
}