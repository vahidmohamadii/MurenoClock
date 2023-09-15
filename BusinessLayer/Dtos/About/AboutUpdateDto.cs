
using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.About;

public class AboutUpdateDto:BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; }
}
