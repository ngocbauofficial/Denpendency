using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Core;
using TopPro.Infrastructure;
using TopPro;
using TopPro.Data;
using TopPro.Domain;
using TopPro.Service.MA001Service;
using TopPro.Service.MA003Service;
using TopPro.Service.MA002Service;

namespace Web.Implementation.Infrastructure
{

        public class DependencyConfigure : Module
        {

            protected override void Load(ContainerBuilder builder)
            {

                builder.RegisterType<DataContext>().As<IDbContext>().InstancePerDependency();
                builder.RegisterGeneric(typeof(RepositoryService<>)).As(typeof(IRepository<>));
                builder.RegisterType<MA001Service>().As<IMA001Service>();
                builder.RegisterType<MA002Service>().As<IMA002Service>();
                builder.RegisterType<MA003Service>().As<IMA003Service>();
                base.Load(builder);
            }


    }
}