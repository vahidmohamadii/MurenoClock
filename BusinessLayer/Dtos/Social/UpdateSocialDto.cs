
using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.Social;

public class UpdateSocialDto:BaseDto
{
    public string Title { get; set; }
    public string ImageFileName { get; set; }
    public string Link { get; set; }
}
