

namespace DataLayer.Entities;

public class Nav: BaseEntity.BaseEntity
{
    public string Title { get; set; }
    public string ImageFileName { get; set; }
    public string Link { get; set; }
    public int? SubGroupId { get; set; }
}
