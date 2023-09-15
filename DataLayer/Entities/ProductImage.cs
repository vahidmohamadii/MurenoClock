using DataLayer.Entities.common;

namespace DataLayer.Entities;

public class ProductImage: BaseEntity
{
    public string Title { get; set; }
    public string ImageFileName { get; set; }
    public int ProductId { get; set; }
    public Product product { get; set; }

}
