namespace DataLayer.Entities;

public class ProductCategory: BaseEntity.BaseEntity
{
    public string Title { get; set; }
    public List<Product> products { get; set; }
}
