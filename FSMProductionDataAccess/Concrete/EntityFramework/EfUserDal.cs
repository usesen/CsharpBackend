using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Core.DataAccess.EntityFramework;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;
using FSMProductionDataAccess.Abstract;
using NHibernate.Hql.Ast.ANTLR.Tree;

namespace FSMProductionDataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, FSMDatabaseContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (FSMDatabaseContext context = new FSMDatabaseContext())
            {
                var result = from ur in context.UserRoles
                    join rl  in context.Roles on ur.RoleId equals rl.Id
                    where ur.UserId == user.Id  
                             select new UserRoleItem { RoleName = rl.RoleName };
                return result.ToList();
            }
        }
    }
}
