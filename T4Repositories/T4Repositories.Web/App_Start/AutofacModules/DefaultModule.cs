﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;

namespace T4Repositories.Web.App_Start.AutofacModules
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(DefaultModule).Assembly)
                .AsImplementedInterfaces();
        }
    }
}