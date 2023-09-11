namespace DataLayer.Entities;

public class Product
{
    public int Id { get; set; }
    public string ImageFileName { get; set; }
    public string  Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public List<ProductImage> productImages { get; set; }
    public int ProductCategoryId { get; set; }
    public ProductCategory productCategory { get; set; }
}
