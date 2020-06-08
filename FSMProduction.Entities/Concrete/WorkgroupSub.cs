using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.Entities;

namespace FSMProduction.Entities.Concrete
{
    public class WorkgroupSub : IEntity
    {
        public virtual int WgrpSubID { get; set; }
        public virtual int WgrpMainID { get; set; }
        public virtual int UserID { get; set; }

    }
}
