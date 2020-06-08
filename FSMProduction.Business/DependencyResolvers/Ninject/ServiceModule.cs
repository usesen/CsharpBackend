using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Business.Abstract;
using FSMProduction.Core.Utilities.Common;
using Ninject.Modules;

namespace FSMProduction.Business.DependencyResolvers.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().ToConstant(WcfProxy<IUserService>.CreateChannel());
        }
    }
}
