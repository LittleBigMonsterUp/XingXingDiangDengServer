using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VirtualityBusCard.Models;

namespace VirtualityBusCard.DAL
{
    public class AccountContext : DbContext
    {

        public AccountContext() : base("AccountContext")
        {

        }
        public DbSet<VirtualityBusCardUser> VirtualityBusCardUser { get; set; }
        public DbSet<VirtualityBusCardMessageUser> VirtualityBusCardMessageUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}