
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using BusinessLayer.Repository;
using DataLayer.Context;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BusinessLayer.AutoFac;

public static class AutoFacConfiguration
{
    public static void AddAutofacServices(this ContainerBuilder container)
    {
        container.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(GenericRepository<>)).InstancePerLifetimeScope();

        var BusinessLayerAssembly=typeof(GenericRepository<>).Assembly;
        var DataLayerAssembly = typeof(MurenoClockContext).Assembly;
        var ApiAssembly = Assembly.GetEntryAssembly();

        container.RegisterAssemblyTypes(BusinessLayerAssembly, DataLayerAssembly, ApiAssembly)
            .AssignableTo<IScopedDependency>()
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();


        container.RegisterAssemblyTypes(BusinessLayerAssembly, DataLayerAssembly, ApiAssembly)
            .AssignableTo<ITransientDependency>()
            .AsImplementedInterfaces()
            .InstancePerDependency();


        container.RegisterAssemblyTypes(BusinessLayerAssembly, DataLayerAssembly, ApiAssembly)
            .AssignableTo<ISingletonDependency>()
            .AsImplementedInterfaces()
            .SingleInstance();
    }

    public static IServiceProvider BuildAutofacServiceProvider(this IServiceCollection services)
    {

        var containerBuilder = new ContainerBuilder();
        containerBuilder.Populate(services);
        containerBuilder.AddAutofacServices();
        var container = containerBuilder.Build();
        return new AutofacServiceProvider(container);
    }
}
