using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.DataAccess.NHihabernate;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;
using FSMProductionDataAccess.Abstract;

namespace FSMProductionDataAccess.Concrete.NHibernate
{
    public class NHUserDal : NhEntityRepositoryBase<User>, IUserDal
    {
        public NHUserDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            throw new NotImplementedException();
        }
    }
}
