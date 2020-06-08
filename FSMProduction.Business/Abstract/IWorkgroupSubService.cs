using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Entities.Concrete;

namespace FSMProduction.Business.Abstract
{
    public interface IWorkgroupSubService
    {
        List<WorkgroupSub> GetAll();
        WorkgroupSub GetById(int id);
        WorkgroupSub Add(WorkgroupSub workgroupsub);
    }
}
