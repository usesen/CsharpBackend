using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.Entities;

namespace FSMProduction.Entities.Concrete
{
    public class Workgroup : IEntity
    {
        public virtual int WorkGroupId { get; set; }
        public virtual string WorkGroupName { get; set; }
        public virtual string Description { get; set; }
        public virtual string City { get; set; }

    }
}
