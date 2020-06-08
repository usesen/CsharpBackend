using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.DataAccess;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;

namespace FSMProductionDataAccess.Abstract
{
    public interface IWorkgroupSubDal : IEntityRepository<WorkgroupSub>
    {
        List<WorkgroupSubDetail> GetWorkgroupSubDetails();
    }
}
