

namespace BusinessLayer.CustomMapping;

public class CustomMappingProfile:AutoMapper.Profile
{
    public CustomMappingProfile(IEnumerable<IhaveCustomMapping> customMappings)
    {
            foreach (var customMapping in customMappings) 
        {
            customMapping.Createmapping(this);
        }
    }
}
