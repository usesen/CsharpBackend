using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.DataAccess.EntityFramework;
using FSMProduction.Entities.Concrete;
using FSMProductionDataAccess.Abstract;

namespace FSMProductionDataAccess.Concrete.EntityFramework
{
    public class EfWorkgroupDal : EfEntityRepositoryBase<Workgroup, FSMDatabaseContext>, IWorkgroupDal
    {

    }
}
