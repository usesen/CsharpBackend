using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;
using FSMProductionDataAccess.Concrete.EntityFramework.Mapping;

namespace FSMProductionDataAccess.Concrete.EntityFramework
{
    public class FSMDatabaseContext : DbContext
    {
        public FSMDatabaseContext()
        {
            Database.SetInitializer<FSMDatabaseContext>(null);
        }
        public DbSet<Workgroup> Workgroups { get; set; }
        public DbSet<WorkgroupSub> WorkgroupSubs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new WorkgroupMap());
            modelBuilder.Configurations.Add(new WorkgroupSubMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
