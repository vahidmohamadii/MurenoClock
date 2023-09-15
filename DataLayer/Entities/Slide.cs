namespace DataLayer.Entities;

public class Slide: BaseEntity.BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; }
    public string Link { get; set; }
}
