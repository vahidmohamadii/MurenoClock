

namespace BusinessLayer.Utility;

public static class GenerateCodeClass
{
    public static string GenerateCode()
    {
        return Guid.NewGuid().ToString();
    }
}
