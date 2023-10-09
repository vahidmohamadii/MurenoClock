
using BusinessLayer.Interfaces;
using BusinessLayer.Repository;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BusinessLayer;

public static class BusinessLayerConfigurationServices
{

    public static void ConfigureBusinessLayerServices(this IServiceCollection services)
    {
        
      
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped(typeof(ICountOfQuery<>), typeof(CountOfQuery<>));







    }
}
