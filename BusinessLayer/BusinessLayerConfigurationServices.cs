

using BusinessLayer.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer;

public static class BusinessLayerConfigurationServices
{
    public static void ConfigureBusinessLayerServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
    }
}
