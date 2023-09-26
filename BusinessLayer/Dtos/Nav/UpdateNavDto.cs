
using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.Nav;

public class UpdateNavDto
{
    public string Title { get; set; }
    public string ImageFileName { get; set; }
    public string Link { get; set; }
    public int? SubGroupId { get; set; }
}
