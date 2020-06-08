using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FSMProduction.Business.ValidationRules.FluentValidation;
using FSMProduction.Entities.Concrete;
using Ninject.Modules;

namespace FSMProduction.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<User>>().To<UserValidatior>().InSingletonScope();
        }
    }
}
