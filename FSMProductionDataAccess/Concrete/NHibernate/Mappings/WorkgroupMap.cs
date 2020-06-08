using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FSMProduction.Entities.Concrete;

namespace FSMProductionDataAccess.Concrete.NHibernate.Mappings
{
    public class WorkgroupMap : ClassMap<Workgroup>
    {
        public WorkgroupMap()
        {
            Table(@"Workgroup");
            LazyLoad();
            Id(x => x.WorkGroupId).Column("WorkGroupId");
            Map(x => x.WorkGroupName).Column("WorkGroupName");
            Map(x => x.Description).Column("Description");
            Map(x => x.City).Column("City");
        }
    }
}
