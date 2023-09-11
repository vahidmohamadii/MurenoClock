namespace DataLayer.Entities;

public class ProductCategory
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Product> products { get; set; }
}
