
using AutoMapper;
using System.Reflection;

namespace BusinessLayer.CustomMapping;

public static class AutoMapperConfiguration
{

    public static void AddCustomMappingProfile(this IMapperConfigurationExpression config)
    {
        config.AddCustomMappingProfile(Assembly.GetEntryAssembly());
    }


    public static void AddCustomMappingProfile(this IMapperConfigurationExpression config,params Assembly[] assemblies)
    {
        var allType = assemblies.SelectMany(a => a.ExportedTypes);

        var List = allType.Where(type => type.IsPublic && !type.IsAbstract
                               && type.GetInterfaces().Contains(typeof(IhaveCustomMapping)))
            .Select(type => (IhaveCustomMapping)Activator.CreateInstance(type));
        var profile = new CustomMappingProfile(List);
        config.AddProfile(profile);
    }
}
