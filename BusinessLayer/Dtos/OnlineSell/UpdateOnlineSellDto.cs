

using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.OnlineSell;

public class UpdateOnlineSellDto:BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; }
    public string Link { get; set; }
}
