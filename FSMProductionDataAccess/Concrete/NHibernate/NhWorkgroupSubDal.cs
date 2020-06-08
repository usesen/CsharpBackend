using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.DataAccess.NHihabernate;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;
using FSMProductionDataAccess.Abstract;
using NHibernate.Linq;

namespace FSMProductionDataAccess.Concrete.NHibernate
{
    public class NHWorkgroupSubDal : NhEntityRepositoryBase<WorkgroupSub>, IWorkgroupSubDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NHWorkgroupSubDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<WorkgroupSubDetail> GetWorkgroupSubDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from wgrpmain in session.Query<Workgroup>()
                             join wgrpsub in session.Query<WorkgroupSub>() on wgrpmain.WorkGroupId equals wgrpsub.WgrpMainID
                             join puser in session.Query<User>() on wgrpsub.UserID equals puser.Id
                             select new WorkgroupSubDetail
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
