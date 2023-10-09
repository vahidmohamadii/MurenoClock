

using DataLayer.Entities.common;

namespace DataLayer.Entities;

public class Language : BaseEntity<int>
{
    public string Title { get; set; }
    public List<About> abouts { get; set; }
}
