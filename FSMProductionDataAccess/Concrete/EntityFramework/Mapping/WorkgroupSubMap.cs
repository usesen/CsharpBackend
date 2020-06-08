using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Entities.Concrete;

namespace FSMProductionDataAccess.Concrete.EntityFramework.Mapping
{
    public class WorkgroupSubMap : EntityTypeConfiguration<WorkgroupSub>
    {
        public WorkgroupSubMap()
        {
            ToTable(@"WorkgroupSubs", @"dbo");
            HasKey(x => x.WgrpSubID);


            Property(x => x.WgrpSubID).HasColumnName("WgrpSubID");
            Property(x => x.WgrpMainID).HasColumnName("WgrpMainID");
            Property(x => x.UserID).HasColumnName("UserID");
        }
    }
}
