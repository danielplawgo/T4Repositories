using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using T4Repositories.Logic;

namespace T4Repositories.Web.App_Start.AutofacModules
{
    public class LogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(typeof(ILogic<>).Assembly)
                .AsImplementedInterfaces();
        }
    }
}