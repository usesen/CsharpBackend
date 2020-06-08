﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace FSMProduction.Business.DependencyResolvers.Ninject
{

    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule(), new AutoMapperModule());
            return kernel.Get<T>();
        }
    }
}
