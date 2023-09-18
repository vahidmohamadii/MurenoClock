
using DataLayer.Entities.common;

namespace DataLayer.Entities;

public class About/*: BaseEntity*/
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; } 
}
