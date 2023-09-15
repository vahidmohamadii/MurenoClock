

using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer;

public static class DataLayerConfigurationService
{
    public static void ConfigureDataLayerRegistration(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<MurenoClockContext>(x => x.UseSqlServer(configuration.GetConnectionString("MurenoClockConnection")));

    }
}
