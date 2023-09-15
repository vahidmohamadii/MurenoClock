

using BusinessLayer.Repository;
using BusinessLayer.Repository.EntityRepository;
using BusinessLayer.Repository.IEntityRepository;
using BusinessLayer.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer;

public static class BusinessLayerConfigurationServices
{
    public static void ConfigureBusinessLayerServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddTransient<IUnitOfWork, BusinessLayer.UnitOfWork.UnitOfWork>();
        services.AddScoped<IAboutRepository, AboutRepository>();
        services.AddScoped<IContactFormRepository, ContactFormRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<INavRepository, NavRepository>();
        services.AddScoped<IOnlineSellRepository, OnlineSellRepository>();
        services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductImageRepository, ProductImageRepository>();
        services.AddScoped<ISlideRepository, SlideRepository>();
        services.AddScoped<ISocialRepository, SocialRepository>();
    }
}
