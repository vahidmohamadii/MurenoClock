﻿

using BusinessLayer.Dtos.ProductImage;

namespace BusinessLayer.Dtos.Product;

public class ProductDto
{
    public string ImageFileName { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int ProductCategoryId { get; set; }
}
