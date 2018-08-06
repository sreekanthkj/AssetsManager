using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Assets.Models.Users;
using Assets.Repository.EntityFramework.Configuration;

namespace Assets.Repositoty.EntityFramework
{
    internal class AssetsManagerContext : DbContext
    {
        DbSet<ApplicationUser> User { get; set; }

        public AssetsManagerContext() : base("name=AssetsManagerContext") //specify name or full connectionstring here !!
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //add congigurations 
            modelBuilder.Configurations.Add(new ApplicationUserConfiguration());
        }
    }
}
