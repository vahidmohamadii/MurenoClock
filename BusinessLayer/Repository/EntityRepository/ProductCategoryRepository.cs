
using AutoMapper;
using BusinessLayer.Dtos.ProductCategory;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ProductCategoryRepository : GenericRepository<ProductCategory,ProductCategoryDto>, IProductCategoryRepository
{
    public ProductCategoryRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
