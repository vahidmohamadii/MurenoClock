namespace DataLayer.Entities;

public class ProductImage
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageFileName { get; set; }
    public int ProductId { get; set; }
    public Product product { get; set; }

}
