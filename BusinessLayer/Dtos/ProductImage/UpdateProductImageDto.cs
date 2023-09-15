

using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.ProductImage;

public class UpdateProductImageDto:BaseDto
{
    public string Title { get; set; }
    public string ImageFileName { get; set; }
    public int ProductId { get; set; }
}
