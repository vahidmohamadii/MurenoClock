﻿using DataLayer.Entities.common;

namespace DataLayer.Entities;

public class ProductCategory: BaseEntity<int>
{
    public string Title { get; set; }
    public List<Product> products { get; set; }
}
