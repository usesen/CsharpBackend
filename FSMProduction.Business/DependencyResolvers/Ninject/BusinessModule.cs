using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Business.Abstract;
using FSMProduction.Business.Concrete;
using FSMProduction.Business.Concrete.Managers;
using FSMProduction.Core.DataAccess;
using FSMProduction.Core.DataAccess.EntityFramework;
using FSMProduction.Core.DataAccess.NHihabernate;
using FSMProductionDataAccess.Abstract;
using FSMProductionDataAccess.Concrete.EntityFramework;
using FSMProductionDataAccess.Concrete.NHibernate.Helpers;
using Ninject.Modules;

namespace FSMProduction.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();



            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<FSMDatabaseContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
