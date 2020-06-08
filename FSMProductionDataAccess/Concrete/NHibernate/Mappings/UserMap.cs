using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FSMProduction.Entities.Concrete;

namespace FSMProductionDataAccess.Concrete.NHibernate.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table(@"User");
            LazyLoad();
            Id(x => x.Id).Column("Id");
            Map(x => x.FirstName).Column("FirstName");
            Map(x => x.LastName).Column("LastName");
            Map(x => x.UserName).Column("UserName");
        }
    }
}
