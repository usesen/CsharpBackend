using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.DataAccess;
using FSMProduction.Entities.Concrete;

namespace FSMProductionDataAccess.Abstract
{
    public interface IWorkgroupDal : IEntityRepository<Workgroup>
    {
    }
}
