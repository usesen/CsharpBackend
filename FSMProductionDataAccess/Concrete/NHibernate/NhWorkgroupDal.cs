using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.DataAccess.NHihabernate;
using FSMProduction.Entities.Concrete;
using FSMProductionDataAccess.Abstract;

namespace FSMProductionDataAccess.Concrete.NHibernate
{
    public class NhWorkgroupDal : NhEntityRepositoryBase<Workgroup>, IWorkgroupDal
    {

        public NhWorkgroupDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
    }
}
