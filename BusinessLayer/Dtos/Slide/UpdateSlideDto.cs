
using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.Slide;

public class UpdateSlideDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; }
    public string Link { get; set; }
}
