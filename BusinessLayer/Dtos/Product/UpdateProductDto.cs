
using BusinessLayer.Dtos.Common;
using BusinessLayer.Dtos.ProductImage;

namespace BusinessLayer.Dtos.Product;

public class UpdateProductDto
{
    public string ImageFileName { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int ProductCategoryId { get; set; }
}
