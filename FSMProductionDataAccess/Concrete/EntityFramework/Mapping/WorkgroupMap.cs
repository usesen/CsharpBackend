using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Entities.Concrete;

namespace FSMProductionDataAccess.Concrete.EntityFramework.Mapping
{
    public class WorkgroupMap : EntityTypeConfiguration<Workgroup>
    {
        public WorkgroupMap()
        {
            ToTable(@"Workgroup", @"dbo");
            HasKey(x => x.WorkGroupId);

            Property(x => x.WorkGroupId).HasColumnName("WorkGroupId");
            Property(x => x.WorkGroupName).HasColumnName("WorkGroupName");
            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.City).HasColumnName("City");
        }
    }
}
