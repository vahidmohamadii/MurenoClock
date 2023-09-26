

using DataLayer.Entities.common;

namespace DataLayer.Entities;

public class About : BaseEntity<int>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; } 
}
