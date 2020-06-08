using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FSMProduction.Entities.Concrete;

namespace FSMProductionDataAccess.Concrete.NHibernate.Mappings
{
    public class WorkgroupSubMap : ClassMap<WorkgroupSub>
    {
        public WorkgroupSubMap()
        {
            Table(@"WorkgroupSub");
            LazyLoad();
            Id(x => x.WgrpSubID).Column("WgrpSubID");
            Map(x => x.WgrpMainID).Column("WgrpMainID");
            Map(x => x.UserID).Column("UserID");
        }
    }
}
