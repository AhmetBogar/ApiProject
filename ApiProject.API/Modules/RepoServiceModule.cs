﻿using ApiProject.BusinessLayer.Mapping;
using ApiProject.BusinessLayer.Services;
using ApiProject.Caching;
using ApiProject.DataAccessLayer;
using ApiProject.DataAccessLayer.Repository;
using ApiProject.DataAccessLayer.UnitOfWorks;
using ApiProject.EntityLayer.Repositories;
using ApiProject.EntityLayer.Services;
using ApiProject.EntityLayer.UnitOfWorks;
using Autofac;
using System.Reflection;
using Module = Autofac.Module;

namespace ApiProject.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();



            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ServiceWithDto<,>)).As(typeof(IServiceWithDto<,>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<ProductServiceWithDto>().As<IProductServiceWithDto>().InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));


            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();



            builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();
        }
    }
}
