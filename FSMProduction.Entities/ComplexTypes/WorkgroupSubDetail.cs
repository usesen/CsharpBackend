using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMProduction.Entities.ComplexTypes
{
    public class WorkgroupSubDetail
    {
        public virtual int WorkgroupSubID { get; set; }
        public virtual string WorkgroupName { get; set; }
        public virtual string UserFullName { get; set; }
    }
}
