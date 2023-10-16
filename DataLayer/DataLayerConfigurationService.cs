

using DataLayer.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer;

public static class DataLayerConfigurationService
{
    public static void ConfigureDataLayerRegistration(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<MurenoClockContext>(x => x.UseSqlServer(configuration.GetConnectionString("MurenoClockConnection")));
        services.AddIdentityCore<IdentityUser>(op => {
            op.Lockout = new LockoutOptions() { DefaultLockoutTimeSpan = TimeSpan.FromHours(24), MaxFailedAccessAttempts = 4 };
            op.Password.RequireUppercase = true;
            op.Password.RequiredLength = 8;
            
        })
            .AddEntityFrameworkStores<MurenoClockContext>();

    }
}
