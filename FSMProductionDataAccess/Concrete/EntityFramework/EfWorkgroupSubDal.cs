using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.DataAccess.EntityFramework;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;
using FSMProductionDataAccess.Abstract;

namespace FSMProductionDataAccess.Concrete.EntityFramework
{
    public class EfWorkgroupSubDal : EfEntityRepositoryBase<WorkgroupSub, FSMDatabaseContext>, IWorkgroupSubDal
    {
        public List<WorkgroupSubDetail> GetWorkgroupSubDetails()
        {
            using (FSMDatabaseContext dbcontext = new FSMDatabaseContext())
            { 
                var result = from wgrpmain in dbcontext.Workgroups
                    join wgrpsub in dbcontext.WorkgroupSubs on wgrpmain.WorkGroupId equals wgrpsub.WgrpSubID
                    join puser in dbcontext.Users on wgrpsub.UserID equals puser.Id
                    select new WorkgroupSubDetail()
                    {
                        WorkgroupSubID = wgrpsub.WgrpSubID,
                        WorkgroupName = wgrpmain.WorkGroupName,
                        UserFullName = puser.UserName

                    };
                return result.ToList();
            }

        }
    }
}
