

using DataLayer.Entities.common;

namespace DataLayer.Entities;

public class Language:BaseEntity<int>
{
    public string Title { get; set; }
    public int AboutId { get; set; }
    public About about { get; set; }
}
