using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using T4Repositories.DataAccess;

namespace T4Repositories.Web.App_Start.AutofacModules
{
    public class DataContextModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataContext>()
                .InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(Repository<>).Assembly)
                .AsImplementedInterfaces();
        }
    }
}